using Duke4.Consulta_General;
using Duke4.Logistica;
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.CXC.Archivo
{
    public partial class cxcmancliente : Duke4.MainFormMantEspecial 
    {

        public cxcmancliente()
        {
            InitializeComponent();

            //this.toolTip1.SetToolTip(this.tabCrtBase1, "ahi campos em blanco en la pestaña 2");
            /*this.ttmensaje.SetToolTip(this.txtsalario, "Ingrese Su salario");
            this.ttmensaje.SetToolTip(this.txtedad, "Ingrese la edad");
            this.ttmensaje.SetToolTip(this.txtdescripcion, "Ingrese una descripción");*/


        }

        private void cxcmancliente_Load(object sender, EventArgs e)
        {
            
            Fun_Set_Nombre_Formulario("Registro de Cliente", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(cmbNCF, "select idncf,codigo +' '+descripcion  codigo from gendbfncf WHERE codigo=01 OR codigo=02 OR codigo = 14 OR codigo = 15 ");
            Txtdireccioncliente.BackColor = Color.White;
            txtExtracredito.BackColor = Color.White;
            tabCrtBase1.TabPages.Remove(Tabestadisticas);
           
            array = new Control[] {  TxtCodigoregion, btnBuscar1, Txtdireccioncliente, Txtcrnc_edulacliente, Txtnombrecliente, TxtCodigociudad,  btnBuscarciudad,  TxtCodigomunicipio, btnBuscar2,  TxtCodigosector, btnBuscarsector,  TxtCodigotipocliente, btnBuscartipocliente, TxtCodigoruta, btnBuscarruta,  Txttelefonocliente, Txtcelularcliente, txtfaxcliente, Txtreferenciacliente, Txtrepresentantecliente, Txtemailcliente, cmbNCF, listcomentarios, txtExtracredito, btnBuscarcondicion,  Txtlimitedecreditocliente,   cmbtipoprecio, Txtcondicion,listBoxalerta,gribbalance };
            MainPanel.Visible = false;
        }
        

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {

            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idcliente as codigo, nombre as descripcion from cxcdbfcliente where nulo " + _ActivateParameter.ToString() + "0", "nombre", "Cliente");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigocliente.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_cliente();
                Completar_condiciones();
                Completar_provincia();
                Completar_tipo_cliente();
                Completar_sector();
                Completar_ruta();
                Completar_region();
                Completar_municipio();
                
                

                if (TxtCodigocliente.Text != string.Empty)
                    TxtCodigocliente.Focus();
            }
        }

        private void Completar_cliente()
        {
            if (TxtCodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {
                DataSet ds = TxtCodigocliente._Dataset;
                Txtcrnc_edulacliente.Text = ds.Tables[0].Rows[0]["rnc"].ToString();
                Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                Txtdireccioncliente.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                Txttelefonocliente.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
                txtfaxcliente.Text = ds.Tables[0].Rows[0]["fax"].ToString();
                Txtcelularcliente.Text = ds.Tables[0].Rows[0]["celular"].ToString();
                Txtreferenciacliente.Text = ds.Tables[0].Rows[0]["referencia"].ToString();
                Txtemailcliente.Text = ds.Tables[0].Rows[0]["email"].ToString();
                Txtrepresentantecliente.Text = ds.Tables[0].Rows[0]["representante"].ToString();
                Txtlimitedecreditocliente.Text = ds.Tables[0].Rows[0]["limitecredito"].ToString();
                listcomentarios.Text = ds.Tables[0].Rows[0]["comentario"].ToString();
                listBoxalerta.Text = ds.Tables[0].Rows[0]["alerta"].ToString();
                txtExtracredito.Text = ds.Tables[0].Rows[0]["idcondicion"].ToString();
                TxtCodigociudad.Text = ds.Tables[0].Rows[0]["idciudad"].ToString();
                TxtCodigotipocliente.Text = ds.Tables[0].Rows[0]["idtipocliente"].ToString();
                TxtCodigosector.Text = ds.Tables[0].Rows[0]["idsector"].ToString();
                TxtCodigoruta.Text = ds.Tables[0].Rows[0]["idruta"].ToString();
                TxtCodigoregion.Text = ds.Tables[0].Rows[0]["idregion"].ToString();
                TxtCodigomunicipio.Text = ds.Tables[0].Rows[0]["idmunicipio"].ToString();
                Txtcondicion.Text= ds.Tables[0].Rows[0]["idcondicion"].ToString();
                cmbNCF.SelectedValue= ds.Tables[0].Rows[0]["idncf"].ToString();
            }
            else
            {
                Txtnombrecliente.Text = "";
            }
        }

        protected override void Crear()
        {
            base.Crear();
            Txtcrnc_edulacliente.Focus();
            tabCrtBase1.SelectedIndex = 0;
            BtnBuscarCliente.Visible = false;
            TxtCodigocliente.Enabled = false;

            TxtCodigocliente.Text = Logistica.FuncionesSQL.Fun_SQL_Buscar_UltimoCod("idcliente", "cxcdbfcliente");


        }
        protected override void Modificar()
        {
            base.Modificar();
            
            tabCrtBase1.SelectedIndex = 0;
            tabCrtBase1.TabPages.Remove(tabPage3);
            tabCrtBase1.TabPages.Add(Tabestadisticas);
            tabCrtBase1.TabPages.Add(tabPage3);
            BtnBuscarCliente.Visible = true;
            TxtCodigocliente.Enabled = true;
            TxtCodigocliente.Focus();
        }
        protected override void AbrirActivar()
        {
            base.AbrirActivar();
            tabCrtBase1.SelectedIndex = 0;
            BtnBuscarCliente.Visible = true;
            TxtCodigocliente.Enabled = true;
            TxtCodigocliente.Focus();
            TxtCodigocliente._MostrarRegDesactivo = TxtCodigocliente._MostrarRegActivo = true;
        }
        protected override void AbrirDesactivar()
        {
            base.AbrirDesactivar();
            tabCrtBase1.SelectedIndex = 0;
            BtnBuscarCliente.Visible = true;
            TxtCodigocliente.Enabled = true;
            TxtCodigocliente.Focus();
        }
        protected override void Retornar()
        {
            base.Retornar();
            tabCrtBase1.TabPages.Remove(Tabestadisticas);
            TxtCodigocliente._IgnorarNulo = false;
            TxtCodigocliente._MostrarRegDesactivo = TxtCodigocliente._MostrarRegActivo = false;
            tabCrtBase1.SelectedIndex = 0;
        }
        protected override void Consultar()
        {
            base.Consultar();
            tabCrtBase1.TabPages.Remove(tabPage3);
            tabCrtBase1.TabPages.Add(Tabestadisticas);
            tabCrtBase1.TabPages.Add(tabPage3);
            tabCrtBase1.SelectedIndex = 0;
            BtnBuscarCliente.Visible = true;
            BtnBuscarCliente.Enabled = TxtCodigocliente.Enabled = true;
            TxtCodigocliente.Focus();
            TxtCodigocliente._IgnorarNulo = true;

        }
        protected override void Activar()
        {
            if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(new Control[] { TxtCodigocliente }))
            {
                Logistica.FuncionesSQL.Fun_SQL_Activar_Mant(this.Name, TxtCodigocliente.Text.Trim(), "cxcdbfcliente", "idcliente");
                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
                LblAlerta.Text = string.Empty;
                base.Activar();
            }
            else
                LblAlerta.Text = Logistica.Mensajes.Stg_Campos_EnBlanco;
        }
        protected override void Desactivar()
        {
            if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(new Control[] { TxtCodigocliente }))
            {
                Logistica.FuncionesSQL.Fun_SQL_Desactivar_Mant(this.Name, TxtCodigocliente.Text.Trim(), "cxcdbfcliente", "idcliente");
                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
                LblAlerta.Text = string.Empty;
                base.Desactivar();
            }
            else
                LblAlerta.Text = Mensajes.Stg_Campos_EnBlanco;
        }


        private void btnBuscartipocliente_Click(object sender, EventArgs e)
        {
        }

        private void btnBuscarvendedor_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarcondicion_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarciudad_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarsector_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarruta_Click(object sender, EventArgs e)
        {

        }

        protected override void Salvar()
        {
            string fecha = "";

            base.Salvar();
            int rdbgrado = 0;

            
            Control[] array = { TxtCodigocliente, Txtnombrecliente, TxtCodigociudad, TxtCodigosector, TxtCodigotipocliente, TxtCodigomunicipio, TxtCodigoregion,cmbNCF };
            try
            {
                if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(array))
                {
                    

                    string cmd = string.Format("Spr_cxc_cliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}'",
                                      _OpcionSQL,
                                      Properties.Settings.Default.idsesion,
                                      1, 
                                       Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigocliente.Text),
                                      Txtnombrecliente.Text,
                                      Txtdireccioncliente.Text,
                                       Txttelefonocliente.Text,
                                       Txtcelularcliente.Text,
                                       Txtcrnc_edulacliente.Text,
                                      cmbNCF.SelectedValue,
                                       Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero( Txtcondicion.Text),
                                       txtfaxcliente.Text,
                                       Txtemailcliente.Text,
                                       Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigociudad.Text),
                                       Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigotipocliente.Text),
                                      Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigosector.Text),
                                       Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigoruta.Text),
                                       checknoITBIS.Checked,
                                       checknoCk.Checked,
                                      checkCuentinco.Checked,
                                       cmbtipoprecio.SelectedValue,
                                       Convert.ToDateTime(System.DateTime.Now).ToString("yyyy-MM-dd"),
                                       Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtlimitedecreditocliente.Text),
                                       Txtreferenciacliente.Text,
                                      Txtrepresentantecliente.Text,
                                      listBoxalerta.Text,
                                      listcomentarios.Text,
                                      0,
                                      fecha,
                                      Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigoregion.Text),
                                      Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigomunicipio.Text));
                                     FuncionesSQL.Fun_Sql_Ejecutar(cmd);
                    Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
                    if (_OpcionSQL == "Insertar")
                        Crear();
                    else
                        Modificar();

                    LblAlerta.Text = string.Empty;
                }
                else
                    LblAlerta.Text = Mensajes.Stg_Campos_EnBlanco;
            }

            
            catch (Exception)
            {

                throw;
            }
        }
           

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void btnBuscarcondicion_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBuscarvendedor_Click_1(object sender, EventArgs e)
        {


        }


        private void btnBuscarruta_Click_1(object sender, EventArgs e)
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
            if (TxtCodigoruta.Fun_SQL_Buscar_SecuenciaRegistro("select descripcion,nombre,r.nulo from nomdbfempleado nm inner join cxcdbfruta r on nm.idempleado=r.idempleado where idruta='" + TxtCodigoruta.Text + "'"))
            {
                DataSet ds = TxtCodigoruta._Dataset;
                Txtdescripcionruta.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                Txtnombrevendedor.Text = ds.Tables[0].Rows[0]["nombre"].ToString();


            }
            else
            {
                Txtdescripcionruta.Text = "";
            }
        }

        private void btnBuscartipocliente_Click_1(object sender, EventArgs e)
        {

            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idtipocliente as codigo, descripcion from cxcdbftipocliente where nulo = 0", "descripcion", "Tipo de Cliente");
            if (consulta.ShowDialog() == DialogResult.OK)
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

        private void btnBuscarsector_Click_1(object sender, EventArgs e)
        {

            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idsector as codigo, descripcion from cxcdbfsector where nulo = 0", "descripcion", "Sector");
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


            }
        }

        private void btnBuscarciudad_Click_1(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idprovincia as codigo, descripcion from cxcdbfprovincia where nulo = 0", "descripcion", "Provincias");
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


            }
            else
            {
                Txtdescripcionciudad.Text = "";
            }
        }

        private void numiUpDownDia_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtCodigocondicion_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscarcondicion);
        }

        private void TxtCodigociudad_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscarciudad);
        }

        private void TxtCodigotipocliente_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscartipocliente);
        }

        private void TxtCodigosector_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscarsector);
        }

        private void TxtCodigoruta_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscarruta);
        }

        private void TxtCodigocondicion_Validating(object sender, CancelEventArgs e)
        {
            if (txtExtracredito.Fun_SQL_Buscar_CodigoRegistro("gendbfcondicion", "idcondicion"))
            {
                DataSet ds = txtExtracredito._Dataset;

                Txtdescripcioncondicion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();

            }
            else Txtdescripcioncondicion.Text = "";

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
                Completar_ruta();

            }
            else
            {
                Txtdescripcionruta.Text = "";
                Txtnombrevendedor.Text = "";

            }


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

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void btnmenos_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblBase7.Visible = true;
            Txtcelularcliente.Visible = true;
            lblBase6.Visible = true;
            txtfaxcliente.Visible = true;
            pictureBox2.Visible = true;


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblBase7.Visible = false;
            Txtcelularcliente.Visible = false;
            lblBase6.Visible = false;
            txtfaxcliente.Visible = false;
            pictureBox2.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            pruebascr fr = new pruebascr();

            fr.ShowDialog();
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idregion as codigo, descripcion from cxcdbfregion where nulo= 0", "descripcion", "Region");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigoregion.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_region();
                if (TxtCodigoregion.Text != string.Empty)
                    TxtCodigoregion.Focus();
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

        private void btnBuscar2_Click(object sender, EventArgs e)
        {

            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idmunicipio as codigo, descripcion from cxcdbfmunicipio where nulo = 0", "descripcion", "Municipios");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigomunicipio.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_municipio();
                if (TxtCodigomunicipio.Text != string.Empty)
                    TxtCodigomunicipio.Focus();

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

        private void btnBuscarcondicion_Click_2(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idcondicion as codigo, descripcion from gendbfcondicion where nulo = 0", "descripcion", "Condiciones");
            if (consulta.ShowDialog() == DialogResult.OK)
            {

                Txtcondicion.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_condiciones();
                if (Txtcondicion.Text != string.Empty)
                    Txtcondicion.Focus();
            }
        }
        private void Completar_condiciones()
        {
            if (Txtcondicion.Fun_SQL_Buscar_CodigoRegistro("gendbfcondicion", "idcondicion"))
            {
                DataSet ds = Txtcondicion._Dataset;
                Txtdescripcioncondicion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                
                    
            }
            else
            {
                Txtdescripcioncondicion.Text = "";
            }
        }

        private void tabCrtBase1_TabIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnBuscar3_Click(object sender, EventArgs e)
        {
        }

        private void tabCrtBase1_SelectedIndexChanged(object sender, EventArgs e)

        {

        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {




        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {


        }

        private void TxtCodigoregion_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscar1);
        }

        private void TxtCodigomunicipio_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void TxtCodigomunicipio_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscar2);
        }

        private void TxtCodigocliente_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, BtnBuscarCliente);
        }

        private void TxtCodigoregion_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigoregion.Fun_SQL_Buscar_CodigoRegistro("cxcdbfregion", "idregion"))
            {
                DataSet ds = TxtCodigoregion._Dataset;

                Txtdescripcionregion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();

            }
            else Txtdescripcionregion.Text = "";
        }

        private void TxtCodigomunicipio_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigomunicipio.Fun_SQL_Buscar_CodigoRegistro("cxcdbfmunicipio", "idmunicipio"))
            {
                DataSet ds = TxtCodigomunicipio._Dataset;

                Txtdescripcionmunicipio.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();

            }
            else Txtdescripcionmunicipio.Text = "";
        }

        private void TxtCodigocliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtCodigocliente_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {
                DataSet ds = TxtCodigocliente._Dataset;

                Completar_cliente();
                Completar_condiciones();
                Completar_provincia();
                Completar_tipo_cliente();
                Completar_sector();
                Completar_ruta();
                Completar_region();
                Completar_municipio();

                

            }
            else
            {
                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(this);
            }

        }
       



        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void tabCrtBase1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Txttelefonocliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txtfaxcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Txtdireccioncliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void listcomentarios_KeyDown(object sender, KeyEventArgs e)
        {

        }
       
        private void listcomentarios_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tabCrtBase1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtExtracredito_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Txtreferenciacliente_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tabCrtBase1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

            if (tabCrtBase1.SelectedIndex == 0)
            {
                Txtcrnc_edulacliente.Focus();

            }
            if (tabCrtBase1.SelectedIndex == 1)
            {
                this.gribbalance.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
                gribbalance.Columns[1].DefaultCellStyle.Format = "C2";
                Txtcondicion.Focus();
                tabCrtBase1.TabStop = false;
                fun_balancexmoneda();
                gribbalance.Columns[0].ReadOnly = true;
                gribbalance.Columns[1].ReadOnly = true;

            }
           
         
        }
        private void fun_balancexmoneda()
        {
            string cmd= "select sum(cxcdbfregistro.balance)as balance,abreviatura from cxcdbfregistro " 
                         + "inner join gendbfmoneda on gendbfmoneda.idmoneda = cxcdbfregistro.idmoneda where idcliente='"+TxtCodigocliente.Text + "'"+
                         " group by abreviatura";

            DataSet ds = new DataSet();
            ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
            gribbalance.DataSource = ds.Tables[0];
        }
       

        private void tabCrtBase1_TabIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Txtreferenciacliente_KeyDown(object sender, KeyEventArgs e)
        {
        



        }

        private void Txtlimitedecreditocliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tabCrtBase1_Selected(object sender, TabControlEventArgs e)
        {
           
        }

        private void Txtcondicion_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tabCrtBase1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Txtcondicion.Focus();
        }

        private void Txtcondicion_Enter(object sender, EventArgs e)
        {

        }

        private void Txtreferenciacliente_KeyUp(object sender, KeyEventArgs e)
        {
            
          
        }

        private void cmbtipoprecio_KeyUp(object sender, KeyEventArgs e)
        {
            

        }

        private void cmbtipoprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
            {
                Txtcrnc_edulacliente.Focus();

        

                Fun_Enfocar_Menu2(e);





            }
        }
        private void Fun_Enfocar_Menu2(KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                
                Cursor.Position = new Point(Cursor.Position.X +0 , Cursor.Position.Y + 500);
           
                menuStrip2.Focus();

                

            }
        }

        private void Txtnombrecliente_MouseUp(object sender, MouseEventArgs e)
        {


        }

        private void Txtnombrecliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                tabCrtBase1.SelectedIndex = 0;



            }
        }

        private void Txtcondicion_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, btnBuscarcondicion);
        }

        private void Txtcondicion_Validating_1(object sender, CancelEventArgs e)
        {
            if (Txtcondicion.Fun_SQL_Buscar_CodigoRegistro("gendbfcondicion", "idcondicion"))
            {
                DataSet ds = Txtcondicion._Dataset;

                Txtdescripcioncondicion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();

            }
            else Txtdescripcioncondicion.Text = "";

        }

        private void Txtreferenciacliente_Enter(object sender, EventArgs e)
        {
           

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            tabCrtBase1.SelectedIndex = 1;
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            button1.PerformClick();
        }
    }
}
    

   
    
