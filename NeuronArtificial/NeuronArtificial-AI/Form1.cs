using System;
using System.Linq;
using System.Windows.Forms;

namespace NeuronArtificial_AI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            xNumericUpDown1.ValueChanged += new EventHandler( ResetHandler ); 
            wNumericUpDown1.ValueChanged += new EventHandler( ResetHandler );
        }

        #region n

            int contor = 1;
            int marginTop = 75;

            private void n_numericUpDown_ValueChanged(object sender, EventArgs e)
            {
                if (contor < n_numericUpDown.Value)
                {
                    contor++;

                    //x
                    Label xLabel = new Label();
                    xLabel.Name = "xi" + contor.ToString();
                    xLabel.Text = "xi" + contor.ToString();
                    xLabel.Size = new System.Drawing.Size(40, 30);
                    xLabel.Location = new System.Drawing.Point(12, marginTop);
                    this.panel.Controls.Add(xLabel);

                    NumericUpDown xNumericUpDown = new NumericUpDown();
                    xNumericUpDown.Name = "xNumericUpDown" + contor.ToString();
                    xNumericUpDown.Size = new System.Drawing.Size(71, 27);
                    xNumericUpDown.Location = new System.Drawing.Point(55, marginTop);
                    xNumericUpDown.TextAlign = HorizontalAlignment.Center;
                    xNumericUpDown.Value = 0;
                    xNumericUpDown.ValueChanged += new EventHandler(ResetHandler);
                    xNumericUpDown.DecimalPlaces = 2;
                    xNumericUpDown.Increment = 0.01M;
                    xNumericUpDown.Maximum = 100;
                    xNumericUpDown.Minimum = -100;
                    this.panel.Controls.Add(xNumericUpDown);

                    //w
                    Label wLabel = new Label();
                    wLabel.Name = "wi" + contor.ToString();
                    wLabel.Text = "wi" + contor.ToString();
                    wLabel.Size = new System.Drawing.Size(40, 30);
                    wLabel.Location = new System.Drawing.Point(137, marginTop);
                    this.panel.Controls.Add(wLabel);

                    NumericUpDown wNumericUpDown = new NumericUpDown();
                    wNumericUpDown.Name = "wNumericUpDown" + contor.ToString();
                    wNumericUpDown.Size = new System.Drawing.Size(71, 27);
                    wNumericUpDown.Location = new System.Drawing.Point(185, marginTop);
                    wNumericUpDown.TextAlign = HorizontalAlignment.Center;
                    wNumericUpDown.Value = 0;
                    wNumericUpDown.ValueChanged += new EventHandler(ResetHandler);
                    wNumericUpDown.DecimalPlaces = 2;
                    wNumericUpDown.Increment = 0.01M;
                    wNumericUpDown.Maximum = 100;
                    wNumericUpDown.Minimum = -100;
                    this.panel.Controls.Add(wNumericUpDown);

                    marginTop = marginTop + 30;

                    Reset();
                }
                else
                {
                    this.panel.Controls.Remove(this.panel.Controls.Find("xi" + contor, true).FirstOrDefault());
                    this.panel.Controls.Remove(this.panel.Controls.Find("xNumericUpDown" + contor, true).FirstOrDefault());

                    this.panel.Controls.Remove(this.panel.Controls.Find("wi" + contor, true).FirstOrDefault());
                    this.panel.Controls.Remove(this.panel.Controls.Find("wNumericUpDown" + contor, true).FirstOrDefault());

                    contor--;
                    marginTop = marginTop - 30;

                    Reset();
                }
            }

        #endregion

        #region Reset

            private void ResetHandler(object sender, EventArgs e)
            {
                Reset();
            }

            private void Reset()
            {
                fct_intrare_textBox.Text = "0";
                fct_intrare_comboBox.SelectedItem = null;
                fct_activare_textBox.Text = "0";
                fct_activare_comboBox.SelectedItem = null;
                teta_numericUpDown.Value = 0;
                g_numericUpDown.Value = 1;
                a_numericUpDown.Value = 1;
            }

        #endregion

        #region FunctiaDeIntrare

            private void fct_intrare_comboBox_SelectedIndexChanged( object sender, EventArgs e )
            {
                var comboBoxVal = fct_intrare_comboBox.Text;

                if( comboBoxVal == "Suma" )
                {
                    decimal suma = 0;
                    for( int i = 1; i <= contor; i++ )
                    {
                        NumericUpDown x = (NumericUpDown)this.panel.Controls.Find( "xNumericUpDown" + i, true ).FirstOrDefault();
                        NumericUpDown w = (NumericUpDown)this.panel.Controls.Find( "wNumericUpDown" + i, true ).FirstOrDefault();
                        decimal prodXW = x.Value * w.Value; 
                        suma = suma + prodXW;
                    }
                    fct_intrare_textBox.Text = suma.ToString();
                }

                if( comboBoxVal == "Produs" )
                {
                    decimal produs = 1;
                    for ( int i = 1; i <= contor; i++ )
                    {
                        NumericUpDown x = (NumericUpDown)this.panel.Controls.Find( "xNumericUpDown" + i, true ).FirstOrDefault();
                        NumericUpDown w = (NumericUpDown)this.panel.Controls.Find( "wNumericUpDown" + i, true ).FirstOrDefault();
                        decimal prodXW = x.Value * w.Value;
                        produs = produs * prodXW;
                    }
                    fct_intrare_textBox.Text = produs.ToString(); 
                }

                if( comboBoxVal == "Maxim" )
                {
                    decimal maxim = -9999M;
                    for ( int i = 1; i <= contor; i++ )
                    {
                        NumericUpDown x = (NumericUpDown)this.panel.Controls.Find( "xNumericUpDown" + i, true ).FirstOrDefault();
                        NumericUpDown w = (NumericUpDown)this.panel.Controls.Find( "wNumericUpDown" + i, true ).FirstOrDefault();
                        decimal prodXW = x.Value * w.Value;
                        if( prodXW > maxim )
                        {
                            maxim = prodXW;
                        }
                    }
                    fct_intrare_textBox.Text = maxim.ToString();
                }

                if( comboBoxVal == "Minim" )
                {
                    decimal minim = 9999M;
                    for (int i = 1; i <= contor; i++)
                    {
                        NumericUpDown x = (NumericUpDown)this.panel.Controls.Find( "xNumericUpDown" + i, true ).FirstOrDefault();
                        NumericUpDown w = (NumericUpDown)this.panel.Controls.Find( "wNumericUpDown" + i, true ).FirstOrDefault();
                        decimal prodXW = x.Value * w.Value;
                        if ( prodXW < minim )
                        {
                            minim = prodXW;
                        }
                    }
                    fct_intrare_textBox.Text = minim.ToString();
                }
            }

        #endregion

        #region FunctiaDeActivare

            System.Drawing.Point capatInterval = new System.Drawing.Point();
            decimal mijlocInterval;

            // Functii
            private decimal Fct_Treapta(decimal teta)
            {
                decimal x = Decimal.Parse(fct_intrare_textBox.Text);
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
                decimal x = decimal.Parse(fct_intrare_textBox.Text);
                return (decimal)(1.00 / (1.00 + Math.Pow(Math.E, (double)((-g) * (x - teta)))));
            }

            private decimal Fct_Semn(decimal teta)
            {
                decimal x = decimal.Parse(fct_intrare_textBox.Text);
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
                decimal x = decimal.Parse(fct_intrare_textBox.Text);
                return (decimal)((Math.Pow(Math.E, (double)(g * (x - teta))) - Math.Pow(Math.E, (double)((-g) * (x - teta))))
                     / (Math.Pow(Math.E, (double)(g * (x - teta))) + Math.Pow(Math.E, (double)((-g) * (x - teta)))));
            }

            private decimal Fct_Liniara(decimal teta, decimal a)
            {
                decimal x = decimal.Parse(fct_intrare_textBox.Text);
                if ( x > a )
                {
                    return 1.00M;
                }
                else
                if ( x < (-a) )
                {
                    return -1.00M;
                }
                else
                if ( ((-a) <= x) && (x <= a) ) // x e [-a,a] ; -a <= x <= a
                {
                    return (decimal)((x - teta) / a);
                }

                return 0;
            }

            private void FctActivareHandler()
            {
                g_line.Visible = true;
                g_label.Visible = true;
                g_numericUpDown.Visible = true;
                a_line.Visible = true;
                a_label.Visible = true;
                a_numericUpDown.Visible = true;

                decimal teta = teta_numericUpDown.Value;
                decimal g = g_numericUpDown.Value;
                decimal a = a_numericUpDown.Value;

                var comboBoxValue = fct_activare_comboBox.Text;

                if (comboBoxValue == "Treaptă")
                {
                    g_line.Visible = false;
                    g_label.Visible = false;
                    g_numericUpDown.Visible = false;
                    a_line.Visible = false;
                    a_label.Visible = false;
                    a_numericUpDown.Visible = false;

                    fct_activare_textBox.Text = Fct_Treapta(teta).ToString();

                    capatInterval.X = 0;
                    capatInterval.Y = 1;

                    mijlocInterval = (capatInterval.X + capatInterval.Y) / 2;
                }

                if (comboBoxValue == "Sigmoidală")
                {
                    a_line.Visible = false;
                    a_label.Visible = false;
                    a_numericUpDown.Visible = false;

                    fct_activare_textBox.Text = Fct_Sigmoidala(teta, g).ToString("0.########");

                    capatInterval.X = 0;
                    capatInterval.Y = 1;

                    mijlocInterval = (capatInterval.X + capatInterval.Y) / 2;
                }

                if (comboBoxValue == "Semn")
                {
                    g_line.Visible = false;
                    g_label.Visible = false;
                    g_numericUpDown.Visible = false;
                    a_line.Visible = false;
                    a_label.Visible = false;
                    a_numericUpDown.Visible = false;

                    fct_activare_textBox.Text = Fct_Semn(teta).ToString();

                    capatInterval.X = (-1);
                    capatInterval.Y = (+1);

                     mijlocInterval = (capatInterval.X + capatInterval.Y) / 2;
                }

                if (comboBoxValue == "Tangenta Hiperbolică")
                {
                    a_line.Visible = false;
                    a_label.Visible = false;
                    a_numericUpDown.Visible = false;

                    fct_activare_textBox.Text = Fct_TangentaHiperbolica(teta, g).ToString("0.########");

                    capatInterval.X = (-1);
                    capatInterval.Y = (+1);

                    mijlocInterval = (capatInterval.X + capatInterval.Y) / 2;
                }

                if (comboBoxValue == "Liniară")
                {
                    g_line.Visible = false;
                    g_label.Visible = false;
                    g_numericUpDown.Visible = false;

                    fct_activare_textBox.Text = Fct_Liniara(teta, a).ToString("0.########");

                    capatInterval.X = (-1);
                    capatInterval.Y = (+1);

                    mijlocInterval = (capatInterval.X + capatInterval.Y) / 2;
                }
                FctIesireHandler();
            }

            private void fct_activare_comboBox_SelectedIndexChanged( object sender, EventArgs e )
            {
                FctActivareHandler();
            }

            private void teta_numericUpDown_ValueChanged(object sender, EventArgs e)
            {
                FctActivareHandler();
            }

            private void g_numericUpDown_ValueChanged(object sender, EventArgs e)
            {
                FctActivareHandler();
            }

            private void a_numericUpDown_ValueChanged(object sender, EventArgs e)
            {
                FctActivareHandler();
            }

        #endregion

        #region FunctiaDeIesire

            private void FctIesireHandler()
            {
                decimal rezFinal = decimal.Parse(fct_activare_textBox.Text); 

                if (binar.Checked)
                {
                    if (rezFinal < mijlocInterval)
                    {
                        rezFinal = capatInterval.X;
                    }
                    else
                    if (rezFinal > mijlocInterval)
                    {
                        rezFinal = capatInterval.Y;
                    }
                    fct_iesire_textBox.Text = rezFinal.ToString();
                }
                else
                {
                    fct_iesire_textBox.Text = rezFinal.ToString();
                }
            }

            private void binar_CheckedChanged(object sender, EventArgs e)
            {
                  FctIesireHandler();
            }

        #endregion
    }
}
