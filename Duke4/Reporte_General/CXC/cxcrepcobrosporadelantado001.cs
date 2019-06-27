using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Duke4.Reporte_General.CXC
{
    public partial class cxcrepcobrosporadelantado001 : Duke4.MainReporte
    {
        public cxcrepcobrosporadelantado001()
        {
            InitializeComponent();
        }
        public DateTimePicker fechainicial = new DateTimePicker();
        public DateTimePicker fechafinal = new DateTimePicker();
        public int idmoneda { get; set; }
        public string nombre { get; set; }
        public int nulo { get; set; }
        public string orden { get; set; }

        private void cxcrepcobrosporadelantado001_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSCXC.spr_rep_Cobro_Adelantado001' Puede moverla o quitarla según sea necesario.
         
            // TODO: esta línea de código carga datos en la tabla 'dSCXC.spr_rep_Cobro_Adelantado001' Puede moverla o quitarla según sea necesario.

           

            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportEmbeddedResource = "Duke4.Reporte_General.CXC." + informe;
            this.reportViewer1.RefreshReport();
            ReportParameter[] v = new ReportParameter[2];
            v[0] = new ReportParameter("desde", Convert.ToDateTime(fechainicial.Value).ToShortDateString());
            v[1] = new ReportParameter("hasta", Convert.ToDateTime(fechafinal.Value).ToShortDateString());
            parametros(v);
          
        }
        public int cuentafilas()
        {
            int i =  // TODO: esta línea de código carga datos en la tabla 'dSCXC.spr_rep_cxc_otros_ingresos001' Puede moverla o quitarla según sea necesario.
            this.spr_rep_Cobro_Adelantado001TableAdapter.Fill(this.dSCXC.spr_rep_Cobro_Adelantado001 , nombre, Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(fechainicial), Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(fechafinal), nulo, idmoneda, orden);


            return i;
        }
    }
}
