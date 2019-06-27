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
    public partial class _newColor2 : _newColor
    {
        public _newColor2()
        {
            InitializeComponent();
        }

        private void _newColor2_Load(object sender, EventArgs e)
        {
            changeColors("69926B", "BBE1BD", "92B895", "E5F5E6");
        }
    }
}
