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
    public partial class _procVMenu : MainBar
    {
        public _procVMenu()
        {
            InitializeComponent();
        }
        private double tasa = 0;
        private int dia = 0;
        void EnableMenuButtons(bool val)
        {
            // El boton Salvar es contrario a los demas botones del menu
            BtnSalvar.Visible = !val;
            BtnCrear.Visible = val;
            BtnModificar.Visible = val;

        }
        private void _procVMenu_Load(object sender, EventArgs e)
        {
            //Inicializa el menu principal
            BtnSalvar.Visible = false;
            //Mostrar solo registros activos
            _ActivateParameter = "=";

            LblAlerta.Text = LblFunctionName.Text = "";

            Fun_Set_Nombre_Formulario("Registro de Factura", this);
            mainPanel.Visible = false;
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");
            Ckbimprimir.Checked = true;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (BtnCrear.Visible)
                this.Close();
            else
            {
               // mainMenuActive = true;
                EnableMenuButtons(true);
                  Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(mainPanel);
                LblFunctionName.Text = LblAlerta.Text = string.Empty;
                mainPanel.Visible = true;

            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            _OpcionSQL = "Modificar";
            LblFunctionName.Text = "Modificando...";
            LblAlerta.Text = "";
            EnableMenuButtons(false);
            Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(mainPanel);
            LblAlerta.Text = LblFunctionName.Text = string.Empty;
            mainPanel.Visible = true;

        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            _OpcionSQL = "Insertar";
            LblFunctionName.Text = "Creando...";
            EnableMenuButtons(false);
            mainPanel.Visible = true;

        }
    }
}
