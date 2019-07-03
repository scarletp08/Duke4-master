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
    public partial class Dateprocesoprueba : Duke4.MainFormProceso
    {
        public Dateprocesoprueba()
        {
            InitializeComponent();
        }

        private void Txtncf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            MFConsulta_Cliente Consulta_Cliente = new MFConsulta_Cliente("=");
            if (Consulta_Cliente.ShowDialog(this) == DialogResult.OK)
            {
                Txtidcliente.Text = Convert.ToString(Consulta_Cliente.MainGrid.SelectedRows[0].Cells[1].Value);
                BtnModificar.Enabled = false;
                Fun_Buscar_Cliente();

            }



        }
        protected void Fun_Buscar_Cliente()
        {
            if (Txtidcliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {
                DataSet ds = Txtidcliente._Dataset;


                Txtcliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                Txtdireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                Txttelefono.Text = ds.Tables[0].Rows[0]["telefono"].ToString();

                Txtbalance.Text = FuncionesSQL.Fun_SQL_Buscar_Balance_Cliente(Txtidcliente.Text);




            }
            else
            {

                Txtcliente.Text = Txtdireccion.Text = Txttelefono.Text = Msknfc.Text = Txtbalance.Text = "";

            }
        }


        protected override void Crear()
        {
            base.Crear();
            Txtfactura.Enabled = false;
            Btnbuscar.Visible = false;
            Txtfactura.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("REGISTRO CXC");
            Txtdescripcion.Focus();


        }
        protected override void Modificar()
        {
            base.Modificar();
            Txtfactura.Enabled = true;
            Btnbuscar.Visible = true;
            Txtfactura.Focus();


        }

        private void btnBuscar4_Click(object sender, EventArgs e)
        {
           
            MainFormConsultaGeneral Consulta_factura = new MainFormConsultaGeneral("select idfactura as codigo, referencia as descripcion from prudbffactura", "referencia", "factura");

            if (Consulta_factura.ShowDialog(this) == DialogResult.OK)

            {

                Txtfactura.Text = Consulta_factura.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_factura();
            }
        }

        private void Completar_factura()
        {
            if (_OpcionSQL == "Modificar")
            {

                string secuencia = Funciones.Fun_Eliminar_Letras_DeString(Txtfactura.Text);

                if (Txtfactura.Fun_SQL_Buscar_SecuenciaRegistro("SELECT * from prudbffactura where REPLACE(secuencia,SUBSTRING(secuencia,PATINDEX('%[^0-9]%', secuencia),1),'')=" + Funciones.Fun_Convierte_String_aEntrero(secuencia)))
                {
                    DataSet ds = Txtfactura._Dataset;
                    Txtfactura.Text = ds.Tables[0].Rows[0]["secuencia"].ToString();
                    Txtidcliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
                    Fun_Buscar_Cliente();
                    Txtvendedor.Text = ds.Tables[0].Rows[0]["idvendedor"].ToString();
                    Fun_Buscar_vendedor();
                    Txtconcepto.Text = ds.Tables[0].Rows[0]["idconcepto"].ToString();
                    FunBuscar_concepto();
                    Txtreferencia.Text = ds.Tables[0].Rows[0]["referencia"].ToString();
                    txtNota1.Text = ds.Tables[0].Rows[0]["nota"].ToString();
                    Txtimporte.Text = ds.Tables[0].Rows[0]["importe"].ToString();
                    Txtexcento.Text = ds.Tables[0].Rows[0]["excento"].ToString();
                    Txtitbis.Text = ds.Tables[0].Rows[0]["itbis"].ToString();
                    Txtneto.Text = ds.Tables[0].Rows[0]["neto"].ToString();
                    Dtpfecha.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fec"].ToString());
                    Dptvence.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha"].ToString());
                    Msknfc.Text = ds.Tables[0].Rows[0]["nfc"].ToString();
                    Cmbmoneda.SelectedValue = ds.Tables[0].Rows[0]["moneda"].ToString();


                }
                else
                {
                    Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);

                }
            }
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



                    Txtcliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
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
                    FuncionesSQL.Fun_SQL_Buscar_Secuencia_NCF(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["idncf"].ToString()), Dtpfecha.Value, Msknfc);
            }
            else
            {

                Txtcliente.Text = Txtdireccion.Text = Txttelefono.Text = Msknfc.Text = Txtbalance.Text = "";

            }
        }

        private void Txtidcliente_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Cliente();
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral Consulta_Vendedor = new MainFormConsultaGeneral("select idempleado as codigo, nombre as descripcion from nomdbfempleado where nulo=0", "nombre", "Vendedor");
            if (Consulta_Vendedor.ShowDialog(this) == DialogResult.OK)
            {

                Txtvendedor.Text = Consulta_Vendedor.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Txtvende.Text = Consulta_Vendedor.MainGrid.SelectedRows[0].Cells[1].Value.ToString();

            }
        }

        protected void Fun_Buscar_vendedor()
        {
            if (Txtvendedor.Fun_SQL_Buscar_CodigoRegistro("nomdbfempleado", "idempleado"))
            {
                DataSet ds = Txtvendedor._Dataset;





                Txtvende.Text = ds.Tables[0].Rows[0]["nombre"].ToString();



            }
            else
            {



            }
        }
        protected void Fun_Buscar_facturat()
        {
            if (Txtfactura.Fun_SQL_Buscar_CodigoRegistro("prudbffactura", "idfactura"))
            {
                DataSet ds = Txtconcepto._Dataset;
                Txtdescripcion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
            }
            else
            {

            }


        }
        protected void FunBuscar_concepto()
        {
            if (Txtconcepto.Fun_SQL_Buscar_CodigoRegistro("cxcdbfconcepto", "idconcepto"))
            {
                DataSet ds = Txtconcepto._Dataset;
                Txtdescripcion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
            }
            else
            {

            }
        }
        private void Txtvendedor_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_vendedor();
        }

        private void Txtconcepto_Validating(object sender, CancelEventArgs e)
        {
            FunBuscar_concepto();
        }

        private void btnBuscar3_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral Consulta_Concepto = new MainFormConsultaGeneral("select idconcepto as codigo, descripcion from cxcdbfconcepto where nulo=0", "descripcion", "Concepto");
            if (Consulta_Concepto.ShowDialog(this) == DialogResult.OK)
            {

                Txtconcepto.Text = Convert.ToString(Consulta_Concepto.MainGrid.SelectedRows[0].Cells[0].Value);
                FunBuscar_concepto();

            }
        }

        private void Dateprocesoprueba_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Proceso estudiante ", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");
            Crear();

        }

        protected override void Salvar()
        {
            base.Salvar();


            Control[] array = { Txtidcliente, Txtvendedor, Txtconcepto };

            if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(array))
            {
                int idfactura=0;
                string cmd = string.Format("exec Spr_pru_factura '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}'",
                    _OpcionSQL, Properties.Settings.Default.idsesion, 1,
                    Txtfactura.Text,
                    Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtidcliente.Text),

                    Txtreferencia.Text,
                    Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtvendedor.Text),
                    Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtconcepto.Text),
                    Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtimporte.Text),
                    Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtexcento.Text),
                    Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtitbis.Text),
                    Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtneto.Text),
                    txtNota1.Text,
                    Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dptvence),

                    Msknfc.Text,
                    Cmbmoneda.SelectedValue,
                    Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfecha));
                DataSet ds= FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                if (_OpcionSQL == "Modificar")
                    idfactura =Funciones.Fun_Convierte_String_aEntrero( ds.Tables[0].Rows[0][0].ToString());
                else
                    idfactura = Funciones.Fun_Convierte_String_aEntrero( ds.Tables[1].Rows[0][0].ToString());

                var Reporte = new Reporte_General.Form1();
                Reporte.idfactura = idfactura;
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

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Txtfactura_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtidcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtfactura_Validating(object sender, CancelEventArgs e)
        {
            Completar_factura();
        }

        private void Txtimporte_TextChanged(object sender, EventArgs e)
        {




        }
        protected void Fun_Calcular_Neto()
        {
            Double itbis = 0.18;
            Txtitbis.Text = Convert.ToString(Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtimporte.Text) * itbis);

            Txtneto.Text = Convert.ToString(Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtimporte.Text) + (Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtitbis.Text))+ (Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal( Txtexcento.Text)));
        }
        private void Txtneto_TextChanged(object sender, EventArgs e)
        {
            }

        private void Txtimporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
     if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }

        }

        private void Txtimporte_Click(object sender, EventArgs e)
        {
            

        }

        private void Txtimporte_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void Txtimporte_Validating(object sender, CancelEventArgs e)
        {
            Fun_Calcular_Neto();
        }

        private void Txtexcento_Validating(object sender, CancelEventArgs e)
        {
            Fun_Calcular_Neto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte_General.Form1 f = new Reporte_General.Form1();
            //f.secuencia = Convert.ToInt32(Txtfactura.Text);
            f.Show();
        }
    }
    
    
    
}
