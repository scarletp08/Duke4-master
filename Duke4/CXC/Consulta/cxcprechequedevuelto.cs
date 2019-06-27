using Duke4.Logistica;
using Funciones_Duke4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.CXC.Consulta
{
    public partial class cxcprechequedevuelto : Duke4.MainFormPresentar
    {
        public cxcprechequedevuelto()
        {
            InitializeComponent();
        }

        private void cxcprechequedevuelto_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Consulta de Cheque Devuelto", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");

        }

        private void Txtchequedevuelto_TextChanged(object sender, EventArgs e)
        {
            Fun_Buscar_Registro();
        }
        protected void Fun_Buscar_Registro()
        {
            
                string secuencia = Funciones.Fun_Eliminar_Letras_DeString(Txtchequedevuelto.Text);

            if (Txtchequedevuelto.Fun_SQL_Buscar_SecuenciaRegistro("SELECT * from cxcdbfregistro where tiporegistro=2 and REPLACE(secuencia,SUBSTRING(secuencia,PATINDEX('%[^0-9]%', secuencia),1),'')=" + Funciones.Fun_Convierte_String_aEntrero(secuencia)))
            {
                Txtchequedevuelto.Enabled = false;
                DataSet ds = Txtchequedevuelto._Dataset;


                if (Funciones.Fun_Convierte_String_aDecimal(ds.Tables[0].Rows[0]["balance"].ToString()) == Funciones.Fun_Convierte_String_aDecimal(ds.Tables[0].Rows[0]["total"].ToString()))
                {

                    Txtcodigocliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
                    Dtpfecha.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha"]);
                    Txtnock.Text = ds.Tables[0].Rows[0]["referencia"].ToString();
                    Txttotal.Text = ds.Tables[0].Rows[0]["total"].ToString();
                    Txtcargo.Text = ds.Tables[0].Rows[0]["totalcargo"].ToString();
                    Txtmonto.Text = ds.Tables[0].Rows[0]["totalimporte"].ToString();
                    Txtconcepto.Text = ds.Tables[0].Rows[0]["comentario"].ToString();
                    Cmbmoneda.SelectedValue = ds.Tables[0].Rows[0]["idmoneda"].ToString();
                    Cmbbanco.SelectedValue = ds.Tables[0].Rows[0]["idbanco"].ToString();
                    Fun_Buscar_Cliente();


                }
            }
            }
        private void Fun_Buscar_Cliente()
        {
            if (Txtcodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {
                DataSet ds = Txtcodigocliente._Dataset;

                if (ds.Tables[0].Rows[0]["idcliente"].ToString() == "1")
                {
                    Txtcodigocliente.Text = "";
                    Txtcodigocliente.Focus();
                    Mensajes.Msgb_NoCobros_CliContado();
                }
                else
                {
                    Txtcodigocliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
                    Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                    Txttelefonocliente.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
                    Txtdireccioncliente.Text = ds.Tables[0].Rows[0]["direccion"].ToString();

                    //string cmd3 = string.Format("select cxcdbfruta.idempleado, nombre from nomdbfempleado inner join cxcdbfruta on nomdbfempleado.idempleado=cxcdbfruta.idempleado where idruta='" + Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["idruta"].ToString()) + "' and nomdbfempleado.nulo=0");
                    //DataSet ds3 = FuncionesSQL.Fun_Sql_Ejecutar(cmd3);
                    //if (ds3.Tables.Count > 0)
                    //    if (ds3.Tables[0].Rows.Count > 0)
                    //    {
                    //        Txtcodigovendedor.Text = ds3.Tables[0].Rows[0]["idempleado"].ToString();
                    //        Txtnombrevendedor.Text = ds3.Tables[0].Rows[0]["nombre"].ToString();
                    //    }


                    Txtbalance.Text = FuncionesSQL.Fun_SQL_Buscar_Balance_Cliente(Txtcodigocliente.Text);

                }


            }
            else
            {
                Txtnombrecliente.Text = Txtdireccioncliente.Text = Txttelefonocliente.Text = Txtbalance.Text = "";
            }

        }
        public string _secuencia = "";
        public bool _nulo = false; protected override void Imprimir()
        {
            base.Imprimir();
            var Reporte = new Reporte_General.CXC.cxcrepchequedevuelto01();
            Reporte._id = _secuencia;
            if (_nulo == false)
                Reporte._Letrero_Copia = "COPIA";
            else
                Reporte._Letrero_Copia = "<<NULO>> COPIA";

            Reporte.Show();
            Reporte.Owner = this;
        }
    }
}
