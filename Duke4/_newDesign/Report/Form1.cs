using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duke4._newDesign.Report
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string idRegistro = "";
        public string Copia = "";

        protected void parametros()
        {

            ReportParameter[] v = new ReportParameter[5];
            v[0] = new ReportParameter("Nombreempresa", "CXA DUKE SOURCE 4.0");
            v[1] = new ReportParameter("Direccionempresa", "CARRETERA DUARTE KM 5 1/2, SANTIAGO, REP. DOM.");
            v[2] = new ReportParameter("Telefonoempresa", "TEL.: 809-226-8554");
            v[3] = new ReportParameter("RNCempresa", "TEL.: 809-226-8554");
            v[4] = new ReportParameter("Emailempresa", "TEL.: 809-226-8554");

            //if (parametro.Length > 0)
            //{
            //    int a = 0;
            //    for (int c = 5; c < lengthparam; c++)
            //    {
            //        v[c] = parametro[a];
            //        a++;
            //    }

            //}
            reportViewer1.LocalReport.SetParameters(v);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fun_Reporte();
        }

        public void Fun_Reporte()
        {
            ReportParameter[] v = new ReportParameter[1];
            // TODO: This line of code loads data into the 'DataSet1.spr_rep_cxc_multipleRegistro01' table. You can move, or remove it, as needed.
            this.spr_rep_cxc_multipleRegistro01TableAdapter.Fill(this.DataSet1.spr_rep_cxc_multipleRegistro01, idRegistro);

            this.reportViewer1.RefreshReport();
            parametros();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 110;
            var setup = reportViewer1.GetPageSettings();
            setup.Margins = new System.Drawing.Printing.Margins(1, 1, 1, 1);
            reportViewer1.SetPageSettings(setup);
        }

    }
}
