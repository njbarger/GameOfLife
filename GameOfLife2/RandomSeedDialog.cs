using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife2
{
    public partial class RandomSeedDialog : Form
    {
        public RandomSeedDialog()
        {
            InitializeComponent();
        }

        public int RngSeed
        {
            get
            {
                return (int)numericUpDown1.Value;
            }
            set
            {
                numericUpDown1.Value = (int)value;
            }
        }

        // Allow random seed option
        private void RandomizeSeed_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            RngSeed = rng.Next(0, int.MaxValue);

        }
    }
}
