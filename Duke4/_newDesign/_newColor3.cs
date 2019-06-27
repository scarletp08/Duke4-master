using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duke4._newDesign
{
    public partial class _newColor3 : _newColor
    {
        public _newColor3()
        {
            InitializeComponent();
        }

        private void _newColor3_Load(object sender, EventArgs e)
        {
            FormTitle.ForeColor = Color.White;
            changeColors("326273", "65AEBF", "65AEBF", "D7E0E5");
        }
    }
}
