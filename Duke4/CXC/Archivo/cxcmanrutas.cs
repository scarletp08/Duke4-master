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
    public partial class cxcmanrutas : Duke4.MainFormMant
    {
        public cxcmanrutas()
        {
            InitializeComponent();
        }

        private void cxcmanrutas_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Registro de Ruta", this);
            array = new Control[] { Txtdescripcion, TxtCodigovendedor, btnBuscarvendedor };
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idruta as codigo, descripcion from cxcdbfruta where nulo " + _ActivateParameter.ToString() + " 0", "descripcion", "Rutas");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigo.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_ruta();
                if (TxtCodigo.Text != string.Empty)
                    TxtCodigo.Focus();

            }

        }

        private void Completar_ruta()
        {
            if (TxtCodigo.Fun_SQL_Buscar_CodigoRegistro("cxcdbfruta", "idruta"))
            {
                DataSet ds = TxtCodigo._Dataset;
                Txtdescripcion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                TxtCodigovendedor.Text = ds.Tables[0].Rows[0]["idempleado"].ToString();
                Completar_vendedor();

                LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);
            }
            else { Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(this); }
        }

        private void btnBuscarvendedor_Click(object sender, EventArgs e)
        {

            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idempleado as codigo,  nombre as descripcion from nomdbfempleado where nulo  = 0", "nombre", "Vendedor");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigovendedor.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_vendedor();
                if (TxtCodigovendedor.Text != string.Empty)
                    TxtCodigovendedor.Focus();
            }
        }
        private void Completar_vendedor()
        {
            if (TxtCodigovendedor.Fun_SQL_Buscar_CodigoRegistro("nomdbfempleado", "idempleado"))
            {
                DataSet ds = TxtCodigovendedor._Dataset;
                Txtdescripcionvendedor.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);




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
            TxtCodigo.Text = Logistica.FuncionesSQL.Fun_SQL_Buscar_UltimoCod("idruta", "cxcdbfruta");

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
                Logistica.FuncionesSQL.Fun_SQL_Activar_Mant(this.Name, TxtCodigo.Text.Trim(), "cxcdbfruta", "idruta");
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
                Logistica.FuncionesSQL.Fun_SQL_Desactivar_Mant(this.Name, TxtCodigo.Text.Trim(), "cxcdbfruta", "idruta");
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
            Control[] array = { TxtCodigo, TxtCodigovendedor, Txtdescripcion };

            if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(array))
            {

                string cmd = string.Format("exec Spr_cxc_ruta '{0}','{1}','{2}','{3}','{4}','{5}'",
                                  _OpcionSQL, Properties.Settings.Default.idsesion, 1, Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigo.Text), Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigovendedor.Text), Txtdescripcion.Text);

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
           
        }

        private void Txtdescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Funciones_Duke4.Funciones.Fun_Enfocar_Menu(e);


        }

        private void TxtCodigovendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_Enfocar_Menu(e);
        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscar);
        }

        private void TxtCodigovendedor_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscarvendedor);
        }

        private void Txtdescripcionvendedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCodigovendedor_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigovendedor.Fun_SQL_Buscar_CodigoRegistro("nomdbfempleado", "idempleado"))
            {
                DataSet ds = TxtCodigovendedor._Dataset;

                Txtdescripcionvendedor.Text = ds.Tables[0].Rows[0]["nombre"].ToString();

            }
            else Txtdescripcionvendedor.Text = "";
        }

        private void TxtCodigo_Validating(object sender, CancelEventArgs e)
        {
            Completar_ruta();
        }
    }

    }
    
    

