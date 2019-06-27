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
    public partial class cxcprecobroadelantado : Duke4.MainFormPresentar
    {
        public cxcprecobroadelantado()
        {
            InitializeComponent();
        }

        private void cxcprecobroadelantado_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Consulta de Cobro por Adelantado", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");

        }
        protected void Fun_Buscar_Cobro_Adelantado()
    {

        string secuencia = Funciones.Fun_Eliminar_Letras_DeString(Txtcobro.Text);

        if (Txtcobro.Fun_SQL_Buscar_SecuenciaRegistro("SELECT * from cxcdbfcobroadelantado where REPLACE(secuencia,SUBSTRING(secuencia,PATINDEX('%[^0-9]%', secuencia),1),'')=" + Funciones.Fun_Convierte_String_aEntrero(secuencia)))
        {

            DataSet ds = Txtcobro._Dataset;


            Txtcodigocliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
            Dtpfecha.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha"]);
            Txtreferencia.Text = ds.Tables[0].Rows[0]["referencia"].ToString();
            Txtmonto.Text = ds.Tables[0].Rows[0]["monto"].ToString();
            Cmbmoneda.SelectedValue = ds.Tables[0].Rows[0]["idmoneda"].ToString();
            Txtconcepto.Text = ds.Tables[0].Rows[0]["concepto"].ToString();
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
           
        }

        public string _secuencia = "";
    public bool _nulo = false;

    protected override void Imprimir()
    {
        base.Imprimir();

        var Reporte = new Reporte_General.CXC.cxcrepcobroadelantado01();
        Reporte._id = _secuencia;
        if (_nulo == false)
            Reporte._Letrero_Copia = "COPIA";
        else
            Reporte._Letrero_Copia = "<<NULO>> COPIA";

        Reporte.Show();
        Reporte.Owner = this;

    }

        private void Txtcobro_TextChanged(object sender, EventArgs e)
        {
            Fun_Buscar_Cobro_Adelantado();
        }
    }
}
