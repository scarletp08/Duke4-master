
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.Opcion_Pago.Proceso
{
    public partial class Cobro_Efectivo : MainPanel
    {
        string montoT = "";
        public Cobro_Efectivo(string monto)
        {
            InitializeComponent();
            montoT = monto;
            TxtMonto.Text = monto;
        }

        private void CobroEfectivo_Load(object sender, EventArgs e)
        {
            Txtpago.Focus();
        }

        private void Txtpago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                
                double pago = Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtpago.Text);
                double monto = Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(TxtMonto.Text);
                if (!string.IsNullOrEmpty(TxtMonto.Text.Trim()) && !string.IsNullOrEmpty(Txtpago.Text.Trim()))
                {
                    Txtpago.Text = String.Format("{0:N2}", Convert.ToDouble(Txtpago.Text.Trim()));
                    if (pago >= monto)
                    {
                        Txtpago.Text = String.Format("{0:N2}", Convert.ToDouble(Txtpago.Text.Trim()));
                        Txtcambio.Text = "$ " + String.Format("{0:N2}", Convert.ToDouble((pago - monto)));
                        Txtcambio.Focus();
                        SendKeys.Send("%");
                        SendKeys.Send("{DOWN}");
                    }
                    else
                    {
                        MessageBox.Show("El pago es menor que el total a pagar");
                        Txtpago.Text = "";
                        Txtcambio.Text = "";
                        Txtpago.Focus();
                    }
                }

              
                
            }
        }
    }
}
