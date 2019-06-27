using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duke4.Opcion_Pago.Proceso
{
    public partial class Cobro_Tarjeta : MainPanel
    {
        string MontoT;
        public Cobro_Tarjeta(string monto)
        {
            InitializeComponent();
            MontoT = monto;
            TxtMonto.Text = monto;
        }
     
     
        private void CobroConTarjeta_Load(object sender, EventArgs e)
        {

            Logistica.FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(CbBanco, "select idbanco, descripcion from bandbfbanco");
            Logistica.FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(CbTipo, "select idtipo, descripcion from bandbftipotarjeta");

        }
               
            

        private void TxtMonto_Leave(object sender, EventArgs e)
        {
            if (Txtaprobacion.Text != string.Empty)
            {
                double D = double.Parse(Txtaprobacion.Text);
                double C = double.Parse(MontoT);
                if (D > C)
                {
                    Txtaprobacion.Text = MontoT;
                    LblAlarma.Text = "Monto no puede ser mayor que el monto aplicado.";
                }
                else
                    LblAlarma.Text = string.Empty;
            }
        }

        private void Mkbfechaven_Enter(object sender, EventArgs e)
        {
            Mkbfechaven.Select(0, 0);
            string texto = Mkbfechaven.Text.Trim();
            Mkbfechaven.Mask = "00/00";
            Mkbfechaven.Text = texto;
            Mkbfechaven.BackColor = Color.LightGoldenrodYellow;
        }

        private void Mkbfechaven_Leave(object sender, EventArgs e)
        {
            string texto = Mkbfechaven.Text.Trim();
            Mkbfechaven.BackColor = SystemColors.Window;
            Mkbfechaven.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (!Mkbfechaven.MaskFull && Mkbfechaven.Text != string.Empty && Mkbfechaven.Enabled == true && Mkbfechaven.ReadOnly == false)
            {
             Funciones_Duke4.Funciones._ErrorProvider.SetError(Mkbfechaven, "Información incompleta");
            }
            else if (Mkbfechaven.MaskFull)
            {
                Mkbfechaven.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

                Mkbfechaven.Text = texto;
                Funciones_Duke4.Funciones._ErrorProvider.SetError(Mkbfechaven, "");

                
            }
            else if (this.Text == string.Empty)
            {
                Mkbfechaven.Mask = "";
                Funciones_Duke4.Funciones._ErrorProvider.SetError(Mkbfechaven, "");
            }

        }

        private void Mkbfechaven_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
