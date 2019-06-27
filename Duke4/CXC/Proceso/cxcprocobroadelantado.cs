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
    public partial class cxcprocobroadelantado : Duke4.MainFormProceso
    {
        public cxcprocobroadelantado()
        {
            InitializeComponent();
        }

        private void cxcprocobroadelantado_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Cobro Adelantado", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");
            Ckbimprimir.Checked = true;
            Crear();
        }
        protected override void Crear()
        {
            base.Crear();
            Txtcobro.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("COBRO ADELANTADO");
            Txtcobro.Enabled = false;
            BtnBuscarCobro.Visible = false;
        }
        protected override void Modificar()
        {
            base.Modificar();
            Txtcobro.Enabled = true;
            BtnBuscarCobro.Visible = true;
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            MFConsulta_Cliente Consulta_Cliente = new MFConsulta_Cliente("=");
            if (Consulta_Cliente.ShowDialog(this) == DialogResult.OK)
            {
                Txtcodigocliente.Text = Convert.ToString(Consulta_Cliente.MainGrid.SelectedRows[0].Cells[1].Value);

                Fun_Buscar_Cliente();

            }
        }
        protected void Fun_Buscar_Cliente()
        {
            if (Txtcodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {
                
                DataSet ds = Txtcodigocliente._Dataset;
              

                if (Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["idcliente"].ToString()) > 1)
                {
                    if (Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(FuncionesSQL.Fun_SQL_Buscar_Balance_Cliente(ds.Tables[0].Rows[0]["idcliente"].ToString()))==0)
                    {
                        Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                       
                    }
                    else
                    {
                        Txtcodigocliente.Text = "";
                        Mensajes.Msgb_Registro_Pendiente();
                        Txtcodigocliente.Focus();
                    }
                }
                else
                {

                    Txtcodigocliente.Text = "";
                    Txtcodigocliente.Focus();
                    Mensajes.Msgb_NoCobro_Adelantado_CliContado();                }
            }
            else
            {

                Txtnombrecliente.Text = "";

            }
        }

        private void Txtcodigocliente_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Cliente();
        }
        protected void Fun_Buscar_Cobro_Adelantado()
        {
            if (_OpcionSQL == "Modificar")
            {

                string secuencia = Funciones.Fun_Eliminar_Letras_DeString(Txtcobro.Text);

                if (Txtcobro.Fun_SQL_Buscar_SecuenciaRegistro("SELECT * from cxcdbfcobroadelantado where REPLACE(secuencia,SUBSTRING(secuencia,PATINDEX('%[^0-9]%', secuencia),1),'')=" + Funciones.Fun_Convierte_String_aEntrero(secuencia)))
                {
                   
                    DataSet ds = Txtcobro._Dataset;


                    if (Funciones.Fun_Convierte_String_aDecimal(ds.Tables[0].Rows[0]["balance"].ToString()) == Funciones.Fun_Convierte_String_aDecimal(ds.Tables[0].Rows[0]["monto"].ToString()))
                    {
                        Txtcobro.Enabled = false;
                        BtnBuscarCobro.Visible = false;
                        Txtcodigocliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
                        Dtpfecha.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha"]);
                        Txtreferencia.Text = ds.Tables[0].Rows[0]["referencia"].ToString();
                        Txtmonto.Text = ds.Tables[0].Rows[0]["monto"].ToString();
                        Txtconcepto.Text = ds.Tables[0].Rows[0]["concepto"].ToString();
                        Cmbmoneda.SelectedValue = ds.Tables[0].Rows[0]["idmoneda"].ToString();
                        Fun_Buscar_Cliente();
                       
                    }
                    else
                    {
                        Mensajes.Msgb_Tiene_Movimiento_No_Modificar();
                        Funciones.Fun_Limpiar_Formulario(MainPanel);
                        Txtcobro.Focus();
                    }

                }
                else
                {

                    Funciones.Fun_Limpiar_Formulario(MainPanel);


                }
            }
        }

        private void BtnBuscarCobro_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral Consulta_Registro = new MainFormConsultaGeneral("select secuencia as codigo, nombre as descripcion from cxcdbfcobroadelantado inner join cxcdbfcliente on cxcdbfcliente.idcliente=cxcdbfcobroadelantado.idcliente where cxcdbfcobroadelantado.nulo=0 ", "nombre", "Registro de Cobro Adelantado");
            if (Consulta_Registro.ShowDialog(this) == DialogResult.OK)
            {
                Txtcobro.Text = Consulta_Registro.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Fun_Buscar_Cobro_Adelantado();

            }
        }

        private void Txtcobro_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Cobro_Adelantado();
        }
        protected override void Salvar()
        {
            base.Salvar();
            Control[] array = { Txtcobro, Txtcodigocliente, Txtmonto, Txtconcepto,Cmbmoneda };
            string id = "";

            if (!Funciones.Fun_Validar_Campos_Vacios(array))
            {
                    Opcion_Pago.Proceso.genpropago pago = new Opcion_Pago.Proceso.genpropago(Txtmonto.Text, Txtcodigocliente.Text, 1);

                    if (pago.ShowDialog() == DialogResult.OK)
                    {
                    

                    string cmd = string.Format("exec Spr_cxc_cobro_adelantado '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'", _OpcionSQL, Properties.Settings.Default.idsesion, 1, Txtcobro.Text,
                        Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfecha), Txtreferencia.Text, Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text), Funciones.Fun_Convierte_String_aDecimal(Txtmonto.Text), Cmbmoneda.SelectedValue, Txtconcepto.Text.Trim());
                        DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                    if (_OpcionSQL == "Modificar")
                        id = ds.Tables[0].Rows[0][0].ToString();
                    else
                        id = ds.Tables[1].Rows[0][0].ToString();

                    string cmdpago = string.Format("exec Spr_gen_pago '{0}','{1}','{2}','{3}','{4}'", Properties.Settings.Default.idsesion, 1, id, Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfecha), pago.cmd2);
                        DataSet ds2 = FuncionesSQL.Fun_Sql_Ejecutar(cmdpago);



                        if (Ckbimprimir.Checked == true)
                        {
                                                 
                            var Reporte = new Reporte_General.CXC.cxcrepcobroadelantado01();
                            Reporte._montoescrito = Funciones.Fun_Numero_aLetras_ConDecimal(Txtmonto.Text);
                                                
                            Reporte._id = id;
                        
                            Reporte.Show();
                            Reporte.Owner = this;
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
            else
            {
                LblAlerta.Text = Mensajes.Stg_Campos_EnBlanco;
            }

        }

        private void Txtconcepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Txtconcepto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                menuStrip2.Focus();
        }
    }
}
