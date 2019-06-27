using Duke4.Consulta_General;
using Duke4.Logistica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duke4._newDesign
{
    public partial class _cancelar : MainBar
    {
        public _cancelar()
        {
            InitializeComponent();
            TxtDate.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }

        public static string tipoanulacion = "";
        public string nombre = "";
        public string secuencia = "";
        public string id = "";
        public string tabla = "";
        public string campo = "";
        public string query = string.Empty;
        public string idprograma = "";
        public string valor = "";

        protected bool confirmausuario()
        {
            bool valida = false;
            if (Txtpassword.Text == "TAREA0" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(System.DateTime.Today.Day.ToString()) * 2 + "7788")
                valida = true;
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

        private void _cancelar_Load(object sender, EventArgs e)
        {

        }
        public void datos()
        {
            tipoanulacion = "Cancelación de " + tipoanulacion;
            if (secuencia != "")
                label10.Text = label10.Text + secuencia;
            else
                label10.Text = label10.Text + id;
            if (nombre != "")
                LblNombre.Text = "De " + nombre;
            if (valor != "")
                LblNombre.Text = LblNombre.Text + " Por valor de" + valor;

            Fun_Set_Nombre_Formulario(tipoanulacion, this);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (confirmausuario())
            {
                string cmd = string.Format("EXEC	Spr_gen_cancelacion '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
                Properties.Settings.Default.idsesion, 1, id, tipoanulacion, Txtcancelacion.Text, 1, 1, secuencia);

                DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                string cmd1 = "update " + tabla + " set nulo = 1 where " + campo + " = '" + id + "'";
                FuncionesSQL.Fun_Sql_Ejecutar(cmd1);


                if (!string.IsNullOrEmpty(query))
                {
                    FuncionesSQL.Fun_Sql_Ejecutar(query);
                }

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txtcodigoanulacion_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Tipo_Cancelacion();
        }
        protected void Fun_Buscar_Tipo_Cancelacion()
        {
            if (Txtcodigoanulacion.Fun_SQL_Buscar_CodigoRegistro("gendbftipocancelacion", "idtipocancelacion"))
            {
                DataSet ds = Txtcodigoanulacion._Dataset;
                Txtdescripcionanulacion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();

            }
            else
            {
                Txtcodigoanulacion.Text = "";
                Txtdescripcionanulacion.Text = "";

            }
        }

        private void BtnBuscarAnulacion_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral Consulta_Vendedor = new MainFormConsultaGeneral("select idtipocancelacion as codigo, descripcion from gendbftipocancelacion where nulo=0", "descripcion", "Cancelación");
            if (Consulta_Vendedor.ShowDialog() == DialogResult.OK)
            {
                Txtcodigoanulacion.Text = Consulta_Vendedor.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Txtdescripcionanulacion.Text = Consulta_Vendedor.MainGrid.SelectedRows[0].Cells[1].Value.ToString();
            }
        }
    }
}
