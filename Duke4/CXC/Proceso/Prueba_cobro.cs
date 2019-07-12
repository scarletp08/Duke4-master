using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Duke4.Consulta_General;
using Duke4.Logistica;
using Funciones_Duke4;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Duke4.CXC.Proceso
{
    public partial class Prueba_cobro : Duke4.MainFormProceso
    {

        public Prueba_cobro()
        {
            InitializeComponent();
        }

        private void txtBase1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            MFConsulta_Cliente consulta = new MFConsulta_Cliente("=");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {
                Txtcodigocliente.Text = Convert.ToString(consulta.MainGrid.SelectedRows[0].Cells[1].Value);
                BtnModificar.Enabled = false;
                Fun_Buscar_Cliente();
            }
        }



        protected void Fun_Buscar_Cliente()
        {
            if (Txtcodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {
                DataSet ds = Txtcodigocliente._Dataset;

                Txtnombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                Txtdireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                Msktelefono.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
                Txtbalance.Text = FuncionesSQL.Fun_SQL_Buscar_Balance_Cliente(Txtcodigocliente.Text);
                Txtreferencia.Text = ds.Tables[0].Rows[0]["referencia"].ToString();

                string cmd2 = string.Format("SELECT  dbo.prudbffactura2.idfactura, dbo.prudbffactura2.secuencia,   dbo.prudbffactura2.referencia, dbo.prudbffactura2.fecha_ingreso, dbo.prudbffactura2.fecha_vencimiento, DATEDIFF(DD, fecha_ingreso, fecha_vencimiento) as dias, dbo.prudbffactura2.neto, prudbffactura2.balance FROM  dbo.cxcdbfcliente INNER JOIN dbo.prudbffactura2 ON dbo.cxcdbfcliente.idcliente = dbo.prudbffactura2.idcliente where  dbo.cxcdbfcliente.idcliente   ='" + Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text) + "' and balance >0 ");
                DataSet ds2 = FuncionesSQL.Fun_Sql_Ejecutar(cmd2);
                if (ds2.Tables.Count > 0)
                {
                    if (ds2.Tables[0].Rows.Count > 0)
                    {
                        Txtbalance.Text = FuncionesSQL.Fun_SQL_Buscar_Balance_Cliente(Txtcodigocliente.Text);

                        gridBase1.DataSource = ds2.Tables[0];
                    }
                    else
                    {
                        Txtcodigocliente.Text = string.Empty;
                        Mensajes.fcobro();
                        Txtcodigocliente.Focus();
                    }
                }



                else
                {
                    Txtcodigocliente.Text = string.Empty;
                }

            }
        }

        private void Fun_Buscar_Vendedor()
        {
            if (Txtcodigovendedor.Fun_SQL_Buscar_CodigoRegistro("nomdbfempleado", "idempleado"))
            {
                DataSet ds = Txtcodigovendedor._Dataset;
                Txtnombrevendedor.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
            }
        }

        private void btnBuscar1_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Cliente();
        }

        private void btnBuscar2_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Vendedor();
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar2_Click_1(object sender, EventArgs e)
        {
            MainFormConsultaGeneral Consulta_Vendedor = new MainFormConsultaGeneral("select idempleado as codigo, nombre as descripcion from nomdbfempleado where nulo=0", "nombre", "Vendedor");
            if (Consulta_Vendedor.ShowDialog(this) == DialogResult.OK)
            {

                Txtcodigovendedor.Text = Convert.ToString(Consulta_Vendedor.MainGrid.SelectedRows[0].Cells[0].Value);
                Txtnombrevendedor.Text = Convert.ToString(Consulta_Vendedor.MainGrid.SelectedRows[0].Cells[1].Value);
                Fun_Buscar_Vendedor();
            }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        protected override void Salvar()
        {
            base.Salvar();
            Control[] array = { Txtcodigocliente, Txtcodigovendedor };

            if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(array))
            {
                int idfcobro = 0;

                string cmd = string.Format("exec sppruebacobros '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}'",
                    _OpcionSQL, Properties.Settings.Default.idsesion, 1,
                    Txtncobro.Text,
                    Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfecha),
                    Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text),
                    Txtreferencia.Text,
                   Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtaplicar.Text),

                  Txtbalance.Text =FuncionesSQL.Fun_SQL_Buscar_Balance_Cliente(Txtcodigocliente.Text),
                  //Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtbalance.Text),
                Txtcomentario.Text,
                   Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtcodigovendedor.Text),
                    Cmbmoneda.SelectedValue

                    );

                DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                if (_OpcionSQL == "Modificar")
                    idfcobro = Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0][0].ToString());

                else
                    idfcobro = Funciones.Fun_Convierte_String_aEntrero(ds.Tables[1].Rows[0][0].ToString());

                // var Reporte = new Reporte.Form2();
                // Reporte.Idfactura = idfactura;
                // Reporte.Show();
                //Reporte.Owner = this;



                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);


                if (_OpcionSQL == "Insertar")

                    Crear();

                else

                    Modificar();
                CheckGrid();
                LblAlerta.Text = string.Empty;
            }
            else

                LblAlerta.Text = Mensajes.Stg_Campos_EnBlanco;
        }
        private void Prueba_cobro_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Cobro", this);
            Crear();
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");
            CheckGrid();

            gridBase1.Columns[""].Width = 25;

        }
        public void CheckGrid()
        {
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();

            checkColumn.FillWeight = 5;

            var checkheader = new CheckBoxHeaderCell();

            checkheader.OnCheckBoxHeaderClick += checkheader_OnCheckBoxHeaderClick;

            checkColumn.HeaderCell = checkheader;

            gridBase1.Columns.Add(checkColumn);
        }
        void checkheader_OnCheckBoxHeaderClick(CheckBoxHeaderCellEventArgs e)
        {
            double aplica = 0; int pos = 0;
            if (gridBase1.Rows.Count > 0)
            {

                foreach (DataGridViewRow item in gridBase1.Rows)
                {
                    gridBase1.BeginEdit(true);
                    item.Cells[""].Value = e.IsChecked;
                    pos = item.Cells[0].RowIndex;
                    if (Convert.ToBoolean(item.Cells[""].Value) == true)
                    {
                        aplica += Convert.ToDouble(item.Cells["Pendiente"].Value);
                        gridBase1.Rows[pos].Cells["aplic"].Value = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["Pendiente"].Value)).ToString("N2");


                    }
                    else if (Convert.ToBoolean(item.Cells[""].Value) == false)
                    {

                        gridBase1.Rows[pos].Cells["aplic"].Value = "";
                    }
                    gridBase1.EndEdit();

                }
                Txtaplicar.Text = aplica + "";
                Txttotalcobro.Text = aplica+"";
            }
        }



        private void Txtcodigocliente_Validating(object sender, CancelEventArgs e)
        {

        }


        private void Completar_cobro()
        {
            if (_OpcionSQL == "Modificar")
            {

                string secuencia = Funciones.Fun_Eliminar_Letras_DeString(Txtncobro.Text);

                if (Txtncobro.Fun_SQL_Buscar_SecuenciaRegistro("SELECT * from prudbfcobro where REPLACE(secuencia,SUBSTRING(secuencia,PATINDEX('%[^0-9]%', secuencia),1),'')=" + Funciones.Fun_Convierte_String_aEntrero(secuencia)))
                {
                    DataSet ds = Txtncobro._Dataset;
                    Txtncobro.Text = ds.Tables[0].Rows[0]["secuencia"].ToString();
                    Txtcodigocliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
                    Fun_Buscar_Cliente();
                    Txtcodigovendedor.Text = ds.Tables[0].Rows[0]["idvendedor"].ToString();
                    Fun_Buscar_Vendedor();
                    Txtcomentario.Text = ds.Tables[0].Rows[0]["comentario"].ToString();
                    

                }
            }
        }
        protected override void Crear()
        {
            base.Crear();
            Txtncobro.Enabled = false;

            Txtncobro.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("COBRO");
            Txtcodigocliente.Focus();


        }
        protected override void Modificar()
        {
            base.Modificar();
            Txtncobro.Enabled = true;

            Txtncobro.Focus();


        }

        private void Txtncobro_Validating(object sender, CancelEventArgs e)
        {
            Completar_cobro();
        }

        private void gridBase1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in gridBase1.Rows)
            {
                if (gridBase1.Rows.Count > 0)
                {
                    int pos = e.RowIndex;
                    double pendiente = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(gridBase1.Rows[pos].Cells["Pendiente"].Value));
                    double aplicar = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(gridBase1.Rows[pos].Cells["aplic"].Value));

                    if (gridBase1.Columns[e.ColumnIndex].Name == "aplic" || gridBase1.Columns[e.ColumnIndex].Name == "")
                    {
                        if (aplicar > 0)
                        {
                            if (pendiente >= aplicar)
                            {
                                gridBase1.Rows[pos].Cells["balf"].Value = pendiente - aplicar;
                                row.Cells["Pendiente"].Value = row.Cells["balf"].Value;
                                gridBase1.Rows[pos].Cells[""].Value = true;
                                row.Cells[""].Value = true;
                            }

                        }
                    }
                    else
                    {
                        //Fun_Calcular_Totales(); //Actualiza los totales
                        gridBase1.Rows[pos].Cells["balf"].Value = string.Empty;
                        gridBase1.Rows[pos].Cells[""].Value = false;

                        gridBase1.Rows[pos].Cells["aplic"].Value = "";
                        row.Cells[""].Value = this;


                    }
                


                
                        
                    }


                
               

                Fun_Calcular_Totales();
            }

        }

        private void Fun_Calcular_Totales()
        {
            double sumaaplicar = 0;


            if (Funciones.Fun_Convierte_String_aDecimal(Txtaplicar.Text.Trim()) <= Funciones.Fun_Convierte_String_aDecimal(Txtbalance.Text.Trim()))
            {

                foreach (DataGridViewRow item in gridBase1.Rows)
                {

                    if (Convert.ToBoolean(item.Cells[""].EditedFormattedValue))
                    {
                        sumaaplicar += Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["aplic"].Value));

                    }
                }

                Txtaplicar.Text = sumaaplicar.ToString();
                Txttotalcobro.Text = sumaaplicar.ToString();

            }
        }

        private void gridBase1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {

            int pos = gridBase1.CurrentCell.RowIndex;
            int posi = gridBase1.CurrentCell.ColumnIndex;

            if (gridBase1.Rows.Count > 0)
            {
                if (gridBase1.Columns[posi].Name == "")
                {
                    gridBase1.BeginEdit(true);
                    if (Convert.ToBoolean(gridBase1.Rows[pos].Cells[""].EditedFormattedValue))
                    {
                        gridBase1.Rows[pos].Cells["aplic"].Value = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(gridBase1.Rows[pos].Cells["Pendiente"].Value)).ToString("N2");
                    }
                    else
                    {

                        gridBase1.Rows[pos].Cells["aplic"].Value = string.Empty;

                    }
                    gridBase1.EndEdit();
                }
            }

        }

        private void gridBase1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txtaplicar_TextChanged(object sender, EventArgs e)
        {

        }


        private void Txtaplicar_Validating(object sender, CancelEventArgs e)
        {
            double aplicar = Funciones.Fun_Convierte_String_aDecimal(Txtaplicar.Text.Trim());
            double balance = Funciones.Fun_Convierte_String_aDecimal(Txtbalance.Text.Trim());

            if (aplicar >= balance)
            {
                Txtaplicar.Text = balance.ToString();
                Txttotalcobro.Text = balance.ToString();
            }
            if (aplicar > 0)
            {
                foreach (DataGridViewRow row in gridBase1.Rows)
                {

                    if (aplicar >= Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["Pendiente"].Value)))
                    {

                        aplicar -= Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["Pendiente"].Value));

                        row.Cells["aplic"].Value = row.Cells["Pendiente"].Value;
                        row.Cells["balf"].Value = "0.00";
                        row.Cells[""].Value = true;
                    }

                    else if (aplicar > 0 && aplicar < Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["Pendiente"].Value)))
                    {
                        row.Cells["aplic"].Value = aplicar;
                        row.Cells["balf"].Value = (Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["Pendiente"].Value)) - aplicar);
                        aplicar = 0;
                        row.Cells[""].Value = true;
                    }
                    else
                    {

                        row.Cells["aplic"].Value = string.Empty;

                        row.Cells[""].Value = false;
                    }

                }
                Txttotalcobro.Text = Txtbalance.Text;

            }
            else
            {
                Txtaplicar.Text = "";
                Txttotalcobro.Text = "";


                foreach (DataGridViewRow row in gridBase1.Rows)
                {

                    row.Cells["aplic"].Value = "";

                    row.Cells[""].Value = false;
                }
            }
        }

        private void Txtaplicar_Validated(object sender, EventArgs e)
        {

        }

        private void gridBase1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }
    }
}
