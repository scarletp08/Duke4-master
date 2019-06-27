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
    public partial class cxcprechequefuturo : Duke4.MainFormPresentar
    {
        public cxcprechequefuturo()
        {
            InitializeComponent();
        }

        private void Txtchequefuturo_TextChanged(object sender, EventArgs e)
        {
            Fun_Buscar_Cheque_Futuro();
        }
        protected void Fun_Buscar_Cheque_Futuro()
        {

            string secuencia = Funciones.Fun_Eliminar_Letras_DeString(Txtchequefuturo.Text);

            if (Txtchequefuturo.Fun_SQL_Buscar_SecuenciaRegistro("SELECT * from cxcdbfchequefuturo where REPLACE(secuencia,SUBSTRING(secuencia,PATINDEX('%[^0-9]%', secuencia),1),'')=" + Funciones.Fun_Convierte_String_aEntrero(secuencia)))
            {

                DataSet ds = Txtchequefuturo._Dataset;


                Txtcodigocliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
                Dtpfecha.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha"]);
                Txtreferencia.Text = ds.Tables[0].Rows[0]["referencia"].ToString();
                Txtcodigovendedor.Text = ds.Tables[0].Rows[0]["idvendedor"].ToString();
                Cmbmoneda.SelectedValue = ds.Tables[0].Rows[0]["idmoneda"].ToString();
                Cmbbanco.SelectedValue = ds.Tables[0].Rows[0]["idbanco"].ToString();
                Txtnock.Text = ds.Tables[0].Rows[0]["nocheque"].ToString();
                Txtbalance.Text = ds.Tables[0].Rows[0]["balancecliente"].ToString();
                Fun_Buscar_Cliente();
                Fun_Buscar_Vendedor();
                Fun_Buscar_Detalle_Registro(Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["idchequefuturo"].ToString()));

            }
        }
        protected void Fun_Buscar_Vendedor()
        {
            if (Txtcodigovendedor.Fun_SQL_Buscar_CodigoRegistro("nomdbfempleado", "idempleado"))
            {
                DataSet ds = Txtcodigovendedor._Dataset;
                Txtnombrevendedor.Text = ds.Tables[0].Rows[0]["nombre"].ToString();

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
          
        }
        public string _secuencia = "";
        public bool _nulo = false;
        protected void Fun_Buscar_Detalle_Registro(int idregistro)
        {
            //Dgv.ClearSelection();
            //string cmd = "";
            //DataSet ds = new DataSet();
            //Dgv.CurrentCell = null;
            
            //    cmd = string.Format("select cxcdbfcobrodetalle.idregistro,cxcdbfregistro.secuencia,cxcdbfregistro.referencia,ncf,cxcdbfregistro.fecha as fechafac,fechavencimiento, DATEDIFF(day, cxcdbfregistro.fecha, getdate()) as dias ,cxcdbfregistro.total,balance, cxcdbfcobrodetalle.monto,montoretencionisr,montoretencionitbis,cxcdbfcobrodetalle.cargo,cxcdbfcobrodetalle.descuento from cxcdbfregistro "
            // + "inner join cxcdbfcobrodetalle on cxcdbfregistro.idregistro = cxcdbfcobrodetalle.idregistro inner join cxcdbfcobro on cxcdbfcobrodetalle.idcobro=cxcdbfcobro.idcobro where cxcdbfcobro.secuencia='" + Txtcobro.Text.Trim() + "'");
            //    ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
            

            //Dgv.DataSource = ds.Tables[0];


        }
        protected override void Imprimir()
        {
            base.Imprimir();
          
                var Reporte = new Reporte_General.CXC.cxcrepchequefuturo01();
                Reporte._id = _secuencia;
                if (_nulo == false)
                    Reporte._Letrero_Copia = "COPIA";
                else
                    Reporte._Letrero_Copia = "<<NULO>> COPIA";

                Reporte.Show();
                Reporte.Owner = this;
           
        }

        private void cxcprechequefuturo_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Consulta de Cheque Futuro", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbbanco, "select idbanco, descripcion from bandbfbanco");

        }
    }
}
