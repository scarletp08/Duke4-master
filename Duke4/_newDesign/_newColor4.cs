﻿using System;
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
    public partial class _newColor4 : _newColor
    {
        public _newColor4()
        {
            InitializeComponent();
        }

        private void _newColor4_Load(object sender, EventArgs e)
        {
            FormTitle.ForeColor = Color.White;
            changeColors("507DBC", "A1C6EA", "B4CDEA", "E8F3FF");
        }
    }
}
