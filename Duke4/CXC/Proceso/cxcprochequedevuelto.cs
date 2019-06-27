using Duke4.Consulta_General;
using Duke4.Logistica;
using Funciones_Duke4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.CXC.Proceso
{
    public partial class cxcprochequedevuelto : Duke4.MainFormProceso
    {
        public cxcprochequedevuelto()
        {
            InitializeComponent();
        }

        private void cxcprochequedevuelto_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Cheque Devuelto", this);

            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbbanco, "select idbanco, descripcion from bandbfbanco");

            Ckbimprimir.Checked = true;
            Crear();
        }
        protected override void Crear()
        {
            base.Crear();
            Txtchequedevuelto.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("CHEQUE DEVUELTO");
            Txtchequedevuelto.Enabled = false;
            BtnBuscarChequeDevuelto.Visible = false;
            Txtconcepto.Text = "CHEQUE DEVUELTO";
        }
        protected override void Modificar()
        {
            base.Modificar();
            Txtchequedevuelto.Enabled = true;
            BtnBuscarChequeDevuelto.Visible = true;
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {

            MFConsulta_Cliente Consulta_Cliente = new MFConsulta_Cliente("=");

            if (Consulta_Cliente.ShowDialog(this) == DialogResult.OK)
            {
                Txtcodigocliente.Focus();

                Txtcodigocliente.Text = Consulta_Cliente._CodigoSeleccionado;

                Fun_Buscar_Cliente();
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

        private void Txtcodigocliente_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Cliente();
        }

        private void Txtmonto_Validating(object sender, CancelEventArgs e)
        {
            Fun_Calcular_Total();
        }

        protected void Fun_Calcular_Total()
        {
            Txttotal.Text = Convert.ToString(Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtmonto.Text) + Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtcargo.Text));
        }

        private void Txtcargo_Validating(object sender, CancelEventArgs e)
        {
            Fun_Calcular_Total();
        }
        protected override void Salvar()
        {
            base.Salvar();
            Control[] array = { Txtchequedevuelto, Txtcodigocliente, Cmbmoneda, Txtmonto, Cmbcuenta, Txtnock, Cmbbanco };

            if (!Funciones.Fun_Validar_Campos_Vacios(array))
            {
                string encabezado = "";
                string detalle = "";
                string cierre = "";
                string xml = "";

                encabezado = "<Registros csecuencia=\"" + Txtchequedevuelto.Text
            + "\" dfecha=\"" + Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfecha)
            + "\" creferencia=\"" + Txtnock.Text
            + "\" nidcliente=\"" + Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text)
            + "\" ntotal=\"" + Funciones.Fun_Convierte_String_aDecimal(Txttotal.Text)
            + "\" nbalance=\"" + Funciones.Fun_Convierte_String_aDecimal(Txttotal.Text)
            + "\" ntotalitbis=\"" + 0
            + "\" ntotalexento=\"" + 0
            + "\" ntotalgravado16=\"" + 0
            + "\" ntotalgravado18=\"" + 0
            + "\" ntotaldescuentoporciento=\"" + 0
            + "\" ntotaldescuentomonto=\"" + 0
            + "\" ntotalimporte=\"" + Funciones.Fun_Convierte_String_aDecimal(Txtmonto.Text)
            + "\" dfechavencimiento=\"" + Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfecha)
            + "\" nidvendedor=\"" + 1
            + "\" cncf=\"" + ""
            + "\" nidcontabilidad=\"" + 0
            + "\" nidmoneda=\"" + Cmbmoneda.SelectedValue
            + "\" ccomentario=\"" + Txtconcepto.Text
            + "\" nbalancecliente =\"" + Funciones.Fun_Convierte_String_aDecimal(Txtbalance.Text)
            + "\" ntiporegistro =\"" + 2
            + "\" ntotalcargo =\"" + Funciones.Fun_Convierte_String_aDecimal(Txtcargo.Text)
            + "\" nidbanco =\"" + Cmbbanco.SelectedValue
            + "\" nidcuentabancaria =\"" + Cmbcuenta.SelectedValue

            + "\"> <Facturas>";




                detalle = detalle + "<Factura nidconcepto=\"" + 0
             + "\" cdescripcion=\"" + "CHEQUE DEVUELTO"
             + "\" ncantidad=\"" + 1
             + "\" nprecio=\"" + Funciones.Fun_Convierte_String_aDecimal(Txtmonto.Text)
             + "\" ndescuentomonto=\"" + 0
             + "\" ndescuentoporciento=\"" + 0
             + "\" nmontoitbis=\"" + 0
             + "\" nmontoexento=\"" + 0
             + "\" nmontogravado16=\"" + 0
             + "\" nmontogravado18=\"" + 0
             + "\" nmontoimporte=\"" + Funciones.Fun_Convierte_String_aDecimal(Txtmonto.Text)
             + "\" norden=\"" + 1
             + "\" nmontocargo=\"" + Funciones.Fun_Convierte_String_aDecimal(Txtcargo.Text)
             + "\"/>";


                cierre = "</Facturas> </Registros>";
                xml = encabezado + detalle + cierre;

                string cmd = string.Format("exec Spr_cxc_registro '{0}','{1}','{2}','{3}'", _OpcionSQL, Properties.Settings.Default.idsesion, 1, xml); //Armo el comando
                DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                if (Ckbimprimir.Checked)
                {
                    var Reporte_Cheque_Devuelto = new Reporte_General.CXC.cxcrepchequedevuelto01();
                    if (_OpcionSQL == "Modificar")
                        Reporte_Cheque_Devuelto._id = ds.Tables[0].Rows[0][0].ToString();
                    else
                        Reporte_Cheque_Devuelto._id = ds.Tables[1].Rows[0][0].ToString();

                    Reporte_Cheque_Devuelto.Show();
                    Reporte_Cheque_Devuelto.Owner = this;
                }

                Funciones.Fun_Limpiar_Formulario(MainPanel);

                if (_OpcionSQL == "Insertar")
                    Crear();

                else Modificar();

                Ckbimprimir.Checked = true;

                LblAlerta.Text = "";
            }
            else
                LblAlerta.Text = Mensajes.Stg_Campos_EnBlanco;


        }

        private void BtnBuscarChequeDevuelto_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral Consulta_Registro = new MainFormConsultaGeneral("select secuencia as codigo, nombre as descripcion from cxcdbfregistro inner join cxcdbfcliente on cxcdbfcliente.idcliente=cxcdbfregistro.idcliente where cxcdbfregistro.nulo=0 and tiporegistro=2 ", "nombre", "Registro de Factura");
            if (Consulta_Registro.ShowDialog(this) == DialogResult.OK)
            {
                Txtchequedevuelto.Text = Consulta_Registro.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Fun_Buscar_Registro();

            }
        }

        protected void Fun_Buscar_Registro()
        {
            if (_OpcionSQL == "Modificar")
            {

                string secuencia = Funciones.Fun_Eliminar_Letras_DeString(Txtchequedevuelto.Text);

                if (Txtchequedevuelto.Fun_SQL_Buscar_SecuenciaRegistro("SELECT * from cxcdbfregistro where tiporegistro=2 and REPLACE(secuencia,SUBSTRING(secuencia,PATINDEX('%[^0-9]%', secuencia),1),'')=" + Funciones.Fun_Convierte_String_aEntrero(secuencia)))
                {
                    DataSet ds = Txtchequedevuelto._Dataset;


                    if (Funciones.Fun_Convierte_String_aDecimal(ds.Tables[0].Rows[0]["balance"].ToString()) == Funciones.Fun_Convierte_String_aDecimal(ds.Tables[0].Rows[0]["total"].ToString()))
                    {
                        Txtchequedevuelto.Enabled = false;
                        BtnBuscarChequeDevuelto.Visible = false;

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
                    else
                    {
                        Mensajes.Msgb_Tiene_Movimiento_No_Modificar();
                        Funciones.Fun_Limpiar_Formulario(MainPanel);
                        Txtchequedevuelto.Focus();
                    }

                }
                else
                {

                    Funciones.Fun_Limpiar_Formulario(MainPanel);


                }
            }
        }

        private void Txtcargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.Fun_Enfocar_Menu(e);
        }

        private void Txtchequedevuelto_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Registro();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
