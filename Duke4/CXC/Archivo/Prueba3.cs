using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Duke4.Consulta_General;
using Duke4.Logistica;
namespace Duke4.CXC.Archivo
{
    public partial class Prueba3 : Duke4.MainFormMant
    {
        public Prueba3()
        {
            InitializeComponent();
        }

        private void Prueba3_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Ejemplo Form", this);
            array = new Control[] { Txtdescripcion };

        }
        protected override void Crear()
        {
            base.Crear();
            Txtcodigo.Enabled = false;
            Btnbuscar.Visible = false;
            Txtcodigo.Text = Logistica.FuncionesSQL.Fun_SQL_Buscar_UltimoCod("idtipocliente", "cxcdbftipocliente");
            Txtdescripcion.Focus();


        }
        protected override void Modificar()
        {
            base.Modificar();
            Txtcodigo.Enabled = true;
            Btnbuscar.Visible = true;
            Txtcodigo.Focus();
        }
        protected override void Consultar()
        {
            base.Consultar();
            Txtcodigo.Enabled = true;
            Btnbuscar.Visible = true;
            Txtcodigo._IgnorarNulo = true;
            Txtcodigo.Focus();
        }

        protected override void Retornar()
        {
            base.Retornar();
            Txtcodigo._IgnorarNulo = false;
            Txtcodigo._MostrarRegDesactivo = Txtcodigo._MostrarRegActivo = false;
        }
        protected override void Activar()

        {
            
            if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(new Control[] { Txtcodigo }))
            {
                Logistica.FuncionesSQL.Fun_SQL_Activar_Mant(this.Name, Txtcodigo.Text, "cxcdbftipocliente", "idtipocliente");
                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
                LblAlerta.Text = string.Empty;
                base.Activar();
            }
            else
            {
                LblAlerta.Text = Logistica.Mensajes.Stg_Campos_EnBlanco;

            }

        }
        protected override void Desactivar()
        {
            if(!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(new Control[] { Txtcodigo}))
            {
                Logistica.FuncionesSQL.Fun_SQL_Desactivar_Mant(this.Name, Txtcodigo.Text, "cxcdbftipocliente", "idtipocliente");
                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
                LblAlerta.Text = string.Empty;
                base.Desactivar();
            }
            else
            {
                LblAlerta.Text = Logistica.Mensajes.Stg_Campos_EnBlanco;
            }
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idtipocliente as codigo, descripcion from cxcdbftipocliente where nulo"+ _ActivateParameter.ToString()+"0","descripcion","tipo de cliente");
            if(consulta.ShowDialog(this)==DialogResult.OK)
            {
                Txtcodigo.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_tipo_cliente();
            }
        }

        private void Completar_tipo_cliente()
        {
            if(Txtcodigo.Fun_SQL_Buscar_CodigoRegistro("cxcdbftipocliente","idtipocliente"))
                {
                DataSet ds = Txtcodigo._Dataset;
                Txtdescripcion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);

            }
            else
            {
                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);

            }
        }
        protected override void Salvar()
        {
            base.Salvar();
            Control[] array = { Txtcodigo, Txtdescripcion };
            if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(array))
            {
                string cmd = string.Format("exec Spr_cxc_tipocliente '{0}','{1}','{2}','{3}','{4}'", _OpcionSQL, Properties.Settings.Default.idsesion, 1, Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtcodigo.Text), Txtdescripcion.Text);
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

        private void Txtcodigo_Validating(object sender, CancelEventArgs e)
        {
            Completar_tipo_cliente();
        }

        private void Txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, Btnbuscar);
        }
    }
    }
    
   
        
    

