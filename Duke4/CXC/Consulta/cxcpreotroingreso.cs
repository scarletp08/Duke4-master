using Duke4.Logistica;
using Funciones_Duke4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.CXC.Consulta
{
    public partial class cxcpreotroingreso : Duke4.MainFormPresentar
    {
        public cxcpreotroingreso()
        {
            InitializeComponent();
        }

        private void cxcpreotroingreso_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Consulta de Otro Ingreso", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");

        }

        private void Txtotroingreso_TextChanged(object sender, EventArgs e)
        {
            Fun_Buscar_Otro_Ingreso();
        }
        protected void Fun_Buscar_Otro_Ingreso()
        {

            string secuencia = Funciones.Fun_Eliminar_Letras_DeString(Txtotroingreso.Text);

            if (Txtotroingreso.Fun_SQL_Buscar_SecuenciaRegistro("SELECT * from cxcdbfotroingreso where REPLACE(secuencia,SUBSTRING(secuencia,PATINDEX('%[^0-9]%', secuencia),1),'')=" + Funciones.Fun_Convierte_String_aEntrero(secuencia)))
            {

                DataSet ds = Txtotroingreso._Dataset;


                Txtnombrecliente.Text = ds.Tables[0].Rows[0]["beneficiario"].ToString();
                Dtpfecha.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha"]);
                Txtreferencia.Text = ds.Tables[0].Rows[0]["referencia"].ToString();
                Txtmonto.Text = ds.Tables[0].Rows[0]["monto"].ToString();
                Cmbmoneda.SelectedValue = ds.Tables[0].Rows[0]["idmoneda"].ToString();
                Txtconcepto.Text = ds.Tables[0].Rows[0]["concepto"].ToString();
                
            }
        }

        public string _secuencia = "";
        public bool _nulo = false;

        protected override void Imprimir()
        {
            base.Imprimir();
            
                var Reporte_Recibo_Ingreso = new Reporte_General.CXC.cxcrepotroingreso01();
                Reporte_Recibo_Ingreso._id = _secuencia;
                if (_nulo == false)
                    Reporte_Recibo_Ingreso._Letrero_Copia = "COPIA";
                else
                    Reporte_Recibo_Ingreso._Letrero_Copia = "<<NULO>> COPIA";

                Reporte_Recibo_Ingreso.Show();
                Reporte_Recibo_Ingreso.Owner = this;
           
        }
    }
}
