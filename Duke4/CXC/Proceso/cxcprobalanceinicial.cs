
using Duke4.Consulta_General;
using Duke4.Logistica;
using Funciones_Duke4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.CXC.Proceso
{
    public partial class cxcprobalanceinicial : MainFormProceso
    {
        public cxcprobalanceinicial()
        {
            InitializeComponent();
        }
                

        private void button1_Click(object sender, EventArgs e)
        {
            double suma=0;
            if (Dgv.SelectedRows.Count> 0 && Dgv.Rows.Count>1 )
            {
                if (Dgv.CurrentRow.Index <= Dgv.Rows.Count - 2)
                {
                    Dgv.Rows.RemoveAt(Dgv.CurrentRow.Index);

                    foreach (DataGridViewRow row in Dgv.Rows)
                    {
                      
                        if (Convert.ToString(row.Cells[3].Value)!=string.Empty)
                        suma += Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells[3].Value));
                    }
                    Txttotal.Text= suma +"";
                  
                }
                else if (Dgv.CurrentRow.Index < Dgv.Rows.Count)
                    MessageBox.Show("No se puede eliminar la ultima linea");
            }
        }

        private void Txtcodigocli_Leave(object sender, EventArgs e)
        {
        }

        private void MPPBalance_Inicial_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Registro de Balance Inicial", this);
            
            Logistica.FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");
            if (Cmbmoneda.Items.Count > 0)
                Cmbmoneda.SelectedIndex = 0;
            Dgv.AllowUserToAddRows = true;

            Crear();
        }

        private void MainGridBase_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int columnIndex = Dgv.CurrentCell.ColumnIndex;

            if (Dgv.Columns[columnIndex].Name == "factura")
            {
                DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;

                dText.KeyPress -= new KeyPressEventHandler(dText_KeyPress);
                dText.KeyPress += new KeyPressEventHandler(dText_KeyPress);
            }
        }
        void dText_KeyPress(object sender, KeyPressEventArgs e)
        {
            int columnIndex = Dgv.CurrentCell.ColumnIndex;

            if (Dgv.Columns[columnIndex].Name == "factura")
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void MainGridBase_CellValueChanged(object sender, DataGridViewCellEventArgs e)

        {
          
        }

        private void calculatxtaplica()
        {
        
            double calculoaplic = 0;
            if (Dgv.Rows.Count > 1)
            {
                
                foreach (DataGridViewRow item in Dgv.Rows)
                {
                 
                    if (Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["monto"].Value)) != 0)
                    {
                        calculoaplic += Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(item.Cells["monto"].Value + "");

                    }
            
                }
                Txttotal.Text = calculoaplic + "";

            }

            
        }
                     

        private void MainGridBase_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv.Columns[e.ColumnIndex].Name == "monto")
            {
                calculatxtaplica();
            }
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            MFConsulta_Cliente Consulta_Cliente = new MFConsulta_Cliente("=");

            if (Consulta_Cliente.ShowDialog(this) == DialogResult.OK)
            {
                Txtcodigocliente.Focus();

                Txtcodigocliente.Text = Consulta_Cliente._CodigoSeleccionado;

                Fun_Buscar_Cliente();
            }
        }
        private void Fun_Buscar_Cliente()
        {
            if (Txtcodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {
                DataSet ds = Txtcodigocliente._Dataset;

                if (ds.Tables[0].Rows[0]["idcliente"].ToString() == "1")
                {
                    Txtcodigocliente.Text = "";
                    Txtcodigocliente.Focus();
                    Mensajes.Msgb_NoCobros_CliContado();
                }
                else
                {
                    Txtcodigocliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
                    Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                    Txttelefonocliente.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
                    Txtdireccioncliente.Text = ds.Tables[0].Rows[0]["direccion"].ToString();

                    //string cmd3 = string.Format("select cxcdbfruta.idempleado, nombre from nomdbfempleado inner join cxcdbfruta on nomdbfempleado.idempleado=cxcdbfruta.idempleado where idruta='" + Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["idruta"].ToString()) + "' and nomdbfempleado.nulo=0");
                    //DataSet ds3 = FuncionesSQL.Fun_Sql_Ejecutar(cmd3);
                    //if (ds3.Tables.Count > 0)
                    //    if (ds3.Tables[0].Rows.Count > 0)
                    //    {
                    //        Txtcodigovendedor.Text = ds3.Tables[0].Rows[0]["idempleado"].ToString();
                    //        Txtnombrevendedor.Text = ds3.Tables[0].Rows[0]["nombre"].ToString();
                    //    }

                   Txtbalance.Text = FuncionesSQL.Fun_SQL_Buscar_Balance_Cliente(Txtcodigocliente.Text);

                         
                    

                }
            }
            else
            {
                Txtnombrecliente.Text = Txtdireccioncliente.Text = Txttelefonocliente.Text = Txtbalance.Text = "";

            }

        }

        private void Txtcodigocliente_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Cliente();
        }

        private void BtnBuscarVendedor_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral Consulta_Vendedor = new MainFormConsultaGeneral("select idempleado as codigo, nombre as descripcion from nomdbfempleado where nulo=0", "nombre", "Vendedor");
            if (Consulta_Vendedor.ShowDialog(this) == DialogResult.OK)
            {

                Txtcodigovendedor.Text = Consulta_Vendedor.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Txtnombrevendedor.Text = Consulta_Vendedor.MainGrid.SelectedRows[0].Cells[1].Value.ToString();

            }
        }

        private void Txtcodigovendedor_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Vendedor();
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
        protected override void Salvar()
        {
            base.Salvar();
            Control[] array = { Txtcodigocliente, Txtcodigovendedor, Cmbmoneda, Dgv };

            if (!Funciones.Fun_Validar_Campos_Vacios(array))
            {
                string encabezado = "";
                string detalle = "";
                string cierre = "";
                string xml = "";
                for (int c = 0; c <= Dgv.Rows.Count - 2; c++)
                {
                    encabezado = "<Registros csecuencia=\"" + FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("REGISTRO CXC")
            + "\" dfecha=\"" + Convert.ToDateTime(Dgv.Rows[c].Cells["fecha"].Value).ToString("yyyyMMdd")
            + "\" creferencia=\"" + Convert.ToString(Dgv.Rows[c].Cells["factura"].Value)
            + "\" nidcliente=\"" + Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text)
            + "\" ntotal=\"" + Funciones.Fun_Convierte_String_aDecimal(Txttotal.Text)
            + "\" nbalance=\"" + Funciones.Fun_Convierte_String_aDecimal(Txttotal.Text)
            + "\" ntotalitbis=\"" + 0
            + "\" ntotalexento=\"" + 0
            + "\" ntotalgravado16=\"" + 0
            + "\" ntotalgravado18=\"" + 0
            + "\" ntotaldescuentoporciento=\"" + 0
            + "\" ntotaldescuentomonto=\"" + 0
            + "\" ntotalimporte=\"" + Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[c].Cells["monto"].Value))
            + "\" dfechavencimiento=\"" + Convert.ToDateTime(Dgv.Rows[c].Cells["fechaven"].Value).ToString("yyyyMMdd")
            + "\" nidvendedor=\"" + Funciones.Fun_Convierte_String_aEntrero(Txtcodigovendedor.Text)
            + "\" cncf=\"" + ""
            + "\" nidcontabilidad=\"" + 0
            + "\" nidmoneda=\"" + Cmbmoneda.SelectedValue
            + "\" ccomentario=\"" + "BALANCE INICIAL"
            + "\" nbalancecliente =\"" + Funciones.Fun_Convierte_String_aDecimal(Txtbalance.Text)
            + "\" ntiporegistro =\"" + 3
            + "\" ntotalcargo =\"" + 0
            + "\" nidbanco =\"" + 0
            + "\" nidcuentabancaria =\"" + 0
            + "\"> <Facturas>";

                  

                        detalle = detalle + "<Factura nidconcepto=\"" + 0
                     + "\" cdescripcion=\"" + ""
                     + "\" ncantidad=\"" + 1
                     + "\" nprecio=\"" + Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[c].Cells["monto"].Value))
                     + "\" ndescuentomonto=\"" + 0
                     + "\" ndescuentoporciento=\"" + 0
                     + "\" nmontoitbis=\"" + 0
                     + "\" nmontoexento=\"" + 0
                     + "\" nmontogravado16=\"" + 0
                     + "\" nmontogravado18=\"" + 0
                     + "\" nmontoimporte=\"" + Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[c].Cells["monto"].Value))
                     + "\" norden=\"" + 1
                     + "\" nmontocargo=\"" + 0
                     + "\"/>";

                    

                    cierre = "</Facturas> </Registros>";
                    xml = encabezado + detalle + cierre;

                    string cmd = string.Format("exec Spr_cxc_registro '{0}','{1}','{2}','{3}'", "INSERTAR", Properties.Settings.Default.idsesion, 1, xml); //Armo el comando
                    DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                }
                Funciones.Fun_Limpiar_Formulario(MainPanel);
                                

                LblAlerta.Text = "";
            }
            else
                LblAlerta.Text = Mensajes.Stg_Campos_EnBlanco;


        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
