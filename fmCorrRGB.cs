using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace myPaint
{
    public partial class fmCorrRGB : Form
    {
        public fmCorrRGB()
        {
            InitializeComponent();
        }

        private void fmCorrRGB_Load(object sender, EventArgs e)
        {
            pnlRed.BackColor = Color.FromArgb(220, 0, 0);
            pnlGreen.BackColor = Color.FromArgb(0, 220, 0);
            pnlBlue.BackColor = Color.FromArgb(0, 0, 220);
        }

        public int CorrR
        {
            get
            {
                return (int)tbRed.Value; 
            }
        }

        public int CorrG
        {
            get
            {
                return (int)tbGreen.Value;
            }
        }

        public int CorrB
        {
            get
            {
                return (int)tbBlue.Value;
            }
        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
            pnlRed.BackColor = Color.FromArgb(220 + (int)tbRed.Value, 0, 0);
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            pnlGreen.BackColor = Color.FromArgb(0, 220 + (int)tbGreen.Value, 0);
        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            pnlBlue.BackColor = Color.FromArgb(0, 0, 220 + (int)tbBlue.Value);
        }
    }
}
