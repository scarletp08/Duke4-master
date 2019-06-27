using Duke4.Logistica;
using Funciones_Duke4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Duke4.Opcion_Pago.Proceso
{
    public partial class genpropago : MainBar
    {
      
        public genpropago(string monto, string cliente, int idprograma)
        {
            InitializeComponent();
            montoT = monto;
            codcliente = cliente;
            idprog = idprograma;
            montototal = montoT;

        }

        public static string montoT;
        string montototal;
        string codcliente;
        int idprog = 0;

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DataSet ds = new DataSet();

        //private bool consultacliente()
        //{
        //    if (moduloT == "CXC")
        //    {
        //        string cmd3 = "SELECT nocheque from cxcdbfcliente where idcliente ='" + GlobalMethods.conviertetxbnumero(codcliente) + "' and nocheque=0";
        //        DataSet ds3 = sps.funciones.conecta(cmd3);
        //        if (ds3.Tables[0].Rows.Count > 0)
        //        {
        //            return true;
        //        }
        //        else return false;
        //    }
        //    else
        //        return true;
            
        //}
        private void Pagos_Load(object sender, EventArgs e)
        {
            
            Fun_Set_Nombre_Formulario("Opciones de Pagos", this);
            Logistica.FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbopcion, "select idtipopago, descripcion from gendbftipopago where nulo=0");
            Cmbopcion.SelectedIndex = 1;
            //string cmd3 = "SELECT nocheque from cxcdbfcliente where idcliente ='" + GlobalMethods.conviertetxbnumero(codcliente) + "' and nocheque=0";
            //DataSet ds3 = sps.funciones.conecta(cmd3);


            //if (Cmbopcion.Items.Count > 0)
            //    Cmbopcion.SelectedIndex = 0;


        }
        protected void InvocarFormulario(Form formulario)
        {
            panel1.Controls.Clear();
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.TopLevel = false;

            panel1.Controls.Add(formulario);

            formulario.Show();
        }

       Cobro_Efectivo efectivo;
       Cobro_Cheque cheque;
       Cobro_Tarjeta tarjeta;
       Cobro_Transferencia transferencia;

        public int valorcombo;
        private void Cmbopcion_SelectedIndexChanged(object sender, EventArgs e)
        {
             

            Lblalerta.Text = "";
            valorcombo = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Cmbopcion.SelectedValue.ToString());


            string cmd3 = "SELECT * from gendbftipopago where idtipopago ='" + valorcombo + "' and nulo=0";
            DataSet ds3 = FuncionesSQL.Fun_Sql_Ejecutar(cmd3);

            numcheque = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds3.Tables[0].Rows[0]["cheque"].ToString());
            banco = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds3.Tables[0].Rows[0]["banco"].ToString());
            autorizacion = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds3.Tables[0].Rows[0]["autorizacion"].ToString());
            numtarjeta = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds3.Tables[0].Rows[0]["tarjeta"].ToString());
            fechaven = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds3.Tables[0].Rows[0]["fechaven"].ToString());
            cvc = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds3.Tables[0].Rows[0]["cvc"].ToString());
            aprobacion = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds3.Tables[0].Rows[0]["aprobacion"].ToString());
            cuentaban = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds3.Tables[0].Rows[0]["cuentaban"].ToString());
            documento = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds3.Tables[0].Rows[0]["documento"].ToString());
            moneda = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds3.Tables[0].Rows[0]["moneda"].ToString());
            tipotarjeta = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds3.Tables[0].Rows[0]["tipotarjeta"].ToString());

            if (Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(montototal) == 0)
            montototal = "";

            if (valorcombo == 1)
            {
                efectivo = new Cobro_Efectivo(montototal);
                InvocarFormulario(efectivo);
            }
            else if (valorcombo == 2)
            {
                //if (consultacliente())
                //{
                    cheque = new Cobro_Cheque(montototal);
                    InvocarFormulario(cheque);
                //}
                //else
                //{
                //    MessageBox.Show("No puede registrar cheques a este cliente");
                //    Cmbopcion.SelectedIndex = 0;
                //}
            }
            else  if (valorcombo == 3)
            {
                tarjeta = new Cobro_Tarjeta(montototal);
                InvocarFormulario(tarjeta);
            }
            else if (valorcombo == 4)
            {
                transferencia = new Cobro_Transferencia(montototal);
                InvocarFormulario(transferencia);
            }
        }

       public string aplicar = "";

        int numcheque = 0, banco = 0, autorizacion = 0, numtarjeta = 0, fechaven = 0, cvc = 0, aprobacion = 0, cuentaban = 0, documento = 0, moneda = 0, tipotarjeta =0;
          
        private void Pagos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                this.Close();
            }


        }

        private void valorseleccionado()
        {
            if (valorcombo == 1)
            {

                aplicar = efectivo.TxtMonto.Text;
            }
            else if (valorcombo == 2)
            {

                aplicar = cheque.TxtMonto.Text;
            }
            else if (valorcombo == 3)
            {
                aplicar = tarjeta.TxtMonto.Text;
            }
            else if (valorcombo == 4)
            {
                aplicar = transferencia.TxtMonto.Text;
            }
        }

        private void BtnElegir_Click(object sender, EventArgs e)
        {
            
            if (MainGrid.Rows.Count > 0 && Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(decimalTextInput1.Text) == Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(montoT))
            {
                DialogResult = DialogResult.OK;
                llenaxmlpago();
                this.Close();
            }else if(Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(decimalTextInput1.Text)< Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(montoT))
                Lblalerta.Text = "Seleccione el monto a pagar   ";

            else Lblalerta.Text = "No hay Datos para procesar   ";
        }
    
        protected bool procesapago(Control[] array)
        {
            bool valida = false;

            if (Funciones.Fun_Validar_Campos_Vacios(array) )
            {

                Lblalerta.Text = Mensajes.Stg_Campos_EnBlanco;
                valida = true;
            }
            else Lblalerta.Text = "";

            return valida;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            valorseleccionado();
            bool validafechaven = true;

            if (Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(aplicar) > 0)
            {
                Control[] array;
                bool valida = false;
                if (valorcombo == 1)
                {
                    array = new Control[] { efectivo.TxtMonto };
                    valida = procesapago(array);


                }
                else if (valorcombo == 2)
                {
                    array = new Control[4];
                    array[0] = cheque.TxtMonto;

                    if (numcheque == 1)
                        array[1] = cheque.TxtNoCK;

                    if (autorizacion == 1)
                        array[2] = cheque.Txtautorizacion;

                    if (banco == 1)
                        array[3] = cheque.CbBanco;

                    valida = procesapago(array);
                }
                else if (valorcombo == 3)
                {
                    array = new Control[7];
                    array[0] = tarjeta.TxtMonto;

                    if (banco == 1)
                        array[1] = tarjeta.CbBanco;

                    if (numtarjeta == 1)
                        array[2] = tarjeta.TxtNoTarjeta;

                    if (cvc == 1)
                        array[3] = tarjeta.Txtcvc;

                    if (fechaven == 1)
                        array[4] = tarjeta.Mkbfechaven;

                    if (tipotarjeta == 1)
                        array[5] = tarjeta.CbTipo;

                    if (aprobacion == 1)
                        array[6] = tarjeta.Txtaprobacion;

                    valida = procesapago(array);

                   // validafechaven = spsfunciones.funciones.maskvalidammdd(tarjeta.Mkbfechaven);
                    
                }
                else if (valorcombo == 4)
                {
                    array = new Control[7];
                    array[0] = transferencia.TxtMonto;

                    if (banco == 1)
                        array[1] = transferencia.CbBanco;

                    if (documento == 1)
                        array[2] = transferencia.Txtdocumento;

                    valida = procesapago(array);

                }
                if (validafechaven)
                { 
                    if (valida == false)
                {
                        if (Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(montoT) >= Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(decimalTextInput1.Text) + Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(aplicar))
                        {

                            // MainGrid.Rows.Add(MainGrid.Rows.Count + 1, Cmbopcion.Text, aplicar, Cmbopcion.SelectedValue, numcheque1, banco1, autorizacion1, numtarjeta1, fechaven1, cvc1, aprobacion1, cuentaban1, documento1, moneda1, tipotarjeta1);
                            if (!sumatipopago())
                            {
                                if (valorcombo == 1)
                                    MainGrid.Rows.Add(MainGrid.Rows.Count + 1, Cmbopcion.Text, aplicar, Cmbopcion.SelectedValue, "", "", "", "", "", "", "", "", "", "", "");
                                else if (valorcombo == 2)
                                    MainGrid.Rows.Add(MainGrid.Rows.Count + 1, Cmbopcion.Text, aplicar, Cmbopcion.SelectedValue, cheque.TxtNoCK.Text, cheque.CbBanco.SelectedValue, cheque.Txtautorizacion.Text, "", "", "", "", "", "", "", "");
                                else if (valorcombo == 3)
                                MainGrid.Rows.Add(MainGrid.Rows.Count + 1, Cmbopcion.Text, aplicar, Cmbopcion.SelectedValue, "", tarjeta.CbBanco.SelectedValue, "", tarjeta.TxtNoTarjeta.Text, tarjeta.Mkbfechaven.Text, tarjeta.Txtcvc.Text, tarjeta.Txtaprobacion.Text, "", "", "", tarjeta.CbTipo.SelectedValue);
                                      
                                   // MainGrid.Rows.Add(MainGrid.Rows.Count + 1, Cmbopcion.Text, aplicar, Cmbopcion.SelectedValue, "", tarjeta.CbBanco.SelectedValue, "", tarjeta.TxtNoTarjeta.Text, tarjeta.Mkbfechaven, tarjeta.Txtcvc, tarjeta.Txtaprobacion, "", "", "", tarjeta.CbTipo.SelectedValue);
                            }

                                decimalTextInput1.Text = Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(decimalTextInput1.Text) + Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(aplicar) + "";
                                if (Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(montototal) > 0)
                                    montototal = Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(montoT) - Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(decimalTextInput1.Text) + "";
                             }

                    }
                    else MessageBox.Show("El monto a pagar no debe ser mayor que el total de la factura");
                }
                else
                    Lblalerta.Text = Mensajes.Stg_Campos_EnBlanco;


            }
            }
        

        public string cmd2 = "";

        protected bool sumatipopago()
        {
            bool valida = false;
            if(MainGrid.Rows.Count>0)
            foreach (DataGridViewRow item in MainGrid.Rows)
            {
                    if (Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(item.Cells[3].Value.ToString()) == Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Cmbopcion.SelectedValue.ToString()))
                {  item.Cells[2].Value = Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(item.Cells[2].Value.ToString()) + Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(aplicar);
                   valida = true;
                }
            }

            return valida;
        }
        protected void llenaxmlpago()
        {
            string encabezado = "";
            string detalle = "";
            string cierre = "";
                     
            encabezado = "<Pagos total =\"" + Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(decimalTextInput1.Text)
              + "\"> <Facturas>";

            foreach (DataGridViewRow item in MainGrid.Rows)
            {
                int pos = item.Cells[0].RowIndex;

                        detalle = detalle + "<Factura idtipopago =\"" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(item.Cells[3].Value + "")
           + "\" idbanco =\"" + Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(item.Cells[5].Value + "")
           + "\" cheque =\"" + Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(item.Cells[4].Value + "")
           + "\" autorizacion =\"" + item.Cells[6].Value
           + "\" tarjeta =\"" + item.Cells[7].Value
           + "\" fechaven =\"" + item.Cells[8].Value
           + "\" cvc =\"" + Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(item.Cells[9].Value + "")
           + "\" aprobacion =\"" + item.Cells[10].Value
           + "\" idcuenta =\"" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(item.Cells[11].Value + "")
           + "\" documento =\"" + item.Cells[12].Value
           + "\" moneda =\"" + item.Cells[13].Value
           + "\" monto =\"" + Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(item.Cells[2].Value + "")
           + "\" codigo =\"" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(item.Cells[0].Value + "")
           + "\" tipotarjeta =\"" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(item.Cells[14].Value + "")

           + "\"/>";
                    

                
            }

            cierre = "</Facturas> </Pagos>";

            cmd2 = encabezado + detalle + cierre;
        }
    }
}
