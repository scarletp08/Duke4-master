using Duke4.Logistica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4._newDesign
{

    public partial class _ConsultaGeneral : Duke4.MainBar
    {
        public DataSet ds = new DataSet();
        public string cmd = "";
        public string filtroCod = "";
        public string filtroDesc = "";
        public string Title;
        public string tituloconsulta = "";

        public string _CodigoSeleccionado = string.Empty;
        public string _DescripSeleccionado = string.Empty;


        public _ConsultaGeneral(string query, string campoCod, string campoDesc, string titulo)
        {
            InitializeComponent();
            cmd = query.Insert(7, " Top 1000 ");

            filtroCod = campoCod;
            filtroDesc = campoDesc;
            tituloconsulta = titulo;
            ds = FuncionesSQL.Fun_Sql_Ejecutar(query);
            MainGrid.DataSource = ds.Tables[0];
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        public bool focus = false;

        public void FiltroAdded()
        {
            string micmd = string.Format(cmd + " and " + filtroDesc + " like  ('%" + TxtNombre.Text.Trim() + "%')");
            ds = FuncionesSQL.Fun_Sql_Ejecutar(micmd);
            MainGrid.DataSource = ds.Tables[0];
        }
        public void FiltroAddedCod()
        {
            string micmd = string.Format(cmd + " and " + filtroCod + " like  ('%" + txtCodigo.Text.Trim() + "%')");
            ds = FuncionesSQL.Fun_Sql_Ejecutar(micmd);
            MainGrid.DataSource = ds.Tables[0];
        }

        IForm formInterface;
        private void MainFormConsultaGenerales_Load(object sender, EventArgs e)
        {
            formInterface = this.Owner as IForm;
            if (formInterface != null)
                formInterface.Fun_Opacity(true);

            Fun_Set_Nombre_Formulario("Consulta de " + tituloconsulta + " ", this);

            TxtNombre.Focus();
        }

        private void TxtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                MainGrid.TabStop = true;

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Up)
            {
                if (MainGrid.Rows.Count > 0)
                {
                    int pos = MainGrid.CurrentCell.RowIndex;
                    if (pos == 0)
                    {
                        TxtNombre.Focus();
                        return true;
                    }
                }
            }

            if (keyData == Keys.Down)
            {
                if (MainGrid.Rows.Count > 0 && focus)
                {
                    MainGrid.Focus();
                    return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void TxtNombre_Enter(object sender, EventArgs e)
        {
            focus = true;
        }

        private void TxtNombre_Leave(object sender, EventArgs e)
        {
            focus = false;
        }

        private void TxtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                SelectAndClose();
            }
        }

        private void MainFormConsultaGenerales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void menuStrip1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
            //                         this.DisplayRectangle);
        }

        private void MainFormConsultaGeneral_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formInterface != null)
                formInterface.Fun_Opacity(false);
        }

        private void BtnSeleccionar_Click_1(object sender, EventArgs e)
        {
            int FA = MainGrid.CurrentCellAddress.Y;

            SelectAndClose();
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEntero1_TextChanged(object sender, EventArgs e)
        {
            if (TxtNombre.Text != "")
            {
                TxtNombre.TextChanged -= TxtNombre_TextChanged;  // dettach the event handler
                TxtNombre.Text = ""; // update value
                TxtNombre.TextChanged += TxtNombre_TextChanged;
            }

            if (txtCodigo.Text == "")
            {
                ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
                MainGrid.DataSource = ds.Tables[0];
            }
            else
                FiltroAddedCod();

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                txtCodigo.TextChanged -= txtEntero1_TextChanged;  // dettach the event handler
                txtCodigo.Text = ""; // update value
                txtCodigo.TextChanged += txtEntero1_TextChanged;
            }

            if (TxtNombre.TextLength >= 3)
                FiltroAdded();
            else if (TxtNombre.Text == "")
            {
                ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
                MainGrid.DataSource = ds.Tables[0];
            }
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                MainGrid.TabStop = true;
        }
        private void SelectAndClose()
        {
            if (MainGrid.CurrentRow != null)
            {
                DialogResult = DialogResult.OK;
                _CodigoSeleccionado = MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                _DescripSeleccionado = MainGrid.SelectedRows[0].Cells[1].Value.ToString();
            }
            this.Close();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                SelectAndClose();
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            focus = false;
        }

        private void MainGrid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectAndClose();
            }
        }

        private void MainGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void MainGrid_DoubleClick(object sender, EventArgs e)
        {
            SelectAndClose();
        }

        private void MainGrid_Enter(object sender, EventArgs e)
        {
            int FA = MainGrid.CurrentCellAddress.Y;
            if (FA >= 0)
                MainGrid.Rows[MainGrid.CurrentCellAddress.Y].Selected = true;
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            focus = true;
        }
    }
}
