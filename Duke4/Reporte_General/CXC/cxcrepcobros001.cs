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
    public partial class cxcrepcobros001 : Duke4.MainReporte
    {
        public cxcrepcobros001()
        {
            InitializeComponent();
        }
        public DateTimePicker fechainicial = new DateTimePicker();
        public DateTimePicker fechafinal = new DateTimePicker();
        public int idcliente { get; set; }
        public string nombre { get; set; }
        public int idciudad { get; set; }
        public int idtipocliente { get; set; }
        public int idruta { get; set; }
        public int nulo { get; set; }
        public int idvendedor { get; set; }
        public int idsector { get; set; }
        public int idcondicion { get; set; }
        public int idregion { get; set; }
        public int idmunicipio { get; set; }
        public int idmoneda { get; set; }
        public string condicionncf { get; set; }
        public int cuentaincobrable { get; set; }
        public string orden { get; set; }
        public int efectivo { get; set; }
        public int cheque { get; set; }
        public int transferencia { get; set; }
        public int tarjeta { get; set; }



        
        private void cxcrepcobros001_Load(object sender, EventArgs e)
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
            int i =  this.spr_rep_Cobro001TableAdapter.Fill(this.dSCXC.spr_rep_Cobro001, Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(fechainicial), Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(fechafinal) ,idcliente, nombre, idtipocliente, idruta, nulo, idvendedor,
              idsector, idmunicipio, idciudad, idregion, cuentaincobrable, idmoneda,idcondicion , efectivo,cheque,transferencia,tarjeta, orden);


            return i;

        }

       

    }
}
