using Duke4.Consulta_General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.CXC.Reporte
{
    public partial class cxcrepacuerdodepagos : Duke4.MainFormReportes
    {
        public cxcrepacuerdodepagos()
        {
            InitializeComponent();
        }

        private void acuerdodepago_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Listado de Acuerdo de pagos", this); 

        }
        //protected override void agregaritems()
        //{
        //    base.agregaritems();
        //    Lsbformato.Items.Add("1->Acuerdos de Pagos");
        //    Lsbformato.Items.Add("1->Acuerdos por Fechas");
        //    Lsbformato.Items.Add("1->Acuerdos por Clientes");
            
        //    Lsbformato.SetSelected(0, true);

        //}

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {


            MFConsulta_Cliente consulta = new MFConsulta_Cliente("=");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigocliente.Text = consulta.MainGrid.SelectedRows[0].Cells[1].Value.ToString();
                Completar_cliente();
                if (TxtCodigocliente.Text != string.Empty)
                    TxtCodigocliente.Focus();

            }

        }

        private void Completar_cliente()
        {
            if (TxtCodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {
                DataSet ds = TxtCodigocliente._Dataset;
                Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();



            }
            else
            {
                Txtnombrecliente.Text = "";
            }
        }
        protected override void Presentar()
        {
            base.Presentar();
            var reporte = new Reporte_General.CXC.cxcrepacuerdodepago001();

            if (Lbsformato.SelectedIndex == 0)
            {
                reporte.informe = "cxcrepacuerdodepago001.rdlc";
            }
            else if (Lbsformato.SelectedIndex == 1)
            {
                reporte.informe = "cxcrepacuerdopago002.rdlc";
            }
            else if (Lbsformato.SelectedIndex == 2)
            {
                

                reporte.informe = "cxcrepacuerdodepago003.rdlc";


            }
            reporte.fechainicial = Dtpfechainicial;
            reporte.fechafinal = Dtpfechafinal;
            reporte.nombre = Txtnombrecliente.Text;
            reporte.idtipoacuerdo = tipoacuerdo();
            reporte.nulo = nulo();
            reporte.orden = Lbsorden.SelectedItem.ToString(); 
            if (reporte.cuentafilas() > 0)
                reporte.Show();
            else Logistica.Mensajes.Datosenlimites();

            Dtpfechainicial.Select();

        }
        protected int nulo()
        {

            int valor = 0;
            if (Convert.ToInt16(cmbestatus.SelectedIndex) == 0)
                valor = 2;
            else if (Convert.ToInt16(cmbestatus.SelectedIndex) == 1)
                valor = 1;
            else if (Convert.ToInt16(cmbestatus.SelectedIndex) == 2)
                valor = 0;

            return valor;

        }
        protected int tipoacuerdo()
        {

            int valor = 0;
            if (Convert.ToInt16(cmbtipoacuerdo.SelectedIndex) == 0)
                valor = 0;
            else if (Convert.ToInt16(cmbtipoacuerdo.SelectedIndex) == 1)
                valor = 1;
            else if (Convert.ToInt16(cmbtipoacuerdo.SelectedIndex) == 2)
                valor = 2;

            return valor;

        }

        private void TxtCodigocliente_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {
                DataSet ds = TxtCodigocliente._Dataset;

                Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();

            }
            else Txtnombrecliente.Text = "";
        }

        private void TxtCodigocliente_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, BtnBuscarCliente);
        }

        private void cmbtipoacuerdo_KeyPress(object sender, KeyPressEventArgs e)
        {

           
        }

        private void cmbestatus_Enter(object sender, EventArgs e)
        {
            

        }

        private void cmbestatus_DropDown(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
    }

