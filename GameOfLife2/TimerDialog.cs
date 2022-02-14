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
    public partial class TimerDialog : Form
    {
        
        public TimerDialog()
        {
            InitializeComponent();
        }

        public int TimerSpeed
        {
            get
            {
                return (int)numericUpDown1.Value;
            }
            set
            {
                numericUpDown1.Value = value;
            }

        }

    }
}
