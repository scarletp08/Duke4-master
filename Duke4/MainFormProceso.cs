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
    public partial class MainFormProceso : MainBar
    {
        public MainFormProceso()
        {
            InitializeComponent();
        }
        //Indica si me encuentro en el menu principal, para actualizar el menu
        bool opcionactiva = true;
        /// <summary>
        /// Cierra la pantalla o refresca el menu y el panel para volver atras
        /// </summary>
        protected virtual void Retornar()
        {
            this.Close();
        }
        /// <summary>
        /// Cambia el string _OpcionSQL a "Modificar", setea el LblFunctionName y cambia el menu principal
        /// </summary>
        protected virtual void Modificar()
        {
            LblAlerta.Text = "";
            BtnCrear.Visible = true;
            BtnModificar.Visible = false;
            _OpcionSQL = "Modificar";
            LblFunctionName.Text = " Modificando...";
            LblAlerta.Text = "";
            Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);

        }
        
        //protected virtual void Modificar()
        //{
        //    LblFunctionName.Text = " Modificando...";
        //    EnableMenuButtons(false);
        //    MainPanel.Visible = true;
        //}
        /// <summary>
        /// Cambia el string _OpcionSQL a "Insertar", setea el LblFunctionName y cambia el menu principal
        /// </summary>
        protected virtual void Crear()
        {
            LblAlerta.Text = "";
            BtnCrear.Visible = false;
            BtnModificar.Visible = true;
            _OpcionSQL = "Insertar";
            LblFunctionName.Text = "     Creando...";
            LblAlerta.Text = "";
            Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
        }
        /// <summary>
        /// Se ejecuta al seleccionar el boton salvar, viene vacio
        /// </summary>
        protected virtual void Salvar()
        {

        }
        protected virtual void Blanquear()
        {
            BtnModificar.Enabled = BtnCrear.Enabled = true;
            if (_OpcionSQL == "Insertar")
                Crear();
            else Modificar();
        }
        private void MainFormProceso_Load(object sender, EventArgs e)
        {
            //Mostrar solo registros activos
            _ActivateParameter = "=";

            SetFormFunctionLocation(this.Width);

            LblAlerta.Text = LblFunctionName.Text = "";
        }
        protected void SetFormFunctionLocation(int posX)
        {            
          //  LblAlerta.Location = new Point(5, this.Height - 33);
            panel2.Size = new Size(this.Width, 11);
            panel2.Location = new Point(0, this.Height - 50);
            MainPanel.Location = new Point(1, 110);
            //   LblFunctionName.Location = new Point(this.Width-210, 101);

        }

        //Click en Boton crear Ejecuta -> Crear()
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            Crear();
        }
        //Click en Boton modificar Ejecuta -> Modificar()
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }
        //Click en Boton salvar Ejecuta -> Salvar()
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
        //Click en Boton retornar Ejecuta -> Retornar()
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Retornar();
        }

        private void MainFormProceso_KeyDown(object sender, KeyEventArgs e)
        {
            //Si se presiona la tecla de Esc ejecuta -> Retornar()
            if (e.KeyCode == Keys.Escape)
            {
                Retornar();
            }
        }

        private void menuStrip1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
                                     this.DisplayRectangle);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Retornar();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Salvar();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Crear();
        
        }

        private void BtnBlanquear_Click(object sender, EventArgs e)
        {
            Blanquear();
        }
    }
}
