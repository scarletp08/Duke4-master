using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4
{
    public partial class MainFormMant : MainBar
    {
        public MainFormMant()
        {
            InitializeComponent();
        }

        public Control[] array = {};

        /// <summary>
        /// Coloca el LblFunctionName a 215 pixeles del ancho del formulario 
        /// </summary>
        /// <param name="posX">El Width del formulario</param>
        protected void SetFormFunctionLocation(int posX)
        {
            LblAlerta.Location = new Point(5, this.Height - 33);
            panel2.Size = new Size(this.Width, 11);
            panel2.Location = new Point(0, this.Height - 50);
            LblFunctionName.Location = new Point(this.Width - 210, 101);
            MainPanel.Location = new Point(1, 130);

        }
        
        /// <summary>
        /// Cambia el string _OpcionSQL a "Insertar", setea el LblFunctionName, cambia el menu principal, y habilita todos los controles
        /// </summary>
        protected virtual void Crear()
        {
            LblAlerta.Text = "";
            BtnCrear.Visible = false;
            BtnModificar.Visible = true;
            BtnConsultar.Visible = true;
            BtnActivar.Visible = false;
            BtnDesactivar.Visible = false;
            BtnSalvar.Visible = true;
            _OpcionSQL = "Insertar";
            LblFunctionName.Text = "Creando...";
            Funciones_Duke4.Funciones.Fun_Habilitar_Control_Objetos(array, true);
            Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
        }
        /// <summary>
        /// Cambia el string _OpcionSQL a "Modificar", setea el LblFunctionName, cambia el menu principal, y habilita todos los controles
        /// </summary>
        protected virtual void Modificar()
        {
            LblAlerta.Text = "";
            BtnCrear.Visible = true;
            BtnModificar.Visible = false;
            BtnConsultar.Visible = true;
            BtnActivar.Visible = true;
            BtnDesactivar.Visible = true;
            BtnSalvar.Visible = true;
            _OpcionSQL = "Modificar";
            _ActivateParameter = "=";
            LblFunctionName.Text = "Modificando...";
            Funciones_Duke4.Funciones.Fun_Habilitar_Control_Objetos(array, true);
            Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
        }
        /// <summary>
        /// Cambia el string _OpcionSQL a "Consultar", setea el LblFunctionName, cambia el menu principal, y deshabilita todos los controles
        /// </summary>
        protected virtual void Consultar()
        {
            LblAlerta.Text = "";
            BtnCrear.Visible = true;
            BtnModificar.Visible = true;
            BtnConsultar.Visible = false;
            BtnActivar.Visible = true;
            BtnDesactivar.Visible = true;
            BtnSalvar.Visible = false;
            _OpcionSQL = "Consultar";
            LblFunctionName.Text = "Consultando...";
            _ActivateParameter = ">=";
            Funciones_Duke4.Funciones.Fun_Habilitar_Control_Objetos(array, false);
            Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
        }
        /// <summary>
        /// Cambia el string _OpcionSQL a "Activar", setea el LblFunctionName, cambia el menu principal, y habilita todos los controles
        /// </summary>
        protected virtual void AbrirActivar()
        {
            LblAlerta.Text = "";
            _OpcionSQL = "Activar";
            LblFunctionName.Text = "Activando...";
            _ActivateParameter = ">";
            Funciones_Duke4.Funciones.Fun_Habilitar_Control_Objetos(array, false);
            Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
        }
        /// <summary>
        /// Cambia el string _OpcionSQL a "Desactivar", setea el LblFunctionName, cambia el menu principal, y habilita todos los controles
        /// </summary>
        protected virtual void AbrirDesactivar()
        {
            LblAlerta.Text = "";
            _OpcionSQL = "Desactivar";
            LblFunctionName.Text = "Desactivando...";
            _ActivateParameter = "=";
             Funciones_Duke4.Funciones.Fun_Habilitar_Control_Objetos(array, false);
            Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
        }
        /// <summary>
        /// Se ejecuta al seleccionar el boton salvar, viene vacio
        /// </summary>
        protected virtual void Salvar()
        {

        }
        /// <summary>
        /// Se ejecuta al seleccionar el boton activar registro, ejecuta la funcion de retornar
        /// </summary>
        protected virtual void Activar()
        {
            //Retornar();
        }
        /// <summary>
        /// Se ejecuta al seleccionar el boton desactivar registro, ejecuta la funcion de retornar
        /// </summary>
        protected virtual void Desactivar()
        {
            //Retornar();
        }

        public bool opcionactiva = false;

        /// <summary>
        /// retorna o cierra el menu principal, limpia el LblEstado, LblAlerta y LblFunctionName, asi como el MainPanel
        /// </summary>
        protected virtual void Retornar()
        {            
              this.Close();
                   }
        private void MainFormMant_Load(object sender, EventArgs e)
        {
            // LblEstado = Registro Activo y Reg Desactivo
            // LblAlerta = Errores en el formulario al guardar
            // LblFunctionName = "Creando", "Modificando", "Activando", "Desactivando"
            LblEstado.Text = LblAlerta.Text = LblFunctionName.Text = string.Empty;
            // Menu de Salvar invisible
            
            // Establece la ubicación de LblFunctionName a 215 pixeles a la izquierda del ancho del formulario
            SetFormFunctionLocation(this.Width);
            Crear();
        }
        private void MainFormMant_KeyDown(object sender, KeyEventArgs e)
        {
            //Si se presiona la tecla de Esc ejecuta -> Retornar()
            if (e.KeyCode == Keys.Escape)
            {
                Retornar();
                
            }
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
        //Click en Boton consultar Ejecuta -> Consultar()
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        //Click en Boton retornar Ejecuta -> Retornar()
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Retornar();
        }
        //Click en Boton activar Ejecuta -> AbrirActivar la primera vez para habilitar el menu de activar
        //Click en Boton activar Ejecuta -> Activar la segunda vez para ejecutar el Activar Registro
        private void BtnActivar_Click(object sender, EventArgs e)
        {
            if (BtnCrear.Visible)
                AbrirActivar();
            else
                Activar();
        }
        //Click en Boton desactivar Ejecuta -> AbrirDesactivar() la primera vez para habilitar el menu de desactivar
        //Click en Boton desactivar Ejecuta -> Desactivar() la segunda vez para ejecutar el Desactivar Registro
        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            if (BtnCrear.Visible)
                AbrirDesactivar();
            else
                Desactivar();
        }
        //Click en Boton salvar Ejecuta -> Salvar()
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void menuStrip1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
                                     this.DisplayRectangle);
        }

        private void BtnCrear_MouseMove(object sender, MouseEventArgs e)
        {
            BtnCrear.Width = 150;
            BtnCrear.Height = 36;

            BtnCrear.Image = Properties.Resources.crear32;


        }

        private void BtnActivar_MouseMove(object sender, MouseEventArgs e)
        {
            //imagen 32x32
            
            BtnActivar.Width = 150;
            BtnActivar.Height = 36;

            BtnActivar.Image = Properties.Resources.like__4_;


        }

        private void BtnActivar_MouseLeave(object sender, EventArgs e)
        {
            //imagen 24x24
            
            BtnActivar.Width = 150;
            BtnActivar.Height = 30;

            BtnActivar.Image = Properties.Resources.like__2_;
        }

        private void BtnDesactivar_MouseMove(object sender, MouseEventArgs e)
        {
            BtnDesactivar.Width = 150;
            BtnDesactivar.Height = 36;
            BtnDesactivar.Image = Properties.Resources.nolike32;

        }

        private void BtnDesactivar_MouseLeave(object sender, EventArgs e)
        {
            BtnDesactivar.Width = 150;
            BtnDesactivar.Height = 30;
           BtnDesactivar.Image = Properties.Resources.nolike24;

        }

        private void BtnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            //imagen 32x32

            BtnCancelar.Width = 150;
            BtnCancelar.Height = 36;

            BtnCancelar.Image = Properties.Resources.retornar32;

        }

        private void BtnCancelar_MouseLeave(object sender, EventArgs e)
        {
            BtnCancelar.Width = 150;
            BtnCancelar.Height = 30;
            BtnCancelar.Image = Properties.Resources.retornar24;

        }

        private void BtnCrear_MouseLeave(object sender, EventArgs e)
        {
            BtnCrear.Width = 150;
            BtnCrear.Height = 30;

            BtnCrear.Image = Properties.Resources.crear24;

        }

        private void BtnModificar_MouseMove(object sender, MouseEventArgs e)
        {

            BtnModificar.Width = 150;
            BtnModificar.Height = 36;

            BtnModificar.Image = Properties.Resources.modificar32;


        }

        private void BtnModificar_MouseLeave(object sender, EventArgs e)
        {
            BtnModificar.Width = 150;
            BtnModificar.Height = 30;

            BtnModificar.Image = Properties.Resources.modificar24;
        }

        private void BtnConsultar_MouseMove(object sender, MouseEventArgs e)
        {
            BtnConsultar.Width = 150;
            BtnConsultar.Height = 36;

            BtnConsultar.Image = Properties.Resources.consulta32;

        }

        private void BtnConsultar_MouseLeave(object sender, EventArgs e)
        {
            BtnConsultar.Width = 150;
            BtnConsultar.Height = 30;

            BtnConsultar.Image = Properties.Resources.consulta24;


        }

        private void BtnSalvar_MouseMove(object sender, MouseEventArgs e)
        {
            BtnSalvar.Width = 150;
            BtnSalvar.Height = 36;

            BtnSalvar.Image = Properties.Resources.salbar32;

        }

        private void BtnSalvar_MouseLeave(object sender, EventArgs e)
        {
            BtnSalvar.Width = 150;
            BtnSalvar.Height = 30;

            BtnSalvar.Image = Properties.Resources.salvar24;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
                Crear();
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
                Modificar();
          

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
                Consultar();
            

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
                Salvar();          
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Activar();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
            Desactivar();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
         
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            Retornar();
        }

        private void menuStrip2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
                                     this.DisplayRectangle);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
