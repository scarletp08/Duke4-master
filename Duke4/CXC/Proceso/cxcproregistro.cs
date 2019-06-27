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
    public partial class cxcproregistro : Duke4.MainFormProceso
    {
        public cxcproregistro()
        {
            InitializeComponent();
        }

        private double tasa = 0;
        private int dia = 0;
        private void button1_Click(object sender, EventArgs e)
        {
       
            Control[] array = { Txtcodigoconcepto, Txtmontogravado };
            
            if (!Funciones.Fun_Validar_Campos_Vacios(array))
            {
                LblAlerta.Text = string.Empty;
                Fun_Agregar_Concepto();               

                Txtcodigoconcepto.Text = Txtdescripcionconcepto.Text = Txtmontogravado.Text = string.Empty;
            }
            else
            {
                LblAlerta.Text = Mensajes.Stg_Campos_EnBlanco;
            }
        }

        private void cxcproregistro_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Registro de Factura", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(Cmbmoneda, "select idmoneda, abreviatura from gendbfmoneda");
            Ckbimprimir.Checked = true;
            Crear();
        }

        private void BtnBuscarVendedor_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral Consulta_Vendedor = new MainFormConsultaGeneral("select idempleado as codigo, nombre as descripcion from nomdbfempleado where nulo=0", "nombre", "Vendedor");
            if (Consulta_Vendedor.ShowDialog() == DialogResult.OK)
            {
                Txtcodigovendedor.Text = Convert.ToString(Consulta_Vendedor.MainGrid.SelectedRows[0].Cells[0].Value);
                Txtnombrevendedor.Text = Convert.ToString(Consulta_Vendedor.MainGrid.SelectedRows[0].Cells[1].Value);
              
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

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            MFConsulta_Cliente Consulta_Cliente = new MFConsulta_Cliente("=");
            if (Consulta_Cliente.ShowDialog(this) == DialogResult.OK)
            {
                Txtcodigocliente.Text = Convert.ToString(Consulta_Cliente.MainGrid.SelectedRows[0].Cells[1].Value);
                BtnModificar.Enabled = false;
                Fun_Buscar_Cliente();
                
            }
        }
        protected void Fun_Buscar_Cliente()
        {
            if (Txtcodigocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbfcliente", "idcliente"))
            {
                DataSet ds = Txtcodigocliente._Dataset;
                if (ds.Tables[0].Rows[0]["idcliente"].ToString() == "1")
                {
                    Txtcodigocliente.Text = "";
                    Txtcodigocliente.Focus();
                    Mensajes.Msgb_NoRegistro_CliContado();
                }
                else
                { 

                dia = 0;

                Txtnombrecliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                Txtdireccioncliente.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                Txttelefonocliente.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
                Txtrnccliente.Text = ds.Tables[0].Rows[0]["rnc"].ToString();
                Txtbalancecliente.Text = FuncionesSQL.Fun_SQL_Buscar_Balance_Cliente(Txtcodigocliente.Text);
                string cmd = string.Format("SELECT dbo.gendbfcondicion.cantidad_dia FROM dbo.cxcdbfcliente CROSS JOIN dbo.gendbfcondicion where gendbfcondicion.idcondicion =cxcdbfcliente.idcondicion and cxcdbfcliente.idcliente='" + Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text.Trim()) + "' and cxcdbfcliente.nulo=0");
                DataSet ds2 = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    dia = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Convert.ToString(ds2.Tables[0].Rows[0][0]));
                }
                Fun_Buscar_Fecha_Vencimiento();

                }

                if(_OpcionSQL!="Modificar")
                FuncionesSQL.Fun_SQL_Buscar_Secuencia_NCF(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["idncf"].ToString()), Dtpfecha.Value, Mskncf);
            }
            else
            {

                Txtnombrecliente.Text =Txtdireccioncliente.Text=Txttelefonocliente.Text=Txtrnccliente.Text=Txtbalancecliente.Text= "";

            }
        }

        protected void Fun_Buscar_Fecha_Vencimiento()
        {
         Dtpfechavencimiento.MinDate = Dtpfecha.Value.AddDays(0);
          
       
                DateTime dt = Dtpfecha.Value;
                dt = dt.AddDays(dia);
                Dtpfechavencimiento.Value = Convert.ToDateTime(dt);
       
        }

        private void Txtcodigocliente_Validating(object sender, CancelEventArgs e)
        {
            if (Txtcodigocliente.Text != "")
                BtnModificar.Enabled = false;

            Fun_Buscar_Cliente();

        }

        

        private void BtnBuscarConcepto_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral Consulta_Concepto = new MainFormConsultaGeneral("select idconcepto as codigo, descripcion from cxcdbfconcepto where nulo=0", "descripcion", "Concepto");
            if (Consulta_Concepto.ShowDialog(this) == DialogResult.OK)
            {

                Txtcodigoconcepto.Text = Convert.ToString(Consulta_Concepto.MainGrid.SelectedRows[0].Cells[0].Value);
                Fun_Buscar_Concepto();

            }
        }
        protected void Fun_Buscar_Concepto()
        {
            tasa = 0;
            if (Txtcodigoconcepto.Fun_SQL_Buscar_SecuenciaRegistro("select idconcepto,descripcion,tasa,cxcdbfconcepto.nulo from cxcdbfconcepto "
            + " inner join gendbftasaitbis on cxcdbfconcepto.iditbis = gendbftasaitbis.iditbis "
            + " where cxcdbfconcepto.nulo = 0 and cxcdbfconcepto.idconcepto = '"+Txtcodigoconcepto.Text+"'"))
            {
                DataSet ds = Txtcodigoconcepto._Dataset;
                Txtdescripcionconcepto.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
                tasa = Funciones.Fun_Convierte_String_aDecimal(ds.Tables[0].Rows[0]["tasa"].ToString());
            }
            else
            {

                Txtdescripcionconcepto.Text = "";

            }
        }
        protected void Fun_Agregar_Concepto()
        {
            double itbis = 0, total = 0, monto = 0;
            int idconcepto = Funciones.Fun_Convierte_String_aEntrero(Txtcodigoconcepto.Text);

            monto = Funciones.Fun_Convierte_String_aDecimal(Txtmontogravado.Text);
            itbis = tasa * (monto/100);
            total = monto + itbis;

            
            bool existe=false;

            foreach (DataGridViewRow row in Dgv.Rows)
            {
                if (Funciones.Fun_Convierte_String_aEntrero(Convert.ToString(row.Cells["dgvid"].Value)) == idconcepto)
                {
                    existe = true;
                    row.Cells["dgvmonto"].Value = monto + Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvmonto"].Value));
                    row.Cells["dgvitbis"].Value = itbis + Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvitbis"].Value));
                    row.Cells["dgvtotal"].Value = total + Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvtotal"].Value));

                }
             
            }

            if(existe==false)
            Dgv.Rows.Add(Dgv.Rows.Count+1,Txtcodigoconcepto.Text, Txtdescripcionconcepto.Text, monto, itbis, total, tasa);
            Fun_Calcular_Totales();
                        
        }
        protected void Fun_Calcular_Totales()
        {
            
            double excento=0,gravado18 = 0, gravado16=0,itbis=0,total=0;
          
                foreach (DataGridViewRow row in Dgv.Rows)
                {
                                
                if (Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvtasaitbis"].Value))==16)
                gravado16 += Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvmonto"].Value));

                else if (Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvtasaitbis"].Value)) ==18)
                gravado18 += Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvmonto"].Value));

                else if (Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvtasaitbis"].Value)) == 0)
                excento += Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvmonto"].Value));

                itbis += Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvitbis"].Value));
                
            }

            Txtgravado16.Text = Convert.ToString(gravado16);
            Txtgravado18.Text = Convert.ToString(gravado18);
            Txtexcento.Text = Convert.ToString(excento);
            Txtitbis.Text= Convert.ToString(itbis);
            Txttotal.Text = Convert.ToString(gravado16 + gravado18 + itbis + excento);
        }
        protected void Fun_Orden()
        {
           
            int contador = 1;
            foreach (DataGridViewRow row in Dgv.Rows)
            {
                row.Cells["dgvorden"].Value = contador;
                contador++;
            }

        }


        private void Txtcodigoconcepto_Validating(object sender, CancelEventArgs e)
        {
            Fun_Buscar_Concepto();
        }
        
        private void Dtpfecha_Validating(object sender, CancelEventArgs e)
        {
            string cmd = "select idncf  from cxcdbfcliente where idcliente ='" + Txtcodigocliente.Text.Trim() + "'";
            DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {

                FuncionesSQL.Fun_SQL_Buscar_Secuencia_NCF(Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0][0].ToString()), Dtpfecha.Value, Mskncf);

            }

            Fun_Buscar_Fecha_Vencimiento();

        }
        

        private void Txtreferencia_Validating(object sender, CancelEventArgs e)
        {
            if (Txtreferencia.Text != "")
            {

                string cmd = string.Format("SELECT cxcdbfregistro.referencia, cxcdbfregistro.idcliente, cxcdbfregistro.secuencia, cxcdbfregistro.fecha FROM cxcdbfregistro "
              + " inner join cxcdbfcliente on cxcdbfcliente.idcliente = cxcdbfregistro.idcliente "
              + " where cxcdbfregistro.idcliente = '" + Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text.Trim()) + "' and cxcdbfcliente.nulo=0 and cxcdbfregistro.secuencia !='" + Txtregistro.Text + "' and cxcdbfregistro.referencia='" + Txtreferencia.Text + "'");
                DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (ds.Tables[0].Rows[0]["referencia"].ToString().Trim() != string.Empty)
                    {
                        Txtreferencia.Text = "";
                        Mensajes.Msgb_Mismo_Registro(ds.Tables[0].Rows[0]["secuencia"].ToString(), Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha"].ToString()));
                        Txtreferencia.Focus();
                    }

                }

            }
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
          
            if (Dgv.SelectedRows.Count > 0 )
            {
                if (Mensajes.Msgb_Eliminar_Fila() == DialogResult.Yes)
                {
                    Dgv.Rows.RemoveAt(Dgv.CurrentRow.Index);
                    Fun_Orden();
                    Fun_Calcular_Totales();
                }
                    
            }
        }

        private void Dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Dgv.Rows.Count > 0) 
            {
                int pos = e.RowIndex;
                if (Dgv.Columns[e.ColumnIndex].Name == "dgvmonto")
                {
                    Dgv.Rows[pos].Cells["dgvitbis"].Value = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvmonto"].Value)) * (Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvtasaitbis"].Value))/100);
                    Dgv.Rows[pos].Cells["dgvtotal"].Value = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvitbis"].Value)) + Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(Dgv.Rows[pos].Cells["dgvmonto"].Value)); ;
                }
                Fun_Calcular_Totales(); 
            }
        }

        private void BtnBuscarVendedor_Click_1(object sender, EventArgs e)
        {
            MainFormConsultaGeneral Consulta_Vendedor = new MainFormConsultaGeneral("select idempleado as codigo, nombre as descripcion from nomdbfempleado where nulo=0", "nombre", "Vendedor");
            if (Consulta_Vendedor.ShowDialog(this) == DialogResult.OK)
            {

                Txtcodigovendedor.Text = Consulta_Vendedor.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Txtnombrevendedor.Text = Consulta_Vendedor.MainGrid.SelectedRows[0].Cells[1].Value.ToString();
               
            }
        }
        protected override void Crear()
        {
            base.Crear();
            Txtregistro.Text = FuncionesSQL.Fun_SQL_Buscar_UltimoNumReg("REGISTRO CXC");
            Txtregistro.Enabled = false;
            BtnBuscarRegistro.Visible = false;
        }
        protected override void Modificar()
        {
            base.Modificar();
            Txtregistro.Enabled = true;
            BtnBuscarRegistro.Visible = true;
        }
        protected override void Salvar()
        {
            base.Salvar();
            Control[] array = { Txtregistro,Txtcodigocliente,Txtcodigovendedor,Txtregistro,Cmbmoneda,Dgv };

            if (!Funciones.Fun_Validar_Campos_Vacios(array)) 
            {
                string encabezado = "";
                string detalle = "";
                string cierre = "";
                string xml = "";
                double tasaitbis = 0,montoexcento=0,montogravado16,montogravado18;
                double importe = Funciones.Fun_Convierte_String_aDecimal(Txttotal.Text) - Funciones.Fun_Convierte_String_aDecimal(Txtitbis.Text);

                encabezado = "<Registros csecuencia=\"" + Txtregistro.Text
            + "\" dfecha=\"" + Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfecha)
            + "\" creferencia=\"" + Txtreferencia.Text
            + "\" nidcliente=\"" + Funciones.Fun_Convierte_String_aEntrero(Txtcodigocliente.Text)
            + "\" ntotal=\"" + Funciones.Fun_Convierte_String_aDecimal(Txttotal.Text)
            + "\" nbalance=\"" + Funciones.Fun_Convierte_String_aDecimal(Txttotal.Text)
            + "\" ntotalitbis=\"" + Funciones.Fun_Convierte_String_aDecimal(Txtitbis.Text)
            + "\" ntotalexento=\"" + Funciones.Fun_Convierte_String_aDecimal(Txtexcento.Text)
            + "\" ntotalgravado16=\"" + Funciones.Fun_Convierte_String_aDecimal(Txtgravado16.Text)
            + "\" ntotalgravado18=\"" + Funciones.Fun_Convierte_String_aDecimal(Txtgravado18.Text)
            + "\" ntotaldescuentoporciento=\"" + 0
            + "\" ntotaldescuentomonto=\"" + 0
            + "\" ntotalimporte=\"" + importe
            + "\" dfechavencimiento=\"" + Funciones.Fun_Convertir_Fecha_FormatoyyyMMdd(Dtpfechavencimiento)
            + "\" nidvendedor=\"" + Funciones.Fun_Convierte_String_aEntrero(Txtcodigovendedor.Text)
            + "\" cncf=\"" + Mskncf.Text
            + "\" nidcontabilidad=\"" + 0 
            + "\" nidmoneda=\"" + Cmbmoneda.SelectedValue
            + "\" ccomentario=\"" + Txtcomentrio.Text
            + "\" nbalancecliente =\"" + Funciones.Fun_Convierte_String_aDecimal(Txtbalancecliente.Text)
            + "\" ntiporegistro =\"" + 1
            + "\" ntotalcargo =\"" + 0
            + "\" nidbanco =\"" + 0
            + "\" nidcuentabancaria =\"" + 0
            + "\"> <Facturas>";

                foreach (DataGridViewRow item in Dgv.Rows) 
                {
                    montoexcento = montogravado16 = montogravado18 = 0;

                    tasaitbis = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvtasaitbis"].Value));

                    if (tasaitbis == 0)
                        montoexcento = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvmonto"].Value));
                    else if (tasaitbis == 0.16)
                        montogravado16 = Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvmonto"].Value));
                    else if (tasaitbis == 0.18)
                        montogravado18= Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvmonto"].Value));


                    detalle = detalle + "<Factura nidconcepto=\"" + Funciones.Fun_Convierte_String_aEntrero(Convert.ToString(item.Cells["dgvid"].Value))
                 + "\" cdescripcion=\"" + item.Cells["dgvdescripcion"].Value
                 + "\" ncantidad=\"" + 1
                 +"\" nprecio=\"" + Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvmonto"].Value))
                 + "\" ndescuentomonto=\"" + 0
                 +"\" ndescuentoporciento=\"" + 0 
                 +"\" nmontoitbis=\"" + Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvitbis"].Value))
                 + "\" nmontoexento=\"" + montoexcento
                 +"\" nmontogravado16=\"" + montogravado16
                 +"\" nmontogravado18=\"" + montogravado18
                 +"\" nmontoimporte=\"" + Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(item.Cells["dgvtotal"].Value))
                 + "\" norden=\"" + Funciones.Fun_Convierte_String_aEntrero(Convert.ToString(item.Cells["dgvorden"].Value))
                 + "\" nmontocargo=\"" + 0
                 + "\"/>";

                }

                cierre = "</Facturas> </Registros>";
                xml = encabezado + detalle + cierre;

                string cmd = string.Format("exec Spr_cxc_registro '{0}','{1}','{2}','{3}'",_OpcionSQL, Properties.Settings.Default.idsesion, 1, xml); //Armo el comando
                DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                  if (Ckbimprimir.Checked) 
                {
                    var Reporte_Registro = new Reporte_General.CXC.cxcrepregistro01(); 
                    if (_OpcionSQL == "Modificar")
                        Reporte_Registro._id = ds.Tables[0].Rows[0][0].ToString(); 
                    else
                        Reporte_Registro._id = ds.Tables[1].Rows[0][0].ToString(); 

                    Reporte_Registro.Show();
                    Reporte_Registro.Owner = this;
                }

                Funciones.Fun_Limpiar_Formulario(MainPanel);

                if (_OpcionSQL == "Insertar")
                    Crear();
                else Modificar();

                Ckbimprimir.Checked = true; 

                LblAlerta.Text = ""; 
            }
            else 
                LblAlerta.Text = Mensajes.Stg_Campos_EnBlanco; 


        }

        private void BtnBuscarRegistro_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral Consulta_Registro = new MainFormConsultaGeneral("select secuencia as codigo, nombre as descripcion from cxcdbfregistro inner join cxcdbfcliente on cxcdbfcliente.idcliente=cxcdbfregistro.idcliente where cxcdbfregistro.nulo=0 and tiporegistro=1 ", "nombre", "Registro de Factura");
            if (Consulta_Registro.ShowDialog(this) == DialogResult.OK)
            {
                Txtregistro.Text = Consulta_Registro.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                BtnCrear.Enabled = false;
                Fun_Buscar_Registro();

            }
        }

        protected void Fun_Buscar_Registro()
        {
            if (_OpcionSQL == "Modificar")
            {

                string secuencia = Funciones.Fun_Eliminar_Letras_DeString(Txtregistro.Text);

                if (Txtregistro.Fun_SQL_Buscar_SecuenciaRegistro("SELECT * from cxcdbfregistro where tiporegistro=1 and REPLACE(secuencia,SUBSTRING(secuencia,PATINDEX('%[^0-9]%', secuencia),1),'')=" + Funciones.Fun_Convierte_String_aEntrero(secuencia)))
                {
                    
                    DataSet ds = Txtregistro._Dataset;


                    if (Funciones.Fun_Convierte_String_aDecimal(ds.Tables[0].Rows[0]["balance"].ToString()) == Funciones.Fun_Convierte_String_aDecimal(ds.Tables[0].Rows[0]["total"].ToString()))
                    {
                        Txtregistro.Enabled = false;
                        BtnBuscarRegistro.Visible = false;
                        Txtcodigocliente.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
                        Dtpfechavencimiento.MinDate = new DateTime(1753, 6, 20);
                        Dtpfechavencimiento.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fechavencimiento"]);
                        Dtpfecha.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha"]);
                        Txtreferencia.Text = ds.Tables[0].Rows[0]["referencia"].ToString();
                        Txtitbis.Text = ds.Tables[0].Rows[0]["totalitbis"].ToString();
                        Txttotal.Text = ds.Tables[0].Rows[0]["total"].ToString();
                        Txtexcento.Text = ds.Tables[0].Rows[0]["totalexento"].ToString();
                        Txtgravado16.Text = ds.Tables[0].Rows[0]["totalgravado16"].ToString();
                        Txtgravado18.Text = ds.Tables[0].Rows[0]["totalgravado18"].ToString();
                        //Dtpfecha.validancf(Txtncf);
                        Mskncf.Text = ds.Tables[0].Rows[0]["ncf"].ToString();
                        Txtcodigovendedor.Text = ds.Tables[0].Rows[0]["idvendedor"].ToString();
                        Txtcomentrio.Text = ds.Tables[0].Rows[0]["comentario"].ToString();
                        Cmbmoneda.SelectedValue = ds.Tables[0].Rows[0]["idmoneda"].ToString();
                        Fun_Buscar_Cliente();
                        Fun_Buscar_Vendedor();
                        Fun_Buscar_Detalle_Registro(Funciones.Fun_Convierte_String_aEntrero(ds.Tables[0].Rows[0]["idregistro"].ToString()));

                    }
                    else
                    {
                        Mensajes.Msgb_Tiene_Movimiento_No_Modificar();
                        Funciones.Fun_Limpiar_Formulario(MainPanel);
                        Txtregistro.Focus();
                    }

                }
                else
                {

                    Funciones.Fun_Limpiar_Formulario(MainPanel);
                    

                }
            }
        }

        protected void Fun_Buscar_Detalle_Registro(int idregistro)
        {
            Dgv.Rows.Clear();
            string cmd = string.Format("select orden,cxcdbfregistrodetalle.idconcepto,cxcdbfregistrodetalle.descripcion,precio,montoitbis,montoimporte,tasa from cxcdbfregistrodetalle "
            + " inner join cxcdbfconcepto on cxcdbfconcepto.idconcepto = cxcdbfregistrodetalle.idconcepto "
            + " inner join gendbftasaitbis on gendbftasaitbis.iditbis = cxcdbfconcepto.iditbis  where idregistro='" + idregistro + "'");

            DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
            for(int c=0; c<ds.Tables[0].Rows.Count;c++)
            {
                Dgv.Rows.Add(Dgv.Rows.Count + 1, ds.Tables[0].Rows[c]["idconcepto"] , ds.Tables[0].Rows[c]["descripcion"], ds.Tables[0].Rows[c]["precio"], ds.Tables[0].Rows[c]["montoitbis"], ds.Tables[0].Rows[c]["montoimporte"], ds.Tables[0].Rows[c]["tasa"]);

            }
          
            
        }

        private void Txtregistro_Validating(object sender, CancelEventArgs e)
        {
            if (Txtregistro.Text != "")
                BtnCrear.Enabled = false;

            Fun_Buscar_Registro();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
