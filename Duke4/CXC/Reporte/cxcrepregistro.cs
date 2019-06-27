using Duke4.Consulta_General;
using Duke4.Logistica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Duke4.CXC.Reporte
{
    public partial class cxcrepregistro : Duke4.MainFormReportes
    {
       
        public cxcrepregistro()
        {
            InitializeComponent();
            idprograma = 1;
        }
               
        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {

            MFConsulta_Cliente consulta = new MFConsulta_Cliente("=");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigocliente.Text = consulta.MainGrid.SelectedRows[0].Cells[1].Value.ToString();
                Completar_cliente();
                if (TxtCodigocliente.Text != string.Empty)
                TxtCodigotipocliente.Focus();

            }

        }
        
        private void Completar_cliente()
        {
            if (TxtCodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {
                DataSet ds = TxtCodigocliente._Dataset;
                Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();



            }
            else
            {
                Txtnombrecliente.Text = "";
            }
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {

            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idtipocliente as codigo, descripcion from cxcdbftipocliente where nulo = 0", "descripcion", "Tipo de Cliente");
            if (consulta.ShowDialog(this) == DialogResult.OK)

            {

                TxtCodigotipocliente.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_tipo_cliente();
                if (TxtCodigotipocliente.Text != string.Empty)
                    TxtCodigoregion.Focus();
            }
        }

        private void Completar_tipo_cliente()
        {
            if (TxtCodigotipocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbftipocliente", "idtipocliente"))
            {
                DataSet ds = TxtCodigotipocliente._Dataset;
                Txtdescripciontipocliente.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();



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
                    cmbmoneda.Focus();
            }
        }
        private void Completar_vendedor()
        {
            if (TxtCodigovendedor.Fun_SQL_Buscar_CodigoRegistro("nomdbfempleado", "idempleado"))
            {
                DataSet ds = TxtCodigovendedor._Dataset;
                Txtnombrevendedor.Text = ds.Tables[0].Rows[0]["nombre"].ToString();




            }
            else
            {
                Txtnombrevendedor.Text = "";

            }
        }

        private void btnBuscarciudad_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idprovincia as codigo, descripcion from cxcdbfprovincia where nulo = 0 and idregion= case when '" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigoregion.Text)+ "' >0 then '" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigoregion.Text) + "' else idregion end", "descripcion", "Provincias");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigociudad.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_provincia();
                if (TxtCodigociudad.Text != string.Empty)
                    TxtCodigomunicipio.Focus();
            }
        }
        private void Completar_provincia()
        {
            if (TxtCodigociudad.Fun_SQL_Buscar_CodigoRegistro("cxcdbfprovincia", "idprovincia"))
            {
                DataSet ds = TxtCodigociudad._Dataset;
                Txtdescripcionciudad.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();


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
                    TxtCodigovendedor.Focus();

            }

        }

        private void Completar_ruta()
        {
            if (TxtCodigoruta.Fun_SQL_Buscar_CodigoRegistro("cxcdbfruta", "idruta"))
            {
                DataSet ds = TxtCodigoruta._Dataset;
                Txtdescripcionruta.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();



            }
            else
            {
                Txtdescripcionruta.Text = "";
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

        private void btnBuscar5_Click(object sender, EventArgs e)
        {


            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idsector as codigo, descripcion from cxcdbfsector where nulo = 0 and idmunicipio= case when '" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigomunicipio.Text) + "' >0 then '" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigomunicipio.Text) + "' else idmunicipio end", "descripcion", "Sector");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigosector.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_sector();
                if (TxtCodigosector.Text != string.Empty)
                    TxtCodigoruta.Focus();

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

        private void cmbBase4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbmonto.SelectedIndex == 0)
            {
                txtmonto.Visible = false;
            }
            else
            {

                txtmonto.Visible = true;
                txtmonto.Focus();
            }
        }

        

        private void TxtCodigocliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
      
        


        private void cxcrepregistro_Load_1(object sender, EventArgs e)
        {
            
            Dtpfechainicial.Select();
            Fun_Set_Nombre_Formulario("Registro de Factura", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(cmbmoneda, "select idmoneda,abreviatura  from gendbfmoneda");
            frm.cambia_size += new controlNCF.Size_Form(Fun_Cambiar_Size);
            InvocarFormulario(frm, panel1);
            frm.inicio();
            




        }
        

        void Fun_Cambiar_Size(bool d)
        {
            if (d)
            {
                panel1.Height = 145;
                panel1.Width = 303;
                
            }
            else
            {
                panel1.Height = 23;
                panel1.Width = 120;
            }
        }

        controlNCF frm = new controlNCF();

        
        private void checkedListBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void TxtCodigocliente_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, BtnBuscarCliente);

        }

        private void TxtCodigotipocliente_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscartipocliente);

        }

        private void TxtCodigovendedor_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscarvendedor);

        }

        private void TxtCodigociudad_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscarciudad);


        }

        private void TxtCodigoruta_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscarruta);

        }

        private void TxtCodigosector_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscarsector);


        }

        private void TxtCodigocliente_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {
                DataSet ds = TxtCodigocliente._Dataset;

                Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();

            }
            else Txtnombrecliente.Text = "";
        }

        private void TxtCodigotipocliente_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigotipocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbftipocliente", "idtipocliente"))
            {
                DataSet ds = TxtCodigotipocliente._Dataset;

                Txtdescripciontipocliente.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();

            }
            else Txtdescripciontipocliente.Text = "";
        }

        private void TxtCodigovendedor_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigovendedor.Fun_SQL_Buscar_CodigoRegistro("nomdbfempleado", "idempleado"))
            {
                DataSet ds = TxtCodigovendedor._Dataset;

                Txtnombrevendedor.Text = ds.Tables[0].Rows[0]["nombre"].ToString();

            }
            else Txtnombrevendedor.Text = "";
        }

        private void TxtCodigociudad_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigociudad.Fun_SQL_Buscar_CodigoRegistro("cxcdbfprovincia", "idprovincia"))
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

        private void TxtCodigotipocliente_KeyDown_1(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscartipocliente);

        }

        private void cmbcondicionmonto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void TxtCodigovendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        protected override void Blanquear()
        {
            base.Blanquear();
           
        }
        protected override void Presentar()
        {
            base.Presentar();
            var reporte = new Reporte_General.CXC.cxcrepregistro001();

            if (Lbsformato.SelectedIndex == 0)
            {
                reporte.informe = "cxcrepregistro001.rdlc";
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
            reporte.condicionncf = frm.condicionncf();
            reporte.orden = Lbsorden.Text;
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
            if (Convert.ToInt16(cmbcuentaincobrable.SelectedValue) == 0)
                valor = 2;
            else if (Convert.ToInt16(cmbcuentaincobrable.SelectedValue) == 1)
                valor = 1;
            else if (Convert.ToInt16(cmbcuentaincobrable.SelectedValue) == 2)
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

        private void TxtCodigoregion_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscarregion);
        }

        private void TxtCodigoregion_Validating(object sender, CancelEventArgs e)
        {
            Completar_region();
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

        private void TxtCodigomunicipio_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscarmunicipio);

        }

        private void TxtCodigomunicipio_Validating(object sender, CancelEventArgs e)
        {
            Completar_municipio();
        }

        private void gridBase1_SelectionChanged(object sender, EventArgs e)
        {
            
                   
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dtpfechainicial.Select();
        }

        private void lblBase14_Click(object sender, EventArgs e)
        {

        }

        private void lblBase15_Click(object sender, EventArgs e)
        {

        }

        private void TxtCodigoregion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtdescripcionregion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCodigomunicipio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtdescripcionmunicipio_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
            
        }

        private void Lbsformato_MeasureItem(object sender, MeasureItemEventArgs e)
        {

        }

        private void lsbBase1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
    }
    
    

