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
    public partial class GridSizeDialog : Form
    {
        public GridSizeDialog()
        {
            InitializeComponent();
        }
        public float Width
        {
            get
            {
                return (float)numericUpDownWidth.Value;
            }
            set
            {
                numericUpDownWidth.Value = (decimal)value;
            }
        }
        public float Height
        {
            get
            {
                return (float)numericUpDownHeight.Value;
            }
            set
            {
                numericUpDownHeight.Value = (decimal)value;
            }
        }
    }
}
