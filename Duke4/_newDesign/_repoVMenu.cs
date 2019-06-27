using Duke4.Consulta_General;
using Duke4.Logistica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Duke4._newDesign
{
    public partial class _repoVMenu : Duke4.MainBar
    {
        public _repoVMenu()
        {
            InitializeComponent();
        }

        protected virtual void Retornar()
        {
            this.Close();
        }
        protected virtual void Presentar()
        {
            var reporte = new Reporte_General.CXC.cxcrepregistro001();

            if (listBox1.SelectedIndex == 0)
            {
                reporte.informe = "cxcrepregistro001.rdlc";
            }
            else if (listBox1.SelectedIndex == 1)
            {
                reporte.informe = "cxcrepregistro002.rdlc";
            }
            else if (listBox1.SelectedIndex == 2)
            {

                reporte.informe = "cxcrepregistro003.rdlc";

            }
            reporte.fechainicial = Dtpfechainicial;
            reporte.fechafinal = Dtpfechafinal;
            reporte.idcliente = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigocliente.Text);
            reporte.nombre = Txtnombrecliente.Text;
            reporte.idtipocliente = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigotipocliente.Text);
            reporte.idvendedor = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigovendedor.Text);
            reporte.idciudad = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigociudad.Text);
            reporte.idruta = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigoruta.Text);
            reporte.idsector = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigosector.Text);
            reporte.idmunicipio = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigomunicipio.Text);
            reporte.idregion = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(TxtCodigoregion.Text);
            reporte.cuentaincobrable = cuentaincobrable();
            reporte.idmoneda = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Convert.ToString(cmbmoneda.SelectedValue));
            reporte.nulo = nulo();
            reporte.condicionncf = condicionncf();
            reporte.orden = lsbBase1.GetItemText(lsbBase1.SelectedItem).Trim();
            if (reporte.cuentafilas() > 0)
                reporte.Show();
            else Mensajes.Datosenlimites();

            Dtpfechainicial.Select();
        }

        private void lsbBase1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Retornar();
        }

        private void RepoVMenu_Load(object sender, EventArgs e)
        {
            lsbBase1.SelectedIndex = 0;
            listBox1.SelectedIndex = 0;
            Dtpfechainicial.Select();
            Fun_Set_Nombre_Formulario("Registro de Factura", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(cmbmoneda, "select idmoneda,abreviatura  from gendbfmoneda");
            Fun_Grid_Solo_Lectura();
            Seleccionar_Grid();
            Fun_Llena_NCF();
            inicio();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            Presentar();
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
        private void Fun_Llena_NCF()
        {
            string cmd = "select descripcion,tipo,idncf from gendbfncf2 where categoria=1";
            DataSet ds = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
            gridBase1.DataSource = ds.Tables[0];


        }
        public void Seleccionar_Grid()
        {
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            var checkheader = new CheckBoxHeaderCell();
            checkheader.OnCheckBoxHeaderClick += checkheader_OnCheckBoxHeaderClick;
            checkColumn.HeaderCell = checkheader;
            gridBase1.Columns.Add(checkColumn);
            gridBase1.Columns[""].Width = 30;
        }
        void checkheader_OnCheckBoxHeaderClick(CheckBoxHeaderCellEventArgs e)
        {
            if (gridBase1.Rows.Count > 0)
            {
                gridBase1.BeginEdit(true);
                gridBase1.CurrentCell = null;
                foreach (DataGridViewRow item in gridBase1.Rows)
                {
                    if (item.Visible == true)
                        item.Cells[""].Value = e.IsChecked;

                }
                gridBase1.EndEdit();
            }

        }
        void inicio()
        {
            if (gridBase1.Rows.Count > 0)
            {
                gridBase1.BeginEdit(true);
                gridBase1.CurrentCell = null;
                foreach (DataGridViewRow item in gridBase1.Rows)
                {
                    item.Cells[""].Value = true;

                }
                gridBase1.EndEdit();
            }

        }
        protected string condicionncf()
        {
            string valores = ",";
            foreach (DataGridViewRow row in gridBase1.Rows)
            {

                int pos = row.Cells[""].RowIndex;
                if (Convert.ToBoolean(row.Cells[""].EditedFormattedValue))
                {
                    valores = valores + gridBase1.Rows[pos].Cells["dgvcodigo"].Value.ToString() + ",";
                }
            }

            return valores;

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
        protected int cuentaincobrable()
        {
            int valor = 0;
            if (Convert.ToInt16(cmbcuentaincobrable.SelectedValue) == 0)
                valor = 2;
            else if (Convert.ToInt16(cmbcuentaincobrable.SelectedValue) == 1)
                valor = 1;
            else if (Convert.ToInt16(cmbcuentaincobrable.SelectedValue) == 2)
                valor = 0;

            return valor;

        }
        private void Completar_tipo_cliente()
        {
            if (TxtCodigotipocliente.Fun_SQL_Buscar_CodigoRegistro("cxcdbftipocliente", "idtipocliente"))
            {
                DataSet ds = TxtCodigotipocliente._Dataset;
            }
            else
                Txtdescripciontipocliente.Text = "";
        }
        private void Completar_region()
        {
            if (TxtCodigoregion.Fun_SQL_Buscar_CodigoRegistro("cxcdbfregion", "idregion"))
            {
                DataSet ds = TxtCodigoregion._Dataset;
                Txtdescripcionregion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();
            }
            else
                Txtdescripcionregion.Text = "";
        }

        private void btnBuscartipocliente_Click(object sender, EventArgs e)
        {
            _ConsultaGeneral consulta = new _ConsultaGeneral("select idtipocliente as codigo, descripcion from cxcdbftipocliente where nulo = 0", "idtipocliente", "descripcion", "Tipo de Cliente");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {
                TxtCodigotipocliente.Text = consulta._CodigoSeleccionado; // consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Txtdescripciontipocliente.Text = consulta._DescripSeleccionado; // consulta.MainGrid.SelectedRows[0].Cells[1].Value.ToString();
                if (TxtCodigotipocliente.Text != string.Empty)
                    TxtCodigoregion.Focus();
            }
        }

        private void TxtCodigotipocliente_Validating(object sender, CancelEventArgs e)
        {
            Completar_tipo_cliente();
        }

        private void btnBuscarregion_Click(object sender, EventArgs e)
        {
            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idregion as codigo, descripcion from cxcdbfregion where nulo = 0", "descripcion", "Regiones");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                TxtCodigoregion.Text = consulta.MainGrid.SelectedRows[0].Cells[0].Value.ToString();
                Completar_region();
                if (TxtCodigoregion.Text != string.Empty)
                    TxtCodigociudad.Focus();
            }
        }
    }
}
