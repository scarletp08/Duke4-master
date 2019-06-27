using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.CXC.Archivo
{
    public partial class pruebascr : Duke4.MainFormMant
    {
        public pruebascr()
        {
            InitializeComponent();
        }

        private void pruebascr_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Fechas importantes", this);


        }

        private void btnBase1_Click(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
