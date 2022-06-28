using System;
using System.Linq;
using System.Windows.Forms;

namespace ArhitecturaNeuronala
{
    public partial class HiddenLayers : Form
    {
        public NeuronalNetwork mainform = new NeuronalNetwork();
        public int indexStrat;

        public HiddenLayers(int _indexStrat, NeuronalNetwork _mainform)
        {
            indexStrat = _indexStrat;
            mainform = _mainform;

            InitializeComponent();


            foreach(Control b in mainform.panel2.Controls.OfType<RoundButton>().ToList())
            {
                RoundButton rbtn = (RoundButton)b;
                if (rbtn.indexStrat == rbtn.indexStrat)
                {
                    fct_intrare_comboBox.SelectedItem = rbtn.selectorInputFunction;
                    fct_activare_comboBox.SelectedItem = rbtn.selectorActivationFunction;
                    comboBox_Output.SelectedItem = rbtn.selectorOutputFunction;

                    teta_numericUpDown.Value = rbtn.teta;
                    a_numericUpDown.Value = rbtn.a;
                    g_numericUpDown.Value = rbtn.g;
                }
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            foreach (Control b in mainform.panel2.Controls.OfType<RoundButton>().ToList())
            {
                RoundButton rbtn = (RoundButton)b;
                if (rbtn.indexStrat == rbtn.indexStrat)
                {
                    rbtn.selectorInputFunction = fct_intrare_comboBox.SelectedItem.ToString();
                    rbtn.selectorActivationFunction = fct_activare_comboBox.SelectedItem.ToString();
                    rbtn.selectorOutputFunction = comboBox_Output.SelectedItem.ToString();

                    rbtn.teta = teta_numericUpDown.Value;
                    rbtn.a = a_numericUpDown.Value;
                    rbtn.g = g_numericUpDown.Value;
                }
            }

            this.Close();
        }

        #region Input_SelectedIndexChanged

        private void comboBox_Input_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBoxVal = fct_intrare_comboBox.Text;

            // foreach neuron in layer i
            foreach (Control b in mainform.panel2.Controls.OfType<RoundButton>().ToList())
            {
                RoundButton rbtn = (RoundButton)b;
                if (rbtn.indexStrat == this.indexStrat)
                {
                    rbtn.selectorInputFunction = comboBoxVal;
                }
            }
        }
        #endregion

        #region Activation_SelectedIndexChanged

        private void comboBox_Activation_SelectedIndexChanged(object sender, EventArgs e)
        {
            g_label.Visible = true;
            g_numericUpDown.Visible = true;
            a_label.Visible = true;
            a_numericUpDown.Visible = true;

            decimal teta = teta_numericUpDown.Value;
            decimal g = g_numericUpDown.Value;
            decimal a = a_numericUpDown.Value;

            var comboBoxValue = fct_activare_comboBox.Text;

            // foreach neuron in layer i
            foreach (Control b in mainform.panel2.Controls.OfType<RoundButton>())
            {
                RoundButton rbtn = (RoundButton)b;
                if (rbtn.indexStrat == this.indexStrat)
                {
                    rbtn.selectorActivationFunction = comboBoxValue;
                }
            }

            if (comboBoxValue == "Treaptă")
            {
                g_label.Visible = false;
                g_numericUpDown.Visible = false;
                a_label.Visible = false;
                a_numericUpDown.Visible = false;
            }

            if (comboBoxValue == "Sigmoidală")
            {
                a_label.Visible = false;
                a_numericUpDown.Visible = false;
            }

            if (comboBoxValue == "Semn")
            {
                g_label.Visible = false;
                g_numericUpDown.Visible = false;
                a_label.Visible = false;
                a_numericUpDown.Visible = false;
            }

            if (comboBoxValue == "Tangenta Hiperbolică")
            {
                a_label.Visible = false;
                a_numericUpDown.Visible = false;
            }

            if (comboBoxValue == "Liniară")
            {
                g_label.Visible = false;
                g_numericUpDown.Visible = false;
            }
        }
        #endregion

        #region Output_SelectedIndexChanged
        private void comboBox_Output_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBoxVal = comboBox_Output.Text;

            // foreach neuron in layer i
            foreach (Control b in mainform.panel2.Controls.OfType<RoundButton>().ToList())
            {
                RoundButton rbtn = (RoundButton)b;
                if (rbtn.indexStrat == this.indexStrat)
                {
                    rbtn.selectorOutputFunction = comboBoxVal;
                }
            }
        }
        #endregion
    }
}
