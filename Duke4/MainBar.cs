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
    public partial class MainBar : Form,IForm
    {
        public MainBar()
        {
            InitializeComponent();
            FormTitle.ForeColor = Color.White;

        }

        #region IForm Members

        public void Fun_Opacity(bool valor)
        {
            Funciones_Duke4.Funciones.Fun_Opacar_Form(this, valor);
        }

        #endregion

        /// <summary>
        /// Este string indica al Procedimiento Almacenado que clase de proceso se hace "Modificar", "Insertar" 
        /// </summary>
        public string _OpcionSQL = "";
        /// <summary>
        /// Este string indica a la consulta general que tipo de registros mostrar; activos, desactivos, todos.
        /// </summary>
        public string _ActivateParameter = "";

        /// <summary>
        /// Funcion para invocar la ayuda en cada formulario (manuales o videos)
        /// </summary>
        protected virtual void Help()
        {

        }
        private void MainBar_Load(object sender, EventArgs e)
        {
            // Setea el Panel Principal encima de los demas objetos
          //  HeaderPanel.BringToFront();
            FormTitle.ForeColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Al dar click al boton ayuda Ejecuta -> Help()
            Help();
        }
        /// <summary>
        /// Cambia el titulo del formulario, da formato general (Border Style, Start Position, Back Color), situa el boton de ayuda
        /// </summary>
        /// <param name="title">el titulo o nombre del formulario</param>
        /// <param name="currentForm">El formulario actual (this)</param>
        protected void Fun_Set_Nombre_Formulario(string title, Form currentForm)
        {
            FormTitle.Text = title;
            currentForm.Text = string.Empty;
            currentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            currentForm.ControlBox = false;
            currentForm.StartPosition = FormStartPosition.CenterScreen;
            currentForm.BackColor = SystemColors.GradientActiveCaption;
            HeaderPanel.Size = new Size(currentForm.Size.Width + 10, 38);
            BtnHelp.Location = new Point((currentForm.Size.Width - 50), 0);
        }

        /// <summary>
        /// Funcion para seguir mover un formulario con el mouse
        /// </summary>
        /// <param name="e"></param>
        protected void MoveTitleBar(MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        bool mouseDown;
        int mouseX = 0, mouseY = 0, mouseinX = 0, mouseinY = 0;
        //Mover el formulario desde el Label de titulo
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveTitleBar(e);
        }
        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        //Mover el formulario desde el Boton de ayuda
        private void BtnHelp_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void BtnHelp_MouseMove(object sender, MouseEventArgs e)
        {
            MoveTitleBar(e);
        }

        private void BtnHelp_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void MainBar_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
                                     this.DisplayRectangle);
        }

        //Mover el formulario desde el Panel de color Azul marino
        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }
        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            MoveTitleBar(e);
        }
        private void HeaderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
