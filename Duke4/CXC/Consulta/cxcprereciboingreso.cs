using Duke4.Logistica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Funciones_Duke4;

namespace Duke4.CXC.Consulta
{
    public partial class cxcprereciboingreso : Duke4.MainFormPresentar
    {
        public cxcprereciboingreso()
        {
            InitializeComponent();
        }

        private void Txtcobro_TextChanged(object sender, EventArgs e)
        {
            Fun_Buscar_Recibo_Ingreso();
        }
        protected void Fun_Buscar_Recibo_Ingreso()
        {

            string secuencia = Funciones.Fun_Eliminar_Letras_DeString(Txtcobro.Text);
          
            if (Txtcobro.Fun_SQL_Buscar_SecuenciaRegistro("SELECT * from cxcdbfcobro where REPLACE(secuencia,SUBSTRING(secuencia,PATINDEX('%[^0-9]%', secuencia),1),'')=" + Funciones.Fun_Convierte_String_aEntrero(secuencia)))
            {

                DataSet ds = Txtcobro._Dataset;


                Txtcodigocliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
                Dtpfecha.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha"]);
                Txtreferencia.Text = ds.Tables[0].Rows[0]["referencia"].ToString();
                Txttotalcargo.Text = ds.Tables[0].Rows[0]["totalcargo"].ToString();
                Txttotalcob.Text = ds.Tables[0].Rows[0]["total"].ToString();
                Txttotaldescuento.Text = ds.Tables[0].Rows[0]["totaldescuento"].ToString();
                Txttotalretencionisr.Text = ds.Tables[0].Rows[0]["totalretencionisr"].ToString();
                Txttotalretencionitbis.Text = ds.Tables[0].Rows[0]["totalretencionitbis"].ToString();
                Txtcodigovendedor.Text = ds.Tables[0].Rows[0]["idvendedor"].ToString();
                Cmbmoneda.SelectedValue = ds.Tables[0].Rows[0]["idmoneda"].ToString();
                Txtbalance.Text = ds.Tables[0].Rows[0]["balancecliente"].ToString();
                Fun_Buscar_Cliente();
                Fun_Buscar_Vendedor();
                Fun_Buscar_Detalle_Registro(Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["idcobro"].ToString()));

            }
        }
        protected void Fun_Buscar_Vendedor()
        {
            if (Txtcodigovendedor.Fun_SQL_Buscar_CodigoRegistro("nomdbfempleado", "idempleado"))
            {
                DataSet ds = Txtcodigovendedor._Dataset;
                Txtnombrevendedor.Text = ds.Tables[0].Rows[0]["nombre"].ToString();

            }
            else
            {
                Txtcodigovendedor.Text = "";
                Txtnombrevendedor.Text = "";

            }
        }
        protected void Fun_Buscar_Cliente()
        {
            if (Txtcodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {

                DataSet ds = Txtcodigocliente._Dataset;
                Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                Txtdireccioncliente.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                Txttelefonocliente.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
                

            }
            else
            {

                //Txtnombrecliente.Text = "";

            }
        }
        public string _secuencia = "";
        public bool _nulo = false;
        protected void Fun_Buscar_Detalle_Registro(int idregistro)
        {
            Dgv.ClearSelection();
            string cmd = "";
            DataSet ds = new DataSet();
            Dgv.CurrentCell = null;
            if (Rbnreciboingreso.Checked)
            {
                cmd = string.Format("select cxcdbfcobrodetalle.idregistro,cxcdbfregistro.secuencia,cxcdbfregistro.referencia,ncf,cxcdbfregistro.fecha as fechafac,fechavencimiento, DATEDIFF(day, cxcdbfregistro.fecha, getdate()) as dias ,cxcdbfregistro.total,balance, cxcdbfcobrodetalle.monto,montoretencionisr,montoretencionitbis,cxcdbfcobrodetalle.cargo,cxcdbfcobrodetalle.descuento from cxcdbfregistro "
             + "inner join cxcdbfcobrodetalle on cxcdbfregistro.idregistro = cxcdbfcobrodetalle.idregistro inner join cxcdbfcobro on cxcdbfcobrodetalle.idcobro=cxcdbfcobro.idcobro where cxcdbfcobro.secuencia='" + Txtcobro.Text.Trim() + "'");
                ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
            }

            Dgv.DataSource = ds.Tables[0];


        }
        protected override void Imprimir()
        {
            base.Imprimir();
            if (Rbnreciboingreso.Checked)
            {
                var Reporte_Recibo_Ingreso = new Reporte_General.CXC.cxcrepcobro01();
                Reporte_Recibo_Ingreso._id = _secuencia;
                if (_nulo == false)
                    Reporte_Recibo_Ingreso._Letrero_Copia = "COPIA";
                else
                    Reporte_Recibo_Ingreso._Letrero_Copia = "<<NULO>> COPIA";

                Reporte_Recibo_Ingreso.Show();
                Reporte_Recibo_Ingreso.Owner = this;
            } else
            {
                var Reporte_Registro = new Reporte_General.CXC.cxcrepcobroadelantadodetalle01();
                Reporte_Registro._id = _secuencia;
                if (_nulo == false)
                    Reporte_Registro._Letrero_Copia = "COPIA";
                else
                    Reporte_Registro._Letrero_Copia = "<<NULO>> COPIA";

                Reporte_Registro.Show();
                Reporte_Registro.Owner = this;
            }
        }

        private void cxcprereciboingreso_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Consulta de Recibo de Ingreso", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");

        }
    }
}
