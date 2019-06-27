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
    public partial class cxcpreregistro : Duke4.MainFormPresentar
    {
        public cxcpreregistro()
        {
            InitializeComponent();
        }

        private void cxcpreregistro_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Consulta de Factura", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");
            
        }

        private void Txtregistro_TextChanged(object sender, EventArgs e)
        {
            Fun_Buscar_Registro();
            
        }
        protected void Fun_Buscar_Registro()
        {

            string secuencia = Funciones.Fun_Eliminar_Letras_DeString(Txtregistro.Text);
            //MessageBox.Show(Funciones.Fun_Convierte_String_aEntrero(secuencia).ToString());
            if (Txtregistro.Fun_SQL_Buscar_SecuenciaRegistro("SELECT * from cxcdbfregistro where tiporegistro=1 and REPLACE(secuencia,SUBSTRING(secuencia,PATINDEX('%[^0-9]%', secuencia),1),'')=" + Funciones.Fun_Convierte_String_aEntrero(secuencia)))
            {
                
                DataSet ds = Txtregistro._Dataset;


                Txtcodigocliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
                Dtpfechavencimiento.MinDate = new DateTime(1753, 6, 20);
                Dtpfechavencimiento.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fechavencimiento"]);
                Dtpfecha.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha"]);
                Txtreferencia.Text = ds.Tables[0].Rows[0]["referencia"].ToString();
                Txtitbis.Text = ds.Tables[0].Rows[0]["totalitbis"].ToString();
                Txttotal.Text = ds.Tables[0].Rows[0]["total"].ToString();
                Txtexcento.Text = ds.Tables[0].Rows[0]["totalexento"].ToString();
                Txtgravado16.Text = ds.Tables[0].Rows[0]["totalgravado16"].ToString();
                Txtgravado18.Text = ds.Tables[0].Rows[0]["totalgravado18"].ToString();
                //Dtpfecha.validancf(Txtncf);
                Mskncf.Text = ds.Tables[0].Rows[0]["ncf"].ToString();
                Txtcodigovendedor.Text = ds.Tables[0].Rows[0]["idvendedor"].ToString();
                Txtcomentrio.Text = ds.Tables[0].Rows[0]["comentario"].ToString();
                Cmbmoneda.SelectedValue = ds.Tables[0].Rows[0]["idmoneda"].ToString();
                Fun_Buscar_Cliente();
                Fun_Buscar_Vendedor();
                Fun_Buscar_Detalle_Registro(Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["idregistro"].ToString()));

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
                Txtrnccliente.Text = ds.Tables[0].Rows[0]["rnc"].ToString();
                Txtbalancecliente.Text = FuncionesSQL.Fun_SQL_Buscar_Balance_Cliente(Txtcodigocliente.Text);
                
           }
            else
            {

                Txtnombrecliente.Text = "";

            }
        }

        public string _secuencia = "";
        public bool _nulo = false;
        protected void Fun_Buscar_Detalle_Registro(int idregistro)
        {
            Dgv.Rows.Clear();
            string cmd = string.Format("select orden,cxcdbfregistrodetalle.idconcepto,cxcdbfregistrodetalle.descripcion,precio,montoitbis,montoimporte,tasa from cxcdbfregistrodetalle "
            + " inner join cxcdbfconcepto on cxcdbfconcepto.idconcepto = cxcdbfregistrodetalle.idconcepto "
            + " inner join gendbftasaitbis on gendbftasaitbis.iditbis = cxcdbfconcepto.iditbis  where idregistro='" + idregistro + "'");

            DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
            for (int c = 0; c < ds.Tables[0].Rows.Count; c++)
            {
                Dgv.Rows.Add(Dgv.Rows.Count + 1, ds.Tables[0].Rows[c]["idconcepto"], ds.Tables[0].Rows[c]["descripcion"], ds.Tables[0].Rows[c]["precio"], ds.Tables[0].Rows[c]["montoitbis"], ds.Tables[0].Rows[c]["montoimporte"], ds.Tables[0].Rows[c]["tasa"]);

            }


        }
        protected override void Imprimir()
        {
            base.Imprimir();
            var Reporte_Registro = new Reporte_General.CXC.cxcrepregistro01();
            Reporte_Registro._id = _secuencia;
            if (_nulo == false)
                Reporte_Registro._Letrero_Copia = "COPIA";
            else
                Reporte_Registro._Letrero_Copia = "<<NULO>> COPIA";
            
            Reporte_Registro.Show();
            Reporte_Registro.Owner = this;
        }


    }
}
