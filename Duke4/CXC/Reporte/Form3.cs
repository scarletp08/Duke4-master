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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       public int Idfactura
        {
            get;
            set;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Muestrat.reportefacturas1' Puede moverla o quitarla según sea necesario.
            this.reportefacturas1TableAdapter.Fill(this.Muestrat.reportefacturas1,Idfactura);

            this.reportViewer1.RefreshReport();
        }
    }
}
