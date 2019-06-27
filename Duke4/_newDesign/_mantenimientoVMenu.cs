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

namespace Duke4
{
    public partial class _mantenimientoVMenu : MainBar
    {
        public _mantenimientoVMenu()
        {
            InitializeComponent();

        }
        #region mantenimiento general options
        public Control[] array = { };
        private void mantenimientoVMenu_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Registro de Conceptos", this);
            this.BackColor = Color.FromArgb(235, 242, 251);
            FormTitle.ForeColor = Color.White;
            EnableButtons(true);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(cmbitbis, "select iditbis,tasa  from gendbftasaitbis");
            array = new Control[] { TxtDescripcion, cmbitbis};
        }
        private void EnableButtons(bool readOnly)
        {
            BtnCrear.Visible = BtnConsultar.Visible = BtnModificar.Visible = BtnActivar.Visible = BtnDesactivar.Visible = readOnly;
            BtnSalvar.Visible = !readOnly;
            MainPanel.Visible = !readOnly;
        }
        void CodigoySearch(bool val)
        {
            btnBuscar.Visible = val;
            TxtCodigo.Enabled = val;
        }
        void Crear()
        {
            EnableButtons(false);
            _OpcionSQL = "Insertar";
            LblFunctionName.Text = "Creando...";
            TxtCodigo.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoCod("idconcepto", "cxcdbfconcepto");
            Funciones_Duke4.Funciones.Fun_Habilitar_Control_Objetos(array, true);
            CodigoySearch(false);
            TxtDescripcion.Focus();
        }
        void Modificar()
        {
            _OpcionSQL = "Modificar";
            _ActivateParameter = "=";
            EnableButtons(false);
            LblFunctionName.Text = "Modificando...";
            Funciones_Duke4.Funciones.Fun_Habilitar_Control_Objetos(array, true);
            CodigoySearch(true);
            TxtCodigo.Focus();
        }
        void Retornar()
        {
            if (BtnCrear.Visible)
                this.Close();
            else
            {
                EnableButtons(true);
                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
                LblEstado.Text = LblAlerta.Text = LblFunctionName.Text = string.Empty;
                TxtCodigo._IgnorarNulo = false;
                TxtCodigo._MostrarRegDesactivo = TxtCodigo._MostrarRegActivo = false;
            }
          
        }
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            Crear();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Retornar();   
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            EnableButtons(false);
            _OpcionSQL = "Consultar";
            LblFunctionName.Text = "Consultando...";
            _ActivateParameter = ">=";
            Funciones_Duke4.Funciones.Fun_Habilitar_Control_Objetos(array, false);
            CodigoySearch(true);
            TxtCodigo.Focus();
            TxtCodigo._IgnorarNulo = true;
        }
        private void BtnActivar_Click(object sender, EventArgs e)
        {
            EnableButtons(false);
            _OpcionSQL = "Activar";
            LblFunctionName.Text = "Activando...";
            _ActivateParameter = ">";
            Funciones_Duke4.Funciones.Fun_Habilitar_Control_Objetos(array, false);
            CodigoySearch(true);
            TxtCodigo._MostrarRegDesactivo = TxtCodigo._MostrarRegActivo = true;


        }
        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            EnableButtons(false);
            _OpcionSQL = "Desactivar";
            LblFunctionName.Text = "Desactivando...";
            _ActivateParameter = "=";
            Funciones_Duke4.Funciones.Fun_Habilitar_Control_Objetos(array, false);
            CodigoySearch(true);
            TxtCodigo.Focus();
        }
        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
          if (_OpcionSQL == "Insertar" || _OpcionSQL == "Modificar")
            {
                int rdbgrado = 0;
                Control[] array = { TxtCodigo, TxtDescripcion, cmbitbis };

                if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(array))
                {
                    string cmd = string.Format("exec Spr_cxc_concepto '{0}','{1}','{2}','{3}','{4}','{5}'",
                                      _OpcionSQL, Properties.Settings.Default.idsesion, 1, Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigo.Text), TxtDescripcion.Text, cmbitbis.SelectedValue);

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
            else if (_OpcionSQL == "Activar")
            {

                if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(new Control[] { TxtCodigo }))
                {
                    FuncionesSQL.Fun_SQL_Activar_Mant(this.Name, TxtCodigo.Text.Trim(), "cxcdbfconcepto", "idconcepto");
                    Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
                    LblAlerta.Text = string.Empty;
                    EnableButtons(true);
                }
                else
                    LblAlerta.Text = Mensajes.Stg_Campos_EnBlanco;
            }
            else if (_OpcionSQL == "Desactivar")
            {
                if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(new Control[] { TxtCodigo }))
                {
                    FuncionesSQL.Fun_SQL_Desactivar_Mant(this.Name, TxtCodigo.Text.Trim(), "cxcdbfconcepto", "idconcepto");
                    Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
                    LblAlerta.Text = string.Empty;
                    EnableButtons(true);
                }
                else
                    LblAlerta.Text = Mensajes.Stg_Campos_EnBlanco;
            }
         
           
        }
        private void mantenimientoVMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Retornar();
                this.Focus();
            }
        }
        #endregion

        #region funciones de cxcmanconceptos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idconcepto as codigo, descripcion from cxcdbfconcepto where nulo " + _ActivateParameter.ToString() + " 0", "descripcion", "Concepto");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {
                TxtCodigo.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_concepto();
                if (TxtCodigo.Text != string.Empty)
                    TxtCodigo.Focus();
            }
        }
        private void Completar_concepto()
        {
            if (TxtCodigo.Fun_SQL_Buscar_CodigoRegistro("cxcdbfconcepto", "idconcepto"))
            {
                DataSet ds = TxtCodigo._Dataset;
                TxtDescripcion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                cmbitbis.SelectedValue = ds.Tables[0].Rows[0]["iditbis"].ToString();
                LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);
            }
            else
                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
        }
        private void TxtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscar);
        }

        private void TxtCodigo_Validating_1(object sender, CancelEventArgs e)
        {
            Completar_concepto();
        }
        private void cmbitbis_KeyPress(object sender, KeyPressEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_Enfocar_Menu(e);
        }

        #endregion

        
    }
}
