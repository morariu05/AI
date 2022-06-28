using System;
using System.Linq;
using System.Windows.Forms;

namespace ArhitecturaNeuronala
{
    public partial class OutputNeurons : Form
    {
        public NeuronalNetwork mainform = new NeuronalNetwork();
        public int indexStrat;
        public int indexNeuronPerStrat;

        public OutputNeurons(int _indexStrat, int _indexNeuronPerStrat, NeuronalNetwork _mainform)
        {
            indexStrat = _indexStrat;
            indexNeuronPerStrat = _indexNeuronPerStrat;
            mainform = _mainform;

            InitializeComponent();

            this.Text = "oN" + indexNeuronPerStrat.ToString() + " Information";

            foreach (Control b in mainform.panel2.Controls.OfType<RoundButton>().ToList())
            {
                RoundButton rbtn = (RoundButton)b;
                if (rbtn.indexStrat == this.indexStrat && rbtn.indexNeuronPerStrat == this.indexNeuronPerStrat)
                {
                    textBox_globalInputValue.Text = rbtn.rezInput.ToString();
                    textBox_activValue.Text = rbtn.rezActivation.ToString();
                    textBox_outputValue.Text = rbtn.rezOutput.ToString();
                }
            }
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
