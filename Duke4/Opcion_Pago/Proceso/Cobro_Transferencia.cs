using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.Opcion_Pago.Proceso
{
    public partial class Cobro_Transferencia : MainPanel
    {
        string montoT = "";
        public Cobro_Transferencia(string monto)
        {
            InitializeComponent();
            montoT = monto;
            TxtMonto.Text = monto;
        }

        private void CobroPorTransferencia_Load(object sender, EventArgs e)
        {
            Logistica.FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(CbBanco, "select idbanco, descripcion from bandbfbanco");
        }
    }
}
