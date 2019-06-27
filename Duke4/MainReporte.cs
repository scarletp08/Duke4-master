using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duke4
{
    public partial class MainReporte : Form
    {
        public MainReporte()
        {
            InitializeComponent();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 110;
            
        }
        public string _Letrero_Copia = "";
        protected void parametros(ReportParameter[] parametro)
        {
            int lengthparam = 5 + parametro.Length;

            ReportParameter[] v= new ReportParameter[lengthparam];
            v[0] = new ReportParameter("Nombreempresa", "CXA DUKE SOURCE 4.0");
            v[1] = new ReportParameter("Direccionempresa", "CARRETERA DUARTE KM 5 1/2, SANTIAGO, REP. DOM.");
            v[2] = new ReportParameter("Telefonoempresa", "TEL.: 809-226-8554");
            v[3] = new ReportParameter("RNCempresa", "TEL.: 809-226-8554");
            v[4] = new ReportParameter("Emailempresa", "TEL.: 809-226-8554");

            if (parametro.Length > 0)
            {
                int a = 0;
                for (int c = 5; c < lengthparam; c++)
                {
                    v[c] = parametro[a];
                    a++;
                }
                
            }
            reportViewer1.LocalReport.SetParameters(v);
            

        }


        protected void parametros2()
        {
            int lengthparam = 5;

            ReportParameter[] v = new ReportParameter[lengthparam];
            v[0] = new ReportParameter("Nombreempresa", "CXA DUKE SOURCE 4.0");
            v[1] = new ReportParameter("Direccionempresa", "CARRETERA DUARTE KM 5 1/2, SANTIAGO, REP. DOM.");
            v[2] = new ReportParameter("Telefonoempresa", "TEL.: 809-226-8554");
            v[3] = new ReportParameter("RNCempresa", "TEL.: 809-226-8554");
            v[4] = new ReportParameter("Emailempresa", "TEL.: 809-226-8554");

            reportViewer1.LocalReport.SetParameters(v);


        }

        public string informe = "";
        public bool horizontal = false;
        private void Form2_Load(object sender, EventArgs e)
        {
            if (informe != "")
                this.Text = informe;
            else this.Text = this.Name;
            DisableWheelNavigation(reportViewer1);
            
            //if (horizontal)
            //{
                //int a = 1;

                //System.Drawing.Printing.PageSettings ps = new System.Drawing.Printing.PageSettings();
                //ps.Landscape = true;
                //ps.PaperSize.RawKind = (int)System.Drawing.Printing.PaperKind.Letter;
                ////ps.Margins = new System.Drawing.Printing.Margins(1,1,0, 0);
                //reportViewer1.SetPageSettings(ps);
            //}
        }
        public void DisableWheelNavigation(ReportViewer r)
        {
            bool fromToolbar = false;
            r.PageNavigation += (obj, ea) => {
                if (fromToolbar) fromToolbar = false;
                else ea.Cancel = true;
            };
            var buttons = new string[] { "firstPage", "previousPage", "nextPage", "lastPage" };
            var toolstrip = r.Controls.Find("toolStrip1", true).OfType<ToolStrip>().First();
            toolstrip.Items.OfType<ToolStripButton>()
                .Where(button => buttons.Contains(button.Name)).ToList().ForEach(item => {
                    var clickEvent = item.GetType().GetEvent("Click");
                    var removeMethod = clickEvent.GetRemoveMethod();
                    var d = Delegate.CreateDelegate(clickEvent.EventHandlerType,
                        toolstrip.Parent, "OnPageNavButtonClick");
                    removeMethod.Invoke(item, new object[] { d });
                    item.Click += (obj, ev) => {
                        var onPageNavigation = toolstrip.Parent.GetType()
                            .GetMethod("OnPageNavigation",
                        BindingFlags.NonPublic | BindingFlags.Instance);
                        Action<int> OnPageNavigation = i => {
                            fromToolbar = true;
                            onPageNavigation.Invoke(toolstrip.Parent, new object[] { i });
                        };
                        if (item.Name == "firstPage") OnPageNavigation(1);
                        else if (item.Name == "previousPage") OnPageNavigation(r.CurrentPage - 1);
                        else if (item.Name == "nextPage") OnPageNavigation(r.CurrentPage + 1);
                        else if (item.Name == "lastPage")
                        {
                            PageCountMode mode;
                            int totalPages = r.GetTotalPages(out mode);
                            if (mode != PageCountMode.Actual) OnPageNavigation(0x7fffffff);
                            else OnPageNavigation(totalPages);
                        }
                    };
                });
        }

        private void MainReporte_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
        bool scroll = true;
        private void reportViewer1_PageNavigation(object sender, PageNavigationEventArgs e)
        {

            //if (!scroll)
            //    e.Cancel = true;

            //scroll = !scroll;
        }
    }
}
