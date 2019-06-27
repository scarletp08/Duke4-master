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
    public partial class cxcprootroingreso : Duke4.MainFormProceso
    {
        public cxcprootroingreso()
        {
            InitializeComponent();
        }

        private void cxcprocobroadelantado_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Otro Ingreso", this);
            
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");
            FuncionesSQL.Fun_Sql_Autocompletar_Texto(Txtnombrecliente, "select beneficiario from cxcdbfotro_ingreso");

            Ckbimprimir.Checked = true;
            Crear();
        }
        protected override void Crear()
        {
            base.Crear();
            Txtotroingreso.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("OTRO INGRESO");
            Txtotroingreso.Enabled = false;
            BtnBuscarCobro.Visible = false;
        }
        protected override void Modificar()
        {
            base.Modificar();
            Txtotroingreso.Enabled = true;
            BtnBuscarCobro.Visible = true;
        }
        
        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consultabeneficiario = new MainFormConsultaGeneral("select idbeneficiario as codigo, nombre as descripcion from cxcdbfbeneficiario where nulo = 0", "nombre", "Beneficiario");
            if (consultabeneficiario.ShowDialog(this) == DialogResult.OK)
            {
                Txtnombrecliente.Text = Convert.ToString(consultabeneficiario.MainGrid.SelectedRows[0].Cells[1].Value);
                               

            }
        }        
       
        protected void Fun_Buscar_Cobro_Adelantado()
        {
            if (_OpcionSQL == "Modificar")
            {

                string secuencia = Funciones.Fun_Eliminar_Letras_DeString(Txtotroingreso.Text);

                if (Txtotroingreso.Fun_SQL_Buscar_SecuenciaRegistro("SELECT * from cxcdbfotroingreso where REPLACE(secuencia,SUBSTRING(secuencia,PATINDEX('%[^0-9]%', secuencia),1),'')=" + Funciones.Fun_Convierte_String_aEntrero(secuencia)))
                {
                    Txtotroingreso.Enabled = false;
                    BtnBuscarCobro.Visible = false;
                    DataSet ds = Txtotroingreso._Dataset;


                   
                        Txtnombrecliente.Text = ds.Tables[0].Rows[0]["beneficiario"].ToString();
                        Dtpfecha.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha"]);
                        Txtreferencia.Text = ds.Tables[0].Rows[0]["referencia"].ToString();
                        Txtmonto.Text = ds.Tables[0].Rows[0]["monto"].ToString();
                        Txtconcepto.Text = ds.Tables[0].Rows[0]["concepto"].ToString();
                        Cmbmoneda.SelectedValue = ds.Tables[0].Rows[0]["idmoneda"].ToString();
                    

                }
                else
                {

                    Txtnombrecliente.Text = "";

                }
            }
        }

        private void BtnBuscarCobro_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral Consulta_Registro = new MainFormConsultaGeneral("select secuencia as codigo, beneficiario as descripcion from cxcdbfotroingreso where nulo=0 ", "beneficiario", "Registro de Otro Ingreso");
            if (Consulta_Registro.ShowDialog(this) == DialogResult.OK)
            {
                Txtotroingreso.Text = Consulta_Registro.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
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
            Control[] array = { Txtotroingreso, Txtnombrecliente, Txtmonto, Txtconcepto,Cmbmoneda };
            string id = "";

            if (!Funciones.Fun_Validar_Campos_Vacios(array))
            {
                    Opcion_Pago.Proceso.genpropago pago = new Opcion_Pago.Proceso.genpropago(Txtmonto.Text, "1", 1);

                    if (pago.ShowDialog() == DialogResult.OK)
                    {
                    

                    string cmd = string.Format("exec Spr_cxc_otro_ingreso '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'", _OpcionSQL, Properties.Settings.Default.idsesion, 1, Txtotroingreso.Text,
                        Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfecha), Txtreferencia.Text, Txtnombrecliente.Text, Funciones.Fun_Convierte_String_aDecimal(Txtmonto.Text), Cmbmoneda.SelectedValue, Txtconcepto.Text.Trim());
                        DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                    if (_OpcionSQL == "Modificar")
                        id = ds.Tables[0].Rows[0][0].ToString();
                    else
                        id = ds.Tables[1].Rows[0][0].ToString();

                    string cmdpago = string.Format("exec Spr_gen_pago '{0}','{1}','{2}','{3}','{4}'", Properties.Settings.Default.idsesion, 1, id, Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfecha), pago.cmd2);
                        DataSet ds2 = FuncionesSQL.Fun_Sql_Ejecutar(cmdpago);



                        if (Ckbimprimir.Checked == true)
                        {
                                                 
                            var Reporte = new Reporte_General.CXC.cxcrepotroingreso01();
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
            Funciones.Fun_Enfocar_Menu(e);
        }
    }
}
