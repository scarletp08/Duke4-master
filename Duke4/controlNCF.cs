using Duke4.Logistica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Duke4
{
    public partial class controlNCF : Form
    {
        
        private int contador = 0;
        // Delegado
        public delegate void Size_Form(bool estado);
        //Evento
        public event Size_Form cambia_size;

        public controlNCF()
        {
            InitializeComponent();
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
        public string condicionncf()
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

       public void inicio()
        {
            if (gridBase1.Rows.Count > 0)
            {
                
                gridBase1.CurrentCell = null;
                foreach (DataGridViewRow item in gridBase1.Rows)
                {
                    item.Cells[""].Value = true;

                }
                gridBase1.EndEdit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void txtBase1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtBase1_TextChanged(object sender, EventArgs e)
        {

        }

        
        public void load()
        {
           

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
            this.gridBase1.DefaultCellStyle.Font = new Font("Tahoma", 5);
            Fun_Grid_Solo_Lectura();
            Seleccionar_Grid();
            Fun_Llena_NCF();
        
            panel1.Visible = true;
          







        }
       

       

        

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
            pictureBox5.Visible = true;
            this.cambia_size(true);




        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            pictureBox5.Visible = false;
            this.cambia_size(false);



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            this.cambia_size(false);

        }
    }
       
       

                   
                   
        
        }




