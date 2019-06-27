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
    public partial class cxcrepchequesdevuelto : Duke4.MainFormReportes
    {
        public cxcrepchequesdevuelto()
        {
            InitializeComponent();
        }

        private void cxcrepchequesdevuelto_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Listado de Cheques devueltos", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(cmbmoneda, "select idmoneda,abreviatura  from gendbfmoneda");

        }

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
            if (TxtCodigosector.Fun_SQL_Buscar_CodigoRegistro("cxcdbsector", "idsector"))
            {
                DataSet ds = TxtCodigosector._Dataset;

                Txtdescripcionsector.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                TxtCodigosector.Focus();
            }
            else Txtdescripcionsector.Text = "";

        }

        private void TxtCodigocliente_KeyDown(object sender, KeyEventArgs e)
        {
            //Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta("F2", BtnBuscarCliente);
        }

        private void lblBase8_Click(object sender, EventArgs e)
        {

        }

        private void lblBase12_Click(object sender, EventArgs e)
        {





        }

        private void cmbBase1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }



    }

