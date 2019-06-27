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
    public partial class cxcprodebcre : Duke4.MainFormProceso
    {
        public cxcprodebcre()
        {
            InitializeComponent();
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

        private void cxcprodebcre_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Registro de Nota DEB/CRE", this);
            Rbncredito.Checked = true;
            Ckbncf.Checked = true;
            BtnModificar.Visible = false;
            BtnCrear.Visible = false;
            Txtcodigocliente.Focus();

            Dgv.Columns["dgvcheck"].Width = 25;

            Dgv.Columns["dgvsecuencia"].ReadOnly = true;
            Dgv.Columns["dgvreferencia"].ReadOnly = true;
            Dgv.Columns["dgvfecha"].ReadOnly = true;
            Dgv.Columns["dgvvence"].ReadOnly = true;
            Dgv.Columns["dgvdias"].ReadOnly = true;
            Dgv.Columns["dgvtotal"].ReadOnly = true;
            Dgv.Columns["dgvbalance"].ReadOnly = true;
            Dgv.Columns["dgvsecuencia"].DisplayIndex = 1;

            Ckbimprimir.Checked = true;
            Txtregistro.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("NOTA DE CREDITO CXC");

            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");
            
        }
        protected override void Crear()
        {
            base.Crear();
        }


        private void Rbndebito_CheckedChanged(object sender, EventArgs e)
        {
            if(Rbndebito.Checked)
            {
                Txtregistro.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("NOTA DE DEBITO CXC");

                FuncionesSQL.Fun_SQL_Buscar_Secuencia_NCF(3, Dtpfecha.Value, Mskncf);
            }
        }

        private void Rbncredito_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbncredito.Checked)
            {
                Txtregistro.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("NOTA DE CREDITO CXC");

                FuncionesSQL.Fun_SQL_Buscar_Secuencia_NCF(4, Dtpfecha.Value, Mskncf);
            }
        }

        private void Dgv_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            int pos = Dgv.CurrentCell.RowIndex;
            int posi = Dgv.CurrentCell.ColumnIndex;

            if (Dgv.Rows.Count > 0)
            {

                if (Dgv.Columns[posi].Name == "dgvcheck")
                {
                    Dgv.BeginEdit(true);
                    if (Convert.ToBoolean(Dgv.Rows[pos].Cells["dgvcheck"].EditedFormattedValue))
                    {
                        Dgv.Rows[pos].Cells["dgvaplicar"].Value = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvbalance"].Value));

                    }
                    else
                    {

                        Dgv.Rows[pos].Cells["dgvcheck"].Value = false;
                        Dgv.Rows[pos].Cells["dgvaplicar"].Value = "";
                        Dgv.Rows[pos].Cells["dgvitbis"].Value = "";
                    }
                    Dgv.EndEdit();
                }
            }
        }
        private bool llevaitbis(string numero)
        {
            bool lleva = false;

            string cmd3 = "select totalitbis from cxcdbfregistro where secuencia='" + numero + "' and totalitbis>0";

            DataSet ds3 = FuncionesSQL.Fun_Sql_Ejecutar(cmd3);
            if (ds3.Tables[0].Rows.Count > 0)
            {

                if (Funciones.Fun_Convierte_String_aDecimal(ds3.Tables[0].Rows[0][0].ToString()) > 0)
                {

                    lleva = true;
                }


            } return lleva;
        }

        

        double exento = 0;
        double gravado = 0;
        int idregistro = 0;
        string ncfregistro = "";
        private void Dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double itbis = 0;
            double itbiscalculado = 0;
            double aplicar = 0;
            double exentofac = 0;
            double gravadofac = 0;
            double balance = 0;
            double subtotal = 0;
            exento = 0;
            gravado = 0;


            int pos = 0;

            if (Dgv.Rows.Count > 0)
            {

                pos = e.RowIndex;
                if (!string.IsNullOrEmpty(Convert.ToString(Dgv.Rows[pos].Cells["dgvaplicar"].Value)))
                {
                    aplicar = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvaplicar"].Value));
                    balance = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvbalance"].Value));
                    gravadofac = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvtotalimporte"].Value));
                    exentofac = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvtotalexento"].Value));
                    ncfregistro = Convert.ToString(Dgv.Rows[pos].Cells["dgvncf"].Value);
                    idregistro = Funciones.Fun_Convierte_String_aEntrero(Convert.ToString(Dgv.Rows[pos].Cells["dgvidregistro"].Value));

                    if (Dgv.Columns[e.ColumnIndex].Name == "dgvitbis")
                    {

                        if (Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvtotalitbis"].Value)) == 0)
                        {
                            MessageBox.Show(Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvtotalitbis"].Value)).ToString());
                            Mensajes.Msgb_Registro_Sin_Itbis();
                            Dgv.Rows[pos].Cells["dgvitbis"].Value = "";
                            Txtitbis.Text = "";
                            Txtsubtotal.Text = Convert.ToString(Dgv.Rows[pos].Cells["dgvaplicar"].Value);
                            Txttotal.Text = Convert.ToString(Dgv.Rows[pos].Cells["dgvaplicar"].Value);
                        }
                        else
                        {
                            if (Funciones.Fun_Convierte_String_aEntrero(Convert.ToString(Dgv.Rows[pos].Cells["dgvdias"].Value)) <= 30)
                            {


                                if (exentofac < balance && aplicar < balance)
                                {

                                    if (aplicar > gravadofac)
                                    {
                                        itbiscalculado = gravadofac * 0.18;
                                        if (gravadofac + itbiscalculado < aplicar)
                                            exento = aplicar - (gravadofac + itbiscalculado);
                                    }
                                    else
                                        itbiscalculado = aplicar * 0.18;

                                    if (!string.IsNullOrEmpty(Convert.ToString(Dgv.Rows[pos].Cells["dgvitbis"].Value)))
                                    {
                                        if (Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvitbis"].Value)) > itbiscalculado)
                                        {
                                            Dgv.Rows[pos].Cells["dgvitbis"].Value = itbiscalculado.ToString("N2");
                                            Txtitbis.Text = itbiscalculado + "";
                                            subtotal = aplicar - itbiscalculado;
                                            Mensajes.Msgb_Itbis_Mayor_Que(subtotal);
                                        }
                                        else
                                        {
                                            Txtitbis.Text = Convert.ToString(Dgv.Rows[pos].Cells["dgvitbis"].Value);
                                            subtotal = aplicar - Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvitbis"].Value));
                                        }
                                    }
                                }
                                else if (exentofac < balance)
                                {

                                    itbiscalculado = gravadofac * 0.18;
                                    if (!string.IsNullOrEmpty(Convert.ToString(Dgv.Rows[pos].Cells["dgvitbis"].Value)))
                                    {
                                        if (Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvitbis"].Value)) > itbiscalculado)
                                        {
                                            Dgv.Rows[pos].Cells["dgvitbis"].Value = itbiscalculado.ToString("N2");
                                            Txtitbis.Text = itbiscalculado + "";
                                            subtotal = gravadofac - itbiscalculado + exentofac;
                                            Mensajes.Msgb_Itbis_Mayor_Que(subtotal);
                                        }
                                        else
                                        {

                                            Txtitbis.Text = Convert.ToString(Dgv.Rows[pos].Cells["dgvitbis"].Value);
                                            subtotal = aplicar - Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvitbis"].Value));

                                        }
                                    }
                                    exento = exentofac;
                                }
                                else
                                {

                                    exento = aplicar;
                                    Dgv.Rows[pos].Cells["dgvitbis"].Value = "";
                                    subtotal = aplicar;
                                }

                                Txttotal.Text = aplicar + "";
                                Txtsubtotal.Text = subtotal + "";
                            }
                            else
                            {
                                Mensajes.Msgb_Registro_Mayor_30dias();
                                Dgv.Rows[pos].Cells["dgvitbis"].Value = "";
                                Txtitbis.Text = "";
                                Txtsubtotal.Text = Convert.ToString(Dgv.Rows[pos].Cells["dgvaplicar"].Value);
                                Txttotal.Text = Convert.ToString(Dgv.Rows[pos].Cells["dgvaplicar"].Value);

                            }
                        }


                    }

                    if (Dgv.Columns[e.ColumnIndex].Name == "dgvaplicar" || Dgv.Columns[e.ColumnIndex].Name == "dgvcheck")
                    {
                        if (Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvaplicar"].Value)) > 0)
                        {

                            foreach (DataGridViewRow item in Dgv.Rows)
                            {

                                if (item.Cells["dgvaplicar"].RowIndex == pos)
                                {


                                    if (aplicar > balance && Rbncredito.Checked)
                                    {
                                        if (aplicar > 0)
                                        {
                                            Dgv.Rows[pos].Cells["dgvaplicar"].Value = Dgv.Rows[pos].Cells["dgvbalance"].Value;
                                        }
                                        else
                                            Dgv.Rows[pos].Cells["dgvaplicar"].Value = "";

                                        aplicar = balance;
                                    }


                                    if (Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvtotalitbis"].Value)) > 0 && Funciones.Fun_Convierte_String_aEntrero(Convert.ToString(Dgv.Rows[pos].Cells["dgvdias"].Value)) <= 30)
                                    {
                                        if (exentofac < balance && aplicar < balance)
                                        {

                                            if (aplicar > gravadofac)
                                            {

                                                itbiscalculado = gravadofac * 0.18;
                                                if (gravadofac + itbiscalculado < aplicar)
                                                    exento = aplicar - (gravadofac + itbiscalculado);
                                            }
                                            else
                                                itbiscalculado = aplicar * 0.18;

                                            Txtitbis.Text = itbiscalculado.ToString("N2") + "";
                                            subtotal = aplicar - itbiscalculado;
                                            Dgv.Rows[pos].Cells["dgvitbis"].Value = itbiscalculado;
                                        }
                                        else if (exentofac < balance)
                                        {

                                            itbiscalculado = gravadofac * 0.18;
                                            Txtitbis.Text = itbiscalculado.ToString("N2") + "";
                                            subtotal = aplicar - itbiscalculado;
                                            Dgv.Rows[pos].Cells["dgvitbis"].Value = itbiscalculado;
                                            exento = exentofac;
                                        }
                                        else
                                        {
                                            exento = aplicar;
                                            subtotal = aplicar;
                                        }

                                    }
                                    else
                                    {
                                        subtotal = aplicar;
                                        Txtitbis.Text = "";
                                    }

                                    Txttotal.Text = aplicar + "";
                                    Txtsubtotal.Text = subtotal + "";
                                    Dgv.Rows[pos].Cells["dgvcheck"].Value = true;
                                }
                                else
                                {
                                    item.Cells["dgvcheck"].Value = false;
                                    item.Cells["dgvaplicar"].Value = string.Empty;
                                    item.Cells["dgvitbis"].Value = string.Empty;
                                }


                            }
                        }

                    }
                }
                else
                {
                    Dgv.Rows[pos].Cells["dgvaplicar"].Value = string.Empty;
                    Dgv.Rows[pos].Cells["dgvitbis"].Value = string.Empty;
                    Dgv.Rows[pos].Cells["dgvcheck"].Value = false;
                    if (!checkactivogrid())
                        Txttotal.Text = Txtsubtotal.Text = Txtitbis.Text = "";

                }

                Fun_Calcular_Gravado();
            }

        }
        protected void Fun_Calcular_Gravado()
        {
            if (exento > 0 && Funciones.Fun_Convierte_String_aDecimal(Txtsubtotal.Text) - exento > 0)
                gravado = Funciones.Fun_Convierte_String_aDecimal(Txtsubtotal.Text) - exento;
            else
                gravado = Funciones.Fun_Convierte_String_aDecimal(Txtsubtotal.Text);

        }
        protected bool checkactivogrid()
        {
            bool check = false;
            foreach (DataGridViewRow item in Dgv.Rows)
            {

                if (Convert.ToBoolean(item.Cells["dgvcheck"].EditedFormattedValue))
                {

                    check = true;
                    break;

                }
            }

            return check;
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

        private void Txtcodigocliente_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Cliente();
        }
        protected override void Retornar()
        {
            if (Funciones.Fun_Convierte_String_aDecimal(Txttotal.Text) > 0)
            {
                if (Mensajes.Msgb_DatosporProcesar() == DialogResult.Yes)
                    this.Close();
            }
            else
                this.Close();

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
                    Mensajes.Msgb_NoDebCre_CliContado();
                }
                else
                {
                    Txtcodigocliente.Enabled = false;
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

                    string cmd2 = string.Format("select idregistro,secuencia,fecha as fechafac,referencia,fechavencimiento, DATEDIFF(day, fecha, getdate()) as dias ,total,balance,ncf,totalitbis,totalgravado16+totalgravado18 as totalimporte,totalexento from cxcdbfregistro where idcliente='" + Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text) + "' and balance >0 and nulo=0");
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
                Txtnombrecliente.Text = Txtdireccioncliente.Text = Txttelefonocliente.Text = Txtbalance.Text = "";

            }

        }

        private void Dtpfecha_Validating(object sender, CancelEventArgs e)
        {
            if(Rbncredito.Checked)
                FuncionesSQL.Fun_SQL_Buscar_Secuencia_NCF(4, Dtpfecha.Value, Mskncf);
            else if (Rbndebito.Checked)
                FuncionesSQL.Fun_SQL_Buscar_Secuencia_NCF(3, Dtpfecha.Value, Mskncf);
        }
        protected override void Salvar()
        {
            base.Salvar();

            Control[] array = { Txtcodigocliente, Txtconcepto, Txtcodigovendedor,Txttotal,Cmbmoneda };
            double balcli = 0;

            int tiponota = 0;
            int idncf = 0;
            string titulonota="";

            if (Rbncredito.Checked)
            {
                tiponota = 1;
                idncf = 4;
                titulonota= "NOTA DE CREDITO";
            }
            else if (Rbndebito.Checked)
            {
                tiponota = 2;
                idncf = 3;
                titulonota = "NOTA DE DEBITO";
            }

            if (!Funciones.Fun_Validar_Campos_Vacios(array))
            {
                if (Funciones.Fun_Convierte_String_aDecimal(Txttotal.Text) > 0)
                {
                    string encabezado = "";
                    string detalle = "";
                    string cierre = "";
                    string xml = "";
                    double balancecliente = Funciones.Fun_Convierte_String_aDecimal(Txtbalance.Text) - Funciones.Fun_Convierte_String_aDecimal(Txttotal.Text);
                   
                    encabezado = "<Debcre dfecha = \"" + Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfecha)
                + "\" nidcliente =\"" + Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text)
                + "\" creferencia =\"" + Txtreferencia.Text
                + "\" cconcepto =\"" + Txtconcepto.Text
                + "\" nitbis =\"" + Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtitbis.Text)
                + "\" ntotal =\"" + Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txttotal.Text)
                + "\" nbalancecliente =\"" + balancecliente
                + "\" nidvendedor =\"" + Funciones.Fun_Convierte_String_aEntrero(Txtcodigovendedor.Text)
                + "\" cncf =\"" + Mskncf.Text
                + "\" nidmoneda =\"" + Cmbmoneda.SelectedValue
                + "\" ntiponota =\"" + tiponota
                + "\" ngravado =\"" + gravado
                + "\" nexento =\"" + exento
                
                + "\"> <Facturas>";

                    foreach (DataGridViewRow item in Dgv.Rows)
                    {
                        if (Convert.ToBoolean(item.Cells["dgvcheck"].EditedFormattedValue))
                        {
                            if (Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvaplicar"].Value)) > 0)
                            {
                                detalle = detalle + "<Factura nidfactura =\"" + Funciones.Fun_Convierte_String_aEntrero(item.Cells["dgvidregistro"].Value + "")
                   + "\" ngravado =\"" + gravado
                   + "\" nexento =\"" + exento
                   + "\" nitbis =\"" + Funciones.Fun_Convierte_String_aDecimal(item.Cells["dgvitbis"].Value + "")
                   + "\" nmonto =\"" + Funciones.Fun_Convierte_String_aDecimal(item.Cells["dgvaplicar"].Value + "")
                   + "\" cncffactura =\"" + item.Cells["dgvncf"].Value
                   + "\"/>";


                            }
                        }
                    }

                    cierre = "</Facturas> </Debcre>";
                    xml = encabezado + detalle + cierre;

                        string cmd = string.Format("exec Spr_cxc_Debcre '{0}','{1}','{2}'", Properties.Settings.Default.idsesion, 1, xml); 
                        DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                    if (Ckbncf.Checked == true)
                       FuncionesSQL.Fun_SQL_Actualizar_NCF(idncf);



                    if (Ckbimprimir.Checked == true)
                    {
                        var Reporte = new Reporte_General.CXC.cxcrepdebcre01();

                        if (tiponota == 1)
                            Reporte._titulonota = "NOTA DE CREDITO";
                        else if (tiponota == 2)
                            Reporte._titulonota = "NOTA DE DEBITO";

                        Reporte._id = ds.Tables[1].Rows[0][0].ToString();

                        Reporte.Show();
                        Reporte.Owner = this;
                    }

                    Funciones.Fun_Limpiar_Formulario(MainPanel);

                    if (tiponota==1)
                        Txtregistro.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("NOTA DE CREDITO CXC");
                    else
                        Txtregistro.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("NOTA DE DEBITO CXC");

                    Txtcodigocliente.Enabled = true;
                    Ckbimprimir.Checked = true;
                    Ckbncf.Checked = true;
                    Rbncredito.Checked = true;

                    LblAlerta.Text = "";

                }
                else
                {
                    if (tiponota == 1)
                    {
                        LblAlerta.Text = "Seleccione Factura a Aplicar Nota de Crédito    ";


                    }
                    else if (tiponota == 2)
                    {
                        LblAlerta.Text = "Seleccione Factura a Aplicar Nota de Débito    ";

                    }

                }

            }
            else LblAlerta.Text = Logistica.Mensajes.Stg_Campos_EnBlanco;
        }

        private void Ckbncf_CheckedChanged(object sender, EventArgs e)
        {
            if (Ckbncf.Checked)

            {

                Mskncf.Visible = true;
                if (Rbncredito.Checked)
                    FuncionesSQL.Fun_SQL_Buscar_Secuencia_NCF(4, Dtpfecha.Value, Mskncf);
                else if (Rbndebito.Checked)
                    FuncionesSQL.Fun_SQL_Buscar_Secuencia_NCF(3, Dtpfecha.Value, Mskncf);

            }
            else
                Mskncf.Visible = false;
        }
    }

}
