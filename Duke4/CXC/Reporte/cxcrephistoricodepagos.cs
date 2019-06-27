using Duke4.Consulta_General;
using Duke4.Logistica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.CXC.Reporte
{
    public partial class cxcrephistoricodepagos : Duke4.MainFormReportes
    {
        public cxcrephistoricodepagos()
        {
            InitializeComponent();
        }

        private void cxcrephistoricodepagos_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Histórico Dias de Pago", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(cmbmoneda, "select idmoneda,abreviatura  from gendbfmoneda");
        }
        //protected override void agregaritems()
        //{
        //    base.agregaritems();

        //    Lsbformato.Items.Add("1->Histórico de Pagos");
        //    Lsbformato.SetSelected(0, true);
        //}

        private void BtnBuscarbeneficiario_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idcliente as codigo, nombre as descripcion from cxcdbfcliente where nulo = 0", "nombre", "Cliente");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigocliente.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_cliente();
                if (TxtCodigocliente.Text != string.Empty)
                    TxtCodigocliente.Focus();
            }
        }

        private void Completar_cliente()
        {
            if (TxtCodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {
                DataSet ds = TxtCodigocliente._Dataset;
                Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                //LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);



            }
            else
            {
                Txtnombrecliente.Text = "";
            }
        }

        private void TxtCodigocliente_Validated(object sender, EventArgs e)
        {
            if (TxtCodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {
                DataSet ds = TxtCodigocliente._Dataset;

                Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                TxtCodigocliente.Focus();
            }
            else Txtnombrecliente.Text = "";
        }
    }
}
