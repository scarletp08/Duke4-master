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
    public partial class cxcproreciboingreso : Duke4.MainFormProceso
    {
        public cxcproreciboingreso()
        {
            InitializeComponent();
        }
        private double tasamoneda = 0;

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

        private void cxcproreciboingreso_Load(object sender, EventArgs e)
        {

            Fun_Set_Nombre_Formulario("Registro de Ingresos", this);
            Rbnreciboingreso.Checked = true;
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
            Dgv.Columns["dgvtotal"].ReadOnly = true;
            Dgv.Columns["dgvbalance"].ReadOnly = true;
            Dgv.Columns["dgvbalancefinal"].ReadOnly = true;
            Dgv.Columns["dgvsecuencia"].DisplayIndex = 1;

            Ckbimprimir.Checked = true;

            Txtcobro.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("COBRO");

            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");
            //tasamoneda= FuncionesSQL.Fun_SQL_Buscar_Tasa_Moneda(Funciones.Fun_Convierte_String_aEntrero(Cmbmoneda.SelectedValue.ToString()));
            
        }
        protected override void Crear()
        {
            base.Crear();
            Txtcobro.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("COBRO");
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

            double aplica = 0;
            double deposito = Funciones.Fun_Convierte_String_aDecimal(Txtdeposito.Text);
            double balance = Funciones.Fun_Convierte_String_aDecimal(Txtbalance.Text);

            if (Dgv.Rows.Count > 0)
            {
                if (Rbnreciboingreso.Checked)
                {

                    Dgv.BeginEdit(true);

                    foreach (DataGridViewRow item in Dgv.Rows)
                    {
                        item.Cells[""].Value = e.IsChecked;

                        if (Convert.ToBoolean(item.Cells[""].Value))
                        {
                            aplica += Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvbalance"].Value));


                            item.Cells["dgvaplicar"].Value = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvbalance"].Value)).ToString("N2");
                            item.Cells["dgvbalancefinal"].Value = "0.00";
                        }

                        else
                            item.Cells["dgvaplicar"].Value = string.Empty;
                        item.Cells["dgvbalancefinal"].Value = string.Empty;
                        item.Cells["dgvdescuento"].Value = string.Empty;
                        item.Cells["dgvcargo"].Value = string.Empty;
                        item.Cells["dgvretencionitbis"].Value = string.Empty;
                        item.Cells["dgvretencionisr"].Value = string.Empty;
                    }

                }
                else if (Rbnaplicardeposito.Checked)
                {


                    if (balance > deposito)
                    {
                        aplica = deposito;
                    }
                    else aplica = balance;

                    foreach (DataGridViewRow item in Dgv.Rows)
                    {

                        if (deposito > 0)
                            item.Cells[""].Value = e.IsChecked;

                        if (Convert.ToBoolean(item.Cells[""].Value) == true)
                        {
                            if (deposito >= Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvbalance"].Value)))
                            {


                                deposito -= Convert.ToDouble(item.Cells["dgvbalance"].Value);
                                item.Cells["dgvaplicar"].Value = Convert.ToDouble(item.Cells["dgvbalance"].Value);
                                item.Cells["dgvbalancefinal"].Value = Convert.ToDouble(item.Cells["dgvbalance"].Value) - Convert.ToDouble(item.Cells["dgvaplicar"].Value);

                            }

                            else if (deposito < Convert.ToDouble(item.Cells["dgvbalance"].Value) && deposito > 0)
                            {
                                item.Cells["dgvaplicar"].Value = deposito;
                                item.Cells["dgvbalancefinal"].Value = Convert.ToDouble(item.Cells["dgvbalance"].Value) - Convert.ToDouble(item.Cells["dgvaplicar"].Value);
                                deposito = 0;
                            }
                        }
                        else if (Convert.ToBoolean(item.Cells[""].Value) == false)
                        {

                            item.Cells["dgvaplicar"].Value = string.Empty;
                            item.Cells["dgvbalancefinal"].Value = string.Empty;
                            item.Cells["dgvdescuento"].Value = string.Empty;
                            item.Cells["dgvcargo"].Value = string.Empty;
                            item.Cells["dgvretencionitbis"].Value = string.Empty;
                            item.Cells["dgvretencionisr"].Value = string.Empty;

                            if (Funciones.Fun_Convierte_String_aDecimal(Txtaplicar.Text) == 0)
                                aplica = 0;

                        }
                    }

                }



                Fun_Calcular_Totales();

                Dgv.EndEdit();
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
                    Mensajes.Msgb_NoCobros_CliContado();
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

                    string cmd2 = string.Format("select idregistro,secuencia,ncf,referencia,fecha as fechafac,fechavencimiento, DATEDIFF(day, fecha, getdate()) as dias ,total,balance,totalitbis from cxcdbfregistro where idcliente='" + Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text) + "' and balance >0 and nulo=0");
                    DataSet ds2 = FuncionesSQL.Fun_Sql_Ejecutar(cmd2);
                    if (ds2.Tables.Count > 0)
                    {
                        if (ds2.Tables[0].Rows.Count > 0)
                        {
                            Txtbalance.Text = FuncionesSQL.Fun_SQL_Buscar_Balance_Cliente(Txtcodigocliente.Text);
                            Txtdeposito.Text = FuncionesSQL.Fun_SQL_Buscar_Deposito_Cliente(Txtcodigocliente.Text);

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
                Txtnombrecliente.Text = Txtdireccioncliente.Text = Txttelefonocliente.Text = Txtbalance.Text = "";

            }

        }

        private void Txtcodigocliente_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Cliente();
        }
        protected override void Retornar()
        {
            if (Funciones.Fun_Convierte_String_aDecimal(Txttotalcob.Text) > 0)
            {
                if (Mensajes.Msgb_DatosporProcesar() == DialogResult.Yes)
                    this.Close();
            }
            else
                this.Close();

        }
        private void Fun_Calcular_Totales()
        {
            double sumaaplicar = 0;
            double sumadescuento = 0;
            double sumacargo = 0;
            double sumaretencionitbis = 0;
            double sumaretencionisr = 0;

            if (Funciones.Fun_Convierte_String_aDecimal(Txtaplicar.Text.Trim()) <= Funciones.Fun_Convierte_String_aDecimal(Txtbalance.Text.Trim()))
            {

                foreach (DataGridViewRow item in Dgv.Rows)
                {

                    if (Convert.ToBoolean(item.Cells[""].EditedFormattedValue))
                    {
                        sumaaplicar += Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvaplicar"].Value));
                        sumadescuento += Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvdescuento"].Value));
                        sumacargo += Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvcargo"].Value));
                        sumaretencionisr += Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvretencionisr"].Value));
                        sumaretencionitbis += Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvretencionitbis"].Value));


                    }
                }

                Txtaplicar.Text = sumaaplicar.ToString();
                Txtcargdesc.Text = sumadescuento.ToString();
                Txttotalcob.Text = (sumaaplicar - sumadescuento).ToString();
                Txttotalcargo.Text = sumacargo.ToString();
                Txttotaldescuento.Text = sumadescuento.ToString();
                Txttotalretencionisr.Text = sumaretencionisr.ToString();
                Txttotalretencionitbis.Text = sumaretencionitbis.ToString();
            }
        }

        private void Ckbncf_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbncf.Checked)
            {
                Dgv.Columns["dgvncf"].Visible = true;
                Dgv.Columns["dgvncf"].FillWeight = 160;
                Dgv.Columns["dgvreferencia"].Visible = false;
                Dgv.Columns["dgvdias"].Visible = false;
            }
            else
            {
                Dgv.Columns["dgvncf"].Visible = false;
                Dgv.Columns["dgvreferencia"].Visible = true;
                Dgv.Columns["dgvdias"].Visible = true;
            }
        }

        private void Txtaplicar_Validating(object sender, CancelEventArgs e)
        {
            double aplicar = Funciones.Fun_Convierte_String_aDecimal(Txtaplicar.Text.Trim());
            double balance = Funciones.Fun_Convierte_String_aDecimal(Txtbalance.Text.Trim());

            if (aplicar >= balance)
            {
                Txtaplicar.Text = balance.ToString();
                Txttotalcob.Text = balance.ToString();
            }
            if (aplicar > 0)
            {
                foreach (DataGridViewRow row in Dgv.Rows)
                {

                    if (aplicar >= Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvbalance"].Value)))
                    {

                        aplicar -= Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvbalance"].Value));

                        row.Cells["dgvaplicar"].Value = row.Cells["dgvbalance"].Value;
                        row.Cells["dgvbalancefinal"].Value = "0.00";
                        row.Cells[""].Value = true;
                    }

                    else if (aplicar > 0 && aplicar < Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvbalance"].Value)))
                    {
                        row.Cells["dgvaplicar"].Value = aplicar;

                        row.Cells["dgvbalancefinal"].Value = (Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvbalance"].Value)) - aplicar);
                        aplicar = 0;
                        row.Cells[""].Value = true;
                    }
                    else
                    {

                        row.Cells["dgvaplicar"].Value = string.Empty;
                        row.Cells["dgvbalancefinal"].Value = string.Empty;
                        row.Cells["dgvdescuento"].Value = string.Empty;
                        row.Cells["dgvcargo"].Value = string.Empty;
                        row.Cells["dgvretencionitbis"].Value = string.Empty;
                        row.Cells["dgvretencionisr"].Value = string.Empty;
                        row.Cells[""].Value = false;
                    }

                }
                Txttotalcob.Text = Txtaplicar.Text;
            }
            else
            {
                Txtaplicar.Text = "";
                Txtcargdesc.Text = "";
                Txttotalcob.Text = "";
                Txttotalcargo.Text = "";
                Txttotaldescuento.Text = "";
                Txttotalretencionisr.Text = "";
                Txttotalretencionitbis.Text = "";
                foreach (DataGridViewRow row in Dgv.Rows)
                {

                    row.Cells["dgvaplicar"].Value = "";
                    row.Cells["dgvbalancefinal"].Value = "";
                    row.Cells["dgvdescuento"].Value = "";
                    row.Cells["dgvcargo"].Value = string.Empty;
                    row.Cells["dgvretencionitbis"].Value = string.Empty;
                    row.Cells["dgvretencionisr"].Value = string.Empty;
                    row.Cells[""].Value = false;
                }
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
                        Dgv.Rows[pos].Cells["dgvbalancefinal"].Value = "0.00";
                    }
                    else
                    {

                        Dgv.Rows[pos].Cells["dgvaplicar"].Value = string.Empty;
                        Dgv.Rows[pos].Cells["dgvdescuento"].Value = string.Empty;
                        Dgv.Rows[pos].Cells["dgvcargo"].Value = string.Empty;
                        Dgv.Rows[pos].Cells["dgvbalancefinal"].Value = string.Empty;
                        Dgv.Rows[pos].Cells["dgvretencionitbis"].Value = string.Empty;
                        Dgv.Rows[pos].Cells["dgvretencionisr"].Value = string.Empty;
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
                double descuento = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvdescuento"].Value));
                double cargo = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvcargo"].Value));
                double aplicar = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvaplicar"].Value));
                double retencionisr = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvretencionisr"].Value));
                double retencionitbis = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvretencionitbis"].Value));
                double total = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvtotal"].Value));
                double itbis = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvtotalitbis"].Value));

                if (Dgv.Columns[e.ColumnIndex].Name == "dgvaplicar" || Dgv.Columns[e.ColumnIndex].Name == "")
                {
                    if (aplicar > 0)
                    {
                        if (pendiente >= aplicar)
                        {
                            Dgv.Rows[pos].Cells["dgvbalancefinal"].Value = pendiente - aplicar;
                            Dgv.Rows[pos].Cells[""].Value = true;
                        }
                        else if (aplicar > pendiente && descuento == 0)
                        {
                            Mensajes.Msgb_MontoFuera_Limite();
                            Dgv.Rows[pos].Cells["dgvaplicar"].Value = string.Empty;
                            Dgv.Rows[pos].Cells[""].Value = false;
                        }
                        else if (aplicar > pendiente && descuento > 0)
                        {
                            Dgv.Rows[pos].Cells["dgvaplicar"].Value = string.Empty;
                            Dgv.Rows[pos].Cells["dgvdescuento"].Value = string.Empty;
                            Dgv.Rows[pos].Cells[""].Value = false;
                            Mensajes.Msgb_MontoFuera_Limite();
                        }
                        // Fun_Calcular_Totales(); //Actualiza los totales
                    }
                    else
                    {
                        //Fun_Calcular_Totales(); //Actualiza los totales
                        Dgv.Rows[pos].Cells["dgvbalancefinal"].Value = string.Empty;
                        Dgv.Rows[pos].Cells[""].Value = false;

                        Dgv.Rows[pos].Cells["dgvaplicar"].Value = "";
                        Dgv.Rows[pos].Cells["dgvdescuento"].Value = "";
                        Dgv.Rows[pos].Cells["dgvcargo"].Value = string.Empty;
                        Dgv.Rows[pos].Cells["dgvretencionitbis"].Value = string.Empty;
                        Dgv.Rows[pos].Cells["dgvretencionisr"].Value = string.Empty;
                    }
                }
                else if (Dgv.Columns[e.ColumnIndex].Name == "dgvdescuento")
                {
                    if (aplicar == 0 && descuento>0)
                    {
                        Mensajes.Msgb_Desc_Sinpago();
                        Dgv.Rows[pos].Cells["dgvdescuento"].Value = string.Empty;
                    }
                    else
                    {
                        if (descuento > 0 && descuento <= pendiente && aplicar == 0)
                        {
                            Dgv.Rows[pos].Cells["dgvaplicar"].Value = descuento;
                            Dgv.Rows[pos].Cells["dgvbalancefinal"].Value = pendiente - descuento;

                        }
                        else if (aplicar != 0)
                        {
                            if (descuento > aplicar)
                            {
                                Dgv.Rows[pos].Cells["dgvdescuento"].Value = string.Empty;
                                Mensajes.Msgb_Desc_Invalido();
                            }
                        }

                        else if (descuento > pendiente)
                        {
                            Dgv.Rows[pos].Cells["dgvdescuento"].Value = string.Empty;
                            Mensajes.Msgb_Desc_Invalido();
                        }
                    }

                }
                else if (Dgv.Columns[e.ColumnIndex].Name == "dgvretencionitbis")
                {
                    if (aplicar == 0 && retencionitbis > 0)
                    {
                        Mensajes.Msgb_Ret_Itbis_Sinpago();
                        Dgv.Rows[pos].Cells["dgvretencionitbis"].Value = string.Empty;
                    }
                    else
                    if (itbis < retencionitbis)
                    {
                        Dgv.Rows[pos].Cells["dgvretencionitbis"].Value = string.Empty;
                        Mensajes.Msgb_Ret_Itbis_Invalida();
                    }
                }
                else if (Dgv.Columns[e.ColumnIndex].Name == "dgvretencionisr")
                {
                    if (aplicar == 0 && retencionisr > 0)
                    {
                        Mensajes.Msgb_Ret_ISR_Sinpago();
                        Dgv.Rows[pos].Cells["dgvretencionisr"].Value = string.Empty;
                    }
                    else
                    if (total < retencionisr)
                    {
                        Dgv.Rows[pos].Cells["dgvretencionisr"].Value = string.Empty;
                        Mensajes.Msgb_Ret_ISR_Invalida();
                    }

                }

                Fun_Calcular_Totales();
            }
        }

        private void Rbnreciboingreso_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbnreciboingreso.Checked)

            {

                label1.Text = "Total Cobrado";
                Txtaplicar.Text = "";
                Txtcargdesc.Text = "";
                Txttotalcob.Text = "";
                Txttotalcargo.Text = "";
                Txttotaldescuento.Text = "";
                Txttotalretencionisr.Text = "";
                Txttotalretencionitbis.Text = "";

                foreach (DataGridViewRow row in Dgv.Rows)
                {

                    row.Cells["dgvaplicar"].Value = "";
                    row.Cells["dgvbalancefinal"].Value = "";
                    row.Cells["dgvdescuento"].Value = "";
                    row.Cells["dgvcargo"].Value = string.Empty;
                    row.Cells["dgvretencionitbis"].Value = string.Empty;
                    row.Cells["dgvretencionisr"].Value = string.Empty;
                    row.Cells[""].Value = false;



                }

            }
        }

        private void Rbnaplicardeposito_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbnaplicardeposito.Checked)

            {

                label1.Text = "Depósito Aplic.";

                if (Txtdeposito.Text != "")
                {

                    Txtaplicar.Text = "";
                    Txtcargdesc.Text = "";
                    Txttotalcob.Text = "";
                    Txttotalcargo.Text = "";
                    Txttotaldescuento.Text = "";
                    Txttotalretencionisr.Text = "";
                    Txttotalretencionitbis.Text = "";
                    foreach (DataGridViewRow row in Dgv.Rows)
                    {

                        row.Cells["dgvaplicar"].Value = "";
                        row.Cells["dgvbalancefinal"].Value = "";
                        row.Cells["dgvdescuento"].Value = "";
                        row.Cells["dgvcargo"].Value = string.Empty;
                        row.Cells["dgvretencionitbis"].Value = string.Empty;
                        row.Cells["dgvretencionisr"].Value = string.Empty;
                        row.Cells[""].Value = false;

                    }

                }
                else
                {
                    Rbnreciboingreso.Checked = true;
                    Mensajes.Msgb_Cliente_Sindeposito();
                }
            }
        }

            protected override void Salvar()
        {
            base.Salvar();
            Control[] array = { Txtcodigocliente, Txtaplicar, Cmbmoneda };

            if (!Funciones.Fun_Validar_Campos_Vacios(array))
            {
                if (Rbnreciboingreso.Checked)
                {
                    Opcion_Pago.Proceso.genpropago pago = new Opcion_Pago.Proceso.genpropago(Txtaplicar.Text, Txtcodigocliente.Text, 1);

                    if (pago.ShowDialog() == DialogResult.OK)
                    {

                        Fun_Procesar_Salvar(pago.cmd2);

                    }
                }
                else if (Rbnaplicardeposito.Checked)
                {
                    Fun_Procesar_Salvar("");

                }

            }
            else
            {
                LblAlerta.Text = Mensajes.Stg_Campos_EnBlanco;
            }

        }
        protected void Fun_Procesar_Salvar(string cmd2)
        {
            Control[] array = { Txtcodigocliente, Txtaplicar, Cmbmoneda };

            if (!Funciones.Fun_Validar_Campos_Vacios(array))
            {

                string encabezado = "";
                string detalle = "";
                string cierre = "";
                string xml = "";
                double balancecliente = Funciones.Fun_Convierte_String_aDecimal(Txtbalance.Text) - Funciones.Fun_Convierte_String_aDecimal(Txtaplicar.Text);
                double total = Funciones.Fun_Convierte_String_aDecimal(Txtaplicar.Text) - Funciones.Fun_Convierte_String_aDecimal(Txtcargdesc.Text);

                encabezado = "<Cobro dfecha = \"" + Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfecha)
            + "\" nidcliente =\"" + Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text)
            + "\" creferencia =\"" + Txtreferencia.Text
            + "\" ntotal =\"" + total
            + "\" nbalancecliente =\"" + balancecliente
            + "\" ccomentario =\"" + " "
            + "\" ntotalcomision =\"" + 0
            + "\" ntasamoneda =\"" + tasamoneda
            + "\" ntotalretencionisr =\"" + Funciones.Fun_Convierte_String_aDecimal(Txttotalretencionisr.Text)
            + "\" ntotalretencionitbis =\"" + Funciones.Fun_Convierte_String_aDecimal(Txttotalretencionitbis.Text)
            + "\" ntotalcargo =\"" + Funciones.Fun_Convierte_String_aDecimal(Txttotalcargo.Text)
            + "\" ntotaldescuento =\"" + Funciones.Fun_Convierte_String_aDecimal(Txttotaldescuento.Text)
            + "\" nidvendedor =\"" + Funciones.Fun_Convierte_String_aEntrero(Txtcodigovendedor.Text)
            + "\" nidmoneda =\"" + Cmbmoneda.SelectedValue
            + "\" nidcierrecaja =\"" + 0


            + "\"> <Facturas>";

                foreach (DataGridViewRow item in Dgv.Rows)
                {
                    if (Convert.ToBoolean(item.Cells[""].EditedFormattedValue))
                    {
                        if (Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvaplicar"].Value)) > 0)
                        {
                            detalle = detalle + "<Factura nidregistro =\"" + Funciones.Fun_Convierte_String_aEntrero(item.Cells["dgvidregistro"].Value + "")
               + "\" nmonto =\"" + Funciones.Fun_Convierte_String_aDecimal(item.Cells["dgvaplicar"].Value + "")
               + "\" nmontoretencionisr =\"" + Funciones.Fun_Convierte_String_aDecimal(item.Cells["dgvretencionisr"].Value + "")
               + "\" nmontoretencionitbis =\"" + Funciones.Fun_Convierte_String_aDecimal(item.Cells["dgvretencionitbis"].Value + "")
               + "\" ncargo =\"" + Funciones.Fun_Convierte_String_aDecimal(item.Cells["dgvcargo"].Value + "")
               + "\" ndescuento =\"" + Funciones.Fun_Convierte_String_aDecimal(item.Cells["dgvdescuento"].Value + "")
               + "\"/>";
                        }
                    }
                }

                cierre = "</Facturas> </Cobro>";
                xml = encabezado + detalle + cierre;

                if (Rbnreciboingreso.Checked)
                {
                    string cmd = string.Format("exec Spr_cxc_cobro '{0}','{1}','{2}'", Properties.Settings.Default.idsesion, 1, xml); //Armo el comando
                    DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);


                    string cmdpago = string.Format("exec Spr_gen_pago '{0}','{1}','{2}','{3}','{4}'", Properties.Settings.Default.idsesion, 1, ds.Tables[1].Rows[0][0].ToString(), Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfecha), cmd2);
                    DataSet ds2 = FuncionesSQL.Fun_Sql_Ejecutar(cmdpago);
                    if (Ckbimprimir.Checked)
                    {
                        var reporte = new Reporte_General.CXC.cxcrepcobro01();
                        reporte._id = ds.Tables[1].Rows[0][0].ToString();


                        reporte.Show();
                        reporte.Owner = this;
                    }
                }
                else if (Rbnaplicardeposito.Checked)
                {
                    string cmd = string.Format("exec Spr_cxc_cobro_deposito '{0}','{1}','{2}'", Properties.Settings.Default.idsesion, 1, xml); //Armo el comando
                    DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);



                    if (Ckbimprimir.Checked)
                    {
                        var Reporte = new Reporte_General.CXC.cxcrepcobroadelantadodetalle01();
                        Reporte._id = ds.Tables[0].Rows[0][0].ToString();


                        Reporte.Show();
                        Reporte.Owner = this;
                    }
                }

                Funciones.Fun_Limpiar_Formulario(MainPanel);
                Txtcobro.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("Cobro");
                Txtcodigocliente.Enabled = true;
                Ckbimprimir.Checked = true;
                LblAlerta.Text = "";

            }
            else
                LblAlerta.Text = Mensajes.Stg_Campos_EnBlanco;
        }

        private void Cmbmoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            tasamoneda = FuncionesSQL.Fun_SQL_Buscar_Tasa_Moneda(Funciones.Fun_Convierte_String_aEntrero(Convert.ToString(Cmbmoneda.SelectedValue)));

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txttotalcob_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtaplicar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
