using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ArhitecturaNeuronala
{
    public partial class NeuronalNetwork : Form
    {
        #region Global variables
        public decimal nrNeuronsInInputLayer;
        public decimal nrNeuronsInOutputLayer;
        public decimal nrHiddenLayers;
        public decimal nrNeuronsInHiddenLayer1;
        public decimal nrNeuronsInHiddenLayer2;
        public decimal nrNeuronsInHiddenLayer3;
        #endregion

        public NeuronalNetwork()
        {
            InitializeComponent();

            this.panel1.Controls.Find("button_Hidden1", true).FirstOrDefault().Enabled = false;
            this.panel1.Controls.Find("button_Hidden2", true).FirstOrDefault().Enabled = false;
            this.panel1.Controls.Find("button_Hidden3", true).FirstOrDefault().Enabled = false;
            this.panel1.Controls.Find("button_Output", true).FirstOrDefault().Enabled = false;
        }

        #region New Neuronal Network
        private void button_newNNetwork_Click(object sender, EventArgs e)
        {
            Generalinformation generalinformation = new Generalinformation(this);
            generalinformation.Show();
        }
        #endregion

        #region Hidden Buttons
        public void InactiveButtons()
        {
            if(nrHiddenLayers == 1)
            {
                this.panel1.Controls.Find("button_Hidden1", true).FirstOrDefault().Enabled = true;
                this.panel1.Controls.Find("button_Hidden2", true).FirstOrDefault().Enabled = false;
                this.panel1.Controls.Find("button_Hidden3", true).FirstOrDefault().Enabled = false;
            }
            if(nrHiddenLayers == 2)
            {
                this.panel1.Controls.Find("button_Hidden1", true).FirstOrDefault().Enabled = true;
                this.panel1.Controls.Find("button_Hidden2", true).FirstOrDefault().Enabled = true;
                this.panel1.Controls.Find("button_Hidden3", true).FirstOrDefault().Enabled = false;
            }
            if(nrHiddenLayers == 3)
            {
                this.panel1.Controls.Find("button_Hidden1", true).FirstOrDefault().Enabled = true;
                this.panel1.Controls.Find("button_Hidden2", true).FirstOrDefault().Enabled = true;
                this.panel1.Controls.Find("button_Hidden3", true).FirstOrDefault().Enabled = true;
            }
            this.panel1.Controls.Find("button_Output", true).FirstOrDefault().Enabled = true;
        }

        private void button_Hidden1_Click(object sender, EventArgs e)
        {
            HiddenLayers hiddenLayers = new HiddenLayers(1, this);
            hiddenLayers.Show();
        }

        private void button_Hidden2_Click(object sender, EventArgs e)
        {
            HiddenLayers hiddenLayers = new HiddenLayers(2, this);
            hiddenLayers.Show();
        }

        private void button_Hidden3_Click(object sender, EventArgs e)
        {
            HiddenLayers hiddenLayers = new HiddenLayers(3, this);
            hiddenLayers.Show();
        }

        private void button_Output_Click(object sender, EventArgs e)
        {
            Output output = new Output(4, this);
            output.Show();
        }

        #endregion

        #region Layers

        #region Handlers
            public void HandleInputButton_Click(object sender, EventArgs e)
            {
                InputRoundButton roundButton = sender as InputRoundButton;
                Input input = new Input(roundButton.indexStrat, roundButton.indexNeuronPerStrat, this);
                input.Text = "iN" + roundButton.indexNeuronPerStrat.ToString() + " Info";
                input.Show();
            }
            public void HandleHiddenButton_Click(object sender, EventArgs e)
            {
                RoundButton roundButton = sender as RoundButton;
                HiddenLayersNeurons hiddenLayers = new HiddenLayersNeurons(roundButton.indexStrat, roundButton.indexNeuronPerStrat, this);
                hiddenLayers.Show();
            }
            public void HandleSynapticWeights_Click(object sender, EventArgs e)
            {
                RoundButton roundButton = sender as RoundButton;
                SynapticWeights synapticWeights = new SynapticWeights(roundButton.indexStrat, roundButton.indexNeuronPerStrat, this);
                synapticWeights.Show();
            }
            public void HandleOutputNeurons_Click(object sender, EventArgs e)
            {
                RoundButton roundButton = sender as RoundButton;
                OutputNeurons outputNeurons = new OutputNeurons(roundButton.indexStrat, roundButton.indexNeuronPerStrat, this);
                outputNeurons.Show();
            }
        #endregion

            public void ClearButton()
            {
                foreach (Control b in panel2.Controls.OfType<InputRoundButton>().ToList())
                {
                    panel2.Controls.Remove(b);
                    b.Dispose();
                }

                foreach (Control b in panel2.Controls.OfType<RoundButton>().ToList())
                {
                    panel2.Controls.Remove(b);
                    b.Dispose();
                }
            }

            private void button_createNNetwork_Click(object sender, EventArgs e)
            {
                ClearButton();
            
                // strat input
                int marginTop = 80;
                for(int i = 1; i <= nrNeuronsInInputLayer; i++)
                {
                    InputRoundButton inputroundButton = new InputRoundButton(0, i, this);
                    inputroundButton.Name = "Input" + i.ToString();
                    inputroundButton.Text = "iN" + i.ToString();
                    inputroundButton.Size = new Size(50,50);
                    inputroundButton.Location = new Point(50, marginTop);
                    inputroundButton.BackColor = Color.SteelBlue;
                    inputroundButton.Click += new EventHandler(HandleInputButton_Click);
                    this.panel2.Controls.Add(inputroundButton);

                    marginTop += 100;
                }

                // straturi hidden
                marginTop = 50;
                for (int i = 1; i <= nrNeuronsInHiddenLayer1; i++)
                {
                    RoundButton roundButton = new RoundButton(1, i, this);
                    roundButton.Name = "HiddenL1" + i.ToString();
                    roundButton.Text = "h1N" + i.ToString();
                    roundButton.Size = new Size(53, 50);
                    roundButton.Location = new Point(320, marginTop);
                    roundButton.BackColor = Color.LightSteelBlue;
                    roundButton.indexStrat = 1;
                    roundButton.indexNeuronPerStrat = i;
                    roundButton.Click += new EventHandler(HandleHiddenButton_Click);
                    this.panel2.Controls.Add(roundButton);

                    RoundButton wButton = new RoundButton(1, i, this);
                    wButton.Name = "w1N" + i.ToString();
                    wButton.Text = "w";
                    wButton.ForeColor = Color.White;
                    wButton.Size = new Size(25, 25);
                    wButton.Location = new Point(300, marginTop-15);
                    wButton.BackColor = Color.DarkCyan;
                    wButton.indexStrat = 1;
                    wButton.indexNeuronPerStrat = i;
                    wButton.Click += new EventHandler(HandleSynapticWeights_Click);
                    this.panel2.Controls.Add(wButton);

                    marginTop += 100;
                }
                if(nrHiddenLayers > 1)
                {
                    marginTop = 20;
                    for (int i = 1; i <= nrNeuronsInHiddenLayer2; i++)
                    {
                        RoundButton roundButton = new RoundButton(2, i, this);
                        roundButton.Name = "HiddenL2" + i.ToString();
                        roundButton.Text = "h2N" + i.ToString();
                        roundButton.Size = new Size(53, 50);
                        roundButton.Location = new Point(550, marginTop);
                        roundButton.BackColor = Color.LightSteelBlue;
                        roundButton.indexStrat = 2;
                        roundButton.indexNeuronPerStrat = i;
                        roundButton.Click += new EventHandler(HandleHiddenButton_Click);
                        this.panel2.Controls.Add(roundButton);

                        RoundButton wButton = new RoundButton(2, i, this);
                        wButton.Name = "w2N" + i.ToString();
                        wButton.Text = "w";
                        wButton.ForeColor = Color.White;
                        wButton.Size = new Size(25, 25);
                        wButton.Location = new Point(530, marginTop-15);
                        wButton.BackColor = Color.DarkCyan;
                        wButton.indexStrat = 2;
                        wButton.indexNeuronPerStrat = i;
                        wButton.Click += new EventHandler(HandleSynapticWeights_Click);
                        this.panel2.Controls.Add(wButton);

                        marginTop += 100;
                    }
                }
                if (nrHiddenLayers > 2)
                {
                    marginTop = 50;
                    for (int i = 1; i <= nrNeuronsInHiddenLayer3; i++)
                    {
                        RoundButton roundButton = new RoundButton(3, i, this);
                        roundButton.Name = "HiddenL3" + i.ToString();
                        roundButton.Text = "h3N" + i.ToString();
                        roundButton.Size = new Size(53, 50);
                        roundButton.Location = new Point(780, marginTop);
                        roundButton.BackColor = Color.LightSteelBlue;
                        roundButton.indexStrat = 3;
                        roundButton.indexNeuronPerStrat = i;
                        roundButton.Click += new EventHandler(HandleHiddenButton_Click);
                        this.panel2.Controls.Add(roundButton);

                        RoundButton wButton = new RoundButton(3, i, this);
                        wButton.Name = "w3N" + i.ToString();
                        wButton.Text = "w";
                        wButton.ForeColor = Color.White;
                        wButton.Size = new Size(25, 25);
                        wButton.Location = new Point(760, marginTop-15);
                        wButton.BackColor = Color.DarkCyan;
                        wButton.indexStrat = 3;
                        wButton.indexNeuronPerStrat = i;
                        wButton.Click += new EventHandler(HandleSynapticWeights_Click);
                        this.panel2.Controls.Add(wButton);

                        marginTop += 100;
                    }
                }

                //strat output
                marginTop = 80;
                for (int i = 1; i <= nrNeuronsInOutputLayer; i++)
                {
                    RoundButton roundButton = new RoundButton(4, i, this);
                    roundButton.Name = "Output" + i.ToString();
                    roundButton.Text = "oN" + i.ToString();
                    roundButton.Size = new Size(50, 50);
                    roundButton.Location = new Point(1050, marginTop);
                    roundButton.BackColor = Color.SteelBlue;
                    roundButton.indexStrat = 4;
                    roundButton.indexNeuronPerStrat = i;
                    roundButton.Click += new EventHandler(HandleOutputNeurons_Click);
                    this.panel2.Controls.Add(roundButton);

                    RoundButton wButton = new RoundButton(4, i, this);
                    wButton.Name = "w3N" + i.ToString();
                    wButton.Text = "w";
                    wButton.ForeColor = Color.White;
                    wButton.Size = new Size(25, 25);
                    wButton.Location = new Point(1030, marginTop - 15);
                    wButton.BackColor = Color.DarkCyan;
                    wButton.indexStrat = 4;
                    wButton.indexNeuronPerStrat = i;
                    wButton.Click += new EventHandler(HandleSynapticWeights_Click);
                    this.panel2.Controls.Add(wButton);

                    marginTop += 100;
                }

                panel2.Paint += new PaintEventHandler(Line);
                panel2.Refresh();
            }
        #endregion

        #region Lines
        
            private void Line(object sender, PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Red, 1);
                int i, j;

                if (nrHiddenLayers == 1)
                {
                    for (i = 1; i <= nrNeuronsInInputLayer; i++) // I
                    {
                        InputRoundButton buttonInput = (InputRoundButton)this.panel2.Controls.Find("Input" + i, true).FirstOrDefault();

                        for (j = 1; j <= nrNeuronsInHiddenLayer1; j++) // HL1
                        {
                            RoundButton hiddenL1 = (RoundButton)this.panel2.Controls.Find("HiddenL1" + j, true).FirstOrDefault();
                            g.DrawLine(pen, buttonInput.Location.X + 50, buttonInput.Location.Y + 25, hiddenL1.Location.X, hiddenL1.Location.Y + 25);
                        }
                    }
                    for (i = 1; i <= nrNeuronsInHiddenLayer1; i++) // HL1
                    {
                        RoundButton hiddenL1 = (RoundButton)this.panel2.Controls.Find("HiddenL1" + i, true).FirstOrDefault();

                        for (j = 1; j <= nrNeuronsInOutputLayer; j++) // O
                        {
                            RoundButton buttonOutput = (RoundButton)this.panel2.Controls.Find("Output" + j, true).FirstOrDefault();
                            g.DrawLine(pen, hiddenL1.Location.X + 50, hiddenL1.Location.Y + 25, buttonOutput.Location.X, buttonOutput.Location.Y + 25);
                    
                        }
                    }
                }
                if (nrHiddenLayers == 2)
                {
                    for (i = 1; i <= nrNeuronsInInputLayer; i++) // I
                    {
                        InputRoundButton buttonInput = (InputRoundButton)this.panel2.Controls.Find("Input" + i, true).FirstOrDefault();

                        for (j = 1; j <= nrNeuronsInHiddenLayer1; j++) // HL1
                        {
                            RoundButton hiddenL1 = (RoundButton)this.panel2.Controls.Find("HiddenL1" + j, true).FirstOrDefault();
                            g.DrawLine(pen, buttonInput.Location.X + 50, buttonInput.Location.Y + 25, hiddenL1.Location.X, hiddenL1.Location.Y + 25);
                        }
                    }
                    for (i = 1; i <= nrNeuronsInHiddenLayer1; i++) // HL1
                    {
                        RoundButton hiddenL1 = (RoundButton)this.panel2.Controls.Find("HiddenL1" + i, true).FirstOrDefault();

                        for (j = 1; j <= nrNeuronsInHiddenLayer2; j++) // HL2
                        {
                            RoundButton hiddenL2 = (RoundButton)this.panel2.Controls.Find("HiddenL2" + j, true).FirstOrDefault();
                            g.DrawLine(pen, hiddenL1.Location.X + 50, hiddenL1.Location.Y + 25, hiddenL2.Location.X, hiddenL2.Location.Y + 25);
                        }
                    }
                    for (i = 1; i <= nrNeuronsInHiddenLayer2; i++) // HL2
                    {
                        RoundButton hiddenL2 = (RoundButton)this.panel2.Controls.Find("HiddenL2" + i, true).FirstOrDefault();

                        for (j = 1; j <= nrNeuronsInOutputLayer; j++) // O
                        {
                            RoundButton buttonOutput = (RoundButton)this.panel2.Controls.Find("Output" + j, true).FirstOrDefault();
                            g.DrawLine(pen, hiddenL2.Location.X + 50, hiddenL2.Location.Y + 25, buttonOutput.Location.X, buttonOutput.Location.Y + 25);
                        }
                    }
                }
                if (nrHiddenLayers == 3)
                {
                    for (i = 1; i <= nrNeuronsInInputLayer; i++) // I
                    {
                        InputRoundButton buttonInput = (InputRoundButton)this.panel2.Controls.Find("Input" + i, true).FirstOrDefault();

                        for (j = 1; j <= nrNeuronsInHiddenLayer1; j++) // HL1
                        {
                            RoundButton hiddenL1 = (RoundButton)this.panel2.Controls.Find("HiddenL1" + j, true).FirstOrDefault();
                            g.DrawLine(pen, buttonInput.Location.X + 50, buttonInput.Location.Y + 25, hiddenL1.Location.X, hiddenL1.Location.Y + 25);
                        }
                    }
                    for (i = 1; i <= nrNeuronsInHiddenLayer1; i++) // HL1
                    {
                        RoundButton hiddenL1 = (RoundButton)this.panel2.Controls.Find("HiddenL1" + i, true).FirstOrDefault();

                        for (j = 1; j <= nrNeuronsInHiddenLayer2; j++) // HL2
                        {
                            RoundButton hiddenL2 = (RoundButton)this.panel2.Controls.Find("HiddenL2" + j, true).FirstOrDefault();
                            g.DrawLine(pen, hiddenL1.Location.X + 50, hiddenL1.Location.Y + 25, hiddenL2.Location.X, hiddenL2.Location.Y + 25);
                        }
                    }
                    for (i = 1; i <= nrNeuronsInHiddenLayer2; i++) // HL2
                    {
                        RoundButton hiddenL2 = (RoundButton)this.panel2.Controls.Find("HiddenL2" + i, true).FirstOrDefault();

                        for (j = 1; j <= nrNeuronsInHiddenLayer3; j++) // HL3
                        {
                            RoundButton hiddenL3 = (RoundButton)this.panel2.Controls.Find("HiddenL3" + j, true).FirstOrDefault();
                            g.DrawLine(pen, hiddenL2.Location.X + 50, hiddenL2.Location.Y + 25, hiddenL3.Location.X, hiddenL3.Location.Y + 25);
                        }
                    }
                    for (i = 1; i <= nrNeuronsInHiddenLayer3; i++) // HL3
                    {
                        RoundButton hiddenL3 = (RoundButton)this.panel2.Controls.Find("HiddenL3" + i, true).FirstOrDefault();

                        for (j = 1; j <= nrNeuronsInOutputLayer; j++) // O
                        {
                            RoundButton buttonOutput = (RoundButton)this.panel2.Controls.Find("Output" + j, true).FirstOrDefault();
                            g.DrawLine(pen, hiddenL3.Location.X + 50, hiddenL3.Location.Y + 25, buttonOutput.Location.X, buttonOutput.Location.Y + 25);
                        }
                    }
                }
            }
        #endregion
    }
}
