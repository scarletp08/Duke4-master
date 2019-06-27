﻿using Duke4._newDesign;
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
    public partial class _conVmenu : MainBar
    {
        public _conVmenu()
        {
            InitializeComponent();
            string cmd = string.Format(queryconsulta + " and cxcdbfregistro.nulo=0 and cast(fecha as date) = cast(getdate() as date) order by secuencia");
            DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
            gridBase1.DataSource = ds.Tables[0];
            Fun_Calcular_Totales();
        }

        string queryconsulta = "SELECT   secuencia, fecha,cxcdbfregistro.referencia,ncf,nombre,idvendedor,totalitbis,total,idregistro, dbo.cxcdbfregistro.nulo, tiporegistro, '' as entrada "
        + "FROM dbo.cxcdbfregistro "
        + "inner JOIN dbo.cxcdbfcliente on cxcdbfcliente.idcliente= cxcdbfregistro.idcliente "
        + "where cxcdbfregistro.tiporegistro=1 ";

        public void SetFormFunctionName(string value)
        {
            LblFunctionName.Text = value;
        }

        string mapfilter()
        {
            if (cmdfilter.SelectedIndex == 0)
                return "secuencia";
            else if (cmdfilter.SelectedIndex == 1)
                return "ncf";
            else
                return "cxcdbfregistro.referencia";
        }


        void Buscar()
        {
            // txtfilter.Text = "";
            string cmd = string.Format(queryconsulta + " and cxcdbfregistro.fecha >= Case When '" + Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(dtpBase1) + "' <> ' ' Then '" + Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(dtpBase1) + "' Else cxcdbfregistro.fecha End  "
            + " and cxcdbfregistro.fecha <= Case When '" + Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(dtpBase2) + "'  <> ' ' Then '" + Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(dtpBase2) + "' Else cxcdbfregistro.fecha End  "
            + " and cxcdbfcliente.idcliente = Case When '" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text) + "' > 0 Then '" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text) + "'   Else cxcdbfcliente.idcliente End ");
            if (cmbBase1.SelectedIndex > 0)
                cmd += " and idmoneda ='" + cmbBase1.SelectedValue + "'";
            if (txtfilter.Text != "")
                cmd += " and " + mapfilter() + " = '" + txtfilter.Text + "'";

            cmd += " order by secuencia";

            DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
            gridBase1.DataSource = ds.Tables[0];

            if (ds.Tables[0].Rows.Count == 0)
                Mensajes.Msgb_Datos_Limites();
            else
            {
                Fun_Visibilidad_Registros_Nulos(ckbBase1.Checked);
                Fun_Calcular_Totales();
            }
        }

        void SetVisible(bool val)
        {
            BtnBuscar.Visible = BtnPresentar.Visible = BtnReimprimir.Visible = BtnCorreo.Visible = BtnCancelar.Visible = BtnModificar.Visible = BtnCodificar.Visible = val;
           BtnImprimir.Visible = BtnEnviar.Visible = !val;
        }

        string menuOpcion = "";
        void SetVisible()
        {
            BtnBuscar.Visible = BtnPresentar.Visible = BtnReimprimir.Visible = BtnCorreo.Visible = BtnCancelar.Visible = BtnModificar.Visible = BtnCodificar.Visible = false;
            BtnImprimir.Visible = BtnEnviar.Visible = false;

            if (menuOpcion == "REIMPRIMIR")
                BtnImprimir.Visible = true;
            else if (menuOpcion == "ENVIARCORREO1")
                BtnEnviar.Visible = true;
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
            double itbis = 0, total = 0;
            int c = 0;

            foreach (DataGridViewRow row in gridBase1.Rows)
            {
                if (row.Visible && Convert.ToInt64(row.Cells["dgvnulo"].Value) == 0)
                {
                    itbis = Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvitbis"].Value)) + itbis;
                    total = Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvtotal"].Value)) + total;
                    c++;
                }
            }
            Txtitbis.Text = Convert.ToString(itbis);
            Txttotal.Text = Convert.ToString(total);
            if (ckbBase1.Checked)
                Txtcantidadregistros.Text = Convert.ToString(gridBase1.Rows.Count);
            else
                Txtcantidadregistros.Text = Convert.ToString(c);
        }

        private void cxcconregistro_Load(object sender, EventArgs e)
        {
            dtpBase1.Select();
            Txtcantidadregistros.TextAlign = HorizontalAlignment.Left;
            LblFunctionName.BringToFront();
            SetVisible(true);
            LblFunctionName.Text = "";
            LblFunctionName.ForeColor = Color.White;
            LblFunctionName.BackColor = Color.MidnightBlue;
            Fun_Grid_Solo_Lectura();
            Fun_Set_Nombre_Formulario("Consulta de Factura", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(cmbBase1, "select idmoneda, abreviatura from gendbfmoneda");
            MainGrid.Rows.Add("112-01-04", "CXC US", "236.00", "0.00");
            MainGrid.Rows.Add("112-01-05", "PRIMA CXC ", "10,384.00", "0.00");
            MainGrid.Rows.Add("112-01-02", "CAJA CHICA", "0.00", "1,620.00");
            MainGrid.Rows.Add("411", "INGRESOS POR VENTAS CREDITO", "0.00", "9,000.00");
        }

        public void Seleccionar_Grid()
        {
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();

            var checkheader = new CheckBoxHeaderCell();
            checkheader.OnCheckBoxHeaderClick += checkheader_OnCheckBoxHeaderClick;
            checkColumn.HeaderCell = checkheader;
            gridBase1.Columns.Add(checkColumn);
            gridBase1.Columns[""].FillWeight = 30;
            gridBase1.Columns[""].SortMode = DataGridViewColumnSortMode.Automatic;
        }

        void checkheader_OnCheckBoxHeaderClick(CheckBoxHeaderCellEventArgs e)
        {
            if (gridBase1.Rows.Count > 0)
            {
                gridBase1.BeginEdit(true);
                foreach (DataGridViewRow item in gridBase1.Rows)
                {
                    if (item.Visible == true)
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
                    if (gridBase1.Columns.Contains(""))
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
                Txtnombrecliente.Text = "";
        }

        private void Txtcodigocliente_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Cliente();
        }

        private void txtMayuscula1_Validating(object sender, CancelEventArgs e)
        {
            if (txtfilter.Text != "")
            {
                string opcion = "";

                if (cmdfilter.SelectedIndex == 0)
                    opcion = "secuencia";
                else if (cmdfilter.SelectedIndex == 1)
                    opcion = "ncf";
                else if (cmdfilter.SelectedIndex == 2)
                    opcion = "cxcdbfregistro.referencia";

                Txtcodigocliente.Text = "";
                string cmd = queryconsulta + " and " + opcion + " like '%" + txtfilter.Text.Trim() + "%'";
                DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
                gridBase1.DataSource = ds.Tables[0];

                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["nulo"].ToString()))
                        ckbBase1.Checked = true;
                    else
                        ckbBase1.Checked = false;

                    Fun_Calcular_Totales();
                }
                else
                {
                    Mensajes.Msgb_Datos_Limites();
                }



              
            }
        }

        private void Txtcodigocliente_TextChanged(object sender, EventArgs e)
        {
            if (Txtcodigocliente.Text == "")
                Txtnombrecliente.Text = "";
        }
        void Presentar()
        {
            if (gridBase1.Rows.Count > 0)
            {
                if (gridBase1.SelectedRows.Count > 0)
                {
                    cxcpreregistro Presenta_Registro = new cxcpreregistro();
                    Funciones_Duke4.Funciones.Fun_Habilitar_Control_Formulario(Presenta_Registro, false);

                    Presenta_Registro.Txtregistro.Text = gridBase1.SelectedRows[0].Cells["dgvsecuencia"].Value.ToString();
                    Presenta_Registro._secuencia = gridBase1.SelectedRows[0].Cells["dgvidregistro"].Value.ToString();
                    Presenta_Registro._nulo = Convert.ToBoolean(gridBase1.SelectedRows[0].Cells["dgvnulo"].Value.ToString());
                    Presenta_Registro.ShowDialog();
                }
                else
                    MessageBox.Show("Debe hacer selección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Debe hacer selección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        void ReImprimir()
        {
            if (gridBase1.Rows.Count >= 1)
            {
                Seleccionar_Grid();
                SetFormFunctionName("Seleccionando para Imprimir...");
                menuOpcion = "REIMPRIMIR";
                SetVisible();
            }
            else
                MessageBox.Show("No hay registro para imprimir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        void Imprimir()
        {
            if (CheckMade())
            {
                gridBase1.ClearSelection();
                GenerateIdForRepo();
                GeneraReporte("Imprimir", idregistro);
                RemoveSeleccionColumn();
                SetFormFunctionName("");
                SetVisible(true);
            }
            else
                MessageBox.Show("Debe hacer selección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        int i = 0;
        public bool CheckMade()
        {
            i = 0;
            if (gridBase1.Columns.Contains(""))
            {
                while (i < gridBase1.Rows.Count && i != -1)
                {
                    if (Convert.ToBoolean(gridBase1.Rows[i].Cells[""].EditedFormattedValue))
                        i = -1;
                    else
                        i++;
                }
                if (i == -1)
                    return true;
            }
            return false;
        }
        Enviar_Mail enviarcorreo = new Enviar_Mail();
        MailMessage mail = new MailMessage();

        //void AbrirOpcionEnviarCorreo()
        //{
        //    enviarcorreo = new Enviar_Mail();
        //    mail = new MailMessage();

        //    if (CheckMade())
        //    {
        //        //  base.AbrirOpcionEnviarCorreo();
        //        if (enviarcorreo.ShowDialog() == DialogResult.OK)
        //        {
        //            //SetFormFunctionName("Enviando...");
        //            //foreach (DataGridViewRow row in refrescarcon.MainGrid.Rows)
        //            //{
        //            //    int pos = row.Cells[""].RowIndex;
        //            //    if (Convert.ToBoolean(row.Cells[""].EditedFormattedValue))
        //            //    {
        //            //        GeneraReporte("Enviar", pos, Convert.ToInt16(row.Cells["nulo1"].Value));
        //            //    }
        //            //}
        //            //InvocarFormulario(enviarcorreo);
        //        }
        //    }
        //    else
        //        MessageBox.Show("Debe hacer selección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //}
        //void HabilitarGridEnviarCorreo()
        //{
        //    if (gridBase1.Rows.Count >= 1)
        //    {
        //        //base.HabilitarGridEnviarCorreo();
        //        Seleccionar_Grid();
        //        SetFormFunctionName("Seleccionando...");


        //    }
        //    else
        //        MessageBox.Show("Debe hacer selección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



        //}


        protected void GeneraReporte(string opcion, string id)
        {
            string ruta = "";
            string nombredoc = "";
            _newDesign.Report.Form1 Reporte_Registro = new _newDesign.Report.Form1();

            Reporte_Registro.idRegistro = id; //",2,3,";
                                              //gridBase1.Rows[pos].Cells["dgvidregistro"].Value.ToString();
            Reporte_Registro.Fun_Reporte();

            if (opcion == "Imprimir")
            {
                Reporte_Registro.Show();

            }
            else if (opcion == "Enviar")
            {
                nombredoc = Reporte_Registro.idRegistro; //gridBase1.Rows[pos].Cells["dgvsecuencia"].Value.ToString() + "-" + DateTime.Now.ToString("yyyyMMdd");
                ruta = Funciones_Duke4.Funciones.Fun_Exportar_aPDF(@"C:\Reporte_Duke4\Reporte_CxC\Registros_Facturas\", nombredoc + ".pdf", Reporte_Registro.reportViewer1);
                mail.Attachments.Add(new Attachment(ruta));
            }
        }
        void Cancelar()
        {
            if (gridBase1.SelectedRows.Count > 0)
            {
                _cancelar cancel = new _cancelar();
                // Anular_Documento cancel = new Anular_Documento();
                _cancelar.tipoanulacion = "Factura"; // FormTitle.Text;
                cancel.secuencia = gridBase1.SelectedRows[0].Cells["dgvsecuencia"].Value.ToString();

                cancel.tabla = "cxcdbfregistro";
                cancel.campo = "idregistro";
                cancel.id = gridBase1.SelectedRows[0].Cells["dgvidregistro"].Value.ToString();
                cancel.nombre = gridBase1.SelectedRows[0].Cells["dgvnombre"].Value.ToString();
                cancel.datos();
                string cmd = string.Format("SELECT * FROM cxcdbfregistro where idregistro = '" + gridBase1.SelectedRows[0].Cells["dgvidregistro"].Value.ToString() + "' ");
                DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["nulo"].ToString()) == false)
                    {
                        if (Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(ds.Tables[0].Rows[0]["balance"].ToString()) != Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(ds.Tables[0].Rows[0]["total"].ToString()))
                        {
                            Mensajes.Msgb_Tiene_Movimiento_No_Cancelar();
                        }
                        else if (cancel.ShowDialog() == DialogResult.OK)
                        {
                            MessageBox.Show("Registro Cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            gridBase1.SelectedRows[0].Cells["dgvnulo"].Value = 1;
                            gridBase1.SelectedRows[0].DefaultCellStyle.BackColor = Color.MistyRose;
                        }
                    }
                    else
                        MessageBox.Show("El documento " + gridBase1.SelectedRows[0].Cells["dgvsecuencia"].Value.ToString() + Environment.NewLine + "de " +
               gridBase1.SelectedRows[0].Cells["dgvnombre"].Value.ToString() + Environment.NewLine + "Ya está cancelado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


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
        void Retornar()
        {
            //base.Retornar();
            if (BtnBuscar.Visible)
                this.Close();
            else
            {
                SetFormFunctionName("");
                SetVisible(true);
                RemoveSeleccionColumn();
                this.Focus();
            }

        }

        public void RemoveSeleccionColumn()
        {
            if (gridBase1.Columns.Contains(""))
                gridBase1.Columns.Remove("");
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            Retornar();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCodificar_Click(object sender, EventArgs e)
        {
            _codificar codificar = new _codificar();
            codificar.ShowDialog();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (gridBase1.SelectedRows.Count > 0)
            {
                _conModify form = new _conModify();
                form.idregistro = Convert.ToInt32(gridBase1.SelectedRows[0].Cells["dgvidregistro"].Value.ToString());
                form.secuencia = gridBase1.SelectedRows[0].Cells["dgvsecuencia"].Value.ToString();
                form.CompleteData();
                form.CompleteName();
                form.ShowDialog();
            }
            else
                MessageBox.Show("Debe hacer selección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //SetFormFunctionName("Cancelando...");
            //SetVisible();
            Cancelar();
        }

        private void GenerateIdForRepo()
        {
            idregistro = ",";
            attatchments = "";
            foreach (DataGridViewRow row in gridBase1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[""].EditedFormattedValue))
                {
                    attatchments += row.Cells["dgvsecuencia"].Value.ToString() + ", ";
                    idregistro += row.Cells["dgvidregistro"].Value.ToString() + ",";
                }
                row.Cells[""].Value = false;
            }
        }

        string attatchments = "", idregistro = "";
        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (CheckMade())
            {
                GenerateIdForRepo();
                GeneraReporte("Enviar", idregistro);
                Enviar_Mail enviarform = new Enviar_Mail();
                enviarform.attachment = attatchments.Substring(0, attatchments.Length - 2);
                enviarform.mail = mail;
                if (enviarform.ShowDialog() == DialogResult.OK)
                {
                    RemoveSeleccionColumn();
                    SetVisible(true);
                    SetFormFunctionName("");
                }
            }
            else
                MessageBox.Show("Debe hacer selección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void BtnCorreo_Click(object sender, EventArgs e)
        {
            if (gridBase1.Rows.Count >= 1)
            {
                Seleccionar_Grid();
                menuOpcion = "ENVIARCORREO1";
                SetFormFunctionName("Preparando para enviar correo...");
                SetVisible();
            }
            else
                MessageBox.Show("No hay registro para imprimir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SetVisible();
        }

        private void BtnReimprimir_Click(object sender, EventArgs e)
        {
            ReImprimir();
        }

        private void BtnPresentar_Click(object sender, EventArgs e)
        {
            Presentar();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void BtnPresentar_MouseHover(object sender, EventArgs e)
        {

        }

        private void gridBase1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridBase1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText(gridBase1[e.ColumnIndex, e.RowIndex].Value.ToString().Trim());
        }

        private void txtfilter_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void menuBase1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ckbBase2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBase2.Checked)
                this.Size = new Size(955, 562);
            else
                this.Size = new Size(955, 402);
        }

        private void _conVmenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void lblBase3_Click(object sender, EventArgs e)
        {

        }
    }
}
