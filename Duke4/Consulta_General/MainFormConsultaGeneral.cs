using Duke4.Logistica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.Consulta_General
{

    public partial class MainFormConsultaGeneral : Duke4.MainBar
    {
        public DataSet ds = new DataSet();
        public string cmd = "";
        public string filtro2 = "";
        public string Title;
        public string tituloconsulta = "";

        public string _CodigoSeleccionado = string.Empty;
        public string _DescripSeleccionado = string.Empty;

 
        public MainFormConsultaGeneral(string query,string filtro, string titulo)

        {
            InitializeComponent();
            cmd = query.Insert(7, " Top 1000 ");
            
            filtro2 = filtro;
            tituloconsulta = titulo;
            ds = FuncionesSQL.Fun_Sql_Ejecutar(query);
            MainGrid.DataSource = ds.Tables[0];
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        public bool focus = false;

        public void FiltroAdded()
        {


            string micmd = string.Format(cmd + " and " + filtro2 + " like  ('%" + TxtNombre.Text.Trim() + "%')");
            ds = FuncionesSQL.Fun_Sql_Ejecutar(micmd);
            MainGrid.DataSource = ds.Tables[0];
        }



        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            int FA = MainGrid.CurrentCellAddress.Y;

            if (MainGrid.CurrentRow != null)
            {
                DialogResult = DialogResult.OK;
                _CodigoSeleccionado = MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                _DescripSeleccionado = MainGrid.SelectedRows[0].Cells[1].Value.ToString();
            }

            this.Close();
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
        public virtual void Busqueda(string cmd)
        {
            DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
            MainGrid.DataSource = ds.Tables[0];
        }

        private void MainGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            MainGrid.Columns[1].Width = 300;
            MainGrid.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            MainGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.Cornsilk;
        }


        private void MainGrid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (MainGrid.CurrentRow != null)
                {
                    DialogResult = DialogResult.OK;
                    _CodigoSeleccionado = MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                    _DescripSeleccionado = MainGrid.SelectedRows[0].Cells[1].Value.ToString();
                }
                this.Close();
            }



        }

        private void MainGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

                e.SuppressKeyPress = true;
        }

        private void MainGrid_DoubleClick(object sender, EventArgs e)
        {
            if (MainGrid.CurrentRow != null)
            {
                DialogResult = DialogResult.OK;
                _CodigoSeleccionado = MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                _DescripSeleccionado = MainGrid.SelectedRows[0].Cells[1].Value.ToString();
            }
            this.Close();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            if(TxtNombre.TextLength>=3)
            FiltroAdded();
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
                if (MainGrid.Rows.Count > 0 && focus == true)
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

        private void MainGrid_Enter(object sender, EventArgs e)
        {
            int FA = MainGrid.CurrentCellAddress.Y;
            if (FA >= 0)
                MainGrid.Rows[MainGrid.CurrentCellAddress.Y].Selected = true;
        }

        private void TxtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                if (MainGrid.CurrentRow != null)
                {
                    DialogResult = DialogResult.OK;
                    _CodigoSeleccionado = MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                    _DescripSeleccionado = MainGrid.SelectedRows[0].Cells[1].Value.ToString();
                }
                this.Close();
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
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
                                     this.DisplayRectangle);
        }

        private void MainFormConsultaGeneral_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formInterface != null)
                formInterface.Fun_Opacity(false);
        }
    }
}
