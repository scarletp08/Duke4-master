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

namespace Duke4.Reporte_General
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            reportViewer2.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer2.ZoomMode = ZoomMode.Percent;
            reportViewer2.ZoomPercent = 110;
        }
        private int _idfactura;
        public int idfactura
        {
            get { return _idfactura; }
            set { _idfactura = value; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //this.reportefacturaTableAdapter.Fill(this.rprueba.reportefactura,idfactura);
            this.reportViewer1.RefreshReport();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           this.reportefacturaTableAdapter.Fill(this.dataSet1.reportefactura, idfactura);
            this.reportViewer2.RefreshReport();
        }
    }
}
