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
    public partial class Forreporte22 : Duke4.MainReporte
    {
        public Forreporte22()
        {
            InitializeComponent();
        }
        public int Idfactura
        {
            get;
            set;
        }
        private void Forreporte22_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsreporte2.reportefactura2' Puede moverla o quitarla según sea necesario.
           
            // TODO: esta línea de código carga datos en la tabla 'dsreporte2.reportefactura2' Puede moverla o quitarla según sea necesario.

            // TODO: esta línea de código carga datos en la tabla 'Dsreporte2.reportefactura2' Puede moverla o quitarla según sea necesario.
            Fun_Reporte();

        }
        public void Fun_Reporte()
        {

            
            ReportParameter[] v = new ReportParameter[1];
            v[0] = new ReportParameter("copia", _Letrero_Copia);
            this.reportefactura2TableAdapter.Fill(this.dsreporte2.reportefactura2, Idfactura);
            this.reportViewer1.RefreshReport();
            parametros(v);
        }
    }
}
