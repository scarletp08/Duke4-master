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
    public partial class MainFormConsulta : MainBar
    {
        public MainFormConsulta()
        {
            InitializeComponent();
           
         }
        public bool opened = false;
        public bool opcionactiva = false, Pdesactivar = false, Pmodificar = false, Pimprimir=false, Pcodificar=false;

        protected virtual void Retornar()
        {
            
        }

        protected virtual void Salvar()
        {
            limpiapanel();
            SetVisible();
        }
        protected virtual void Refrescar()
        {
            SetFormFunctionName("Datos Refrescados...");
            
        }

        protected virtual void Filtrar()
        {
            SetFormFunctionName("Datos Filtrados...");
            
        }
        protected virtual void Presentar()
        {


        }

        protected virtual void HabilitarGridEnviarCorreo()
        {
            opened = true;
            SetVisible2("ENVIARCORREO1");
        }
        protected virtual void AbrirOpcionEnviarCorreo()
        {
           
           
        }
        protected virtual void EnviarCorreo()
        {
            limpiapanel();
            SetVisible();
        }
        protected virtual void Cancelar()
        {
            SetFormFunctionName("Cancelando...");

            SetVisible();
        }
        protected virtual void Buscar()
        {
            SetFormFunctionName("Datos Filtrados...");
            SetVisible();
        }
        protected virtual void Modificar()
        {
            SetFormFunctionName("Modificando...");

            SetVisible();
        }
        protected virtual void Codificar()
        {
            SetFormFunctionName("Codificando...");

            SetVisible();
        }
        protected virtual void Imprimir()
        {
            //SetVisible(true, true, true, true, false, true, true, true, true, false, false, false);
        }
        protected virtual void ReImprimir()
        {
            SetVisible2("REIMPRIMIR");
        }

        DataSet dspermisos = new DataSet();
        

        public void SetVisible()
        {
            BtnFiltrar.Visible = true;
            BtnPresentar.Visible = true;
            BtnReImprimir.Visible = true;
            BtnGuardar.Visible = false;
            BtnExportar.Visible = true;
            BtnCancelar.Visible = true;
            BtnModificar.Visible = true;
            BtnCodificar.Visible = true;
            BtBuscar.Visible = false;
            BtnEnviar.Visible = false;
            BtnImprimir.Visible = false;
        }

        public void SetVisible2(string opcion)
        {
            if (opcion=="FILTRAR")
                BtBuscar.Visible = true;

            else 
            if (opcion=="REIMPRIMIR")
                BtnImprimir.Visible = true;
            
            else if (opcion == "ENVIARCORREO2")
                BtnEnviar.Visible = true;

            if (opcion == "ENVIARCORREO1")
                BtnExportar.Visible = true;
            else
                BtnExportar.Visible = false;

              BtnReImprimir.Visible = false;
              //BtnRefrescar.Visible = false;
              BtnPresentar.Visible = false;
              BtnFiltrar.Visible = false;
              BtnGuardar.Visible = false;
              BtnCancelar.Visible = false;
              BtnModificar.Visible = false;
              BtnCodificar.Visible = false;
              
              
        }
        protected void limpiapanel()
        {
            //if (MainPanel.Controls.Count > 0)
            //    MainPanel.Controls.Clear();
            SetFormFunctionName(string.Empty);
        }
        protected void InvocarFormulario(Form formulario)
        {
            //MainPanel.Controls.Clear();
            //formulario.FormBorderStyle = FormBorderStyle.None;
            //formulario.TopLevel = false;
            //MainPanel.Controls.Add(formulario);
            //formulario.Show();

        }

        protected void SetFormMainPanelSize(int Height, int Width)
        {
            //MainPanel.Height = Height;
            //MainPanel.Width = Width;
        }
        protected void SetFormFunctionLocation(int posX)
        {
            LblFunctionName.Location = new Point(posX, 80);
        }
        protected void SetFormFunctionName(string functionName)
        {
            LblFunctionName.Text = functionName;
        }

        private void MainFormConsulta_Load(object sender, EventArgs e)
        {
            BtnGuardar.Visible = false;
            BtBuscar.Visible = false;
            BtnEnviar.Visible = false;
            BtnImprimir.Visible = false;
            

        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            //if (BtnRefrescar.Visible)
            //{
            //    opcionactiva = false;
            //    Refrescar();
            //}
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            if (BtnFiltrar.Visible)
            {
                //opcionactiva = true;
                Filtrar();
            }
        }

        private void BtnPresentar_Click(object sender, EventArgs e)
        {
            if (BtnPresentar.Visible)
            {
                Presentar();
            }
        }

        private void BtnReImprimir_Click(object sender, EventArgs e)
        {
            if (BtnReImprimir.Visible)
            {
                
                opcionactiva = true;
                ReImprimir();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (BtnGuardar.Visible)
            {
                //opcionactiva = true;
                Salvar();
            }
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            if (BtnExportar.Visible)
            {
                opcionactiva = true;
                if (opened)
                    AbrirOpcionEnviarCorreo();
                else
                    HabilitarGridEnviarCorreo();

            }
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (BtnEnviar.Visible)
            {
                opcionactiva = false;
                EnviarCorreo();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (BtnCancelar.Visible)
            {
                Cancelar();
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (BtnModificar.Visible)
            {
                opcionactiva = true;
                Modificar();
            }
        }

        private void BtnCodificar_Click(object sender, EventArgs e)
        {
            if (BtnCodificar.Visible)
            {
                opcionactiva = true;
                Codificar();
            }
        }

        private void menuStrip1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
                                     this.DisplayRectangle);
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (BtnFiltrar.Visible)
            {
                //opcionactiva = true;
                Filtrar();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (BtnPresentar.Visible)
            {
                Presentar();
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (BtnReImprimir.Visible)
            {

                opcionactiva = true;
                ReImprimir();
            }
        }

        private void BtnActivar_Click(object sender, EventArgs e)
        {
            if (BtnGuardar.Visible)
            {
                //opcionactiva = true;
                Salvar();
            }
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            if (BtnExportar.Visible)
            {
                opcionactiva = true;
                if (opened)
                    AbrirOpcionEnviarCorreo();
                else
                    HabilitarGridEnviarCorreo();

            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (BtnEnviar.Visible)
            {
                opcionactiva = false;
                EnviarCorreo();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (BtnCancelar.Visible)
            {
                Cancelar();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (BtnModificar.Visible)
            {
                opcionactiva = true;
                Modificar();
            }
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            if (BtnCodificar.Visible)
            {
                opcionactiva = true;
                Codificar();
            }
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            if (BtBuscar.Visible)
            {
                opcionactiva = false;
                Buscar();
            }
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            if (BtnImprimir.Visible)
            {

                opcionactiva = true;
                Imprimir();
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Retornar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (BtBuscar.Visible)
            {
                opcionactiva = false;
                Buscar();
            }
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (BtnImprimir.Visible)
            {
                
                opcionactiva = true;
                Imprimir();
            }
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            Retornar();
            
        }

        private void MainFormConsulta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Retornar();
            }
        }
    }
}
