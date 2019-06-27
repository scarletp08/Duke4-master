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
    public partial class cxcrepchequesfuturos : Duke4.MainFormReportes
    {
        public cxcrepchequesfuturos()
        {
            InitializeComponent();
        }


        private void cxcrepchequesfuturos_Load(object sender, EventArgs e)

        {


            Fun_Set_Nombre_Formulario("Listado de Cheques Futuristas", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(cmbBancos, "select idbanco,descripcion  from bandbfbanco");

            this.Dtpdepoinicial.Format = DateTimePickerFormat.Custom;
            this.Dtpdepoinicial.CustomFormat = " ";
            this.Dtpdepfinal.Format = DateTimePickerFormat.Custom;
            this.Dtpdepfinal.CustomFormat = " ";



        }
        //protected override void agregaritems()
        //{
        //    base.agregaritems();
        //    Lsbformato.Items.Add("1->Cheques Futuristas");
        //    Lsbformato.Items.Add("2->Cheques Futuristas" + "\n\r" + "Resumidos");
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

        private void lblBase6_Click(object sender, EventArgs e)
        {

        }
        protected override void Presentar()
        {
            base.Presentar();
            var reporte = new Reporte_General.CXC.cxcrepchequesfuturos001();

            if (Lbsformato.SelectedIndex == 0)
            {
                reporte.informe = "cxcrepchequesfuturos001.rdlc";
            }
            else if (Lbsformato.SelectedIndex == 1)
            {
                reporte.informe = "cxcrepchequesfuturos002.rdlc";
            }

            reporte.fechainicial = Dtpfechainicial;
            reporte.fechafinal = Dtpfechafinal;
            reporte.depositoinicial = Dtpdepoinicial;
            reporte.depositofinal = Dtpdepfinal;
            reporte.nombre = Txtnombrecliente.Text;
            reporte.idtipocliente = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigotipocliente.Text);
            reporte.idvendedor = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigovendedor.Text);
            reporte.idciudad = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigociudad.Text);
            reporte.idruta = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigoruta.Text);
            reporte.idsector = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigosector.Text);
            reporte.idmunicipio = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigomunicipio.Text);
            reporte.idregion = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigoregion.Text);
            reporte.nulo = nulo();
            reporte.procesado = procesado();
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
        protected int procesado()
        {

            int valor = 0;
            if (Convert.ToInt16(cmbprocesado.SelectedIndex) == 0)
                valor = 2;
            else if (Convert.ToInt16(cmbprocesado.SelectedIndex) == 1)
                valor = 1;
            else if (Convert.ToInt16(cmbprocesado.SelectedIndex) == 2)
                valor = 0;

            return valor;

        }

        private void ckbBase1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbBase2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtBase1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dtpdepoinicial_Enter(object sender, EventArgs e)
        {
            //ckbBase1.Select();
        }

        private void Dtpdepfinal_Enter(object sender, EventArgs e)
        {
            //ckbBase2.Select();
        }

        private void Dtpdepoinicial_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void Dtpdepoinicial_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void cmbprocesado_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ckbBase1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (ckbBase1.Checked == true)
            {
                Dtpdepoinicial.Format = DateTimePickerFormat.Custom;
                Dtpdepoinicial.CustomFormat = "dd/MM/yyyy";
                Dtpdepfinal.Format = DateTimePickerFormat.Custom;
                Dtpdepfinal.CustomFormat = "dd/MM/yyyy";
            }
            else
            {
                this.Dtpdepoinicial.Format = DateTimePickerFormat.Custom;
                this.Dtpdepoinicial.CustomFormat = " ";
                this.Dtpdepfinal.Format = DateTimePickerFormat.Custom;
                this.Dtpdepfinal.CustomFormat = " ";

            }
        }

        private void ckbBase1_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void ckbBase1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dtpfechafinal_KeyPress(object sender, KeyPressEventArgs e)
        {




        }

        private void ckbBase1_BackColorChanged_1(object sender, EventArgs e)
        {

        }

        private void ckbBase1_TabIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void fes(object sender, EventArgs e)
        {

        }

        private void Dtpfechafinal_KeyDown(object sender, KeyEventArgs e)
        {


        }

        private void Dtpfechafinal_KeyUp(object sender, KeyEventArgs e)

        {
        }

        private void Dtpfechafinal_KeyDown_1(object sender, KeyEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checkBox1.BackColor = Color.Azure;
        }

        private void txtBase1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cmbBase1_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void cmbBase1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cmbprocesado_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {



        }

        private void ckbBase1_BackColorChanged_2(object sender, EventArgs e)
        {
            
        }

        private void ckbBase1_TabIndexChanged_2(object sender, EventArgs e)
        {
            
        }
    }
}
    

