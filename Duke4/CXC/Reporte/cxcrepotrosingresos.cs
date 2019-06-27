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
    public partial class cxcrepotrosingresos : Duke4.MainFormReportes
    {
        public cxcrepotrosingresos()
        {
            InitializeComponent();
        }

        private void PanelFiltrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cxcrepotrosingresos_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Listado de Otros Ingresos", this);
            FuncionesSQL.Fun_SQL_Completar_ComboboxTexto(cmbmoneda, "select idmoneda,abreviatura  from gendbfmoneda");


        }
        //protected override void agregaritems()
        //{
        //    base.agregaritems();
        //    Lsbformato.Items.Add("1->Otros Ingresos");



        //    Lsbformato.SetSelected(0, true);

        //}



        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {

            MainFormConsultaGeneral consulta = new MainFormConsultaGeneral("select idbeneficiario as codigo, nombre as descripcion from cxcdbfbeneficiario where nulo = 0", "nombre", "Beneficiario");
            if (consulta.ShowDialog(this) == DialogResult.OK)
            {

                Txtnombrebeneficiario.Text = consulta.MainGrid.SelectedRows[0].Cells[1].Value.ToString();
            
                //if (TxtCodigocliente.Text != string.Empty)
                //TxtCodigocliente.Focus();
            }
        }
        protected override void Presentar()
        {
            base.Presentar();
            var reporte = new Reporte_General.CXC.cxcrepotroingreso001();

            if (Lbsformato.SelectedIndex == 0)
            {
                reporte.informe = "cxcrepotroingreso001.rdlc";
            }
            else if (Lbsformato.SelectedIndex == 1)
            {
                reporte.informe = "cxcrepregistro002.rdlc";
            }
            else if (Lbsformato.SelectedIndex == 2)
            {
                //double a = 0.25;

                reporte.informe = "cxcrepregistro003.rdlc";
                

            }
            reporte.fechainicial = Dtpfechainicial;
            reporte.fechafinal = Dtpfechafinal;
            reporte.nombre = Txtnombrebeneficiario.Text;
            reporte.idmoneda = Funciones_Duke4.Funciones.Fun_Convierte_String_aEntrero(Convert.ToString(cmbmoneda.SelectedValue));
            reporte.nulo = nulo();
            reporte.orden = cmborden.Text;
            if (reporte.cuentafilas() > 0)
                reporte.Show();
            else Logistica.Mensajes.Datosenlimites();

            Dtpfechainicial.Select();
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

        private void cmborden_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}