using Duke4.Consulta_General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.Opcion_Pago.Archivo
{
    public partial class genmantipopago : Duke4.MainFormMant
    {
        public genmantipopago()
        {
            InitializeComponent();
        }

        public string ActivateParameter = "=";

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral Empresa = new MainFormConsultaGeneral("select idtipopago as codigo, descripcion from gendbftipopago where nulo " + ActivateParameter.ToString() + " 0", "descripcion", "Tipo Pago");
            if (Empresa.ShowDialog() == DialogResult.OK)
            {

                Txtcodigo.Text = Empresa.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                CompletarTipoPago();
                if (Txtdescripcion.Text != string.Empty)
                    Txtdescripcion.Focus();

            }
        }

        public void CompletarTipoPago()
        {
            if (Txtcodigo.Fun_SQL_Buscar_CodigoRegistro("gendbftipopago", "idtipopago"))
            {
                DataSet ds = Txtcodigo._Dataset;

                Txtdescripcion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                Ckbcheque.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["cheque"]);
                Ckbbanco.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["banco"]);
                Ckbautorizacion.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["autorizacion"]);
                Ckbtarjeta.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["tarjeta"]);
                Ckbfechaven.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["fechaven"]);
                Ckbcvc.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["cvc"]);
                Ckbaprobacion.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["aprobacion"]);
                Ckbcuentaban.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["cuentaban"]);
                //Ckbregistro.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["registro"]);
                Ckbdocumento.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["documento"]);
                Ckbmoneda.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["moneda"]);
                

                if (Convert.ToInt32(ds.Tables[0].Rows[0]["nulo"].ToString()) == 0 && ActivateParameter == ">=")
                    LblLetrero.Text = "Registro Activo";

                else if (Convert.ToInt32(ds.Tables[0].Rows[0]["nulo"].ToString()) > 0 && ActivateParameter == ">=")
                    LblLetrero.Text = "Registro Desactivo";

            }
            else
                Txtdescripcion.Text = string.Empty;
        }

        private void Txtcodigo_Leave(object sender, EventArgs e)
        {
           
        }

        private void Txtcodigo_Validating(object sender, CancelEventArgs e)
        {
            CompletarTipoPago();
            if (Txtdescripcion.Text != string.Empty)
                Txtdescripcion.Focus();
        }
    }
    
}
