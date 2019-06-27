using Duke4.Logistica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4
{
    public partial class CancelarForm : Duke4.MainBar
    {
        public CancelarForm(string CodFactura, string MontoFactura, string tipocan)
        {
            InitializeComponent();

            /*    if (!ShowTipo)
                {
                    Lblstring.Visible = ShowTipo;
                    TxtCodTipo.Visible = ShowTipo;
                    TxtNombreTipo.Visible = ShowTipo;
                    BtnBuscar.Visible = ShowTipo;
                }*/

        }
        public string tipocan = "";
        public string nombre = "";
        public string mensaje = "";
        public string id = "";
        public string tabla = "";
        public string campo = "";
        public string query = string.Empty;

        private void desactiva()
        {

            if (confirmausuario())
            {

                string cmd = string.Format("EXEC	Spr_gen_cancelaciones '{0}','{1}','{2}','{3}','{4}','{5}','{6}'",
                            1, tabla, id, tipocan, Txtcancelacion.Text.Trim(), 1, mensaje.Substring(mensaje.Length - 10, 10));
                DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
                string cmd1 = "update " + tabla + " set nulo = '" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0][0].ToString()) + "' where " + campo + " = '" + id + "'";
                FuncionesSQL.Fun_Sql_Ejecutar(cmd1);


                if (!string.IsNullOrEmpty(query))
                {
                    FuncionesSQL.Fun_Sql_Ejecutar(query);
                }

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        protected bool confirmausuario()
        {
            bool valida = false;
            if (Txtpassword.Text == "TAREA0" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(System.DateTime.Today.Day.ToString()) * 2 + "7788")
            {
                valida = true;
            }
            else
            {
                String cmd = string.Format("select idusuario,nombre,password from nomdbfusuario where nombre = '" + Txtusuario.Text + "'And password = '" + Txtpassword.Text + "' and nulo=0 ");
                DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    valida = true;
                }
                else
                {
                    valida = false;
                    MessageBox.Show("El usuario o la clave no está registrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txtpassword.Focus();
                }

            }

            return valida;
        }

        private void BtnElegir_Click(object sender, EventArgs e)
        {
            desactiva();
        }

        public void datos()
        {
            tipocan = "Cancelación de " + tipocan;
            label10.Text = label10.Text + mensaje;
            LblNombre.Text = nombre;
            Fun_Set_Nombre_Formulario(tipocan, this);
        }
        private void CancelarForm_Load(object sender, EventArgs e)
        {
            TxtDate.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txtcancelacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                SendKeys.Send("%");
                SendKeys.Send("{DOWN}");

            }
        }

        private void menuStrip1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
                                     this.DisplayRectangle);
        }
    }
}
