using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Duke4.Consulta_General;
using Duke4.Logistica;
using Funciones_Duke4;

namespace Duke4.CXC.Proceso
{
    public partial class Datos_factura2 : Duke4.MainFormProceso
    {
        public Datos_factura2()
        {
            InitializeComponent();
        }

        private void Txtneto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            MFConsulta_Cliente consulta = new MFConsulta_Cliente("=");
            if(consulta.ShowDialog(this)==DialogResult.OK)
            {
                Txtidcliente.Text = Convert.ToString(consulta.MainGrid.SelectedRows[0].Cells[1].Value);
                BtnModificar.Enabled = false;
                Fun_Buscar_Cliente();
            }
            
        }

        private void Fun_Buscar_Cliente()
        {
            if(Txtidcliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
                  {
                DataSet ds = Txtidcliente._Dataset;
          

                Txtnombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                Txttelefono.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
                Txtdireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                Txtbalance.Text = FuncionesSQL.Fun_SQL_Buscar_Balance_Cliente(Txtidcliente.Text);
            }
        }

        private void Btnconcento_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consultaconcepto = new MainFormConsultaGeneral("select idconcepto as codigo, descripcion from cxcdbfconcepto where nulo=0", "Descripcion", "Concepto");
            if (consultaconcepto.ShowDialog(this) == DialogResult.OK)
            {
                Txtidconcepto.Text = Convert.ToString(consultaconcepto.MainGrid.SelectedRows[0].Cells[0].Value);
                Txtdescripcionconcepto.Text =Convert.ToString( consultaconcepto.MainGrid.SelectedRows[0].Cells[0].Value);
                Fun_Buscar_Concepto();
            }
        }
          private void Fun_Buscar_Concepto()
        {
            if(Txtidconcepto.Fun_SQL_Buscar_CodigoRegistro("cxcdbfconcepto", "idconcepto"))
            {
                DataSet ds = Txtidconcepto._Dataset;
                Txtdescripcionconcepto.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();

            }
            
        }

