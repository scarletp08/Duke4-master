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
    public partial class cxcmanprovincias : Duke4.MainFormMant
    {
        public cxcmanprovincias()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idprovincia as codigo, descripcion from cxcdbfprovincia where nulo " + _ActivateParameter.ToString() + " 0", "descripcion", "Provincias");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigo.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_provincia();
                if (TxtCodigo.Text != string.Empty)
                    TxtCodigo.Focus();
            }
        }
        private void Completar_provincia()
        {
            if (TxtCodigo.Fun_SQL_Buscar_CodigoRegistro("cxcdbfprovincia", "idprovincia"))
            {
                DataSet ds = TxtCodigo._Dataset;
                Txtdescripcion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);
                TxtCodigoregion.Text = ds.Tables[0].Rows[0]["idregion"].ToString();
                Completar_region();

            }
            else
            {
                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
            }
        }
        protected override void Crear()
        {
            base.Crear();
            btnBuscar.Visible = false;
            TxtCodigo.Enabled = false;
            TxtCodigo.Text = Logistica.FuncionesSQL.Fun_SQL_Buscar_UltimoCod("idprovincia", "cxcdbfprovincia");

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
                Logistica.FuncionesSQL.Fun_SQL_Activar_Mant(this.Name, TxtCodigo.Text.Trim(), "cxcdbfprovincia", "idprovincia");
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
                Logistica.FuncionesSQL.Fun_SQL_Desactivar_Mant(this.Name, TxtCodigo.Text.Trim(), "cxcdbfprovincia", "idprovincia");
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
            Control[] array = { TxtCodigo, TxtCodigoregion,Txtdescripcion };

            if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(array))
            {

                string cmd = string.Format("exec Spr_cxc_provincia '{0}','{1}','{2}','{3}','{4}','{5}'",
                                  _OpcionSQL, Properties.Settings.Default.idsesion, 1, Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigo.Text), Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigoregion.Text), Txtdescripcion.Text);

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

        private void cxcmanprovincias_Load(object sender, EventArgs e)
        {
         
            Fun_Set_Nombre_Formulario("Registro de Provincias", this);
            array = new Control[] { Txtdescripcion, TxtCodigoregion,btnBuscarregion };
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {

            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idregion as codigo, descripcion from cxcdbfregion where nulo = 0", "descripcion", "Region");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigoregion.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_region();
                if (TxtCodigoregion.Text != string.Empty)
                    TxtCodigoregion.Focus();
            }

        }

        private void Completar_region()
        {
            if (TxtCodigoregion.Fun_SQL_Buscar_CodigoRegistro("cxcdbfregion", "idregion"))
            {
                DataSet ds = TxtCodigoregion._Dataset;
               Txtdescripcionregion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);
            }
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCodigo_Validated(object sender, EventArgs e)
        {
            
        }

        private void Txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funciones_Duke4.Funciones.Fun_Enfocar_Menu(e);
        }

        private void TxtCodigo_Validating(object sender, CancelEventArgs e)
        {
            Completar_provincia();
        }

        private void TxtCodigoregion_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigoregion.Fun_SQL_Buscar_CodigoRegistro("cxcdbfprovincia", "idregion"))
            {
                DataSet ds = TxtCodigoregion._Dataset;

                Txtdescripcionregion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();

            }
            else Txtdescripcionregion.Text = "";
        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscar);
        }

        private void TxtCodigoregion_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscarregion);
        }

        private void TxtCodigoregion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_Enfocar_Menu(e);
            Txtdescripcion.Focus();
        }
    }
}

    

