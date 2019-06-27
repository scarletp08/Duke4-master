using Duke4.Consulta_General;
using Duke4.Logistica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.CXC.Reporte
{
    public partial class cxcrepcobrosporadelantado : Duke4.MainFormReportes
    {
        public cxcrepcobrosporadelantado()
        {
            InitializeComponent();
        }

        private void BtnBuscarbeneficiario_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idcliente as codigo, nombre as descripcion from cxcdbfcliente where nulo = 0", "nombre", "Cliente");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigocliente.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
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
                //LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);



            }
            else
            {
                Txtnombrecliente.Text = "";
            }
        }

        private void cxcrepcobrosporadelantado_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Listado de Cobros por Adelantado", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(cmbmoneda, "select idmoneda,abreviatura  from gendbfmoneda");

        }
        //protected override void agregaritems()
        //{
        //    base.agregaritems();
        //    Lsbformato.Items.Add("1->Cobros por Adelantado");



        //    Lsbformato.SetSelected(0, true);

        //}

        private void TxtCodigocliente_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {
                DataSet ds = TxtCodigocliente._Dataset;

                Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();

            }
            else Txtnombrecliente.Text = "";
        }

        private void TxtCodigocliente_Validated(object sender, EventArgs e)
        {
            //if (TxtCodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            //{
            //    DataSet ds = TxtCodigocliente._Dataset;

            //    Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
            //    TxtCodigocliente.Focus();
            //}
            //else Txtnombrecliente.Text = "";
        }
        protected override void Presentar()
        {
            base.Presentar();
            var reporte = new Reporte_General.CXC.cxcrepcobrosporadelantado001();

            if (Lbsformato.SelectedIndex == 0)
            {
                reporte.informe = "cxcrepcobrosporadelantado001.rdlc";
            }
            //else if (listBox1.SelectedIndex == 1)
            //{
            //    reporte.informe = "cxcrepregistro002.rdlc";
            //}
            //else if (listBox1.SelectedIndex == 2)
            //{
            //    //double a = 0.25;

            //    reporte.informe = "cxcrepregistro003.rdlc";


            //}
            reporte.fechainicial = Dtpfechainicial;
            reporte.fechafinal = Dtpfechafinal;
            reporte.nombre = Txtnombrecliente.Text;
           reporte.idmoneda = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Convert.ToString(cmbmoneda.SelectedValue));
            reporte.nulo = nulo();
            reporte.orden = cmborden.Text;
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
    }
}
