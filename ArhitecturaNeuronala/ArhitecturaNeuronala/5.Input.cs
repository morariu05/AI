using System;
using System.Linq;
using System.Windows.Forms;

namespace ArhitecturaNeuronala
{
    public partial class Input : Form
    {
        public NeuronalNetwork mainform = new NeuronalNetwork();
        public int indexStrat;
        public int indexNeuronPerStrat;

        public Input(int _indexStrat, int _indexNeuronPerStrat, NeuronalNetwork _mainform)
        {
            indexStrat = _indexStrat;
            indexNeuronPerStrat = _indexNeuronPerStrat;
            mainform = _mainform;

            InitializeComponent();

            foreach (Control b in mainform.panel2.Controls.OfType<InputRoundButton>().ToList())
            {
                InputRoundButton rbtn = (InputRoundButton)b;
                if (rbtn.indexStrat == this.indexStrat && rbtn.indexNeuronPerStrat == this.indexNeuronPerStrat)
                {
                    numericInput.Value = rbtn.valueX;
                }
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            // foreach neuron in layer i
            foreach (Control b in mainform.panel2.Controls.OfType<InputRoundButton>().ToList())
            {
                InputRoundButton rbtn = (InputRoundButton)b;
                if (rbtn.indexStrat == this.indexStrat && rbtn.indexNeuronPerStrat == this.indexNeuronPerStrat)
                {
                    rbtn.valueX = numericInput.Value;
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
