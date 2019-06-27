using Duke4.Consulta_General;
using Duke4.Logistica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Duke4.CXC.Consulta
{
    public partial class cxcconreciboingreso : Duke4.MainFormConsulta
    {
        public cxcconreciboingreso()
        {
            InitializeComponent();
            string cmd = string.Format(queryconsultaing + " cxcdbfcobro.nulo=0 and cast(fecha as date) = cast(getdate() as date) order by secuencia");
            DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
            gridBase1.DataSource = ds.Tables[0];
            Fun_Calcular_Totales();
        }
        
        string queryconsultaing = "SELECT     secuencia, fecha,cxcdbfcobro.referencia,cxcdbfcobro.idcliente,nombre,idvendedor,total,idcobro, dbo.cxcdbfcobro.nulo, '' as entrada "
        + "FROM dbo.cxcdbfcobro "
        + "inner JOIN dbo.cxcdbfcliente on cxcdbfcliente.idcliente= cxcdbfcobro.idcliente where ";

        string queryconsultadep = "SELECT adelanto.secuencia, adelanto.fecha,adelanto.referencia,dbo.cxcdbfcliente.idcliente, dbo.cxcdbfcliente.nombre, cxcdbfregistro.idvendedor , "
            + "adelanto.total, adelanto.idcobro, adelanto.nulo,'' as entrada "
            + "FROM dbo.cxcdbfcobroadelantadodetalle as adelanto "
            + "inner join dbo.cxcdbfregistro ON dbo.cxcdbfregistro.idregistro = adelanto.idregistro "
            + "INNER JOIN dbo.cxcdbfcliente ON dbo.cxcdbfregistro.idcliente = dbo.cxcdbfcliente.idcliente "
            + " where ";
        protected override void Filtrar()
        {
            base.Filtrar();
            txtMayuscula1.Text = "";
            string cmd = "";
            if(Rbnreciboingreso.Checked)
            cmd = string.Format(queryconsultaing + " cxcdbfcobro.fecha >= Case When '" + Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(dtpBase1) + "' <> ' ' Then '" + Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(dtpBase1) + "' Else cxcdbfcobro.fecha End  "
            + " and cxcdbfcobro.fecha <= Case When '" + Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(dtpBase2) + "'  <> ' ' Then '" + Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(dtpBase2) + "' Else cxcdbfcobro.fecha End  "
            + " and cxcdbfcliente.idcliente = Case When '" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text) + "' > 0 Then '" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text) + "'   Else cxcdbfcliente.idcliente End "
            + " and idmoneda ='" + cmbBase1.SelectedValue + "'"
            + " order by secuencia");
            else
                cmd = string.Format(queryconsultadep + " adelanto.fecha >= Case When '" + Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(dtpBase1) + "' <> ' ' Then '" + Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(dtpBase1) + "' Else adelanto.fecha End  "
            + " and adelanto.fecha <= Case When '" + Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(dtpBase2) + "'  <> ' ' Then '" + Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(dtpBase2) + "' Else adelanto.fecha End  "
            + " and cxcdbfcliente.idcliente = Case When '" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text) + "' > 0 Then '" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text) + "'   Else cxcdbfcliente.idcliente End "
            + " and adelanto.idmoneda ='" + cmbBase1.SelectedValue + "'"
            + " order by secuencia");

            DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

            gridBase1.DataSource = ds.Tables[0];

            Fun_Visibilidad_Registros_Nulos(ckbBase1.Checked);

            Fun_Calcular_Totales();


        }
        private void Fun_Grid_Solo_Lectura()
        {
            gridBase1.ReadOnly = false;
            foreach (DataGridViewColumn c in gridBase1.Columns)
            {
                if (c.Index != (gridBase1.ColumnCount - 1))
                    c.ReadOnly = true;
            }
        }
        protected void Fun_Calcular_Totales()
        {
            double total = 0;
            int c = 0;
            
                foreach (DataGridViewRow row in gridBase1.Rows)
                {

                if (row.Visible)
                {
                    total = Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvtotal"].Value)) + total;
                    c++;
                }

            }
            Txttotal.Text = Convert.ToString(total);
            Txtcantidadregistros.Text =Convert.ToString(c);
        }
        private void cxcconregistro_Load(object sender, EventArgs e)
        {
            dtpBase1.Select();
            Fun_Grid_Solo_Lectura();
            Fun_Set_Nombre_Formulario("Consulta de Recibo de Ingreso", this);
            Rbnreciboingreso.Checked = true;
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(cmbBase1, "select idmoneda, abreviatura from gendbfmoneda");

        }
        public void Seleccionar_Grid()
        {
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            
            var checkheader = new CheckBoxHeaderCell();
            checkheader.OnCheckBoxHeaderClick += checkheader_OnCheckBoxHeaderClick;
            checkColumn.HeaderCell = checkheader;
            gridBase1.Columns.Add(checkColumn);
            gridBase1.Columns[""].Width = 25;
            
        }

        void checkheader_OnCheckBoxHeaderClick(CheckBoxHeaderCellEventArgs e)
        {
            if (gridBase1.Rows.Count > 0)
            {
                gridBase1.BeginEdit(true);
                foreach (DataGridViewRow item in gridBase1.Rows)
                {
                    if(item.Visible==true)
                    item.Cells[""].Value = e.IsChecked;

                }
                gridBase1.EndEdit();
            }

        }
        

        private void Fun_Visibilidad_Registros_Nulos(bool estado)
        {
            gridBase1.CurrentCell = null;
            CurrencyManager cm = (CurrencyManager)BindingContext[gridBase1.DataSource];
            cm.SuspendBinding();
            foreach (DataGridViewRow row in gridBase1.Rows)
            {
                if (Convert.ToInt64(row.Cells["dgvnulo"].Value) > 0)
                {
                    
                    row.Visible = estado;
                    if(gridBase1.Columns.Contains(""))
                    row.Cells[""].Value = false;
                    row.DefaultCellStyle.BackColor = Color.MistyRose;
                    
                }
            }
        }

        private void ckbBase1_CheckedChanged(object sender, EventArgs e)
        {
            Fun_Visibilidad_Registros_Nulos(ckbBase1.Checked);
            Fun_Calcular_Totales();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            MFConsulta_Cliente Consulta_Cliente = new MFConsulta_Cliente("=");
            if (Consulta_Cliente.ShowDialog() == DialogResult.OK)
            {
                Txtcodigocliente.Text = Convert.ToString(Consulta_Cliente.MainGrid.SelectedRows[0].Cells[1].Value);

                Fun_Buscar_Cliente();

            }
        }
        protected void Fun_Buscar_Cliente()
        {
            if (Txtcodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {

                DataSet ds = Txtcodigocliente._Dataset;
                Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();

              
            }
            else
            {

                Txtnombrecliente.Text = "";

            }
        }

        private void Txtcodigocliente_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Cliente();
        }

        private void txtMayuscula1_Validating(object sender, CancelEventArgs e)
        {
            if (txtMayuscula1.Text != "")
            {
                string opcion = "";

                if (cmbBase3.SelectedIndex == 0)
                {
                    if (Rbnreciboingreso.Checked)
                        opcion = "secuencia";
                    else opcion = "adelanto.secuencia";

                }
                else if (cmbBase3.SelectedIndex == 1)
                    opcion = "referencia";
                

                Txtcodigocliente.Text = "";
                string cmd = "";
                if(Rbnreciboingreso.Checked)
                cmd = queryconsultaing + opcion + " like '%" + txtMayuscula1.Text + "%'";
                else cmd = queryconsultadep + opcion + " like '%" + txtMayuscula1.Text + "%'";
                DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
                gridBase1.DataSource = ds.Tables[0];

                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["nulo"].ToString()) == true)
                        ckbBase1.Checked = true;
                    else
                        ckbBase1.Checked = false;
                }

                Fun_Calcular_Totales();
            }
        }

        private void Txtcodigocliente_TextChanged(object sender, EventArgs e)
        {
            if (Txtcodigocliente.Text == "")
                Txtnombrecliente.Text = "";
        }
        protected override void Presentar()
        {
            if (gridBase1.Rows.Count > 0)
            {
                base.Presentar();

                if (gridBase1.SelectedRows.Count > 0)
                {
                    cxcprereciboingreso Presenta_Registro = new cxcprereciboingreso();
                    Presenta_Registro.Rbnaplicardeposito.Checked = Rbnaplicardeposito.Checked;
                    Presenta_Registro.Rbnreciboingreso.Checked = Rbnreciboingreso.Checked;
                    Funciones_Duke4.Funciones.Fun_Habilitar_Control_Formulario(Presenta_Registro, false);

                    Presenta_Registro.Txtcobro.Text = gridBase1.SelectedRows[0].Cells["dgvsecuencia"].Value.ToString();
                    Presenta_Registro._secuencia = gridBase1.SelectedRows[0].Cells["dgvidcobro"].Value.ToString();
                    Presenta_Registro._nulo = Convert.ToBoolean(gridBase1.SelectedRows[0].Cells["dgvnulo"].Value.ToString());
                    Presenta_Registro.ShowDialog();
                }
                else
                    MessageBox.Show("Debe hacer selección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



            }
            else
                MessageBox.Show("Debe hacer selección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        protected override void ReImprimir()
        {
            if (gridBase1.Rows.Count >= 1)
            {
                Seleccionar_Grid();
                SetFormFunctionName("Seleccionando...");
                base.ReImprimir();
            }
            else
                MessageBox.Show("No hay registro para imprimir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        protected override void Imprimir()
        {

            if (CheckMade())
            {
                    gridBase1.ClearSelection();

                

                foreach (DataGridViewRow row in gridBase1.Rows)
                {

                    int pos = row.Cells[""].RowIndex;
                    if (Convert.ToBoolean(row.Cells[""].EditedFormattedValue))
                    {
                        GeneraReporte("Imprimir", pos, Convert.ToBoolean(gridBase1.Rows[pos].Cells["dgvnulo"].Value.ToString()));
                    }
                    
                    row.Cells[""].Value = false;
                    

                }
                

            }
            else
                MessageBox.Show("Debe hacer selección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }
        public bool CheckMade()
        {
            if (gridBase1.Columns.Contains(""))
            {
                foreach (DataGridViewRow row in gridBase1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[""].EditedFormattedValue))
                        return true;
                }
            }
            return false;
        }
        Enviar_Mail enviarcorreo = new Enviar_Mail();
        MailMessage mail = new MailMessage();

        protected override void AbrirOpcionEnviarCorreo()
        {
            enviarcorreo = new Enviar_Mail();
            mail = new MailMessage();

            if (CheckMade())
            {
                base.AbrirOpcionEnviarCorreo();
               
                if (enviarcorreo.ShowDialog() == DialogResult.OK)
                {
                    SetFormFunctionName("Enviando...");

                    //foreach (DataGridViewRow row in refrescarcon.MainGrid.Rows)
                    //{

                    //    int pos = row.Cells[""].RowIndex;
                    //    if (Convert.ToBoolean(row.Cells[""].EditedFormattedValue))
                    //    {
                    //        GeneraReporte("Enviar", pos, Convert.ToInt16(row.Cells["nulo1"].Value));

                    //    }

                    //}

                    //InvocarFormulario(enviarcorreo);
                }
            }
            else
                MessageBox.Show("Debe hacer selección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        protected override void HabilitarGridEnviarCorreo()
        {
            if (gridBase1.Rows.Count >= 1)
            {
                base.HabilitarGridEnviarCorreo();
                Seleccionar_Grid();
                SetFormFunctionName("Seleccionando...");


            }
            else
                MessageBox.Show("Debe hacer seleccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }


        protected void GeneraReporte(string opcion, int pos, bool nulo)
        {
            string ruta = "";
            string nombredoc = "";

            if (Rbnreciboingreso.Checked)
            {
                Reporte_General.CXC.cxcrepcobro01 Reporte_Recibo_Ingreso = new Reporte_General.CXC.cxcrepcobro01();

                if (nulo == false)
                    Reporte_Recibo_Ingreso._Letrero_Copia = "COPIA";
                else
                    Reporte_Recibo_Ingreso._Letrero_Copia = "<<NULO>> COPIA";

                Reporte_Recibo_Ingreso._id = gridBase1.Rows[pos].Cells["dgvidcobro"].Value.ToString();
                Reporte_Recibo_Ingreso.Fun_Reporte();

                if (opcion == "Imprimir")
                {
                    Reporte_Recibo_Ingreso.Show();

                }
                else if (opcion == "Enviar")
                {

                    nombredoc = gridBase1.Rows[pos].Cells["dgvsecuencia"].Value.ToString() + "-" + System.DateTime.Now.ToString("yyyyMMdd");
                    ruta = Funciones_Duke4.Funciones.Fun_Exportar_aPDF(@"C:\Reporte_Duke4\Reporte_CxC\Registros_Facturas\", nombredoc + ".pdf", Reporte_Recibo_Ingreso.reportViewer1);
                    mail.Attachments.Add(new Attachment(ruta));
                }
            }
            else
            {
                Reporte_General.CXC.cxcrepcobroadelantadodetalle01 Reporte_Recibo_Ingreso = new Reporte_General.CXC.cxcrepcobroadelantadodetalle01();

                if (nulo == false)
                    Reporte_Recibo_Ingreso._Letrero_Copia = "COPIA";
                else
                    Reporte_Recibo_Ingreso._Letrero_Copia = "<<NULO>> COPIA";

                Reporte_Recibo_Ingreso._id = gridBase1.Rows[pos].Cells["dgvidcobro"].Value.ToString();
                Reporte_Recibo_Ingreso.Fun_Reporte();

                if (opcion == "Imprimir")
                {
                    Reporte_Recibo_Ingreso.Show();

                }
                else if (opcion == "Enviar")
                {

                    nombredoc = gridBase1.Rows[pos].Cells["dgvsecuencia"].Value.ToString() + "-" + System.DateTime.Now.ToString("yyyyMMdd");
                    ruta = Funciones_Duke4.Funciones.Fun_Exportar_aPDF(@"C:\Reporte_Duke4\Reporte_CxC\Registros_Facturas\", nombredoc + ".pdf", Reporte_Recibo_Ingreso.reportViewer1);
                    mail.Attachments.Add(new Attachment(ruta));
                }
            }
        }
        protected override void Cancelar()
        {
            if (gridBase1.SelectedRows.Count > 0)
            {
                
                    Anular_Documento cancel = new Anular_Documento();
                    Anular_Documento.tipoanulacion = FormTitle.Text;

                    cancel.secuencia = gridBase1.SelectedRows[0].Cells["dgvsecuencia"].Value.ToString();

                if (Rbnreciboingreso.Checked)
                {
                    cancel.tabla = "cxcdbfcobro";
                    cancel.campo = "idcobro";
                    cancel.query = "update cxcdbfregistro set balance=balance + cxcdbfcobrodetalle.monto from cxcdbfregistro "
                        + " inner join cxcdbfcobrodetalle on cxcdbfcobrodetalle.idregistro = cxcdbfregistro.idregistro "
                        + " inner join cxcdbfcobro on cxcdbfcobrodetalle.idcobro=cxcdbfcobro.idcobro where cxcdbfcobro.idcobro = '" + gridBase1.SelectedRows[0].Cells["dgvidcobro"].Value.ToString() + "'";

                    cancel.id = gridBase1.SelectedRows[0].Cells["dgvidcobro"].Value.ToString();
                    cancel.nombre = gridBase1.SelectedRows[0].Cells["dgvnombre"].Value.ToString();
                    cancel.datos();
                    string cmd = string.Format("SELECT * FROM cxcdbfcobro where idcobro = '" + gridBase1.SelectedRows[0].Cells["dgvidcobro"].Value.ToString() + "' and nulo =1");
                    DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
                    if (ds.Tables[0].Rows.Count == 0)
                    {

                        if (cancel.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("Registro Cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gridBase1.SelectedRows[0].Cells["dgvnulo"].Value = 1;
                            gridBase1.SelectedRows[0].DefaultCellStyle.BackColor = Color.MistyRose;

                        }
                    }
                    else MessageBox.Show("El documento " + gridBase1.SelectedRows[0].Cells["dgvsecuencia"].Value.ToString() + Environment.NewLine + "de " +
                      gridBase1.SelectedRows[0].Cells["dgvnombre"].Value.ToString() + Environment.NewLine + "Ya está cancelado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }else
                {
                    //cancel.tabla = "cxcdbfcobroadelantadodetalle";
                    //cancel.campo = "secuencia";
                    //cancel.query = "update cxcdbfregistro set balance=balance + cxcdbfcobroadelantadodetalle.total from cxcdbfregistro "
                    //+ "inner join cxcdbfcobroadelantadodetalle on cxcdbfcobroadelantadodetalle.idfactura = cxcdbfregistro.idregistro "
                    //+ "where cxcdbfregistro.idregistro = '" + refrescarcon.MainGrid.SelectedRows[0].Cells["idregistrofac1"].Value.ToString() + "'"
                    //+ "update cxcdbfcobroadelantado set balance=balance + cxcdbfcobroadelantadodetalle.total from cxcdbfcobroadelantado "
                    //+ "inner join cxcdbfcobroadelantadodetalle on cxcdbfcobroadelantadodetalle.referencia = cxcdbfcobroadelantado.numero "
                    //+ "where cxcdbfcobroadelantadodetalle.referencia = '" + refrescarcon.MainGrid.SelectedRows[0].Cells["numero1"].Value.ToString() + "'";

                    //cancel.id = gridBase1.SelectedRows[0].Cells["dgvidcobro"].Value.ToString();
                    //cancel.nombre = gridBase1.SelectedRows[0].Cells["dgvnombre"].Value.ToString();
                    //cancel.datos();
                    //string cmd = string.Format("SELECT * FROM cxcdbfcobroadelantadodetalle where idcobro = '" + gridBase1.SelectedRows[0].Cells["dgvidcobro"].Value.ToString() + "' and nulo =1");
                    //DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
                    //if (ds.Tables[0].Rows.Count == 0)
                    //{

                    //    if (cancel.ShowDialog() == DialogResult.OK)
                    //    {
                    //        MessageBox.Show("Registro Cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        gridBase1.SelectedRows[0].Cells["dgvnulo"].Value = 1;
                    //        gridBase1.SelectedRows[0].DefaultCellStyle.BackColor = Color.MistyRose;

                    //    }
                    //}
                    //else MessageBox.Show("El documento " + gridBase1.SelectedRows[0].Cells["dgvsecuencia"].Value.ToString() + Environment.NewLine + "de " +
                    //  gridBase1.SelectedRows[0].Cells["dgvnombre"].Value.ToString() + Environment.NewLine + "Ya está cancelado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
                MessageBox.Show("Debe hacer selección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



        }
        private void gridBase1_Sorted(object sender, EventArgs e)
        {
            this.gridBase1.FirstDisplayedCell = this.gridBase1.CurrentCell;
        }

        private void gridBase1_Sorted_1(object sender, EventArgs e)
        {
            Fun_Visibilidad_Registros_Nulos(ckbBase1.Checked);

            Fun_Calcular_Totales();
        }
        protected override void Retornar()
        {

            base.Retornar();
            if (!opcionactiva)
            {

                this.Close();
            }
            else
            {
                limpiapanel();
                opcionactiva = false;
                SetVisible();
                opened = false;
                RemoveSeleccionColumn();
                this.Focus();

            }
            
           

        }

        public void RemoveSeleccionColumn()
        {
            if (gridBase1.Columns.Contains(""))
                gridBase1.Columns.Remove("");
        }
        
        private void Rbnaplicardeposito_CheckedChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
    }
}
