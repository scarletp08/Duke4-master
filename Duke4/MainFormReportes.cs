using Duke4.Logistica;
using Funciones_Duke4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duke4
{
    public partial class MainFormReportes : MainBar
    {
        public MainFormReportes()
        {
            InitializeComponent();
        }
        DataSet_General.DSGEN.OrdenDataTable ds = new DataSet_General.DSGEN.OrdenDataTable();
        DataTable dt = new DataTable();
        public int idprograma = 0;

        protected virtual void Blanquear()
        {
            Funciones.Fun_Limpiar_Formulario(this);
        }
        protected void InvocarFormulario(Form formulario, Panel p1)
        {
            p1.Controls.Clear();
            //formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.TopLevel = false;
            p1.Controls.Add(formulario);
            formulario.Show();
        }
        protected virtual void Presentar()
        {
            //matriz1 = matriz1;

            String[] matriz = new String[Lbsorden.Items.Count];

            for (int i = 0; i < Lbsorden.Items.Count; i++)
            {
                matriz[i] = Lbsorden.Items[i].ToString();
            }
            bool areEqual = matriz1.SequenceEqual(matriz);

            if (areEqual == false)
            {
                foreach (DataRowView drv in Lbsformato.Items)
                {

                    ordenTableAdapter1.DeleteQuery(Convert.ToInt16(Convert.ToString(drv.Row[Lbsformato.ValueMember])));
                }
                MessageBox.Show("");
                for (int x = 0; x < dt.Rows.Count; x++)
                {

                    ordenTableAdapter1.InsertQuery(Convert.ToInt16(ds.Rows[x]["idformato"].ToString()), Convert.ToInt16(ds.Rows[x]["idorden"].ToString()), Convert.ToInt16(ds.Rows[x]["orden"].ToString()));
                }

            }
        }

        private void MainFormReportes_Load(object sender, EventArgs e)
        {
           
            idprograma = 1;
            

            this.gendbfformatoreporteTableAdapter.Fill(this.dSGEN.gendbfformatoreporte, idprograma);
            this.ordenTableAdapter1.Fill(ds, idprograma);
            ordenar();
         
            matriz1 = new string[Lbsorden.Items.Count];
            for (int i = 0; i < Lbsorden.Items.Count; i++)
            {
                
                matriz1[i] = Lbsorden.Items[i].ToString();
            }
            Lbsorden.Focus();






        }
        public String[] matriz1;
                    
       
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            Presentar();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBlanquear_Click_1(object sender, EventArgs e)
        {
            Blanquear();
        }

        private void Lsbformato_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            ordenar();
            Lbsorden.Focus();

        }
        public class Item
        {
            public string Name { get; set; }
            public string Value { get; set; }

            public Item(string name, string value)
            {
                Name = name;
                Value = value;
            }
            public override string ToString()
            {
                return Name;
            }
        }
        protected void ordenar()
        {
            IEnumerable<DataRow> orderedRows = ds.AsEnumerable()
.OrderBy(r => r.Field<int>("orden"));

            dt = orderedRows.CopyToDataTable();

            if (Lbsformato.SelectedItems.Count > 0)
            {
                Lbsorden.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt16(dt.Rows[i]["idformato"].ToString()) == Convert.ToInt16(Lbsformato.SelectedValue.ToString()))
                    {
                        Item obj = new Item(dt.Rows[i]["descripcion"].ToString(), dt.Rows[i]["idorden"].ToString());
                        this.Lbsorden.Items.Add(obj);

                    }
                }

            }

        }

        private void Lbsorden_DragDrop(object sender, DragEventArgs e)
        {
            int a = this.Lbsorden.Items.Count - 1;
            Point point = Lbsorden.PointToClient(new Point(e.X, e.Y));
            int index = this.Lbsorden.IndexFromPoint(point);
            if (index < 0) index = a - 1;

            Item obj = new Item(((Item)Lbsorden.SelectedItem).Name, ((Item)Lbsorden.SelectedItem).Value);

            this.Lbsorden.Items.Remove(Lbsorden.SelectedItem);

            this.Lbsorden.Items.Insert(index, obj);


            mientrastanto();
        }
        protected void mientrastanto()
        {

            for (int i = 0; i < ds.Rows.Count; i++)
            {


                for (int x = 0; x < Lbsorden.Items.Count; x++)
                {

                    if (Lbsformato.SelectedValue.ToString() == ds.Rows[i]["idformato"].ToString() && ((Item)Lbsorden.Items[x]).Value.ToString() == ds.Rows[i]["idorden"].ToString())
                    {
                        ds.Rows[i]["orden"] = x + 1;
                    }

                }

            }




        }

        private void Lbsorden_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void Lbsorden_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Lbsorden.SelectedItem == null) return;
            this.Lbsorden.DoDragDrop(this.Lbsorden.SelectedItem, DragDropEffects.Move);
        }

        private int prevIndex = -1;

        private void Lbsorden_MouseMove(object sender, MouseEventArgs e)
        {

            int index = Lbsorden.IndexFromPoint(Lbsorden.PointToClient(Cursor.Position));
            if (index != prevIndex)
            {
                prevIndex = index;
                Lbsorden.Invalidate();
            }



        }

        private void Lbsorden_MouseLeave(object sender, EventArgs e)
        {
            prevIndex = -1;
            Lbsorden.Invalidate();
        }

        private void Lbsorden_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;

            Color c;
            if (e.Index == prevIndex)
            {
                c = Color.FromArgb(0, 120, 215); //c = Color.Red; // whatever the "highlight" color should be
            }
            else if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                c = Color.FromArgb(0, 120, 215);
            }
            else
            {

                c = e.BackColor;
            }
            using (SolidBrush brsh = new SolidBrush(c))
            {
                g.FillRectangle(brsh, e.Bounds);
            }

            using (SolidBrush brsh = new SolidBrush(e.ForeColor))
            {
                g.DrawString(Lbsorden.Items[e.Index].ToString(), e.Font,
                 brsh, e.Bounds, StringFormat.GenericDefault);
            }

                   
        e.DrawFocusRectangle();


        }

        private void sListBox1_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void sListBox1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void sListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
           
        }

        private void sListBox1_MouseDown(object sender, MouseEventArgs e)
        {
        }


        private void sListBox1_MouseLeave(object sender, EventArgs e)
        {
        }
            

        private void sListBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void sListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Lbsorden_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lbsorden.SelectedIndex = 0;
        }

        
    }
}
