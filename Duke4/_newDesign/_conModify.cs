using Duke4.Consulta_General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duke4._newDesign
{
    public partial class _conModify : MainBar
    {
        public _conModify()
        {
            InitializeComponent();
            
        }
        public int idregistro;
        public string secuencia;

        private void _conModify_Load(object sender, EventArgs e)
        {
            //
         //   CompleteData();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void CompleteName()
        {
            Fun_Set_Nombre_Formulario("Modificando registro: " + secuencia, this);
        }

       public void CompleteData()
        {
            string cmd = "select fecha, referencia, idvendedor, emp.nombre, comentario  from cxcdbfregistro inner join nomdbfempleado emp on emp.idempleado = idvendedor where idregistro = " + idregistro;
            DataSet ds = Logistica.FuncionesSQL.Fun_Sql_Ejecutar(cmd);

            dtpBase1.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha"].ToString());
            txtreferencia.Text = ds.Tables[0].Rows[0]["referencia"].ToString();
            TxtCodigo.Text = ds.Tables[0].Rows[0]["idvendedor"].ToString();
            Txtnombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
            txtNota.Text = ds.Tables[0].Rows[0]["comentario"].ToString();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idempleado as codigo,  nombre as descripcion from nomdbfempleado where nulo  = 0", "nombre", "Vendedor");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {
                TxtCodigo.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Txtnombre.Text = consulta.MainGrid.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void TxtCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (TxtCodigo.Fun_SQL_Buscar_CodigoRegistro("nomdbfempleado", "idempleado"))
            {
                DataSet ds = TxtCodigo._Dataset;
                Txtnombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();

            }
            else
                Txtnombre.Text = "";
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {

        }
    }
}
