using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duke4.CXC.Reporte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Idfactura
        {
            get;
            set;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosfactura2.reportefactura2' Puede moverla o quitarla según sea necesario.
            this.reportefactura1TableAdapter.Fill(this.dataSet1234.reportefactura1,Idfactura);

           this.reportViewer1.RefreshReport();
           
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
