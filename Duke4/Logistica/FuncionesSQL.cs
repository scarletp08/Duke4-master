using Funciones_Duke4;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duke4.Logistica
{
    public class FuncionesSQL
    {

        /// <summary>
        /// Retorna el nombre de la base de datos
        /// </summary>
        /// <returns>string con el nombre de la base de datos actual</returns>
        public static string Fun_Sql_NombreBd()
        {
            string connectionString = Properties.Settings.Default.Duke4ConnectionString;
            System.Data.SqlClient.SqlConnectionStringBuilder builder = new System.Data.SqlClient.SqlConnectionStringBuilder(connectionString);


            string database = builder.InitialCatalog;
            return database;
        }

        /// <summary>
        /// Busca en la base de datos para autocompletar la descripción segun se presionen teclas del textbox
        /// </summary>
        /// <param name="cajaTexto">El control tipo Textbox a completar</param>
        /// <param name="cmd">Comando a ejecutar</param>
        public static void Fun_Sql_Autocompletar_Texto(TextBox cajaTexto, string cmd)
        {
            DataTable dt = new DataTable();
            SqlConnection cnn;
            SqlCommand command;

            try
            {
                cnn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Duke4.Properties.Settings.Duke4ConnectionString"].ConnectionString);
                cnn.Open();
                command = new SqlCommand(cmd, cnn);

                SqlDataAdapter adap = new SqlDataAdapter(command);

                adap.Fill(dt);

                AutoCompleteStringCollection AutoItem = new AutoCompleteStringCollection();
                foreach (DataRow rw in dt.Rows)
                {
                    AutoItem.Add(rw[0].ToString());
                }

                cajaTexto.AutoCompleteCustomSource = AutoItem;

            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// Busca en la base de datos la secuencia del ncf de acuerdo al tipo que se le envia
        /// </summary>
        /// <param name="idncf">id del ncf a buscar secuencia</param>
        /// <param name="dtp">datetimepicker a utilizar para saber si buscar nueva o vieja version de ncf</param>
        public static void Fun_SQL_Buscar_Secuencia_NCF(int idncf,DateTime dtp, MaskedTextBox msk)
        {

            var date1 = "01/05/2018";
            DateTime dt2 = DateTime.ParseExact(date1, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DataSet ds = new DataSet();
            string cmd = "", secuencia = "";

            if (dtp < dt2)
            {
                msk.Mask = ">A000000000000000000";
                msk.Size = new Size(160, 23);
                cmd = "select base,secuencia from gendbfncf where idncf = '" + idncf + "'";
                ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                if (ds.Tables[0].Rows.Count > 0)
                {

                    secuencia = string.Format("{0:00000000}", Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0][1].ToString()) + 1);
                    msk.Text = ds.Tables[0].Rows[0][0].ToString() + secuencia;
                
                }
            }
            else
            {
                msk.Mask = ">A0000000000";
                msk.Size = new Size(101, 23);
                cmd = "select serie,secuencia,tipo from gendbfncf2 where idncf ='" + idncf + "'";

                ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    secuencia = string.Format("{0:00000000}", Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0][1].ToString()) + 1);
                    msk.Text = ds.Tables[0].Rows[0][0].ToString()+ ds.Tables[0].Rows[0][2].ToString() + secuencia;
                   
                }
            }
            

        }
        /// <summary>
        /// Busca en la base de datos el balance del cliente enviado
        /// </summary>
        /// <param name="idcliente">id de cliente a buscar el balance</param>
        public static string Fun_SQL_Buscar_Balance_Cliente(string idcliente)
        {
            string cmd = "select sum(cxcdbfregistro.balance) from cxcdbfregistro where cxcdbfregistro.idcliente ='" + idcliente + "' and cxcdbfregistro.nulo=0";

            DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
            
            return ds.Tables[0].Rows[0][0].ToString();
        }
        /// <summary>
        /// Busca en la base de datos la tasa de la moneda enviada
        /// </summary>
        /// <param name="idmoneda">id de la moneda a buscar la tasa</param>
        public static double Fun_SQL_Buscar_Tasa_Moneda(int idmoneda)
        {
            double tasa = 0;
            if (idmoneda > 0)
            {
                string cmd = "select tasa from gendbfmoneda where idmoneda='" + idmoneda + "'";

                DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                if (ds.Tables[0].Rows.Count > 0)
                    tasa = Funciones.Fun_Convierte_String_aDecimal(ds.Tables[0].Rows[0][0].ToString());
            }

            return tasa;
        }


        /// <summary>
        /// Busca en la base de datos el deposito del cliente enviado
        /// </summary>
        /// <param name="idcliente">id de cliente a buscar el deposito</param>
        public static string Fun_SQL_Buscar_Deposito_Cliente(string idcliente)
        {
            string cmd = "select sum(balance) from cxcdbfcobroadelantado where idcliente ='" + idcliente + "' and nulo=0";

            DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

            return ds.Tables[0].Rows[0][0].ToString();
        }

        /// <summary>
        /// Incrementa +1 la secuencia del tipo de comprobante enviado
        /// </summary>
        /// <param name="idncf">id de cliente a buscar el deposito</param>
        public static void Fun_SQL_Actualizar_NCF(int idncf)
        {
            string cmd = "update gendbfncf2 set secuencia = secuencia+1 where tipo ='" + idncf + "' ";

            FuncionesSQL.Fun_Sql_Ejecutar(cmd);
            
        }

        /// <summary>
        /// Busca en la base de datos para autocompletar el codigo y descripción segun se presionen teclas del textbox
        /// </summary>
        /// <param name="cajaTexto">El control tipo Textbox a completar</param>
        /// <param name="cmd">Comando a ejecutar</param>

        public static void Fun_Sql_Autocompletar_TextoyCodigo(TextBox cajaTexto, string cmd)
        {
            DataTable dt = new DataTable();
            SqlConnection cnn;
            SqlCommand command;

            try
            {
                cnn = new SqlConnection(Properties.Settings.Default.Duke4ConnectionString);
                cnn.Open();
                command = new SqlCommand(cmd, cnn);


                SqlDataAdapter adap = new SqlDataAdapter(command);

                adap.Fill(dt);

                AutoCompleteStringCollection AutoItem = new AutoCompleteStringCollection();
                foreach (DataRow rw in dt.Rows)
                {
                    AutoItem.Add(String.Format("{0,-20} | {1}", rw[1].ToString(), rw[0].ToString()));

                }

                cajaTexto.AutoCompleteCustomSource = AutoItem;



            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// Ejecuta el comando en SQL
        /// </summary>
        /// <param name="cmd">El comando a ejecutar</param>
        /// <returns>Un Objeto tipo Dataset</returns>
        public static DataSet Fun_Sql_Ejecutar(string cmd)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Duke4.Properties.Settings.Duke4ConnectionString"].ConnectionString);

                SqlDataAdapter da = new SqlDataAdapter(cmd, cn);

                cn.Close();
                da.Fill(ds);

                cn.Dispose();
                da.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            
            return ds;
        }

        /// <summary>
        /// Tomar datos de SQL, un id y descripción e insertarlos en un Combobox, muestra solo la descripción
        /// </summary>
        /// <param name="combo">El combobox a modificar</param>
        /// <param name="cmd">Los datos a insertar en el combobox</param>
        public static void Fun_SQL_Completar_ComboboxTexto(ComboBox combo, string cmd)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.Duke4ConnectionString);
            List<CmbItem> lista = new List<CmbItem>();

            SqlCommand comand = new SqlCommand(cmd, cn);
            comand.CommandText = cmd;
            cn.Open();
            SqlDataReader drd = comand.ExecuteReader();

            lista.Add(new CmbItem("Seleccione", "0"));

            while (drd.Read())
            {
                lista.Add(new CmbItem(drd[1].ToString(), drd[0].ToString()));
            }

            combo.DisplayMember = "Name";
            combo.ValueMember = "Value";
            combo.DataSource = lista;

            //if (drd.HasRows)
            //{
            //    combo.SelectedIndex = 1;
            //}
        }

      
        /// <summary>
        /// Tomar datos de SQL, un id y descripción e insertarlos en un Combobox, muestra id y descripción
        /// </summary>
        /// <param name="combo">El combobox a modificar</param>
        /// <param name="cmd">Los datos a insertar en el combobox</param>
        public static void Fun_SQL_Completar_Combobox_TextoyCod(ComboBox combo, string cmd)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.Duke4ConnectionString);
            List<CmbItem> lista = new List<CmbItem>();

            SqlCommand comand = new SqlCommand(cmd, cn);
            comand.CommandText = cmd;
            cn.Open();
            SqlDataReader drd = comand.ExecuteReader();

            lista.Add(new CmbItem("Seleccione", "0"));

            while (drd.Read())
            {

                lista.Add(new CmbItem(String.Format("{0,-20} | {1}", drd[1].ToString(), drd[2].ToString()), drd[0].ToString()));

            }
            combo.DisplayMember = "Name";
            combo.ValueMember = "Value";
            combo.DataSource = lista;
        }
        /// <summary>
        /// Busca el ultimo codigo de la BD
        /// </summary>
        /// <param name="nombreCampo">nombre de la celda tipo int ej IdEstudiante</param>
        /// <param name="nombreTabla">nombre de la tabla a buscar</param>
        /// <returns>string con el ultimo codigo +1</returns>
        public static string Fun_SQL_Buscar_UltimoCod(string nombreCampo, string nombreTabla)
        {
            string cmd = "select MAX(" + nombreCampo.Trim() + ") as mayor from " + nombreTabla.Trim();
            int mayor = 0;
            DataSet ds = Fun_Sql_Ejecutar(cmd);

            mayor = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0][0].ToString()) + 1;

            return mayor.ToString();
        }

        /// <summary>
        /// Busca el ultimo numero de un proceso de la BD
        /// </summary>
        /// <param name="nombreProceso">nombre del proceso a buscar ultimo registro string ej Cobro</param>
        ///// <param name="condicion">condicion a utilizar</param>
        /// <returns>string con el ultimo numero de registro</returns>
        public static string Fun_SQL_Buscar_UltimoNumReg(string nombreProceso)
        {
            string cmd = "spr_gen_Secuencias '" + nombreProceso + "', 'NO'";
            DataSet ds = Fun_Sql_Ejecutar(cmd);
            if (ds.Tables[0].Rows.Count > 0)
                return ds.Tables[0].Rows[0][0].ToString();
            else
                return string.Empty;
        }
        /// <summary>
        /// Proceso de Activar un registro de Mantenimiento
        /// </summary>
        /// <param name="nombreprograma">proceso desde donde se ejecuta</param>
        /// <param name="codigo">el id del registro</param>
        /// <param name="tabla">a la que pertenece el registro</param>
        /// <param name="campo">el nombre del codigo ej IdSuplidor</param>
        public static void Fun_SQL_Activar_Mant(string nombreprograma, string codigo, string tabla, string campo)
        {
            string cmd2 = "select nulo from " + tabla + " where " + campo + " = '" + codigo + "'";
            DataSet ds2 = Fun_Sql_Ejecutar(cmd2);
            if (ds2.Tables[0].Rows.Count > 0)
            {
                if (Convert.ToBoolean(ds2.Tables[0].Rows[0][0].ToString()))
                {
                    string cmd = string.Format("EXEC	Spr_gen_cancelacion '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
                Properties.Settings.Default.idsesion, 1, codigo, nombreprograma, "N/A", 0, 1, "");


                    DataSet ds = Fun_Sql_Ejecutar(cmd);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string cmd1 = "update " + tabla + " set nulo = 0 where " + campo + " = '" + codigo + "'";
                        DataSet ds1 = Fun_Sql_Ejecutar(cmd1); ;
                        Mensajes.Msgb_Registro_SalvadoExito();
                    }
                }

                else MessageBox.Show("Este código está Activo");
            }
            else MessageBox.Show("Este código no existe");
        }
        /// <summary>
        /// Proceso de Desactivar un registro de Mantenimiento
        /// </summary>
        /// <param name="nombreprograma">proceso desde donde se ejecuta</param>
        /// <param name="codigo">el id del registro</param>
        /// <param name="tabla">a la que pertenece el registro</param>
        /// <param name="campo">el nombre del codigo ej IdCliente</param>
        public static void Fun_SQL_Desactivar_Mant(string nombreprograma, string codigo, string tabla, string campo)
        {
            string cmd2 = "select nulo from " + tabla + " where " + campo + " = '" + codigo + "'";
            DataSet ds2 = Fun_Sql_Ejecutar(cmd2);
            if (ds2.Tables[0].Rows.Count > 0)
            {
                if (!Convert.ToBoolean(ds2.Tables[0].Rows[0][0].ToString()))
                {
                    string cmd = string.Format("EXEC	Spr_gen_cancelacion '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
            Properties.Settings.Default.idsesion, 1, codigo, nombreprograma, "N/A", 1, 1, "");


            DataSet ds = Fun_Sql_Ejecutar(cmd);
            if (ds.Tables[0].Rows.Count > 0)
            {
                string cmd1 = "update " + tabla + " set nulo =1 where " + campo + "  = '" + codigo + "'";
                DataSet ds1 = Fun_Sql_Ejecutar(cmd1);
                Mensajes.Msgb_Registro_SalvadoExito();
                    }
            }

                else MessageBox.Show("Este código está Desactivado");

            }
            else MessageBox.Show("Este código no existe");
        }
    }
}