        private void Btnvendedor_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral Consulta_Vendedor = new MainFormConsultaGeneral("select idempleado as codigo, nombre as descripcion from nomdbfempleado where nulo=0", "nombre", "Vendedor");
            if (Consulta_Vendedor.ShowDialog(this) == DialogResult.OK)
            {

                Txtidvendedor.Text = Convert.ToString(Consulta_Vendedor.MainGrid.SelectedRows[0].Cells[0].Value);
                Txtnombrevendedor.Text = Convert.ToString(Consulta_Vendedor.MainGrid.SelectedRows[0].Cells[1].Value);
                Fun_Buscar_Vendedor();
            }
        }
            private void Fun_Buscar_Vendedor()
        {
            if (Txtidvendedor.Fun_SQL_Buscar_CodigoRegistro("nomdbfempleado", "idempleado"))
            {
                DataSet ds = Txtidvendedor._Dataset;
                Txtnombrevendedor.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
            }
        }

        private void Txtidcliente_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Cliente();
        }

        private void Txtidconcepto_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Concepto();
        }

        private void Txtidvendedor_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Vendedor();
        }

        protected void Fun_Calcular_Neto()
        {
            Double itbis = 0.18;
            Txtitbis.Text = Convert.ToString(Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtimporte.Text) * itbis);

            Txtneto.Text = Convert.ToString(Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtimporte.Text) + (Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtitbis.Text)) + (Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtexcento.Text)));
        }

        private void Txtimporte_Validating(object sender, CancelEventArgs e)
        {
            Fun_Calcular_Neto();
        }

        private void Txtexcento_Validating(object sender, CancelEventArgs e)
        {
            Fun_Calcular_Neto();
        }

        protected override void Crear()
        {
            base.Crear();
            Txtfactura.Enabled = false;
            BtnBuscarfactura.Visible = false;
            Txtfactura.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("REGISTRO CXC");
            Txtidcliente.Focus();


        }

        protected override void Modificar()
        {
            base.Modificar();
            Txtfactura.Enabled = true;
            BtnBuscarfactura.Visible = true;
            Txtfactura.Focus();
        }


        protected void Fun_Buscar_factura()
        {
            if (Txtidcliente.Fun_SQL_Buscar_CodigoRegistro("prudbffactura", "idfactura"))
            {
                DataSet ds = Txtidcliente._Dataset;
                if (ds.Tables[0].Rows[0]["idfactura"].ToString() == "1")
                {
                    Txtidcliente.Text = "";
                    Txtidcliente.Focus();
                    Mensajes.Msgb_NoRegistro_CliContado();
                }
                else
                {



                    Txtidcliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
                    Fun_Buscar_Cliente();

                    //string cmd = string.Format("SELECT      dbo.cxcdbfcliente.idcliente, dbo.cxcdbfcliente.nombre, dbo.cxcdbfcliente.direccion, dbo.cxcdbfcliente.telefono, dbo.cxcdbfcliente.referencia, dbo.nomdbfempleado.idempleado, dbo.nomdbfempleado.nombre AS nombre_vendedor, dbo.cxcdbfconcepto.idconcepto, dbo.cxcdbfconcepto.descripcion FROM         dbo.cxcdbfregistro INNER JOIn dbo.cxcdbfcliente ON dbo.cxcdbfregistro.idcliente = dbo.cxcdbfcliente.idcliente CROSS JOIN dbo.nomdbfempleado CROSS JOIN dbo.cxcdbfconcepto where dbo.cxcdbfconcepto.idconcepto='" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtidcliente.Text.Trim()) + "' and cxcdbfcliente.nulo=0");
                    //DataSet ds2 = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
                    //if (ds2.Tables[0].Rows.Count > 0)
                    //{
                    //    dia = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Convert.ToString(ds2.Tables[0].Rows[0][0]));
                    //}
                    //Fun_Buscar_Fecha_Vencimiento();

                }

                if (_OpcionSQL != "Modificar")
                    FuncionesSQL.Fun_SQL_Buscar_Secuencia_NCF(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["idncf"].ToString()), Dtpfechaingreso.Value, Mskrnc);
            }
            else
            {

                Txtidcliente.Text = Txtdireccion.Text = Txttelefono.Text = Mskrnc.Text = Txtbalance.Text = "";

            }
        }
        private void Completar_factura()
        {
            if (_OpcionSQL == "Modificar")
            {

                string secuencia = Funciones.Fun_Eliminar_Letras_DeString(Txtfactura.Text);

                if (Txtfactura.Fun_SQL_Buscar_SecuenciaRegistro("SELECT * from prudbffactura2 where REPLACE(secuencia,SUBSTRING(secuencia,PATINDEX('%[^0-9]%', secuencia),1),'')=" + Funciones.Fun_Convierte_String_aEntrero(secuencia)))
                {
                    DataSet ds = Txtfactura._Dataset;
                    Txtfactura.Text = ds.Tables[0].Rows[0]["secuencia"].ToString();
                    Txtidcliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
                    Fun_Buscar_Cliente();
                    Txtidvendedor.Text = ds.Tables[0].Rows[0]["idvendedor"].ToString();
                    Fun_Buscar_Vendedor();
                    Txtidconcepto.Text = ds.Tables[0].Rows[0]["idconcepto"].ToString();
                    Fun_Buscar_Concepto();
                    Txtreferencia.Text = ds.Tables[0].Rows[0]["referencia"].ToString();
                    txtNota1.Text = ds.Tables[0].Rows[0]["nota"].ToString();
                    Txtimporte.Text = ds.Tables[0].Rows[0]["importe"].ToString();
                    Txtexcento.Text = ds.Tables[0].Rows[0]["excento"].ToString();
                    Txtitbis.Text = ds.Tables[0].Rows[0]["itbis"].ToString();
                    Txtneto.Text = ds.Tables[0].Rows[0]["neto"].ToString();
                    Dtpfechaingreso.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha_ingreso"].ToString());
                    Dtpfechavencimiento.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha_vencimiento"].ToString());
                    Mskrnc.Text = ds.Tables[0].Rows[0]["nfc"].ToString();
                    Cmbmoneda.SelectedValue = ds.Tables[0].Rows[0]["moneda"].ToString();


                }
                else
                {
                    Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);

                }
            }
        }
        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Datos_factura2_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Prueba Estudiante #2",this);
   
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");
            Crear();
        }

        private void Txtfactura_Validating(object sender, CancelEventArgs e)
        {
            Completar_factura();
        }
        protected override void Salvar()
        {
            base.Salvar();


            Control[] array = { Txtidcliente, Txtidvendedor, Txtidconcepto };

            if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(array))
            {
                int idfactura = 0;
                string cmd = string.Format("exec sprudbffactura2 '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}'",
                    _OpcionSQL, Properties.Settings.Default.idsesion, 1,
                    Txtfactura.Text,
                    Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtidcliente.Text),

                    Txtreferencia.Text,
                    Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtidvendedor.Text),
                    Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtidconcepto.Text),
                    Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtimporte.Text),
                    Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtexcento.Text),
                    Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtitbis.Text),
                    Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtneto.Text),
                    txtNota1.Text,
                    Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfechaingreso),

                    Mskrnc.Text,
                    Cmbmoneda.SelectedValue,
                    Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfechavencimiento));
                DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                if (_OpcionSQL == "Modificar")
                    idfactura = Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0][0].ToString());
                else
                    idfactura = Funciones.Fun_Convierte_String_aEntrero(ds.Tables[1].Rows[0][0].ToString());

                var Reporte = new Reporte.Forreporte22();
                Reporte.Idfactura = idfactura;
                Reporte.Show();
               Reporte.Owner = this;


                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);


                if (_OpcionSQL == "Insertar")

                    Crear();

                else

                    Modificar();
                LblAlerta.Text = string.Empty;
            }
            else

                LblAlerta.Text = Mensajes.Stg_Campos_EnBlanco;

        }

        private void BtnBuscarfactura_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral Consulta_Registro = new MainFormConsultaGeneral("select secuencia as codigo, nombre as descripcion from prudbffactura2 inner join cxcdbfcliente on cxcdbfcliente.idcliente=prudbffactura2.idcliente where prudbffactura2.nulo=0  ", "referencia", "factura");
            if (Consulta_Registro.ShowDialog(this) == DialogResult.OK)
            {
                Txtfactura.Text = Consulta_Registro.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                BtnCrear.Enabled = false;
                Completar_factura();

            }
        }

        private void btnBase1_Click(object sender, EventArgs e)
        {
          
        }
    }

}
