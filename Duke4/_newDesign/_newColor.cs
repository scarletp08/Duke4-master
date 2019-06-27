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
    public partial class _newColor : Form
    {
        public _newColor()
        {
            InitializeComponent();
        }

        private void _newColors_Load(object sender, EventArgs e)
        {
            FormTitle.Text = "Consulta de Facturas CxP";
            HeaderPanel.BackColor = ColorTranslator.FromHtml("#67A3C6");
            menuStrip2.BackColor = ColorTranslator.FromHtml("#AFCBDD");
            this.BackColor = ColorTranslator.FromHtml("#D2E4F4");
            panel2.BackColor = ColorTranslator.FromHtml("#90C3ED");
        }
        protected void MoveTitleBar(MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        public void changeColors(string dark, string med, string lowBar, string light)
        {
            HeaderPanel.BackColor = ColorTranslator.FromHtml("#" + dark);
            menuStrip2.BackColor = ColorTranslator.FromHtml("#" + med);
            panel2.BackColor = ColorTranslator.FromHtml("#" + lowBar);
            this.BackColor = ColorTranslator.FromHtml("#" + light);
        }
        bool mouseDown;
        int mouseX = 0, mouseY = 0, mouseinX = 0, mouseinY = 0;

        private void BtnCodificar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HeaderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            MoveTitleBar(e);
        }

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }
    }
}
