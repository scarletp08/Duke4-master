using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.CXP.Proceso
{
    public partial class cxpproregistro : Duke4.MainFormProceso
    {
        public cxpproregistro()
        {
            InitializeComponent();
        }

        private void cxpproregistro_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Registro de Factura", this);
        }
    }
}
