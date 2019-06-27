using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4
{
    public partial class MainFormPresentar : Duke4.MainBar
    {
        public MainFormPresentar()
        {
            InitializeComponent();
        }
        protected virtual void Imprimir()
        {

        }
        private void BtnReImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();

        }

        private void MainFormPresentar_Load(object sender, EventArgs e)
        {
            LblFunctionName.Text = "Presentando...           ";
            LblFunctionName.Location = new Point(this.Width - 210, 50);
            LblFunctionName.BackColor = Color.LightSteelBlue;
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainFormPresentar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void menuStrip1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
                                     this.DisplayRectangle);
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
