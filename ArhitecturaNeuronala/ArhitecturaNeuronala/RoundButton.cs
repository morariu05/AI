using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace ArhitecturaNeuronala
{
    public class RoundButton : Button
    {
        NeuronalNetwork mainform;

        public int indexStrat;
        public int indexNeuronPerStrat;

        public int nrIntrari = 1;
        public List<decimal> x = new List<decimal>();
        public List<decimal> w = new List<decimal>();
        public List<decimal> xProdw = new List<decimal>();

        public string selectorInputFunction = "Suma"; // +, *, max, min 
        public string selectorActivationFunction = "Treaptă"; // tr, sigm, semn, tanH, lin
        public string selectorOutputFunction = "Real"; // real/binar
        public decimal teta = 0;
        public decimal a = 1;
        public decimal g = 1;
        public int capatX;
        public int capatY;

        public decimal rezInput;
        public decimal rezActivation;
        public decimal rezOutput;

        public RoundButton() { }

        public RoundButton(int _indexStrat, int _indexNeuronPerStrat, NeuronalNetwork _mainForm)
        {
            indexStrat = _indexStrat;
            indexNeuronPerStrat = _indexNeuronPerStrat;
            mainform = _mainForm;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new Font(this.Font.FontFamily, 8);
            this.Region = new Region(graphicsPath);
            base.OnPaint(e);
        }

        public void RefreshResult()
        {
            GetInputValues();
            //XprodW();
            CalcRezInputFunction();
            CalcRezActivationFunction();
            CalcRezOutputFunction();
        }

        public void GetInputValues()
        {
            if (x.Count != 0)
            {
                x.Clear();
                //w.Clear();
            }
            // prod = intrari strat input * wi
            if (indexStrat == 1)
            {
                int index = 0;
                foreach (Control b in mainform.panel2.Controls.OfType<InputRoundButton>())
                {
                    InputRoundButton rbtn = (InputRoundButton)b;
                    if (rbtn.indexStrat == this.indexStrat - 1)
                    {
                        x.Add(rbtn.valueX);
                        w.Add(0);
                        // xProdw.Add(rbtn.valueX * w[index]);

                        index++;
                    }
                }
            }
            
            // prod = iesiri strat precedent * wi
            if (indexStrat > 1 && indexStrat <= 4)
            {
                int index = 0;
                foreach (Control b in mainform.panel2.Controls.OfType<RoundButton>())
                {
                    RoundButton rbtn = (RoundButton)b;
                    if (rbtn.indexStrat == this.indexStrat-1)
                    {
                        x.Add(rbtn.rezOutput);
                        w.Add(0);
                        //xProdw.Add(rbtn.rezOutput * w[index]);

                        index++;
                    }
                }
            }

            nrIntrari = xProdw.Count;
        }

        public void XprodW()
        {
            if (xProdw.Count != 0)
            {
                xProdw.Clear();
            }

            for(int i = 0; i < x.Count; i++)
            {
                xProdw.Add(x[i] * w[i]);
            }
        }

        #region Rez Input Function
        public void CalcRezInputFunction()
        {
            if (selectorInputFunction == "Suma")
            {
                decimal suma = 0;
                for (int i = 1; i <= nrIntrari; i++)
                {   
                    suma = suma + xProdw[i];
                }
                rezInput = suma;
            }

            if (selectorInputFunction == "Produs")
            {
                decimal produs = 1;
                for (int i = 1; i <= nrIntrari; i++)
                {
                    produs = produs * xProdw[i];
                }
                rezInput = produs;
            }

            if (selectorInputFunction == "Maxim")
            {
                decimal maxim = -9999M;
                for (int i = 1; i <= nrIntrari; i++)
                {
                    if (xProdw[i] > maxim)
                    {
                        maxim = xProdw[i];
                    }
                }
                rezInput = maxim;
            }

            if (selectorInputFunction == "Minim")
            {
                decimal minim = 9999M;
                for (int i = 1; i <= nrIntrari; i++)
                {
                    if (xProdw[i] < minim)
                    {
                        minim = xProdw[i];
                    }
                }
                rezInput = minim;
            }
        }
        #endregion

        #region Rez Activation Function

        #region Functii
        private decimal Fct_Treapta(decimal teta)
        {
            decimal x = rezInput;
            if (x >= teta)
            {
                return 1.00M;
            }
            else
            {
                return 0.00M;
            }
        }

        private decimal Fct_Sigmoidala(decimal teta, decimal g)
        {
            decimal x = rezInput;
            return (decimal)(1.00 / (1.00 + Math.Pow(Math.E, (double)((-g) * (x - teta)))));
        }

        private decimal Fct_Semn(decimal teta)
        {
            decimal x = rezInput;
            if (x > teta)
            {
                return 1.00M;
            }
            else
            {
                return -1.00M;
            }
        }

        private decimal Fct_TangentaHiperbolica(decimal teta, decimal g)
        {
            decimal x = rezInput;
            return (decimal)((Math.Pow(Math.E, (double)(g * (x - teta))) - Math.Pow(Math.E, (double)((-g) * (x - teta))))
                 / (Math.Pow(Math.E, (double)(g * (x - teta))) + Math.Pow(Math.E, (double)((-g) * (x - teta)))));
        }

        private decimal Fct_Liniara(decimal teta, decimal a)
        {
            decimal x = rezInput;
            if (x > a)
            {
                return 1.00M;
            }
            else
            if (x < (-a))
            {
                return -1.00M;
            }
            else
            if (((-a) <= x) && (x <= a)) // x e [-a,a] ; -a <= x <= a
            {
                return (decimal)((x - teta) / a);
            }

            return 0;
        }
        #endregion

        public void CalcRezActivationFunction()
        {
            if (selectorActivationFunction == "Treaptă")
            { 
                capatX = 0;
                capatY = 1;

                rezActivation = Fct_Treapta(teta);
            }

            if (selectorActivationFunction == "Sigmoidală")
            {
                capatX = 0;
                capatY = 1;

                rezActivation = Fct_Sigmoidala(teta, g);
            }

            if (selectorActivationFunction == "Semn")
            {
                capatX = (-1);
                capatY = (+1);

                rezActivation = Fct_Semn(teta);
            }

            if (selectorActivationFunction == "Tangenta Hiperbolică")
            {
                capatX = (-1);
                capatY = (+1);

                rezActivation = Fct_TangentaHiperbolica(teta, g);
            }

            if (selectorActivationFunction == "Liniară")
            {
                capatX = (-1);
                capatY = (+1);

                rezActivation = Fct_Liniara(teta, a);
            }
        }

        #endregion

        #region Rez Output Function

        public void CalcRezOutputFunction()
        {
            decimal mijlocInterval = (capatX + capatY)/2;
            decimal rezFinal = rezOutput;

            if (selectorOutputFunction == "Binar")
            {
                if (rezFinal < mijlocInterval)
                {
                    rezFinal = capatX;
                }
                else
                if (rezFinal >= mijlocInterval)
                {
                    rezFinal = capatY;
                }
                rezOutput = rezFinal;
            }
        }

        #endregion
    }
}
