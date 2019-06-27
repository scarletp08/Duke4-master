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
    public partial class cxcmanMoneda : Duke4.MainFormMant
    {
        public cxcmanMoneda()
        {
            InitializeComponent();
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idmoneda as codigo,  descripcion,abreviatura,tasa from gendbfmoneda where nulo " + _ActivateParameter.ToString() + " 0", "descripcion", "Mneda");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigo.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_moneda();
                if (TxtCodigo.Text != string.Empty)
                    Txtdescripcion.Focus();
            }

        }

        private void cxcmanMoneda_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Registro de monedas y configuracion de cuentas contables", this);
            array = new Control[] { Txtdescripcion, Txtabreviatura,  TxtTasa,TxtCodigo };
        }
        private void Completar_moneda()
        {
            if (TxtCodigo.Fun_SQL_Buscar_CodigoRegistro("gendbfmoneda", "idmoneda"))
            {
                DataSet ds = TxtCodigo._Dataset;
                Txtdescripcion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                Txtabreviatura.Text = ds.Tables[0].Rows[0]["abreviatura"].ToString();
                TxtTasa.Text = ds.Tables[0].Rows[0]["tasa"].ToString();
                LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);





            }
            else
            {
                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
            }
        }

        private void TxtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (_OpcionSQL != "Insertar")
                Completar_moneda();
        }


        protected override void Crear()
        {
            base.Crear();
            btnBuscar.Visible = false;
            TxtCodigo.Enabled = false;
            TxtCodigo.Text = Logistica.FuncionesSQL.Fun_SQL_Buscar_UltimoCod("idmoneda", "gendbfmoneda");
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
                Logistica.FuncionesSQL.Fun_SQL_Activar_Mant(this.Name, TxtCodigo.Text.Trim(), "gendbfmoneda", "idmoneda");
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
                Logistica.FuncionesSQL.Fun_SQL_Desactivar_Mant(this.Name, TxtCodigo.Text.Trim(), "gendbfmoneda", "idmoneda");
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
            Control[] array = { TxtCodigo, Txtdescripcion,Txtabreviatura,TxtTasa };

            if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(array))
            {


                string cmd = string.Format("exec Spr_gen_moneda '{0}','{1}','{2}','{3}','{4}','{5}','{6}'",
                                  _OpcionSQL, Properties.Settings.Default.idsesion, 1, Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigo.Text), Txtdescripcion.Text, Txtabreviatura.Text, Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(TxtTasa.Text));


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

        private void TxtTasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_Enfocar_Menu(e);
            Txtdescripcion.Focus();
        }

        private void TxtCodigo_Validated(object sender, EventArgs e)
        {
            
        }

        private void TxtCodigo_Validating_1(object sender, CancelEventArgs e)
        {
            Completar_moneda();
        }

        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscar);
        }
    }
}
