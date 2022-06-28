using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArhitecturaNeuronala
{
    public class InputRoundButton : Button
    {
        NeuronalNetwork mainform;

        public int indexStrat;
        public int indexNeuronPerStrat;

        public decimal valueX = 0M;

        public InputRoundButton(int _indexStrat, int _indexNeuronPerStrat, NeuronalNetwork _mainForm)
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
    }
}
