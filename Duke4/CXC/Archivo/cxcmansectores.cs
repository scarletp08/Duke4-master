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
    public partial class cxcmansectores : Duke4.MainFormMant
    {
        public cxcmansectores()
        {
            InitializeComponent();
        }

        private void btnBuscarprovincia_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idprovincia as codigo, descripcion from cxcdbfprovincia where nulo  = 0", "descripcion", "Provincias");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigoprovincia.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_provincia();
                if (TxtCodigoprovincia.Text != string.Empty)
                    TxtCodigoprovincia.Focus();
            }
        }
        private void Completar_provincia()
        {
            if (TxtCodigoprovincia.Fun_SQL_Buscar_CodigoRegistro("cxcdbfprovincia", "idprovincia"))
            {
                DataSet ds = TxtCodigoprovincia._Dataset;
                Txtdescripcionprovincia.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);




            }
            else
            {
                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
            }
        }

        private void btnBuscarmunicipio_Click(object sender, EventArgs e)
        {

            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idmunicipio as codigo, descripcion from cxcdbfmunicipio where nulo = 0", "descripcion", "Municipios");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigomunicipio.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_municipio();
                if (TxtCodigomunicipio.Text != string.Empty)
                    TxtCodigomunicipio.Focus();

            }

        }

        private void Completar_municipio()
        {
            if (TxtCodigomunicipio.Fun_SQL_Buscar_CodigoRegistro("cxcdbfmunicipio", "idmunicipio"))
            {
                DataSet ds = TxtCodigomunicipio._Dataset;
                Txtdescripcionmunicipio.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                //TxtCodigoprovincia.Text = ds.Tables[0].Rows[0]["idprovincia"].ToString();
                //Completar_provincia();

                LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void cxcmansectores_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Registro de Sectores", this);
            array = new Control[] { Txtdescripcion, TxtCodigomunicipio, btnBuscarmunicipio,TxtCodigoprovincia,btnBuscarprovincia };
        }
        //crear
        protected override void Crear()
        {
            base.Crear();
            btnBuscar.Visible = false;
            TxtCodigo.Enabled = false;
            TxtCodigo.Text = Logistica.FuncionesSQL.Fun_SQL_Buscar_UltimoCod("idsector", "cxcdbfsector");

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
                Logistica.FuncionesSQL.Fun_SQL_Activar_Mant(this.Name, TxtCodigo.Text.Trim(), "cxcdbfsector", "idsector");
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
                Logistica.FuncionesSQL.Fun_SQL_Desactivar_Mant(this.Name, TxtCodigo.Text.Trim(), "cxcdbfsector", "idsector");
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
            Control[] array = { TxtCodigo,TxtCodigomunicipio, TxtCodigoprovincia, Txtdescripcion };

            if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(array))
            {

                string cmd = string.Format("exec Spr_cxc_sector '{0}','{1}','{2}','{3}','{4}','{5}','{6}'",
                                  _OpcionSQL, Properties.Settings.Default.idsesion, 1, Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigo.Text),Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigomunicipio.Text), Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigoprovincia.Text), Txtdescripcion.Text);

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

        private void TxtCodigo_Validated(object sender, EventArgs e)
        {
            Completar_sector();
        }

        private void Txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_Enfocar_Menu(e);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {


            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idsector as codigo, descripcion from cxcdbfsector where nulo " + _ActivateParameter.ToString() + " 0", "descripcion", "Sector");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigo.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_sector();
                if (TxtCodigo.Text != string.Empty)
                    TxtCodigo.Focus();

            }

        }

        private void Completar_sector()
        {
            if (TxtCodigo.Fun_SQL_Buscar_CodigoRegistro("cxcdbfsector", "idsector"))
            {
                DataSet ds = TxtCodigo._Dataset;
                Txtdescripcion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                TxtCodigoprovincia.Text = ds.Tables[0].Rows[0]["idprovincia"].ToString();
                Completar_provincia();
                TxtCodigomunicipio.Text = ds.Tables[0].Rows[0]["idmunicipio"].ToString();
                Completar_municipio();

                LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);
            }
            else
            { Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(this); }
        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscar);
        }

        private void TxtCodigomunicipio_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscarmunicipio);
        }

        private void TxtCodigoprovincia_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscarprovincia);
        }

        private void TxtCodigoprovincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_Enfocar_Menu(e);
        }

        private void TxtCodigo_Validating(object sender, CancelEventArgs e)
        {
            Completar_sector();
        }

        private void TxtCodigomunicipio_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigomunicipio.Fun_SQL_Buscar_CodigoRegistro("cxcdbfmunicipio", "idmunicipio"))
            {
                DataSet ds = TxtCodigomunicipio._Dataset;

                Txtdescripcionmunicipio.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();

            }
            else Txtdescripcionmunicipio.Text = "";
        }

        private void TxtCodigoprovincia_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigoprovincia.Fun_SQL_Buscar_CodigoRegistro("cxcdbfprovincia", "idprovincia"))
            {
                DataSet ds = TxtCodigoprovincia._Dataset;

                Txtdescripcionprovincia.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();

            }
            else Txtdescripcionprovincia.Text = "";
        }
    }
}
    
    

