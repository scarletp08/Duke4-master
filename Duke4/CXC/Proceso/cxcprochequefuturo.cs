using Duke4.Consulta_General;
using Duke4.Logistica;
using Funciones_Duke4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.CXC.Proceso
{
    public partial class cxcprochequefuturo : Duke4.MainFormProceso
    {
        public cxcprochequefuturo()
        {
            InitializeComponent();
        }

        private void cxcprochequefuturo_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Registro de Cheque Futuro", this);
            BtnModificar.Visible = false;
            BtnCrear.Visible = false;
            Txtcodigocliente.Focus();

            CheckGrid();

            Dgv.Columns[""].Width = 25;

            Dgv.Columns["dgvsecuencia"].ReadOnly = true;
            Dgv.Columns["dgvreferencia"].ReadOnly = true;
            Dgv.Columns["dgvfecha"].ReadOnly = true;
            Dgv.Columns["dgvvence"].ReadOnly = true;
            Dgv.Columns["dgvdias"].ReadOnly = true;
            Dgv.Columns["dgvbalance"].ReadOnly = true;
            Dgv.Columns["dgvsecuencia"].DisplayIndex = 1;

            Ckbimprimir.Checked = true;
            Txtchequefuturo.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("CHEQUE FUTURO");

            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbbanco, "select idbanco, descripcion from bandbfbanco");
            Crear();
            
        }
        protected override void Crear()
        {
            base.Crear();
        }
        public void CheckGrid()
        {
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();

            checkColumn.FillWeight = 5;

            var checkheader = new CheckBoxHeaderCell();

            checkheader.OnCheckBoxHeaderClick += checkheader_OnCheckBoxHeaderClick;

            checkColumn.HeaderCell = checkheader;

            Dgv.Columns.Add(checkColumn);
        }
        void checkheader_OnCheckBoxHeaderClick(CheckBoxHeaderCellEventArgs e)
        {

            double aplica = 0; int pos = 0;
            if (Dgv.Rows.Count > 0)
            {

                foreach (DataGridViewRow item in Dgv.Rows)
                {
                    Dgv.BeginEdit(true);
                    item.Cells[""].Value = e.IsChecked;
                    pos = item.Cells[0].RowIndex;
                    if (Convert.ToBoolean(item.Cells[""].Value) == true)
                    {
                        aplica += Convert.ToDouble(item.Cells["dgvbalance"].Value);
                        Dgv.Rows[pos].Cells["dgvaplicar"].Value = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvbalance"].Value)).ToString("N2");


                    }
                    else if (Convert.ToBoolean(item.Cells[""].Value) == false)
                    {

                        Dgv.Rows[pos].Cells["dgvaplicar"].Value = "";
                    }
                    Dgv.EndEdit();

                }
                Txtaplicar.Text = aplica + "";
            }
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            MFConsulta_Cliente Consulta_Cliente = new MFConsulta_Cliente("=");

            if (Consulta_Cliente.ShowDialog(this) == DialogResult.OK)
            {
                Txtcodigocliente.Focus();

                Txtcodigocliente.Text = Consulta_Cliente._CodigoSeleccionado;

                Fun_Buscar_Cliente();
            }
        }
        private void Fun_Buscar_Cliente()
        {
            if (Txtcodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {
                DataSet ds = Txtcodigocliente._Dataset;

                if (ds.Tables[0].Rows[0]["idcliente"].ToString() == "1")
                {
                    Txtcodigocliente.Text = "";
                    Txtcodigocliente.Focus();
                    Mensajes.Msgb_NoChequeFuturo_CliContado();
                }
                else
                {
                    Txtcodigocliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
                    Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                    Txttelefonocliente.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
                    Txtdireccioncliente.Text = ds.Tables[0].Rows[0]["direccion"].ToString();

                    //string cmd3 = string.Format("select cxcdbfruta.idempleado, nombre from nomdbfempleado inner join cxcdbfruta on nomdbfempleado.idempleado=cxcdbfruta.idempleado where idruta='" + Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["idruta"].ToString()) + "' and nomdbfempleado.nulo=0");
                    //DataSet ds3 = FuncionesSQL.Fun_Sql_Ejecutar(cmd3);
                    //if (ds3.Tables.Count > 0)
                    //    if (ds3.Tables[0].Rows.Count > 0)
                    //    {
                    //        Txtcodigovendedor.Text = ds3.Tables[0].Rows[0]["idempleado"].ToString();
                    //        Txtnombrevendedor.Text = ds3.Tables[0].Rows[0]["nombre"].ToString();
                    //    }

                    string cmd2 = string.Format("select idregistro,secuencia,fecha as fechafac,referencia, fechavencimiento, DATEDIFF(day, fecha, getdate()) as dias ,total,balance from cxcdbfregistro where idcliente='" + Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text) + "' and balance >0 and nulo=0");
                    DataSet ds2 = FuncionesSQL.Fun_Sql_Ejecutar(cmd2);
                    if (ds2.Tables.Count > 0)
                    {
                        if (ds2.Tables[0].Rows.Count > 0)
                        {
                            Txtbalance.Text = FuncionesSQL.Fun_SQL_Buscar_Balance_Cliente(Txtcodigocliente.Text);

                            Dgv.DataSource = ds2.Tables[0];
                        }
                        else
                        {
                            Txtcodigocliente.Text = string.Empty;
                            Mensajes.Msgb_NoFacturas_EnMoneda();
                            Txtcodigocliente.Focus();
                        }
                    }

                }
            }
            else
            {
                Txtcodigocliente.Text = string.Empty;
            }

        }

        private void Txtcodigocliente_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Cliente();
        }

        private void BtnBuscarVendedor_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral Consulta_Vendedor = new MainFormConsultaGeneral("select idempleado as codigo, nombre as descripcion from nomdbfempleado where nulo=0", "nombre", "Vendedor");
            if (Consulta_Vendedor.ShowDialog(this) == DialogResult.OK)
            {

                Txtcodigovendedor.Text = Consulta_Vendedor.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Txtnombrevendedor.Text = Consulta_Vendedor.MainGrid.SelectedRows[0].Cells[1].Value.ToString();

            }
        }

        private void Txtcodigovendedor_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Vendedor();
        }

        protected void Fun_Buscar_Vendedor()
        {
            if (Txtcodigovendedor.Fun_SQL_Buscar_CodigoRegistro("nomdbfempleado", "idempleado"))
            {
                DataSet ds = Txtcodigovendedor._Dataset;
                Txtnombrevendedor.Text = ds.Tables[0].Rows[0]["nombre"].ToString();

            }
            else
            {
                Txtcodigovendedor.Text = "";
                Txtnombrevendedor.Text = "";

            }
        }

        private void Dgv_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            int pos = Dgv.CurrentCell.RowIndex;
            int posi = Dgv.CurrentCell.ColumnIndex;

            if (Dgv.Rows.Count > 0)
            {
                if (Dgv.Columns[posi].Name == "")
                {
                    Dgv.BeginEdit(true);
                    if (Convert.ToBoolean(Dgv.Rows[pos].Cells[""].EditedFormattedValue))
                    {
                        Dgv.Rows[pos].Cells["dgvaplicar"].Value = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvbalance"].Value)).ToString("N2");
                    }
                    else
                    {

                        Dgv.Rows[pos].Cells["dgvaplicar"].Value = string.Empty;

                    }
                    Dgv.EndEdit();
                }
            }
        }

        private void Dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv.Rows.Count > 0)
            {
                int pos = e.RowIndex;
                double pendiente = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvbalance"].Value));
                double aplicar = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvaplicar"].Value));
               
                if (Dgv.Columns[e.ColumnIndex].Name == "dgvaplicar" || Dgv.Columns[e.ColumnIndex].Name == "")
                {
                    if (aplicar > 0)
                    {
                        if (aplicar> pendiente)
                        {
                            
                            Dgv.Rows[pos].Cells["dgvaplicar"].Value = Dgv.Rows[pos].Cells["dgvbalance"].Value;
                            Dgv.Rows[pos].Cells[""].Value = true;
                        }


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

                foreach (DataGridViewRow item in Dgv.Rows)
                {

                    if (Convert.ToBoolean(item.Cells[""].EditedFormattedValue))
                    {
                        sumaaplicar += Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvaplicar"].Value));
                       
                    }
                }

                Txtaplicar.Text = sumaaplicar.ToString();
                
            }
        }

        private void Txtaplicar_Validating(object sender, CancelEventArgs e)
        {
            double aplicar = Funciones.Fun_Convierte_String_aDecimal(Txtaplicar.Text.Trim());
            double balance = Funciones.Fun_Convierte_String_aDecimal(Txtbalance.Text.Trim());

            if (aplicar >= balance)
            {
                Txtaplicar.Text = balance.ToString();
            }
            if (aplicar > 0)
            {
                foreach (DataGridViewRow row in Dgv.Rows)
                {

                    if (aplicar >= Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvbalance"].Value)))
                    {

                        aplicar -= Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvbalance"].Value));

                        row.Cells["dgvaplicar"].Value = row.Cells["dgvbalance"].Value;
                        row.Cells[""].Value = true;
                    }

                    else if (aplicar > 0 && aplicar < Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvbalance"].Value)))
                    {
                        row.Cells["dgvaplicar"].Value = aplicar;

                        aplicar = 0;
                        row.Cells[""].Value = true;
                    }
                    else
                    {

                        row.Cells["dgvaplicar"].Value = string.Empty;
                        
                        row.Cells[""].Value = false;
                    }

                }
             
            }
            else
            {
                Txtaplicar.Text = "";
                
                foreach (DataGridViewRow row in Dgv.Rows)
                {

                    row.Cells["dgvaplicar"].Value = "";
                    
                    row.Cells[""].Value = false;
                }
            }
        }
        protected override void Salvar()
        {
            base.Salvar();
            Control[] array = { Txtchequefuturo, Txtcodigocliente, Txtcodigovendedor, Txtaplicar, Cmbmoneda, Dgv ,Txtnock,Dtpfechadeposito,Cmbbanco};

            if (!Funciones.Fun_Validar_Campos_Vacios(array))
            {
                string encabezado = "";
                string detalle = "";
                string cierre = "";
                string xml = "";
               
                encabezado = "<ChequesFuturos csecuencia=\"" + Txtchequefuturo.Text
            + "\" dfecha=\"" + Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfecha)
            + "\" creferencia=\"" + Txtreferencia.Text
            + "\" nidcliente=\"" + Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text)
            + "\" nidvendedor=\"" + Funciones.Fun_Convierte_String_aEntrero(Txtcodigovendedor.Text)
            + "\" nidbanco=\"" + Cmbbanco.SelectedValue
            + "\" nnocheque=\"" + Funciones.Fun_Convierte_String_aEntrero(Txtnock.Text)
            + "\" dfechadeposito=\"" + Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfechadeposito)
            + "\" ntotal=\"" + Funciones.Fun_Convierte_String_aDecimal(Txtaplicar.Text)
            + "\" nbalancecliente =\"" + Funciones.Fun_Convierte_String_aDecimal(Txtbalance.Text)
            + "\" nidmoneda=\"" + Cmbmoneda.SelectedValue
            
            + "\"> <Facturas>";


                foreach (DataGridViewRow item in Dgv.Rows)
                {
                    if (Convert.ToBoolean(item.Cells[""].EditedFormattedValue))
                    {
                        if (Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvaplicar"].Value)) > 0)
                        {
                            detalle = detalle + "<Factura nidfactura=\"" + Funciones.Fun_Convierte_String_aEntrero(Convert.ToString(item.Cells["dgvidregistro"].Value))
                   + "\" nmonto=\"" + Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvaplicar"].Value))
                   + "\"/>";

                        }
                    }
                }
               

                cierre = "</Facturas> </ChequesFuturos>";
                xml = encabezado + detalle + cierre;

                string cmd = string.Format("exec Spr_cxc_chequefuturo '{0}','{1}','{2}'",Properties.Settings.Default.idsesion, 1, xml); //Armo el comando
                DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                if (Ckbimprimir.Checked)
                {
                    var Reporte_ChequeFuturo = new Reporte_General.CXC.cxcrepchequefuturo01();
                                        
                    Reporte_ChequeFuturo._id = ds.Tables[1].Rows[0][0].ToString();

                    Reporte_ChequeFuturo.Show();
                    Reporte_ChequeFuturo.Owner = this;
                }

                Funciones.Fun_Limpiar_Formulario(MainPanel);

                
                Txtchequefuturo.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("CHEQUE FUTURO");
                

                Ckbimprimir.Checked = true;

                LblAlerta.Text = "";
            }
            else
                LblAlerta.Text = Mensajes.Stg_Campos_EnBlanco;


        }
        protected override void Retornar()
        {
            if (Funciones.Fun_Convierte_String_aDecimal(Txtaplicar.Text) > 0)
            {
                if (Mensajes.Msgb_DatosporProcesar() == DialogResult.Yes)
                    this.Close();
            }
            else
                this.Close();

        }

        private void Dtpfecha_Validating(object sender, CancelEventArgs e)
        {
            if (Dtpfecha.Value > Dtpfechadeposito.Value)
            {
                Dtpfechadeposito.Value = Dtpfecha.Value;
                Dtpfechadeposito.MinDate = Dtpfecha.Value.AddDays(0);

            }
        }

        private void Dtpfechadeposito_Validating(object sender, CancelEventArgs e)
        {
            if (Dtpfecha.Value > Dtpfechadeposito.Value)
            {
                Dtpfechadeposito.Value = Dtpfecha.Value;
                Dtpfechadeposito.MinDate = Dtpfecha.Value.AddDays(0);

            }
        }
    }
}
