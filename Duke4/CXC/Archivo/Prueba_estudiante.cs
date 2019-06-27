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
    public partial class Prueba_estudiante : Duke4.MainFormMant
    {
        public Prueba_estudiante()
        {
            InitializeComponent();
        }

        private void Prueba_estudiante_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Registro estudiante ", this);
            array = new Control[] { Txtdescripcion,msktelefono,Cmbsexo };
            //Cmbsexo.SelectedIndex = 0;
            //Cmbsexo.Text = "Seleccione";
        }

        protected override void Crear()
        {
            base.Crear();
            Txtcodigo.Enabled = false;
            Btnbuscar.Visible = false;
            Txtdecimal.Enabled = true;
            Dtpingreso.Enabled = true;
            mskCedula1.Enabled = true;
            Txtcorreo.Enabled = true;
            Cmbsexo.Enabled = true;
            Ckbestado.Enabled = true;
            groupBox1.Enabled = true;
            msktelefono.Enabled = true;
            Txtcodigo.Text = Logistica.FuncionesSQL.Fun_SQL_Buscar_UltimoCod("idestudiante", "prudbfestudiante");
            Txtdescripcion.Focus();
        }

        protected override void Modificar()
        {
            base.Modificar();
            Txtcodigo.Enabled = true;
            Btnbuscar.Visible = true;
            Txtdecimal.Enabled = true;
            Dtpingreso.Enabled = true;
            mskCedula1.Enabled = true;
            Txtcorreo.Enabled = true;
            Cmbsexo.Enabled = true;
            Ckbestado.Enabled = true;
            groupBox1.Enabled = true;
            msktelefono.Enabled = true;
            Txtcodigo.Focus();
        }
        protected override void Consultar()
        {
            base.Consultar();
            Txtdecimal.Enabled = false;
            Dtpingreso.Enabled = false;
            mskCedula1.Enabled = false;
            Txtcorreo.Enabled = false;
            groupBox1.Enabled = false;
            Cmbsexo.Enabled = false;
            Ckbestado.Enabled = false;
            msktelefono.Enabled = false;
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
                Logistica.FuncionesSQL.Fun_SQL_Activar_Mant(this.Name, Txtcodigo.Text, "prudbfestudiante", "idestudiante");
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
            if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(new Control[] { Txtcodigo }))
            {
                Logistica.FuncionesSQL.Fun_SQL_Desactivar_Mant(this.Name, Txtcodigo.Text, "prudbfestudiante", "idestudiante");
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
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idestudiante as codigo, descripcion,sexo from prudbfestudiante where nulo" + _ActivateParameter.ToString() + "nulo", "descripcion", "Estudiante");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {
                Txtcodigo.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Estudiante();
            }
        }

        private void Estudiante()
        {
            if (Txtcodigo.Fun_SQL_Buscar_CodigoRegistro("prudbfestudiante", "idestudiante"))
            {
                DataSet ds = Txtcodigo._Dataset;
                Txtdescripcion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                Txtcorreo.Text = ds.Tables[0].Rows[0]["correo"].ToString();
                Txtdecimal.Text = ds.Tables[0].Rows[0]["balance"].ToString();
                msktelefono.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
                mskCedula1.Text = ds.Tables[0].Rows[0]["cedula"].ToString();
                Cmbsexo.Text = ds.Tables[0].Rows[0]["sexo"].ToString();


     



                //LblEstado.Text = Funciones_Duke4.Funciones.Fun_Buscar_Estado_Registro(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["nulo"].ToString()), _ActivateParameter);

            }
            else
            {
                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);

            }
        }


        protected override void Salvar()
        {
           
            base.Salvar();

            

            int grado = 0;

            if(rdbBase1.Checked)
            {
                grado = 1;
            }
            else
            
                if (rdbBase2.Checked)
                {
                    grado = 2;
                }
            else
               
                if (rdbBase3.Checked)
                {
                    grado = 3;
                }
          
          

            Control[] array = { Txtcodigo, Txtdescripcion };
            if (!Funciones_Duke4.Funciones.Fun_Validar_Campos_Vacios(array))
            {
                string cmd = string.Format("exec Spr_pru_estudiante '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}'",
                    _OpcionSQL, Properties.Settings.Default.idsesion,1, 
                    Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtcodigo.Text),
                  

                    Funciones_Duke4.Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpingreso),
                    Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Txtdecimal.Text),
                     Funciones_Duke4.Funciones.Fun_Convertir_Bool_aInt(Ckbestado.Checked),


              Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Cmbsexo.SelectedIndex.ToString()),
              grado,
              msktelefono.Text          ,
              mskCedula1.Text,
              Txtcorreo.Text,
              Txtdescripcion.Text,
               
                                       
                                      
          Funciones_Duke4.Funciones.Fun_Validar_Correo(Txtcorreo.Text));

                FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                Funciones_Duke4.Funciones.Fun_Limpiar_Formulario(MainPanel);
                Funciones_Duke4.Funciones.Fun_Limpiar_DateTimePicker(Dtpingreso);
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
            Estudiante();
        }

        private void Txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            Funciones_Duke4.Funciones.Fun_F2_Abrir_Consulta(e, Btnbuscar);
        }

        private void Cmbsexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int contador = Cmbsexo.SelectedIndex;

        }

        private void Txtcodigo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Txtcodigo_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
    
}
