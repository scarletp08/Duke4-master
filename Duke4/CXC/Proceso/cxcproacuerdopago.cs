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
    public partial class cxcproacuerdopago : Duke4.MainFormProceso
    {
        public cxcproacuerdopago()
        {
            InitializeComponent();
        }

        private void cxcprocobroadelantado_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Acuerdo de pago", this);
            Crear();
        }
        protected override void Crear()
        {
            base.Crear();
            Txtacuerdopago.Text = Logistica.FuncionesSQL.Fun_SQL_Buscar_UltimoCod("idacuerdo", "cxcdbfacuerdopago");
            Txtacuerdopago.Enabled = false;
            BtnBuscarAcuerdoPago.Visible = false;
            Rdbabierto.Checked = true;
        }
        protected override void Modificar()
        {
            base.Modificar();
            Txtacuerdopago.Enabled = true;
            BtnBuscarAcuerdoPago.Visible = true;
            Rdbabierto.Checked = true;
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
                    
                        Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                       
                  
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
        protected void Fun_Buscar_Acuerdo_Pago()
        {
            if (_OpcionSQL == "Modificar")
            {

                string secuencia = Funciones.Fun_Eliminar_Letras_DeString(Txtacuerdopago.Text);

                if (Txtacuerdopago.Fun_SQL_Buscar_CodigoRegistro("cxcdbfacuerdopago", "idacuerdo"))
                {
                    Txtacuerdopago.Enabled = false;
                    BtnBuscarAcuerdoPago.Visible = false;
                    DataSet ds = Txtacuerdopago._Dataset;
                    

                        Txtcodigocliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
                        Dtpfecha.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha"]);
                        Txtmonto.Text = ds.Tables[0].Rows[0]["monto"].ToString();
                        Txtconcepto.Text = ds.Tables[0].Rows[0]["nota"].ToString();
                        Cmbhorario.Text = ds.Tables[0].Rows[0]["horario"].ToString();
                    if (Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["horario"].ToString()) == 1)
                        Rdbabierto.Checked = true;
                    else Rdbcerrado.Checked = true;

                        Fun_Buscar_Cliente();

                       
                   
                }
                else
                {

                    Funciones.Fun_Limpiar_Formulario(MainPanel);


                }
            }
        }

        private void BtnBuscarCobro_Click(object sender, EventArgs e)
        {
           
        }

        private void Txtcobro_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Acuerdo_Pago();
        }
        protected override void Salvar()
        {
            base.Salvar();
            Control[] array = { Txtacuerdopago, Txtcodigocliente, Txtmonto, Txtconcepto };
            
            int estado = 0;
            string a;

            if (!Funciones.Fun_Validar_Campos_Vacios(array))
            {
                if (Rdbabierto.Checked) estado = 1;
                else estado = 2;
                a = Cmbhorario.Text;

                    string cmd = string.Format("exec Spr_cxc_acuerdo_pago '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'", _OpcionSQL, Properties.Settings.Default.idsesion, 1, Txtacuerdopago.Text,
                        Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfecha), Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text), Txtconcepto.Text.Trim(),a, Funciones.Fun_Convierte_String_aDecimal(Txtmonto.Text), estado);
                        DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                    
                        Funciones.Fun_Limpiar_Formulario(MainPanel);


                if (_OpcionSQL == "Insertar")
                    Crear();
                else
                    Modificar();
              
                                        
          

            }
            else
            {
                LblAlerta.Text = Mensajes.Stg_Campos_EnBlanco;
            }

        }

        private void BtnBuscarAcuerdoPago_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral Consulta_Registro = new MainFormConsultaGeneral("select idacuerdo as codigo, nombre as descripcion from cxcdbfacuerdopago inner join cxcdbfcliente on cxcdbfcliente.idcliente=cxcdbfacuerdopago.idcliente where cxcdbfacuerdopago.nulo=0 ", "nombre", "Registro de Acuerdo de Pago");
            if (Consulta_Registro.ShowDialog(this) == DialogResult.OK)
            {
                Txtacuerdopago.Text = Consulta_Registro.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Fun_Buscar_Acuerdo_Pago();

            }
        }

        private void Txtconcepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones.Fun_Enfocar_Menu(e);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
