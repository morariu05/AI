using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ArhitecturaNeuronala
{
    public partial class Generalinformation : Form
    {
        NeuronalNetwork neuronalNetwork;

        public Generalinformation(NeuronalNetwork neuronalNtw)
        {
            neuronalNetwork = neuronalNtw;

            InitializeComponent();
        }

        int contor = 1;
        int marginTop = 80;

        #region Hidden Layers

        private void numeric_Hidden_ValueChanged(object sender, EventArgs e)
        {
            if(contor < numeric_Hidden.Value)
            {
                contor++;
                Label nrHiddenLayer = new Label();
                nrHiddenLayer.Name = "nrHiddenLayer" + contor.ToString();
                nrHiddenLayer.Text = "Number of Neurons in the Hidden Layer " + contor.ToString();
                nrHiddenLayer.Size = new Size(300, 20);
                nrHiddenLayer.Location = new Point(9, marginTop);
                this.panel.Controls.Add(nrHiddenLayer);

                NumericUpDown nrNeuronsInHiddenLayer = new NumericUpDown();
                nrNeuronsInHiddenLayer.Name = "nrNeuronsInHiddenLayer" + contor.ToString();
                nrNeuronsInHiddenLayer.Size = new Size(80, 27);
                nrNeuronsInHiddenLayer.Location = new Point(332, (marginTop - 2));
                nrNeuronsInHiddenLayer.Value = 1;
                nrNeuronsInHiddenLayer.Minimum = 1;
                nrNeuronsInHiddenLayer.TextAlign = HorizontalAlignment.Center;
                this.panel.Controls.Add(nrNeuronsInHiddenLayer);

                marginTop += 45;
            }
            else
            {
                this.panel.Controls.Remove(this.panel.Controls.Find("nrHiddenLayer" + contor, true).FirstOrDefault());
                this.panel.Controls.Remove(this.panel.Controls.Find("nrNeuronsInHiddenLayer" + contor, true).FirstOrDefault());

                contor--;
                marginTop -= 45;
            }
        }

        #endregion

        #region Save Button
        private void button_Save_Click(object sender, EventArgs e)
        {
            neuronalNetwork.nrNeuronsInInputLayer = numeric_Input.Value;
            neuronalNetwork.nrNeuronsInOutputLayer = numeric_Output.Value;
            neuronalNetwork.nrHiddenLayers = numeric_Hidden.Value;
            neuronalNetwork.nrNeuronsInHiddenLayer1 = numericHiddenL1.Value;

            if(numeric_Hidden.Value > 1)
            {
                NumericUpDown numericHiddenL2 = (NumericUpDown)this.panel.Controls.Find("nrNeuronsInHiddenLayer" + contor, true).FirstOrDefault();
                neuronalNetwork.nrNeuronsInHiddenLayer2 = numericHiddenL2.Value;
            }
            if(numeric_Hidden.Value > 2)
            {
                NumericUpDown numericHiddenL3 = (NumericUpDown)this.panel.Controls.Find("nrNeuronsInHiddenLayer" + contor, true).FirstOrDefault();
                neuronalNetwork.nrNeuronsInHiddenLayer3 = numericHiddenL3.Value;
            }

            neuronalNetwork.InactiveButtons();

            this.Close();
        }
        #endregion

    }
}
