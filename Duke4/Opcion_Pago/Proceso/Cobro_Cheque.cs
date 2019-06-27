
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duke4.Opcion_Pago.Proceso
{
    public partial class Cobro_Cheque : MainPanel
    {
        string MontoT;
        public Cobro_Cheque(string monto)
        {
            InitializeComponent();
            MontoT = monto;
            TxtMonto.Text = monto;
        }
        ErrorProvider error = new ErrorProvider();

        private bool textoVacio()
        {
            bool flag = false;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == string.Empty)
                    {
                        flag = true;
                        error = new ErrorProvider();
                        error.SetError(item, "Este campo no puede estar en blanco");
                    }
                    else
                        error.SetError(item, "");
                }

                else if (item is ComboBox)
                {
                    if (((ComboBox)item).SelectedIndex == 0)
                    {
                        flag = true;
                        error = new ErrorProvider();
                        error.SetError(item, "Este campo no puede estar en blanco");
                    }
                    else
                        error.Clear();
                }
                else if (item is MaskedTextBox)
                {
                    if (!((MaskedTextBox)item).MaskFull)
                    {
                        flag = true;
                        error = new ErrorProvider();
                        error.SetError(item, "Este campo no puede estar en blanco");
                    }
                    else
                        error.Clear();
                }

            }
            return flag;
        }

        
        private void Salvar()
        {
            double D = Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(TxtMonto.Text);
            double C = Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(MontoT);


            if (textoVacio())
                LblAlarma.Text =  Logistica.Mensajes.Stg_Campos_EnBlanco;
            else if (D > C )
            {
                LblAlarma.Text = "Monto no puede ser mayor que el monto aplicado.";
                error.SetError(TxtMonto, "Monto no puede ser mayor que el monto aplicado.");
            } else
            {
                LblAlarma.Text = string.Empty;
                DialogResult = DialogResult.OK;
            }
        }

        private void CobroConCheque_Load(object sender, EventArgs e)
        {
            
        Logistica.FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(CbBanco, "select idbanco, descripcion from bandbfbanco");

        }

        private void BtnElegir_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void TxtMonto_KeyUp(object sender, KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("%");
                SendKeys.Send("{TAB}");
                SendKeys.Send("{TAB}");
                
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TxtMonto_Leave(object sender, EventArgs e)
        {
            if(TxtMonto.Text != string.Empty)
            {
                double D = Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(TxtMonto.Text);
                double C = Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(MontoT);
                if (D > C)
                {
                    TxtMonto.Text = MontoT;
                    LblAlarma.Text = "Monto no puede ser mayor que el monto aplicado.";
                }
                else
                    LblAlarma.Text = string.Empty;
            }
        }
    }
}
