﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.Reporte_General.CXC
{
    public partial class cxcrepcobro01 : Duke4.MainReporte
    {
        public cxcrepcobro01()
        {
            InitializeComponent();
        }
        public string _id { get; set; }
        private void cxcrepcobro01_Load(object sender, EventArgs e)
        {
            Fun_Reporte();
         
        }
        public void Fun_Reporte()
        {
            ReportParameter[] v = new ReportParameter[1];
            v[0] = new ReportParameter("copia", _Letrero_Copia);
            // TODO: esta línea de código carga datos en la tabla 'dSCXC.Spr_rep_cxc_cobro01' Puede moverla o quitarla según sea necesario.
            this.spr_rep_cxc_cobro01TableAdapter.Fill(this.dSCXC.Spr_rep_cxc_cobro01,_id);
            this.reportViewer1.RefreshReport();
            parametros(v);
        }
    }
}
