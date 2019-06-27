using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.Reporte_General.CXC
{
    public partial class cxcrepcliente001 : Duke4.MainReporte
    {
        public cxcrepcliente001()
        {
            InitializeComponent();
        }
        public string codigoinicial { get; set; }
        public string codigofinal { get; set; }
        public DateTimePicker fechainicial = new DateTimePicker();
        public DateTimePicker fechafinal = new DateTimePicker();
        public string nombre { get; set; }
        public int idciudad { get; set; }
        public int idtipocliente { get; set; }
        public int idruta { get; set; }
        public int nulo { get; set; }
        public int idcondicion { get; set; }
        public int idsector { get; set; }
        public int idregion { get; set; }
        public int idmunicipio { get; set; }
        public int idmoneda { get; set; }
        public string condicionncf { get; set; }
        public int cuentaincobrable { get; set; }
        public string orden { get; set; }
        public int itbis { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
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
            int i =// TODO: esta línea de código carga datos en la tabla 'dSCXC.spr_rep_cxc_cliente001' Puede moverla o quitarla según sea necesario.
            this.spr_rep_cxc_cliente001TableAdapter.Fill(this.dSCXC.spr_rep_cxc_cliente001, codigoinicial, codigofinal, nombre, idcondicion, idciudad, idtipocliente, idruta,condicionncf, Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(fechainicial), Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(fechafinal), nulo, itbis, cuentaincobrable, idsector, idmunicipio, idregion, orden);






            return i;

        }
    }
}
