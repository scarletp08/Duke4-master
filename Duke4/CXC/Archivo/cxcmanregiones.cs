using Duke4.Consulta_General;
using Duke4.Logistica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.CXC.Archivo
{
    public partial class cxcmanregiones : Duke4.MainFormMant
    {
        public cxcmanregiones()
        {
            InitializeComponent();
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idregion as codigo, descripcion from cxcdbfregion where nulo " + _ActivateParameter.ToString() + " 0", "descripcion", "Region");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigo.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_region();
                if (TxtCodigo.Text != string.Empty)
                    TxtCodigo.Focus();
            }
        }
             private void Completar_region()
        {
            if (TxtCodigo.Fun_SQL_Buscar_CodigoRegistro("cxcdbfregion", "idregion"))
            {
                DataSet ds = TxtCodigo._Dataset;
                Txtdescripcion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);



            }
            else
            {
                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
            }

        }

        private void cxcmanregiones_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Registro de Regiones", this);
            array = new Control[] { Txtdescripcion,  };
        }
        protected override void Crear()
        {
            base.Crear();
            btnBuscar.Visible = false;
            TxtCodigo.Enabled = false;
            TxtCodigo.Text = Logistica.FuncionesSQL.Fun_SQL_Buscar_UltimoCod("idregion", "cxcdbfregion");
            Txtdescripcion.Focus();
        }
        protected override void Modificar()
        {
            base.Modificar();
            btnBuscar.Visible = true;
            TxtCodigo.Enabled = true;
            TxtCodigo.Focus();
        }
        protected override void AbrirActivar()
        {
            base.AbrirActivar();
            btnBuscar.Visible = true;
            TxtCodigo.Enabled = true;
            TxtCodigo.Focus();
            TxtCodigo._MostrarRegDesactivo = TxtCodigo._MostrarRegActivo = true;
        }
        protected override void AbrirDesactivar()
        {
            base.AbrirDesactivar();
            btnBuscar.Visible = true;
            TxtCodigo.Enabled = true;
            TxtCodigo.Focus();
        }
        protected override void Retornar()
        {
            base.Retornar();

            TxtCodigo._IgnorarNulo = false;
            TxtCodigo._MostrarRegDesactivo = TxtCodigo._MostrarRegActivo = false;
        }
        protected override void Consultar()
        {
            base.Consultar();
            btnBuscar.Visible = true;
            btnBuscar.Enabled = TxtCodigo.Enabled = true;
            TxtCodigo.Focus();
            TxtCodigo._IgnorarNulo = true;
        }
        protected override void Activar()
        {
            if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(new Control[] { TxtCodigo }))
            {
                Logistica.FuncionesSQL.Fun_SQL_Activar_Mant(this.Name, TxtCodigo.Text.Trim(), "cxcdbfregion", "idregion");
                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
                LblAlerta.Text = string.Empty;
                base.Activar();
            }
            else
                LblAlerta.Text = Logistica.Mensajes.Stg_Campos_EnBlanco;
        }
        protected override void Desactivar()
        {
            if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(new Control[] { TxtCodigo }))
            {
                Logistica.FuncionesSQL.Fun_SQL_Desactivar_Mant(this.Name, TxtCodigo.Text.Trim(), "cxcdbfregion", "idregion");
                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
                LblAlerta.Text = string.Empty;
                base.Desactivar();
            }
            else
                LblAlerta.Text = Mensajes.Stg_Campos_EnBlanco;
        }

        protected override void Salvar()
        {
            base.Salvar();
            int rdbgrado = 0;
            Control[] array = { TxtCodigo, Txtdescripcion };

            if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(array))
            {
                string cmd = string.Format("exec Spr_cxc_region '{0}','{1}','{2}','{3}','{4}'",
                                  _OpcionSQL, Properties.Settings.Default.idsesion, 1, Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigo.Text), Txtdescripcion.Text);

                FuncionesSQL.Fun_Sql_Ejecutar(cmd);

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

        private void Txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_Enfocar_Menu(e);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtCodigo_Validating(object sender, CancelEventArgs e)
        {
            Completar_region();
        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscar);
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

