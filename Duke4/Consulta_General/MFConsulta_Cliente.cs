using Duke4.Logistica;
using Funciones_Duke4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.Consulta_General
{
    public partial class MFConsulta_Cliente : Duke4.MainBar
    {

        public string _CodigoSeleccionado = "";

        public MFConsulta_Cliente(string activateParameter)
        {
            InitializeComponent();
            p = activateParameter;
            MainGrid.AutoGenerateColumns = false;

            int FA = MainGrid.CurrentCellAddress.Y;
            if (FA >= 0)
                MainGrid.Rows[MainGrid.CurrentCellAddress.Y].Selected = false;
            MainGrid.ClearSelection();


        }

        public bool usarcontado = false;

        string p = "";
        DataSet ds = new DataSet();

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (MainGrid.SelectedRows.Count == 1)
            {
                DialogResult = DialogResult.OK;
                _CodigoSeleccionado = MainGrid.Rows[MainGrid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            }

            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            MainGrid.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            MainGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.Cornsilk;
        }



        private void MainGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

                e.SuppressKeyPress = true;
        }

        private void MainGrid_DoubleClick(object sender, EventArgs e)
        {
            if (MainGrid.SelectedRows.Count == 1)
            {
                DialogResult = DialogResult.OK;
                _CodigoSeleccionado = MainGrid.Rows[MainGrid.CurrentCell.RowIndex].Cells[1].Value.ToString();
            }
            this.Close();
        }



        private void Txtnombre_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Cmbbuscarpor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txtnombre.Text = "";
            Txtnombre.Focus();
        }

        private void MainGrid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (MainGrid.SelectedRows.Count == 1)
                {
                    DialogResult = DialogResult.OK;
                    _CodigoSeleccionado = MainGrid.Rows[MainGrid.CurrentCell.RowIndex].Cells[1].Value.ToString();
                }
                this.Close();
            }
        }

        private void llenatextbox()
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                if (MainGrid.Rows.Count > 0)
                {
                    int pos = MainGrid.CurrentCell.RowIndex;


                    Txtdireccion.Text = ds.Tables[0].Rows[pos]["direccion"].ToString();
                    Txtciudad.Text = ds.Tables[0].Rows[pos]["ciudescripcion"].ToString();

                    Txtruta.Text = ds.Tables[0].Rows[pos]["rutdescripcion"].ToString();
                    Txtemail.Text = ds.Tables[0].Rows[pos]["email"].ToString();
                    Mkbcelular.Text = ds.Tables[0].Rows[pos]["celular"].ToString();
                    Mkbfax.Text = ds.Tables[0].Rows[pos]["fax"].ToString();
                    Mkbrncced.Text = ds.Tables[0].Rows[pos]["rnc"].ToString();
                    Mkbtelefono.Text = ds.Tables[0].Rows[pos]["telefono"].ToString();

                    string cmd3 = string.Format("select cxcdbfruta.idempleado, nombre from nomdbfempleado inner join cxcdbfruta on nomdbfempleado.idempleado=cxcdbfruta.idempleado where idruta='" + Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[pos]["idruta"].ToString()) + "' ");
                    DataSet ds3 = FuncionesSQL.Fun_Sql_Ejecutar(cmd3);

                    if (ds3.Tables[0].Rows.Count > 0)
                    {


                        Txtvendedor.Text = ds3.Tables[0].Rows[0]["nombre"].ToString();




                    }
                }
            }
            else Txtdireccion.Text = Txtciudad.Text = Txtruta.Text = Txtemail.Text = Mkbcelular.Text = Mkbfax.Text = Mkbrncced.Text = Mkbtelefono.Text = Txtvendedor.Text = "";

        }




        private void MainGrid_Enter(object sender, EventArgs e)
        {
            llenatextbox();

        }
        public bool focus = false;

        private void Txtnombre_Leave(object sender, EventArgs e)
        {
            focus = false;
        }

        private void Txtnombre_Enter(object sender, EventArgs e)
        {
            focus = true;

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
                        Txtnombre.Focus();
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



        private void Txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (Convert.ToInt32(e.KeyCode) == 13)
            {
                if (MainGrid.SelectedRows.Count == 1)
                {
                    DialogResult = DialogResult.OK;
                    _CodigoSeleccionado = MainGrid.Rows[MainGrid.CurrentCell.RowIndex].Cells[1].Value.ToString();
                }
                this.Close();
            }
        }
        IForm formInterface;
        private void MFConsulta_Cliente_Load(object sender, EventArgs e)
        {
            formInterface = this.Owner as IForm;
            if (formInterface != null)
                formInterface.Fun_Opacity(true);

            Fun_Set_Nombre_Formulario("Consulta de Clientes", this);
            string cmd = "";
            if (usarcontado == false)
                cmd = string.Format("SELECT top 1000 	cli.idcliente, cli.nombre, cli.direccion, cli.telefono, cli.celular, "
            + " cli.fax, cli.email, cli.rnc, ciu.descripcion as ciudescripcion, rut.descripcion as rutdescripcion, rut.idruta "
            + " from cxcdbfcliente as cli inner join cxcdbfprovincia as ciu on cli.idciudad = ciu.idprovincia "
            + " inner join cxcdbfruta as rut on cli.idruta = rut.idruta where cli.nulo" + p + "0 and idcliente > 1");
            else if (usarcontado == true)
                cmd = string.Format("SELECT top 1000	cli.idcliente, cli.nombre, cli.direccion, cli.telefono, cli.celular, "
            + " cli.fax, cli.email, cli.rnc, ciu.descripcion as ciudescripcion, rut.descripcion as rutdescripcion, rut.idruta "
            + " from cxcdbfcliente as cli inner join cxcdbfprovincia as ciu on cli.idciudad = ciu.idprovincia "
            + " inner join cxcdbfruta as rut on cli.idruta = rut.idruta where cli.nulo" + p + "0");



            ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

            MainGrid.DataSource = ds.Tables[0];
            llenatextbox();
        }

        private void Txtnombre_TextChanged(object sender, EventArgs e)
        {

            if (Txtnombre.TextLength >= 3)
            {
                string opcion = "";


                if (Cmbbuscarpor.SelectedIndex == 0)
                    opcion = "nombre";
                else if (Cmbbuscarpor.SelectedIndex == 1)
                    opcion = "idcliente";
                else if (Cmbbuscarpor.SelectedIndex == 2)
                    opcion = "rnc";
                else if (Cmbbuscarpor.SelectedIndex == 3)
                    opcion = "telefono";
                else if (Cmbbuscarpor.SelectedIndex == 4)
                    opcion = "email";
                else if (Cmbbuscarpor.SelectedIndex == 5)
                    opcion = "celular";
                else if (Cmbbuscarpor.SelectedIndex == 6)
                    opcion = "fax";
                
                if (!string.IsNullOrEmpty(Cmbbuscarpor.Text.Trim()))
                {
                    string cmd = string.Format("SELECT top 1000 	cli.idcliente, cli.nombre, cli.direccion, cli.telefono, cli.celular,"
               + "cli.fax, cli.email, cli.rnc, ciu.descripcion as ciudescripcion, rut.descripcion as rutdescripcion, rut.idruta"
               + " from cxcdbfcliente as cli inner join cxcdbfprovincia as ciu on cli.idciudad = ciu.idprovincia inner join cxcdbfruta as rut on cli.idruta = rut.idruta where " + opcion + " like  ('%" + Txtnombre.Text.Trim() + "%') and cli.nulo" + p + "0");
                    ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
                    llenatextbox();

                }
                MainGrid.DataSource = ds.Tables[0];
            }
        }

        private void MainGrid_SelectionChanged(object sender, EventArgs e)
        {
            llenatextbox();
        }


        private void MFConsulta_Cliente_KeyDown(object sender, KeyEventArgs e)
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

        private void MFConsulta_Cliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formInterface != null)
                formInterface.Fun_Opacity(false);
        }
    }
}
