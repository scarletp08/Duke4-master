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
    public partial class cxcpredebcre : Duke4.MainFormPresentar
    {
        public cxcpredebcre()
        {
            InitializeComponent();
        }

        private void cxcpredebcre_Load(object sender, EventArgs e)
        {
        
            Fun_Set_Nombre_Formulario("Consulta de Nota de Débito/Crédito", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");

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
           
                cmd = string.Format("select cxcdbfregistro.idregistro, cxcdbfregistro.secuencia, cxcdbfregistro.fecha as fechafac ,cxcdbfregistro.referencia, fechavencimiento, cxcdbfregistro.total as totalfac ,balance,cxcdbfdebcre.total,cxcdbfdebcre.itbis  from cxcdbfregistro"
                + " inner join cxcdbfdebcre on cxcdbfdebcre.idfactura = cxcdbfregistro.idregistro where cxcdbfdebcre.secuencia='" + Txtregistro.Text.Trim() + "'");
                ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
            

            Dgv.DataSource = ds.Tables[0];


        }
        protected override void Imprimir()
        {
            base.Imprimir();
            
                var Reporte = new Reporte_General.CXC.cxcrepdebcre01();
                Reporte._id = _secuencia;
                if (_nulo == false)
                Reporte._Letrero_Copia = "COPIA";
                else
                Reporte._Letrero_Copia = "<<NULO>> COPIA";

                if (Rbncredito.Checked)
                Reporte._titulonota = "NOTA DE CREDITO";
                else if (Rbndebito.Checked)
                Reporte._titulonota = "NOTA DE DEBITO";

            Reporte.Show();
            Reporte.Owner = this;
           
        }

        private void Txtregistro_TextChanged(object sender, EventArgs e)
        {
            Fun_Buscar_Nota_Debcre();
        }
        protected void Fun_Buscar_Nota_Debcre()
        {

            string secuencia = Funciones.Fun_Eliminar_Letras_DeString(Txtregistro.Text);

            if (Txtregistro.Fun_SQL_Buscar_SecuenciaRegistro("SELECT * from cxcdbfdebcre where REPLACE(secuencia,SUBSTRING(secuencia,PATINDEX('%[^0-9]%', secuencia),1),'')=" + Funciones.Fun_Convierte_String_aEntrero(secuencia)))
            {

                DataSet ds = Txtregistro._Dataset;

                Txtcodigocliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
                Dtpfecha.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha"]);
                Txtreferencia.Text = ds.Tables[0].Rows[0]["referencia"].ToString();
                Txtsubtotal.Text = ds.Tables[0].Rows[0]["gravado"].ToString();
                Txttotal.Text = ds.Tables[0].Rows[0]["total"].ToString();
                Txtitbis.Text = ds.Tables[0].Rows[0]["itbis"].ToString();
                Txtcodigovendedor.Text = ds.Tables[0].Rows[0]["idvendedor"].ToString();
                Cmbmoneda.SelectedValue = ds.Tables[0].Rows[0]["idmoneda"].ToString();
                Txtbalance.Text = ds.Tables[0].Rows[0]["balancecliente"].ToString();
                Mskncf.Text = ds.Tables[0].Rows[0]["ncf"].ToString();
                Txtconcepto.Text = ds.Tables[0].Rows[0]["concepto"].ToString();
                Fun_Buscar_Cliente();
                Fun_Buscar_Vendedor();
                Fun_Buscar_Detalle_Registro(Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["idregistro"].ToString()));

            }
        }
    }
}
