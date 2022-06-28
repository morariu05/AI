using System;
using System.Linq;
using System.Windows.Forms;

namespace ArhitecturaNeuronala
{
    public partial class SynapticWeights : Form
    {
        NeuronalNetwork mainform = new NeuronalNetwork();
        public int indexStrat;
        public int indexNeuronPerStrat;

        public SynapticWeights(int _indexStrat, int _indexNeuronPerStrat, NeuronalNetwork _mainform)
        {
            indexStrat = _indexStrat;
            indexNeuronPerStrat = _indexNeuronPerStrat;
            mainform = _mainform;

            InitializeComponent();

            if (indexStrat == 4)
            {
                this.Text = "oN" + indexNeuronPerStrat.ToString() + " Synaptic Weights Information";
            }
            else
            {
                this.Text = "h" + indexStrat.ToString() + "N" + indexNeuronPerStrat.ToString() + " Synaptic Weights Information";
            }


            int marginTop = 12;
            foreach (Control b in mainform.panel2.Controls.OfType<RoundButton>())
            {
                RoundButton rbtn = (RoundButton)b;
                if (rbtn.indexNeuronPerStrat == this.indexNeuronPerStrat && rbtn.indexStrat == this.indexStrat)
                {
                    for (int i = 0; i < rbtn.w.Count; i++)
                    {
                        Label xLabel = new Label();
                        xLabel.Name = "xi" + i.ToString();
                        xLabel.Text = "Input " + i.ToString();
                        xLabel.Size = new System.Drawing.Size(50, 20);
                        xLabel.Location = new System.Drawing.Point(15, marginTop);
                        this.panel.Controls.Add(xLabel);

                        TextBox xTextBox = new TextBox();
                        xTextBox.Name = "xTextBox" + i.ToString();
                        xTextBox.Size = new System.Drawing.Size(125, 27);
                        xTextBox.Location = new System.Drawing.Point(90, marginTop - 2);
                        xTextBox.ReadOnly = true;
                        xTextBox.Text = rbtn.x[i].ToString();
                        this.panel.Controls.Add(xTextBox);

                        Label wLabel = new Label();
                        wLabel.Name = "wi" + i.ToString();
                        wLabel.Text = "Synaptic Weight " + i.ToString();
                        wLabel.Size = new System.Drawing.Size(120, 20);
                        wLabel.Location = new System.Drawing.Point(265, marginTop);
                        this.panel.Controls.Add(wLabel);

                        NumericUpDown wNumericUpDown = new NumericUpDown();
                        wNumericUpDown.Name = "wNumericUpDown" + i.ToString();
                        wNumericUpDown.Size = new System.Drawing.Size(91, 27);
                        wNumericUpDown.Location = new System.Drawing.Point(415, marginTop - 2);
                        wNumericUpDown.TextAlign = HorizontalAlignment.Center;
                        wNumericUpDown.Value = rbtn.w[i];
                        wNumericUpDown.DecimalPlaces = 2;
                        wNumericUpDown.Increment = 0.01M;
                        wNumericUpDown.Maximum = 100;
                        wNumericUpDown.Minimum = -100;
                        this.panel.Controls.Add(wNumericUpDown);

                        marginTop = marginTop + 30;
                    }
                    break;
                }
            }
        }
        
        private void button_Save_Click(object sender, EventArgs e)
        {
            RoundButton clickedButton = sender as RoundButton;

            foreach (Control b in mainform.panel2.Controls.OfType<RoundButton>())
            {
                RoundButton rbtn = (RoundButton)b;
                if (rbtn.indexNeuronPerStrat == this.indexNeuronPerStrat && rbtn.indexStrat == this.indexStrat)
                {
                    rbtn.x.Clear();
                    rbtn.w.Clear();
                    rbtn.xProdw.Clear();

                    int index = 1;
                    NumericUpDown w = new NumericUpDown();
                    TextBox x = new TextBox();

                    x = (TextBox)this.panel.Controls.Find("xTextBox" + index, true).FirstOrDefault();
                    w = (NumericUpDown)this.panel.Controls.Find("wNumericUpDown" + index, true).FirstOrDefault();
                    while (x != null && w != null)
                    {
                        x = (TextBox)this.panel.Controls.Find("xTextBox" + index, true).FirstOrDefault();
                        w = (NumericUpDown)this.panel.Controls.Find("wNumericUpDown" + index, true).FirstOrDefault();

                        rbtn.x.Add(int.Parse(x.Text));
                        rbtn.w.Add(w.Value);
                        rbtn.xProdw.Add(int.Parse(x.Text) * w.Value);
                        index++;
                    }
                }
            }



            foreach (Control b in mainform.panel2.Controls.OfType<RoundButton>())
            {
                RoundButton rbtn = (RoundButton)b;
                rbtn.RefreshResult();
            }

            this.Close();
        }
    }
}
