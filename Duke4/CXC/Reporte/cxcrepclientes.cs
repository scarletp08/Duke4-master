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
    public partial class cxcrepclientes : Duke4.MainFormReportes
    {
        public cxcrepclientes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Txtdescripciontipocliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanelFiltrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBase10_Click(object sender, EventArgs e)
        {

        }

        private void Txtdescripcionsector_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarsector_Click(object sender, EventArgs e)
        {

            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idsector as codigo, descripcion from cxcdbfsector where nulo = 0 and idmunicipio= case when '" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigomunicipio.Text) + "' >0 then '" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigomunicipio.Text) + "' else idmunicipio end", "descripcion", "Sector");
            if (consulta.ShowDialog() == DialogResult.OK)
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

                //LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);
            }
        }

        private void TxtCodigosector_TextChanged(object sender, EventArgs e)
        {

        }

        private void cxcrepclientes_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Listado de clientes", this);
            //Fun_Grid_Solo_Lectura();
            //Seleccionar_Grid();
            //Fun_Llena_NCF();
            // inicio();
            
            InvocarFormulario(frm, panel1);
            frm.inicio();
          
            frm.cambia_size += new controlNCF.Size_Form(Fun_Cambiar_Size);

            TxtCodigocliente.Focus();

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


       
        
        

        
        

        private void btnBuscartipocliente_Click(object sender, EventArgs e)
        {

            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idtipocliente as codigo, descripcion from cxcdbftipocliente where nulo = 0", "descripcion", "Tipo de Cliente");
            if (consulta.ShowDialog() == DialogResult.OK)
            {

                TxtCodigotipocliente.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_tipo_cliente();
                if (TxtCodigotipocliente.Text != string.Empty)
                    TxtCodigovendedor.Focus();
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
            if (consulta.ShowDialog() == DialogResult.OK)
            {

                TxtCodigovendedor.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_vendedor();
                if (TxtCodigovendedor.Text != string.Empty)
                    TxtCodigoregion.Focus();
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
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idprovincia as codigo, descripcion from cxcdbfprovincia where nulo = 0 and idregion= case when '" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigoregion.Text) + "' >0 then '" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigoregion.Text) + "' else idregion end", "descripcion", "Provincias");
            if (consulta.ShowDialog() == DialogResult.OK)
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
            if (consulta.ShowDialog() == DialogResult.OK)
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

        private void btnBuscarcondicion_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idcondicion as codigo, descripcion from gendbfcondicion where nulo = 0", "descripcion", "Condicion");
            if (consulta.ShowDialog() == DialogResult.OK)
            {

                TxtCodigocondicion.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_condicion();
                if (TxtCodigocondicion.Text != string.Empty)
                    TxtCodigocondicion.Focus();

            }

        }

        private void Completar_condicion()
        {
            if (TxtCodigoruta.Fun_SQL_Buscar_CodigoRegistro("gendbfcondicion", "idcondicion"))
            {
                DataSet ds = TxtCodigocondicion._Dataset;
                Txtdescripcioncondicion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();


                //LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);
            }
            else
            {
                Txtdescripcioncondicion.Text = "";
            }
        }

        private void btnBuscarcondicion_Click_1(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idcondicion as codigo, descripcion from gendbfcondicion where nulo = 0", "descripcion", "Condiciones");
            if (consulta.ShowDialog() == DialogResult.OK)
            {

                TxtCodigocondicion.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_condiciones();
                if (TxtCodigocondicion.Text != string.Empty)
                    TxtCodigocondicion.Focus();
            }
        }
        private void Completar_condiciones()
        {
            if (TxtCodigocondicion.Fun_SQL_Buscar_CodigoRegistro("gendbfcondicion", "idcondicion"))
            {
                DataSet ds = TxtCodigocondicion._Dataset;
                Txtdescripcioncondicion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
               


            }
            else
            {
                Txtdescripcioncondicion.Text = "";
            }
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idcliente as codigo, nombre as descripcion from cxcdbfcliente where nulo = 0", "descripcion", "Cliente");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigocliente.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
         
                if (TxtCodigocliente.Text != string.Empty)
                    Txtlimitecodigocliente.Focus();
            }

        }

        private void btnBuscarlimitecliente_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idcliente as codigo, nombre as descripcion from cxcdbfcliente where nulo = 0", "descripcion", "Cliente");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                Txtlimitecodigocliente.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();

                if (Txtlimitecodigocliente.Text != string.Empty)
                    TxtCodigocliente.Focus();
            }
        }

        private void cmbBase5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtCodigotipocliente_Validated(object sender, EventArgs e)
        {
            if (TxtCodigotipocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbftipocliente", "idtipocliente"))
            {
                DataSet ds = TxtCodigocliente._Dataset;

                Txtdescripciontipocliente.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                TxtCodigocliente.Focus();
            }
            else Txtdescripciontipocliente.Text = "";
        }

        private void TxtCodigovendedor_Validated(object sender, EventArgs e)
        {
            if (TxtCodigovendedor.Fun_SQL_Buscar_CodigoRegistro("nomdbfempleado", "idempleado"))
            {
                DataSet ds = TxtCodigovendedor._Dataset;

                Txtnombrevendedor.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                TxtCodigovendedor.Focus();
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

        private void TxtCodigocondicion_Validated(object sender, EventArgs e)
        {
            if (TxtCodigocondicion.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcondicion", "idcondicion"))
            {
                DataSet ds = TxtCodigocondicion._Dataset;

                Txtdescripcioncondicion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                TxtCodigosector.Focus();
            }
            else Txtdescripcioncondicion.Text = "";
        }
        protected override void Presentar()
        {
            base.Presentar();

            var reporte = new Reporte_General.CXC.cxcrepcliente001();

            if (Lbsformato.SelectedIndex == 0)
            {
                reporte.informe = "cxcrepcliente001.rdlc";
            }
            else if (Lbsformato.SelectedIndex == 1)
            {
                reporte.informe = "cxcrepcliente002.rdlc";
            }
            else if (Lbsformato.SelectedIndex == 2)
            {
                reporte.informe = "cxcrepcliente003.rdlc";
            }
            else if (Lbsformato.SelectedIndex == 3)
            {
                reporte.informe = "cxcrepcliente004.rdlc";
            }
            else if (Lbsformato.SelectedIndex == 4)
            {
                reporte.informe = "cxcrepcliente005.rdlc";
            }
            else if (Lbsformato.SelectedIndex == 5)
            {
                reporte.informe = "cxcrepcliente006.rdlc";
            }
            else if (Lbsformato.SelectedIndex == 6)
            {
                reporte.informe = "cxcrepcliente007.rdlc";
            }

            reporte.codigoinicial = TxtCodigocliente.Text;
            reporte.codigofinal = Txtlimitecodigocliente.Text;
            reporte.nombre = Txtnombrecliente.Text;
            reporte.idcondicion = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigocondicion.Text);
            reporte.idciudad = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigociudad.Text);
            reporte.idtipocliente = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigotipocliente.Text);
            reporte.idruta = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigoruta.Text);
            reporte.condicionncf = frm.condicionncf();
            reporte.fechainicial = Dtpfechainicial;
            reporte.fechafinal = Dtpfechafinal;
            reporte.nulo = nulo();
            reporte.itbis = noitbis(); ;
            reporte.cuentaincobrable = cuentaincobrable();
            reporte.idsector = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigosector.Text);

            reporte.orden = Lbsorden.Text;


            reporte.idmunicipio = 0;//Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigomunicipio.Text);
            reporte.idregion = 0;// Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigoregion.Text);


            if (reporte.cuentafilas() > 0)
                reporte.Show();
            else Logistica.Mensajes.Datosenlimites();

            TxtCodigocliente.Select();

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
        protected int noitbis()
        {
            int valor = 0;
            if (Convert.ToInt16(cmbitbis.SelectedValue) == 0)
                valor = 2;
            else if (Convert.ToInt16(cmbitbis.SelectedValue) == 1)
                valor = 1;
            else if (Convert.ToInt16(cmbitbis.SelectedValue) == 2)
                valor = 0;

            return valor;

        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtCodigocliente.Focus();
        }

        private void cmbestatus_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        private void TxtCodigoregion_Validating(object sender, CancelEventArgs e)
        {
            Completar_region();
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

        private void TxtCodigomunicipio_Validating(object sender, CancelEventArgs e)
        {
            Completar_municipio();

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
    }
}
