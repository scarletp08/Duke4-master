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
    public partial class cxcrepnotasdebito_credito : Duke4.MainFormReportes
    {
        public cxcrepnotasdebito_credito()
        {
            InitializeComponent();
        }

        private void cxcrepnotasdebito_credito_Load(object sender, EventArgs e)
        {
            ckbcredito.Checked = true;
          
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(cmbmoneda, "select idmoneda,abreviatura  from gendbfmoneda");


            Fun_Set_Nombre_Formulario("Listado de Notas de Débito/Crédito(CXC)", this);
        }
        //protected override void agregaritems()
        //{
        //    base.agregaritems();

        //    Lsbformato.Items.Add("1->Notas Débito/Crédito");
        //    Lsbformato.SetSelected(0, true);
        //}

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
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

        private void btnBuscartipocliente_Click(object sender, EventArgs e)
        {

            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idtipocliente as codigo, descripcion from cxcdbftipocliente where nulo = 0", "descripcion", "Tipo de Cliente");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigotipocliente.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_tipo_cliente();
                if (TxtCodigotipocliente.Text != string.Empty)
                    TxtCodigotipocliente.Focus();
            }
        }

        private void Completar_tipo_cliente()
        {
            if (TxtCodigotipocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbftipocliente", "idtipocliente"))
            {
                DataSet ds = TxtCodigotipocliente._Dataset;
                Txtdescripciontipocliente.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                //LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);



            }
            else
            {
                Txtdescripciontipocliente.Text = "";
            }
        }

        private void btnBuscarvendedor_Click(object sender, EventArgs e)
        {

            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idempleado as codigo,  nombre as descripcion from nomdbfempleado where nulo  = 0", "nombre", "Vendedor");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigovendedor.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_vendedor();
                if (TxtCodigovendedor.Text != string.Empty)
                    TxtCodigovendedor.Focus();
            }
        }
        private void Completar_vendedor()
        {
            if (TxtCodigovendedor.Fun_SQL_Buscar_CodigoRegistro("nomdbfempleado", "idempleado"))
            {
                DataSet ds = TxtCodigovendedor._Dataset;
                Txtnombrevendedor.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                //LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);




            }
            else
            {
                Txtnombrevendedor.Text = "";

            }
        }

        private void btnBuscarciudad_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idprovincia as codigo, descripcion from cxcdbfprovincia where nulo = 0", "descripcion", "Provincias");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigociudad.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_provincia();
                if (TxtCodigociudad.Text != string.Empty)
                    TxtCodigociudad.Focus();
            }
        }
        private void Completar_provincia()
        {
            if (TxtCodigociudad.Fun_SQL_Buscar_CodigoRegistro("cxcdbfprovincia", "idprovincia"))
            {
                DataSet ds = TxtCodigociudad._Dataset;
                Txtdescripcionciudad.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                //LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);


            }
            else
            {
                Txtdescripcionciudad.Text = "";
            }
        }

        private void btnBuscarruta_Click(object sender, EventArgs e)
        {

            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idruta as codigo, descripcion from cxcdbfruta where nulo = 0", "descripcion", "Rutas");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigoruta.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_ruta();
                if (TxtCodigoruta.Text != string.Empty)
                    TxtCodigoruta.Focus();

            }

        }

        private void Completar_ruta()
        {
            if (TxtCodigoruta.Fun_SQL_Buscar_CodigoRegistro("cxcdbfruta", "idruta"))
            {
                DataSet ds = TxtCodigoruta._Dataset;
                Txtdescripcionruta.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();


                //LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);
            }
            else
            {
                Txtdescripcionruta.Text = "";
            }
        }

        private void btnBuscarsector_Click(object sender, EventArgs e)
        {

            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idsector as codigo, descripcion from cxcdbfsector where nulo = 0", "descripcion", "Sector");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigosector.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_sector();
                if (TxtCodigosector.Text != string.Empty)
                    TxtCodigosector.Focus();

            }

        }

        private void Completar_sector()
        {
            if (TxtCodigosector.Fun_SQL_Buscar_CodigoRegistro("cxcdbfsector", "idsector"))
            {
                DataSet ds = TxtCodigosector._Dataset;
                Txtdescripcionsector.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();

                
            }
        }

        private void ckbcredito_CheckedChanged(object sender, EventArgs e)
        {
            
          
            if (ckbcredito.Checked == true)
            {
                ckbcreditospordevolucion.Visible = true;
                ckbcreditospordevolucion.Checked = true;
                ckbdebito.Checked = false;
                
            }
            else
            {
               
                ckbcreditospordevolucion.Visible = false;
          

            }
        }

        private void ckbdebito_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdebito.Checked == true)
            {
                ckbcredito.Checked = false;
            }
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ckbcreditospordevolucion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Txtnombrevendedor_TextChanged(object sender, EventArgs e)
        {

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

        private void TxtCodigotipocliente_Validated(object sender, EventArgs e)
        {
        }

        private void TxtCodigovendedor_Validated(object sender, EventArgs e)
        {
            if (TxtCodigovendedor.Fun_SQL_Buscar_CodigoRegistro("nomdbfempleado", "idempleado"))
            {
                DataSet ds = TxtCodigovendedor._Dataset;

                Txtnombrevendedor.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
        
            }
            else Txtnombrevendedor.Text = "";
        }

        private void TxtCodigociudad_Validated(object sender, EventArgs e)
        {
            if (TxtCodigociudad.Fun_SQL_Buscar_CodigoRegistro("cxcdbfprovincia", "idcprovincia"))
            {
                DataSet ds = TxtCodigociudad._Dataset;

                Txtdescripcionciudad.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                TxtCodigociudad.Focus();
            }
            else Txtdescripcionciudad.Text = "";
        }

        private void TxtCodigoruta_Validated(object sender, EventArgs e)
        {
            if (TxtCodigoruta.Fun_SQL_Buscar_CodigoRegistro("cxcdbfruta", "idruta"))
            {
                DataSet ds = TxtCodigoruta._Dataset;

                Txtdescripcionruta.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                TxtCodigoruta.Focus();
            }
            else Txtdescripcionruta.Text = "";
        }

        private void TxtCodigosector_Validated(object sender, EventArgs e)
        {
            if (TxtCodigosector.Fun_SQL_Buscar_CodigoRegistro("cxcdbfsector", "idsector"))
            {
                DataSet ds = TxtCodigosector._Dataset;

                Txtdescripcionsector.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                TxtCodigosector.Focus();
            }
            else Txtdescripcionsector.Text = "";
        }

        private void TxtCodigotipocliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBase3_Click(object sender, EventArgs e)
        {

        }

        private void lblBase13_Click(object sender, EventArgs e)
        {

        }

        private void cmbBase1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBase5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblBase9_Click(object sender, EventArgs e)
        {

        }

        private void cmbmoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblBase12_Click(object sender, EventArgs e)
        {

        }

        private void cmbBase4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblBase10_Click(object sender, EventArgs e)
        {

        }

        private void Txtdescripcionsector_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCodigosector_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBase7_Click(object sender, EventArgs e)
        {

        }

        private void Txtdescripcionruta_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCodigoruta_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBase6_Click(object sender, EventArgs e)
        {

        }

        private void Txtdescripcionciudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBase8_Click(object sender, EventArgs e)
        {

        }

        private void TxtCodigociudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBase7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblBase5_Click(object sender, EventArgs e)
        {

        }

        private void Txtdescripciontipocliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBase4_Click(object sender, EventArgs e)
        {

        }

        private void TxtCodigocliente_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void TxtCodigotipocliente_Validating(object sender, CancelEventArgs e)
        {

            if (TxtCodigotipocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbftipocliente", "idtipocliente"))
            {
                DataSet ds = TxtCodigocliente._Dataset;

                Txtdescripciontipocliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
            
            }
            else Txtdescripciontipocliente.Text = "";
        }

        private void TxtCodigovendedor_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void TxtCodigociudad_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigociudad.Fun_SQL_Buscar_CodigoRegistro("cxcdbfprovincia", "idcprovincia"))
            {
                DataSet ds = TxtCodigociudad._Dataset;

                Txtdescripcionciudad.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                
            }
            else Txtdescripcionciudad.Text = "";
        }

        private void TxtCodigoruta_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigoruta.Fun_SQL_Buscar_CodigoRegistro("cxcdbfruta", "idruta"))
            {
                DataSet ds = TxtCodigoruta._Dataset;

                Txtdescripcionruta.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                
            }
            else Txtdescripcionruta.Text = "";
        }

        private void TxtCodigosector_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigosector.Fun_SQL_Buscar_CodigoRegistro("cxcdbfsector", "idsector"))
            {
                DataSet ds = TxtCodigosector._Dataset;

                Txtdescripcionsector.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                
            }
            else Txtdescripcionsector.Text = "";
        }

        private void TxtCodigocliente_Validated_1(object sender, EventArgs e)
        {
            if (TxtCodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {
                DataSet ds = TxtCodigocliente._Dataset;

                Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();

            }
            else Txtnombrecliente.Text = "";
        }

        private void TxtCodigotipocliente_Validated_1(object sender, EventArgs e)
        {
            if (TxtCodigotipocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbftipocliente", "idtipocliente"))
            {
                DataSet ds = TxtCodigocliente._Dataset;

                Txtdescripciontipocliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();

            }
            else Txtdescripciontipocliente.Text = "";
        }

        private void TxtCodigociudad_Validated_1(object sender, EventArgs e)
        {
            if (TxtCodigociudad.Fun_SQL_Buscar_CodigoRegistro("cxcdbfprovincia", "idcprovincia"))
            {
                DataSet ds = TxtCodigociudad._Dataset;

                Txtdescripcionciudad.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();

            }
            else Txtdescripcionciudad.Text = "";
        }

        private void TxtCodigoruta_Validated_1(object sender, EventArgs e)
        {
            if (TxtCodigoruta.Fun_SQL_Buscar_CodigoRegistro("cxcdbfruta", "idruta"))
            {
                DataSet ds = TxtCodigoruta._Dataset;

                Txtdescripcionruta.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();

            }
            else Txtdescripcionruta.Text = "";
        }

        private void TxtCodigosector_Validated_1(object sender, EventArgs e)
        {

            if (TxtCodigosector.Fun_SQL_Buscar_CodigoRegistro("cxcdbfsector", "idsector"))
            {
                DataSet ds = TxtCodigosector._Dataset;

                Txtdescripcionsector.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();

            }
            else Txtdescripcionsector.Text = "";
        }
        protected override void Presentar()
        {
            base.Presentar();
            var reporte = new Reporte_General.CXC.cxcrepdebitocredito001();
            if (ckbcredito.Checked==true)
            {
                reporte.tipo = 1;
                reporte.tiponota = "CREDITO";
            }
            else if (ckbdebito.Checked==true)
            {
                reporte.tipo = 2;
                reporte.tiponota = "DEBITO";

            }
            if (Lbsformato.SelectedIndex == 0)
            {
                reporte.informe = "cxcrepdebitocredito001.rdlc";
            }
            else if (Lbsformato.SelectedIndex == 1)
            {
                reporte.informe = "cxcrepregistro002.rdlc";
            }
            else if (Lbsformato.SelectedIndex == 2)
            {

                reporte.informe = "cxcrepregistro003.rdlc";

            }

            reporte.fechainicial = Dtpfechainicial;
            reporte.fechafinal = Dtpfechafinal;
            reporte.idcliente = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigocliente.Text);
            reporte.nombre = Txtnombrecliente.Text;
            reporte.idtipocliente = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigotipocliente.Text);
            reporte.idvendedor = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigovendedor.Text);
            reporte.idciudad = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigociudad.Text);
            reporte.idruta = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigoruta.Text);
            reporte.idsector = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigosector.Text);
            reporte.idmunicipio = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigomunicipio.Text);
            reporte.idregion = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigoregion.Text);
            reporte.cuentaincobrable = cuentaincobrable();
            reporte.idmoneda = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Convert.ToString(cmbmoneda.SelectedValue));
            reporte.nulo = nulo();
            reporte.dias = dias();




            reporte.orden = cmborden.Text;
            if (reporte.cuentafilas() > 0)
                reporte.Show();
            else Logistica.Mensajes.Datosenlimites();

            Dtpfechainicial.Select();
        }
       
        protected int nulo()
        {

            int valor = 0;
            if (Convert.ToInt16(cmbestatus.SelectedIndex) == 0)
                valor = 2;
            else if (Convert.ToInt16(cmbestatus.SelectedIndex) == 1)
                valor = 1;
            else if (Convert.ToInt16(cmbestatus.SelectedIndex) == 2)
                valor = 0;

            return valor;

        }

        protected int cuentaincobrable()
        {
            int valor = 0;
            if (Convert.ToInt16(cmbcuentaincobrable.SelectedIndex) == 0)
                valor = 2;
            else if (Convert.ToInt16(cmbcuentaincobrable.SelectedIndex) == 1)
                valor = 1;
            else if (Convert.ToInt16(cmbcuentaincobrable.SelectedIndex) == 2)
                valor = 0;

            return valor;

        }
        protected int dias()
        {
           
            int valor = 0;
            if (Convert.ToInt16(cmbdias.SelectedIndex) == 0)
                valor = 2;
            else if (Convert.ToInt16(cmbdias.SelectedIndex) == 1)
                valor = 1;
            else if (Convert.ToInt16(cmbdias.SelectedIndex) == 2)
                valor = 0;

            return valor;

        }

        private void btnBuscarregion_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idregion as codigo, descripcion from cxcdbfregion where nulo = 0", "descripcion", "Regiones");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigoregion.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_region();
                if (TxtCodigoregion.Text != string.Empty)
                    TxtCodigociudad.Focus();
            }
        }
        private void Completar_region()
        {
            if (TxtCodigoregion.Fun_SQL_Buscar_CodigoRegistro("cxcdbfregion", "idregion"))
            {
                DataSet ds = TxtCodigoregion._Dataset;
                Txtdescripcionregion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();



            }
            else
            {
                Txtdescripcionregion.Text = "";
            }
        }

        private void cmborden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblBase11_Click(object sender, EventArgs e)
        {

        }

        private void TxtCodigosector_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtCodigoruta_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblBase10_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBuscarmunicipio_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idmunicipio as codigo, descripcion from cxcdbfmunicipio where nulo = 0 and idprovincia= case when '" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigociudad.Text) + "' >0 then '" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigociudad.Text) + "' else idprovincia end", "descripcion", "Municipios");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigomunicipio.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_municipio();
                if (TxtCodigomunicipio.Text != string.Empty)
                    TxtCodigosector.Focus();
            }
        }
        private void Completar_municipio()
        {
            if (TxtCodigomunicipio.Fun_SQL_Buscar_CodigoRegistro("cxcdbfmunicipio", "idmunicipio"))
            {
                DataSet ds = TxtCodigomunicipio._Dataset;
                Txtdescripcionmunicipio.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();



            }
            else
            {
                Txtdescripcionmunicipio.Text = "";
            }
        }

        private void cmbmoneda_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
    

