using Funciones_Duke4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4.CXC.Consulta
{
    public partial class cxcconmovimientoregistro : Duke4.MainBar
    {
        public cxcconmovimientoregistro()
        {
            InitializeComponent();
        }

        protected void Fun_Buscar_Movimiento()
        {
            string cmd2 = "";
            string letra = Txtregistro.Text.Substring(0, 1);
            string secuencia = Funciones.Fun_Eliminar_Letras_DeString(Txtregistro.Text);
            secuencia = string.Format("{0:000000000}", Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(secuencia));
            secuencia = letra + secuencia;
            

            string cmd = "    SELECT secuencia,fecha,'FACTURA   ' as tipo,total as totaldebito,CAST( 0 AS numeric(10,2)) as totalcredito,balance,CAST( 0 AS numeric(10,2)) as balanceo, "
        + " CAST('' AS CHARACTER(150)) as Nota, tiporegistro as tipomovimiento "
        + " FROM cxcdbfregistro where Nulo = 0 and cxcdbfregistro.secuencia = '" + secuencia + "' "
        + " union "
        + " SELECT dbo.cxcdbfcobro.secuencia , dbo.cxcdbfcobro.fecha,'COBROS    ' as tipo, "
        + "        CAST(0 as numeric(12, 2)) as totaldebito,dbo.cxcdbfcobrodetalle.monto AS totalcredito,CAST(0 as numeric(12, 2)) as balance,CAST(0 as numeric(12, 2)) as balanceo, "
        + "   cxcdbfcobro.comentario as Nota, CAST(10 AS int) as tipomovimiento "
        + "     FROM dbo.cxcdbfcobro INNER JOIN dbo.cxcdbfcobrodetalle ON dbo.cxcdbfcobro.idcobro = dbo.cxcdbfcobrodetalle.idcobro "
        + "     inner join cxcdbfregistro on cxcdbfregistro.idregistro = cxcdbfcobrodetalle.idregistro "
        + "     where cxcdbfcobro.Nulo = 0  and cxcdbfregistro.secuencia = '" + secuencia + "' and cxcdbfregistro.Nulo = 0 "
        + "     union "
        + " SELECT A.secuencia,a.fecha,'NOTA CRED.' as tipo,CAST(0 as numeric(12, 2)) as totaldebito,B.monto as totalcredito,CAST(0 as numeric(12, 2)) as balance,CAST(0 as numeric(12, 2)) as balanceo, "
        + "     a.concepto as Nota, CAST(11 AS int) as tipomovimiento "
        + "     FROM cxcdbfdebcre as A INNER JOIN cxcdbfdebcredetalle as B on A.idregistro = B.idregistro "
        + "     inner join cxcdbfregistro on cxcdbfregistro.idregistro = B.idfactura "
        + "     where a.Nulo = 0  and tiponota = 1  and cxcdbfregistro.secuencia = '" + secuencia + "' and cxcdbfregistro.Nulo = 0 "
        + "     union "
        + " SELECT A.secuencia,a.fecha,'NOTA DEB. ' as tipo,B.monto as totaldebito,CAST(0 as numeric(12, 2)) as totalcredito,CAST(0 as numeric(12, 2)) as balance,CAST(0 as numeric(12, 2)) as balanceo, "
        + "     a.concepto as Nota, CAST(12 AS int) as tipomovimiento "
        + "     FROM cxcdbfdebcre as A INNER JOIN cxcdbfdebcredetalle as B on A.idregistro = B.idregistro "
        + "     inner join cxcdbfregistro on cxcdbfregistro.idregistro = B.idfactura "
        + "     where a.Nulo = 0  and tiponota = 2  and cxcdbfregistro.secuencia = '" + secuencia + "' and cxcdbfregistro.Nulo = 0 "
        + "     union all "
        + "     SELECT A.secuencia,A.fecha as fecreg,'COB. ADELANTADO' as tipo,CAST(0 as numeric(12, 2)) as totalcredito,A.total as totalcredito,CAST(0.00 as numeric(12, 2)) as balance,CAST(0 as numeric(12, 2)) as balanceo, "
        + " '' as Nota, CAST(10 AS int) as tipomovimiento "
        + "     from cxcdbfcobroadelantadodetalle as A "
        + "     inner join cxcdbfregistro on cxcdbfregistro.idregistro = A.idregistro "
        + "     where A.Nulo = 0 and cxcdbfregistro.secuencia = '" + secuencia + "' and cxcdbfregistro.Nulo = 0 ";

            DataSet ds = Logistica.FuncionesSQL.Fun_Sql_Ejecutar(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                cmd2 = "select cxcdbfregistro.idcliente,nombre,direccion,rnc from cxcdbfcliente "
            + " inner join cxcdbfregistro on cxcdbfregistro.idcliente=cxcdbfcliente.idcliente "
            + " where secuencia ='" + secuencia + "'";

                DataSet ds2 = Logistica.FuncionesSQL.Fun_Sql_Ejecutar(cmd2);

                Txtcodigocliente.Text = ds2.Tables[0].Rows[0]["idcliente"].ToString();
                Txtnombrecliente.Text = ds2.Tables[0].Rows[0]["nombre"].ToString();
                Txtdireccioncliente.Text = ds2.Tables[0].Rows[0]["direccion"].ToString();
                mskRncCedula1.Text = ds2.Tables[0].Rows[0]["rnc"].ToString();


                double c = 0;
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    c += Funciones.Fun_Convierte_String_aDecimal(row[3].ToString()) - Funciones.Fun_Convierte_String_aDecimal(row[4].ToString());
                    gridBase1.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], c, row[7], row[8]);
                }
            }


        }
        protected void Fun_Calcular_Totales()
        {
            double totalcredito = 0, totaldebito = 0, balance = 0, balanceo = 0;
            int c = 0;

            foreach (DataGridViewRow row in gridBase1.Rows)
            {

                if (row.Visible)
                {
                    totalcredito += Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvtotalcredito"].Value));
                    totaldebito += Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvtotaldebito"].Value));
                    balance += Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvbalance"].Value));
                    balanceo += Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(Convert.ToString(row.Cells["dgvbalanceo"].Value));

                }

            }
            Txttotaldebito.Text = Convert.ToString(totaldebito);
            Txttotalcredito.Text = Convert.ToString(totalcredito);
            Txtbalance.Text = Convert.ToString(balance);
            Txtbalanceo.Text = Convert.ToString(balanceo);
        }

        private void Txtregistro_Validating(object sender, CancelEventArgs e)
        {
            gridBase1.Rows.Clear();
            Fun_Buscar_Movimiento();
            Fun_Calcular_Totales();

        }

        private void cxcconmovimientoregistro_Load(object sender, EventArgs e)
        {
            Fun_Grid_Solo_Lectura();
            Fun_Set_Nombre_Formulario("Consulta de Movimiento de Registro", this);

        }
        private void Fun_Grid_Solo_Lectura()
        {
            gridBase1.ReadOnly = false;
            foreach (DataGridViewColumn c in gridBase1.Columns)
            {
                if (c.Index != (gridBase1.ColumnCount - 1))
                    c.ReadOnly = true;
            }
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
                                     this.DisplayRectangle);

        }
    }
}
