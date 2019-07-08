using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.CXC.Reporte
{
    public partial class Form2 : Duke4.MainReporte
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int Idfactura
        { get;
            set;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1234.reportefactura1' Puede moverla o quitarla según sea necesario.
            Fun_Reporte();
        }
        public void Fun_Reporte()
        {


            ReportParameter[] v = new ReportParameter[1];
            v[0] = new ReportParameter("copia", _Letrero_Copia);
            // TODO: esta línea de código carga datos en la tabla 'dSCXC.Spr_rep_cxc_registro01' Puede moverla o quitarla según sea necesario.
            this.reportefactura1TableAdapter.Fill(this.DataSet1234.reportefactura1, Idfactura);
            this.reportViewer1.RefreshReport();
            parametros(v);

        }
    }
}
