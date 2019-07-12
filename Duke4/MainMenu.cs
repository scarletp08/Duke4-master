using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.Timers;
using System.Linq;
using System.Reflection;
using System.IO;
using Duke4.Logistica;
using Duke4.CXC;
using Duke4.CXC.Consulta;

namespace Duke4
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {

            InitializeComponent();

        }

        public static SortedList formInstances = new SortedList(); // Para guardar las referencias de las instancias de los formularios

        public Form AbrirVentana(Type type)
        {
            return AbrirVentana(type, false);
        }
        public Form AbrirVentana(Type type, bool dialog)
        {
            Form formulario;
            if ((formulario = (Form)formInstances[type.ToString()]) == null || formulario.IsDisposed)
            {
                formulario = (Form)Activator.CreateInstance(type);
                formInstances[type.ToString()] = formulario;
            }

            formulario.Activate();
            if (dialog)
                formulario.Focus();
            else
            {
                // formulario.MdiParent = this;
                formulario.Show();

                formulario.Owner = this;


            }
            formulario.Focus();

            return formulario;
        }




        //    DialogResult mb = new DialogResult();
        private void MainMenu_Load(object sender, EventArgs e)
        {
            SetFormTitle("");
            this.Size = SystemInformation.PrimaryMonitorSize;
            Lbluser.Text = "";

        }

        protected void SetFormTitle(string title)
        {
            FormTitle.Text = title;
            this.Text = string.Empty;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            HeaderPanel.Size = new Size(this.Size.Width, HeaderPanel.Height);
            panelOptions.Location = new Point(HeaderPanel.Size.Width - 160, 0);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            LblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToLongTimeString();

        }


        protected void salir()
        {

            DialogResult dialogo = MessageBox.Show("¿Desea salir del Sistema?",
              "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogo == DialogResult.Yes)
            {
                Registra_Salida();
                Application.Exit();
            }

        }
        protected void Registra_Salida()
        {
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string cmd1 = string.Format("exec Spr_gen_sesion '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'", "MODIFICAR", Duke4.Properties.Settings.Default.idsesion, Duke4.Properties.Settings.Default.idusuario, "", sqlFormattedDate, Environment.MachineName, FuncionesSQL.Fun_Sql_NombreBd(), 1);
            FuncionesSQL.Fun_Sql_Ejecutar(cmd1);
        }

        private void cxcproregistro_Click(object sender, EventArgs e)
        {
            CXC.Proceso.cxcproregistro formulario = (CXC.Proceso.cxcproregistro)AbrirVentana(typeof(CXC.Proceso.cxcproregistro));

        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            salir();
        }

        private void cxcproreciboingreso_Click(object sender, EventArgs e)
        {
            CXC.Proceso.cxcproreciboingreso formulario = (CXC.Proceso.cxcproreciboingreso)AbrirVentana(typeof(CXC.Proceso.cxcproreciboingreso));

        }

        private void cobroAdelantadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Proceso.cxcprocobroadelantado formulario = (CXC.Proceso.cxcprocobroadelantado)AbrirVentana(typeof(CXC.Proceso.cxcprocobroadelantado));

        }

        private void notaDeDébitoCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Proceso.cxcprodebcre formulario = (CXC.Proceso.cxcprodebcre)AbrirVentana(typeof(CXC.Proceso.cxcprodebcre));

        }

        private void otroIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Proceso.cxcprootroingreso formulario = (CXC.Proceso.cxcprootroingreso)AbrirVentana(typeof(CXC.Proceso.cxcprootroingreso));

        }


        private void chequeDevueltoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CXC.Proceso.cxcprochequefuturo formulario = (CXC.Proceso.cxcprochequefuturo)AbrirVentana(typeof(CXC.Proceso.cxcprochequefuturo));

        }

        private void chequeDevueltoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CXC.Proceso.cxcprochequedevuelto formulario = (CXC.Proceso.cxcprochequedevuelto)AbrirVentana(typeof(CXC.Proceso.cxcprochequedevuelto));

        }

        private void balanceInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Proceso.cxcprobalanceinicial formulario = (CXC.Proceso.cxcprobalanceinicial)AbrirVentana(typeof(CXC.Proceso.cxcprobalanceinicial));

        }

        private void acuerdoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Proceso.cxcproacuerdopago formulario = (CXC.Proceso.cxcproacuerdopago)AbrirVentana(typeof(CXC.Proceso.cxcproacuerdopago));

        }

        private void registroDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Consulta.cxcconregistro formulario = (CXC.Consulta.cxcconregistro)AbrirVentana(typeof(CXC.Consulta.cxcconregistro));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void reciboDeIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Consulta.cxcconreciboingreso formulario = (CXC.Consulta.cxcconreciboingreso)AbrirVentana(typeof(CXC.Consulta.cxcconreciboingreso));

        }

        private void notaDeDébitoCréditoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CXC.Consulta.cxccondebcre formulario = (CXC.Consulta.cxccondebcre)AbrirVentana(typeof(CXC.Consulta.cxccondebcre));

        }

        private void otroIngresoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CXC.Consulta.cxcconotroingreso formulario = (CXC.Consulta.cxcconotroingreso)AbrirVentana(typeof(CXC.Consulta.cxcconotroingreso));

        }

        private void chequeDevueltoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CXC.Consulta.cxcconchequedevuelto formulario = (CXC.Consulta.cxcconchequedevuelto)AbrirVentana(typeof(CXC.Consulta.cxcconchequedevuelto));

        }

        private void chequeFuturoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Consulta.cxcconchequefuturo formulario = (CXC.Consulta.cxcconchequefuturo)AbrirVentana(typeof(CXC.Consulta.cxcconchequefuturo));

        }

        private void cobroPorAdelantadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Consulta.cxcconcobroadelantado formulario = (CXC.Consulta.cxcconcobroadelantado)AbrirVentana(typeof(CXC.Consulta.cxcconcobroadelantado));

        }

        private void tipoDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Archivo.cxcmantipocliente formulario = (CXC.Archivo.cxcmantipocliente)AbrirVentana(typeof(CXC.Archivo.cxcmantipocliente));

        }

        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Archivo.cxcmanMoneda formulario = (CXC.Archivo.cxcmanMoneda)AbrirVentana(typeof(CXC.Archivo.cxcmanMoneda));
        }

        private void condicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Archivo.cxcmancondiciones formulario = (CXC.Archivo.cxcmancondiciones)AbrirVentana(typeof(CXC.Archivo.cxcmancondiciones));
        }

        private void regiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Archivo.cxcmanregiones formulario = (CXC.Archivo.cxcmanregiones)AbrirVentana(typeof(CXC.Archivo.cxcmanregiones));
        }

        private void provinciaCiudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Archivo.cxcmanprovincias formulario = (CXC.Archivo.cxcmanprovincias)AbrirVentana(typeof(CXC.Archivo.cxcmanprovincias));
        }

        private void conceptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Archivo.cxcmanconceptos formulario = (CXC.Archivo.cxcmanconceptos)AbrirVentana(typeof(CXC.Archivo.cxcmanconceptos));
        }

        private void municipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Archivo.cxcmanmunicipios formulario = (CXC.Archivo.cxcmanmunicipios)AbrirVentana(typeof(CXC.Archivo.cxcmanmunicipios));
        }

        private void sectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Archivo.cxcmansectores formulario = (CXC.Archivo.cxcmansectores)AbrirVentana(typeof(CXC.Archivo.cxcmansectores));
        }

        private void registroDeFacturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CXC.Reporte.cxcrepregistro formulario = (CXC.Reporte.cxcrepregistro)AbrirVentana(typeof(CXC.Reporte.cxcrepregistro));

        }

        private void rutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Archivo.cxcmanrutas formulario = (CXC.Archivo.cxcmanrutas)AbrirVentana(typeof(CXC.Archivo.cxcmanrutas));

        }

        private void movimientoFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Consulta.cxcconmovimientoregistro formulario = (CXC.Consulta.cxcconmovimientoregistro)AbrirVentana(typeof(CXC.Consulta.cxcconmovimientoregistro));

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Reporte.cxcrepclientes formulario = (CXC.Reporte.cxcrepclientes)AbrirVentana(typeof(CXC.Reporte.cxcrepclientes));

        }

        private void facturasPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void recibosDeIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Reporte.cxcrepreciboingreso formulario = (CXC.Reporte.cxcrepreciboingreso)AbrirVentana(typeof(CXC.Reporte.cxcrepreciboingreso));

        }

        private void notasDeDébitoCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Reporte.cxcrepnotasdebito_credito formulario = (CXC.Reporte.cxcrepnotasdebito_credito)AbrirVentana(typeof(CXC.Reporte.cxcrepnotasdebito_credito));

        }

        private void balanceAUnaFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Reporte.cxcrepbalanceaunafecha formulario = (CXC.Reporte.cxcrepbalanceaunafecha)AbrirVentana(typeof(CXC.Reporte.cxcrepbalanceaunafecha));

        }

        private void otrosIngresosToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void otrosIngresosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CXC.Reporte.cxcrepotrosingresos formulario = (CXC.Reporte.cxcrepotrosingresos)AbrirVentana(typeof(CXC.Reporte.cxcrepotrosingresos));

        }

        private void chequesDevueltosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Reporte.cxcrepchequesdevuelto formulario = (CXC.Reporte.cxcrepchequesdevuelto)AbrirVentana(typeof(CXC.Reporte.cxcrepchequesdevuelto));


        }

        private void chequesFuturosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Reporte.cxcrepchequesfuturos formulario = (CXC.Reporte.cxcrepchequesfuturos)AbrirVentana(typeof(CXC.Reporte.cxcrepchequesfuturos));


        }

        private void cobroPorAdelantadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CXC.Reporte.cxcrepcobrosporadelantado formulario = (CXC.Reporte.cxcrepcobrosporadelantado)AbrirVentana(typeof(CXC.Reporte.cxcrepcobrosporadelantado));

        }

        private void acuerdoDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Reporte.cxcrepacuerdodepagos formulario = (CXC.Reporte.cxcrepacuerdodepagos)AbrirVentana(typeof(CXC.Reporte.cxcrepacuerdodepagos));

        }

        private void históricoDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Reporte.cxcrephistoricodepagos formulario = (CXC.Reporte.cxcrephistoricodepagos)AbrirVentana(typeof(CXC.Reporte.cxcrephistoricodepagos));

        }

        private void cxcrep_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CXC.Archivo.cxcmancliente formulario = (CXC.Archivo.cxcmancliente)AbrirVentana(typeof(CXC.Archivo.cxcmancliente));


        }

        private void button1_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void registroDeFacturaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CXP.Proceso.cxpproregistro formulario = (CXP.Proceso.cxpproregistro)AbrirVentana(typeof(CXP.Proceso.cxpproregistro));
        }

        private void blue1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _newDesign._newColor formulario = (Duke4._newDesign._newColor)AbrirVentana(typeof(Duke4._newDesign._newColor));
        }

        private void blue2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _newDesign._newColor3 formulario = (_newDesign._newColor3)AbrirVentana(typeof(_newDesign._newColor3));
        }

        private void blue3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _newDesign._newColor4 formulario = (_newDesign._newColor4)AbrirVentana(typeof(_newDesign._newColor4));
        }

        private void green1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _newDesign._newColor2 formulario = (_newDesign._newColor2)AbrirVentana(typeof(_newDesign._newColor2));
        }

        private void green2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _newDesign._newColor6 formulario = (_newDesign._newColor6)AbrirVentana(typeof(_newDesign._newColor6));
        }

        private void yellow1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _newDesign._newColor5 formulario = (_newDesign._newColor5)AbrirVentana(typeof(_newDesign._newColor5));
        }

        private void yellow2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _newDesign._newColor7 formulario = (_newDesign._newColor7)AbrirVentana(typeof(_newDesign._newColor7));
        }

        private void mantMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _mantenimientoVMenu formulario = (_mantenimientoVMenu)AbrirVentana(typeof(_mantenimientoVMenu));
        }

        private void repoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _newDesign._repoVMenu formulario = (_newDesign._repoVMenu)AbrirVentana(typeof(_newDesign._repoVMenu));
        }

        private void procesoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Proceso.cxcproregistro formulario = (CXC.Proceso.cxcproregistro)AbrirVentana(typeof(CXC.Proceso.cxcproregistro));
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _conVmenu formulario = (_conVmenu)AbrirVentana(typeof(_conVmenu));
        }

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Archivo.Prueba3 formulario= (CXC.Archivo.Prueba3)AbrirVentana(typeof(CXC.Archivo.Prueba3));
        }

        private void pruebaEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Archivo.Prueba_estudiante formulario= (CXC.Archivo.Prueba_estudiante)AbrirVentana(typeof(CXC.Archivo.Prueba_estudiante));
        }

        private void pruebaEstudianteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CXC.Proceso.Dateprocesoprueba formulario = (CXC.Proceso.Dateprocesoprueba)AbrirVentana(typeof(CXC.Proceso.Dateprocesoprueba));
        }

        private void pruebaReporteFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_General.Form1 formulario = (Reporte_General.Form1)AbrirVentana(typeof(Reporte_General.Form1));


        }

        private void prueba2EstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Proceso.Datos_factura2 formulario = (CXC.Proceso.Datos_factura2)AbrirVentana(typeof(CXC.Proceso.Datos_factura2));
        }

        private void pruebaEstudianteToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void purebamuestraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CXC.Reporte.Muestrat formulario = (CXC.Reporte.Muestrat)AbrirVentana(typeof(CXC.Reporte.Muestrat));
        }

        private void pruebaEstudiante3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CXC.Proceso.Prueba_cobro formulario = (CXC.Proceso.Prueba_cobro)AbrirVentana(typeof(CXC.Proceso.Prueba_cobro));
        }
    }
}
