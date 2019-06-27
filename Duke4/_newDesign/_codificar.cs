using Duke4.Consulta_General;
using Duke4.Logistica;
using System;
using System.Collections;
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
    public partial class _codificar : MainBar
    {
        public _codificar()
        {
            InitializeComponent();
            Fun_Set_Nombre_Formulario("Codificación Contable", this);
            VisibleListview(false);
            MainGrid.Rows.Add();
            MainGrid.Font = new Font("Verdana", 8f);
            MainGrid.Columns[1].ReadOnly = true;
            MainGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            TxtCreditoM.Visible = TxtDebitoM.Visible = false;
            TxtCredito.Enabled = TxtDebito.Enabled = TxtDebitoM.Enabled = TxtCreditoM.Enabled = false;

        }
        double TotalDeb = 0, TotalCred = 0;
        string cmd;
        DataSet ds;
        TextBox tb;
        public double Total = 0;
       // MainFormConsultaGeneral consul = new MainFormConsultaGeneral("select nocuenta as codigo, descripcion from condbfcatalogocuentas  where nulo=0", "descripcion", "Cuentas Contables");

        private void VisibleListview(bool val)
        {
            MainGrid.ActivateDisablingArrows = val;
            LstCuenta.Visible = val;
            if (!val)
                MainGrid.SelectedV = true;
        }

        public double TotalColumn(string name)
        {
            double total = 0;
            foreach (DataGridViewRow i in MainGrid.Rows)
            {
                if (i.Cells[name].Value != null)
                    total += Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(i.Cells[name].Value.ToString());
            }
            return total;
        }

        public void EndCellEditDebito(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3)
            {
                TotalDeb = TotalColumn("debito");
                TotalCred = TotalColumn("credito");
                if (TotalDeb > TotalCred)
                {
                    TxtDebito.Visible = true;
                    TxtCredito.Visible = false;
                    TxtDebitoM.Visible = false;
                    TxtCreditoM.Visible = true;
                    TxtDebito.Text = TotalDeb.ToString("N2");
                    TxtCreditoM.Text = TotalCred.ToString("N2");

                }
                else if (TotalDeb < TotalCred)
                {
                    TxtCredito.Visible = true;
                    TxtDebito.Visible = false;
                    TxtCreditoM.Visible = false;
                    TxtDebitoM.Visible = true;
                    TxtCredito.Text = TotalCred.ToString("N2");
                    TxtDebitoM.Text = TotalDeb.ToString("N2");
                }
                else if (TotalDeb == TotalCred)
                {
                    TxtCredito.Visible = true;
                    TxtDebito.Visible = true;
                    TxtCreditoM.Visible = false;
                    TxtDebitoM.Visible = false;
                    TxtCredito.Text = TotalCred.ToString("N2");
                    TxtDebito.Text = TotalDeb.ToString("N2");
                }
            }
        }

        private void InitializeListCuenta(string text)
        {
            cmd = "select nocuenta,descripcion from condbfcatalogocuentas where nocuenta like '" + text + "%'";
            ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
            LstCuenta.Headers = new ArrayList(new string[] { "Cuenta", "Descripción" });
            LstCuenta.SetDataSource(ds.Tables[0], new ArrayList(new string[] { "nocuenta", "descripcion" }));
        }

        private void EndCellEditCuenta(int RowIndex)
        {
            if (!string.IsNullOrEmpty(MainGrid.Rows[RowIndex].Cells["nocuenta"].Value as string))
            {
                cmd = "select nocuenta, descripcion from condbfcatalogocuentas where nulo = 0 and nocuenta = '" + MainGrid.Rows[RowIndex].Cells["nocuenta"].Value.ToString() + "'";
                ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MainGrid.Rows[RowIndex].Cells["nocuenta"].Value = ds.Tables[0].Rows[0]["nocuenta"].ToString();
                    MainGrid.Rows[RowIndex].Cells["descripcion"].Value = ds.Tables[0].Rows[0]["descripcion"].ToString();
                    VisibleListview(false);
                }
                else
                {
                    MainGrid.Rows[RowIndex].Cells["nocuenta"].Value = MainGrid.Rows[RowIndex].Cells["descripcion"].Value = string.Empty;
                    VisibleListview(false);
                }
            }
            else
            {
                MainGrid.Rows[RowIndex].Cells["nocuenta"].Value = MainGrid.Rows[RowIndex].Cells["descripcion"].Value = string.Empty;
                VisibleListview(false);
            }
        }

        void tb_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tb.Text))
                InitializeListCuenta(tb.Text);
        }

        public bool CheckCuadre()
        {
            return TotalColumn("credito") == TotalColumn("debito") ? true : false;
        }

        private void _codificar_Load(object sender, EventArgs e)
        {

        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LstCuenta_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Enter)
            //{
            //    if (LstCuenta.SelectedIndices[0] > -1)
            //    {
            //        MainGrid.Rows[MainGrid.CurrentCell.RowIndex].Cells["nocuenta"].Value = LstCuenta.Items[LstCuenta.SelectedIndices[0]].SubItems[0].Text;
            //        MainGrid.Rows[MainGrid.CurrentCell.RowIndex].Cells["descripcion"].Value = LstCuenta.Items[LstCuenta.SelectedIndices[0]].SubItems[1].Text;
            //        VisibleListview(false);
            //        MainGrid.Focus();
            //        MainGrid.CurrentCell = MainGrid.Rows[MainGrid.CurrentCell.RowIndex].Cells["debito"];
            //    }
            //}
        }

        private void LstCuenta_DoubleClick(object sender, EventArgs e)
        {
        //    if (LstCuenta.SelectedIndices[0] > -1)
        //    {
        //        MainGrid.Rows[MainGrid.CurrentCell.RowIndex].Cells["nocuenta"].Value = LstCuenta.Items[LstCuenta.SelectedIndices[0]].SubItems[0].Text;
        //        MainGrid.Rows[MainGrid.CurrentCell.RowIndex].Cells["descripcion"].Value = LstCuenta.Items[LstCuenta.SelectedIndices[0]].SubItems[1].Text;
        //        VisibleListview(false);
        //        MainGrid.Focus();
        //        MainGrid.CurrentCell = MainGrid.Rows[MainGrid.CurrentCell.RowIndex].Cells["debito"];
        //    }
        }

        private void MainGrid_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyData == Keys.Right)
            //{
            //    if (!MainGrid.EnterFired)
            //    {
            //        EndCellEditCuenta(MainGrid.CurrentCell.RowIndex);
            //        MainGrid.EnterFired = true;
            //    }
            //}
            //if (e.KeyData == Keys.Down)
            //{
            //    if (MainGrid.ActivateDisablingArrows && LstCuenta.Items.Count > 0)
            //    {
            //        LstCuenta.Focus();
            //        LstCuenta.SelectedItems.Clear();
            //        LstCuenta.Items[0].Selected = true;
            //        LstCuenta.Select();
            //    }
            //}
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            //if (consul.ShowDialog() == DialogResult.OK)
            //{
            //    if (!string.IsNullOrEmpty(MainGrid.CurrentRow.Cells["nocuenta"].Value as string))
            //    {
            //        MainGrid.Rows.Add();
            //        MainGrid.CurrentCell = MainGrid.Rows[MainGrid.CurrentRow.Index + 1].Cells["nocuenta"];
            //    }

            //    MainGrid.CurrentRow.Cells["nocuenta"].Value = consul.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
            //    MainGrid.CurrentRow.Cells["descripcion"].Value = consul.MainGrid.SelectedRows[0].Cells[1].Value.ToString();
            //    MainGrid.CurrentCell = MainGrid.Rows[MainGrid.CurrentRow.Index + 1].Cells["debito"];
            //}
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            //if (MainGrid.CurrentRow.Index > -1)
            //{
            //    MainGrid.CurrentRow.Cells["nocuenta"].Value = MainGrid.CurrentRow.Cells["descripcion"].Value = string.Empty;
            //    MainGrid.CurrentCell = MainGrid.Rows[MainGrid.CurrentRow.Index].Cells["nocuenta"];
            //}
        }

        private void MainGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
          //  EndCellEditDebito(e);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
