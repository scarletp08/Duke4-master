using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Duke4.Logistica
{

    #region Labels

    /// <summary>
    /// Label base, Verdana 9.75 negro
    /// </summary>
    public partial class LblBase : Label
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Font = new Font("Verdana", 9.75f);
            this.ForeColor = Color.Black;
        }
    }
    /// <summary>
    /// Label negrita, Verdana 9.75 negro y con negrita
    /// </summary>
    public partial class LblNegrita : LblBase
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Font = new Font(this.Font, FontStyle.Bold);
            this.ForeColor = Color.Black;
        }
    }
    /// <summary>
    /// Label Rojo, Verdana 9.75 Rojo y con negrita
    /// </summary>
    public partial class LblRojo : LblNegrita
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.ForeColor = Color.Red;
        }
    }
    /// <summary>
    /// Label Verde, Verdana 9.75 verde y con negrita
    /// </summary>
    public partial class LblVerde : LblNegrita
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.ForeColor = Color.Green;
        }
    }
    /// <summary>
    /// Label Grande, Verdana 14 negro y con negrita
    /// </summary>
    public partial class LblGrandeNgta : LblNegrita
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Font = new Font(this.Font.FontFamily, 14f, FontStyle.Bold);
        }
    }
    /// <summary>
    /// Label Grande, Verdana 14 negro y sin negrita
    /// </summary>
    public partial class LblGrande : LblNegrita
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Font = new Font(this.Font.FontFamily, 14f);
        }
    }
    #endregion
        
    #region Textbox

    /// <summary>
    /// Textbox base, font, colores de entrada y salida, error provider, Fun_SQL_BuscaCodigo
    /// </summary>
    public partial class TxtBase : TextBox
    {
        public bool _Focus = false;
        public string _Codigo = "";
        public ErrorProvider _LocalError = new ErrorProvider();
        public DataSet _Dataset = new DataSet();
        public bool _MostrarRegActivo = false;
        public bool _MostrarRegDesactivo = false;
        public bool _IgnorarNulo = false;// ignora si el codigo esta nulo o no en la Base de Datos

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect, // punto X del upper-left corner o padding del inicio
          int nTopRect,// punto Y del upper-left corner o padding de arriba
          int nRightRect, // punto X del lower-right corner o longitud del objeto
          int nBottomRect,// punto Y del lower-right corner o altura del objeto
                          //RADIOUS que tu quiere que sea el round
          int nheightRect, //height del ellipse
          int nweightRect //width del ellipse
      );

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15));
            //base.BackColor = SystemColors.Window;
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                SendKeys.Send("+{TAB}");
            }
            else if (e.KeyData == Keys.Down)
            {
                SendKeys.Send("{TAB}");
            }
            else
            {
                base.OnKeyDown(e);
            }
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            this.Select(0, 0);
            _Focus = true;
            this.BackColor = Color.LightGoldenrodYellow;
            _Codigo = this.Text;



        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            this.BackColor = SystemColors.Window;
            if (!string.IsNullOrEmpty(this.Text.Trim()))
                Funciones_Duke4.Funciones._ErrorProvider.SetError(this, string.Empty);

        }

        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);

        }
        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);
            _Codigo = "";

        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
        public bool Fun_SQL_Buscar_CodigoRegistro(string nombre_tabla_sql, string codigo_tabla_sql)
        {
            if (this.Text != string.Empty && _Codigo != this.Text)
            {

                string cmd = string.Format("select * from " + nombre_tabla_sql + " where " + codigo_tabla_sql + " ='" + this.Text + "'");
                _Dataset = FuncionesSQL.Fun_Sql_Ejecutar(cmd);

                if (_Dataset.Tables[0].Rows.Count > 0)
                {
                    if (!_IgnorarNulo)
                    {
                        if (Funciones_Duke4.Funciones.Fun_Convertir_Bool_aInt(Convert.ToBoolean(_Dataset.Tables[0].Rows[0]["nulo"].ToString())) == 0 && !_MostrarRegActivo)
                            return true;
                        else if (Funciones_Duke4.Funciones.Fun_Convertir_Bool_aInt(Convert.ToBoolean(_Dataset.Tables[0].Rows[0]["nulo"].ToString())) > 0 && !_MostrarRegDesactivo && _Focus)
                        {
                            Mensajes.Msgb_Registro_Desactivado();
                            this.Text = string.Empty;
                            this.Focus();
                            return false;
                        }
                        else if (Funciones_Duke4.Funciones.Fun_Convertir_Bool_aInt(Convert.ToBoolean(_Dataset.Tables[0].Rows[0]["nulo"].ToString())) > 0 && !_MostrarRegDesactivo && !_Focus)
                        {
                            this.Text = string.Empty;
                            return false;
                        }

                        else if (Funciones_Duke4.Funciones.Fun_Convertir_Bool_aInt(Convert.ToBoolean(_Dataset.Tables[0].Rows[0]["nulo"].ToString())) > 0 && _MostrarRegDesactivo)
                            return true;

                        else if (Funciones_Duke4.Funciones.Fun_Convertir_Bool_aInt(Convert.ToBoolean(_Dataset.Tables[0].Rows[0]["nulo"].ToString())) == 0 && _MostrarRegActivo && _Focus)
                        {
                            Mensajes.Msgb_Registro_Activado();
                            this.Text = string.Empty;
                            this.Focus();
                            return false;
                        }
                    }
                    else
                        return true;
                }
                else if (_Focus)
                {
                    Mensajes.Msgb_Registro_NoExiste();
                    this.Text = string.Empty;
                    this.Focus();
                    return false;
                }
            }
            else if (this.Text != string.Empty && _Codigo == this.Text && _Dataset.Tables.Count > 0)
            {
                return true;

            }
            _Focus = false;

            return false;
        }

        public bool Fun_SQL_Buscar_SecuenciaRegistro(string cmd)
        {
            if (this.Text != string.Empty)
            {
                _Dataset = FuncionesSQL.Fun_Sql_Ejecutar(cmd);
                if (_Dataset.Tables[0].Rows.Count > 0)
                {
                    if (!_IgnorarNulo)
                    {
                        if (Funciones_Duke4.Funciones.Fun_Convertir_Bool_aInt(Convert.ToBoolean(_Dataset.Tables[0].Rows[0]["nulo"].ToString())) == 0 && !_MostrarRegActivo)
                            return true;
                        else if (Funciones_Duke4.Funciones.Fun_Convertir_Bool_aInt(Convert.ToBoolean(_Dataset.Tables[0].Rows[0]["nulo"].ToString())) > 0 && !_MostrarRegDesactivo && _Focus)
                        {
                            Mensajes.Msgb_Registro_Desactivado();
                            this.Text = string.Empty;
                            this.Focus();
                            return false;
                        }
                        else if (Funciones_Duke4.Funciones.Fun_Convertir_Bool_aInt(Convert.ToBoolean(_Dataset.Tables[0].Rows[0]["nulo"].ToString())) > 0 && !_MostrarRegDesactivo && !_Focus)
                        {

                            return true;
                        }

                        else if (Funciones_Duke4.Funciones.Fun_Convertir_Bool_aInt(Convert.ToBoolean(_Dataset.Tables[0].Rows[0]["nulo"].ToString())) > 0 && _MostrarRegDesactivo)
                            return true;

                        else if (Funciones_Duke4.Funciones.Fun_Convertir_Bool_aInt(Convert.ToBoolean(_Dataset.Tables[0].Rows[0]["nulo"].ToString())) == 0 && _MostrarRegActivo && _Focus)
                        {
                            Mensajes.Msgb_Registro_Activado();
                            this.Text = string.Empty;
                            this.Focus();
                            return false;
                        }
                    }
                    else
                        return true;
                }
                else if (_Focus)
                {
                    Mensajes.Msgb_Registro_NoExiste();
                    this.Text = string.Empty;
                    this.Focus();
                    return false;
                }
            }
            else if (this.Text != string.Empty && _Codigo == this.Text && _Dataset.Tables.Count > 0)
            {
                return true;

            }
            return false;
        }
    }
    /// <summary>
    /// Textbox con letra mayuscula
    /// </summary>
    public partial class TxtMayuscula : TxtBase
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.CharacterCasing = CharacterCasing.Upper;
        }
    }
    /// <summary>
    /// Textbox para números decimalesS
    /// </summary>
    public partial class TxtDecimal : TxtBase
    {
        int suma = 0;
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            base.TextAlign = HorizontalAlignment.Right;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            suma = 0;
            if (this.SelectionStart == 0 && e.KeyChar == ',' || this.SelectionStart == 0 && e.KeyChar == '.')
                e.Handled = true;
            else
                e.Handled = false;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;
            else if (e.KeyChar == '.' && this.Text.IndexOf('.') > -1)
                e.Handled = true;
            else if (!char.IsControl(e.KeyChar))
            {
                TextBox textBox = this;
                if (textBox.Text.IndexOf('.') > -1 &&
                         textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                {
                    e.Handled = true;
                }
                for (int i = 0; i < this.Text.Length; i++)
                {
                    if (this.Text[i] != '.')
                        suma++;
                }
                if (textBox.SelectionStart >= 0 && textBox.SelectionStart < suma - 1)
                {
                    e.Handled = false;
                }
            }
        }
        protected override void OnValidated(EventArgs e)
        {
            TextBox textBox = this;
            string ultimoCaracter = "";

            if (this.Text.Trim() != "")
                ultimoCaracter = textBox.Text.Substring(0, 1);

            if (ultimoCaracter.Equals(","))
            {
                this.Text = textBox.Text.Substring(1, this.TextLength - 1);
                this.Text = String.Format("{0:N2}", Convert.ToDouble(this.Text)).Trim('$');
            }
            else if (this.Text.Trim() != "")
                this.Text = String.Format("{0:N2}", Convert.ToDouble(this.Text)).Trim('$');
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (base.Text.Trim() == "")
                base.Text = "0.00";
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (base.Text.Trim() == "0.00")
                base.Text = "";
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            double confirma;
            if (this.ReadOnly == true && Double.TryParse(this.Text.Trim(), out confirma) || this.Enabled == false && Double.TryParse(this.Text.Trim(), out confirma))
            {
                this.Text = String.Format("{0:N2}", Convert.ToDouble(this.Text.Trim()));
            }
            else if (_Focus == false && this.Enabled == true && Double.TryParse(this.Text.Trim(), out confirma))
                this.Text = String.Format("{0:N2}", Convert.ToDouble(this.Text.Trim()));
        }
    }
    /// <summary>
    /// Textbox para contraseñas o claves
    /// </summary>
    public partial class TxtClave : TxtBase
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            base.CharacterCasing = CharacterCasing.Upper;
            this.PasswordChar = '*';
        }
    }
    /// <summary>
    /// Textox para números enteros
    /// </summary>
    public partial class TxtEntero : TxtBase
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
            {
                _LocalError.SetError(this, "Solo insertar digitos");
                e.Handled = true;
            }
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            base.TextAlign = HorizontalAlignment.Right;
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }
    }
    /// <summary>
    /// Texbox para mostrar totales decimales, con un color amarillo fuerte
    /// </summary>
    public partial class TxtTotal : TxtDecimal
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            base.BackColor = Color.FromArgb(255, 255, 128);
        }
    }

    /// <summary>
    /// Textbox que valida UN (1) string como correo electronico
    /// </summary>
    public class TxtCorreo : TxtBase
    {
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            if (!string.IsNullOrEmpty(this.Text.Trim()))
            {
                if (!Funciones_Duke4.Funciones.Fun_Validar_Correo(this.Text))
                {
                    _LocalError.SetError(this, "No es un formato de correo valido");
                }
                else
                    _LocalError.SetError(this, string.Empty);
            }
            else
                _LocalError.SetError(this, string.Empty);
        }
    }
    /// <summary>
    /// Textbox tipo memo/nota/comentario en mayuscula
    /// </summary>
    public class TxtNota : TxtMayuscula
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.ScrollBars = ScrollBars.Vertical;
            this.Multiline = true;
        }
    }
    #endregion

    #region MaskedTextbox
    /// <summary>
    /// MaskedTextbox colores, validar completar la mascara, navegacion en el objeto
    /// </summary>
    public partial class MskBase : MaskedTextBox
    {
        public ErrorProvider _LocalError = new ErrorProvider();

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
     (
         int nLeftRect, // punto X del upper-left corner
         int nTopRect,// punto Y del upper-left corner
         int nRightRect, // punto X del lower-right corner
         int nBottomRect,// punto Y del lower-right corner
                         //RADIOUS
         int nheightRect, //height del ellipse
         int nweightRect //width del ellipse
     );

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, 15, 15));
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            this.BackColor = Color.LightGoldenrodYellow;
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            this.BackColor = SystemColors.Window;
            this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (!string.IsNullOrEmpty(this.Text))
            {
                if (!this.MaskFull && this.Enabled == true && this.ReadOnly == false)
                    _LocalError.SetError(this, "Información incompleta");
                else if (this.MaskFull)
                {
                    _LocalError.SetError(this, string.Empty);
                }
            }
            else
                Funciones_Duke4.Funciones._ErrorProvider.SetError(this, string.Empty);
            this.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                SendKeys.Send("+{TAB}");
            }
            else if (e.KeyData == Keys.Down)
            {
                SendKeys.Send("{TAB}");
            }
            else
            {
                base.OnKeyDown(e);
            }
        }
    }
    /// <summary>
    /// MaskedTextBox con mascara de tarjeta
    /// </summary>
    public partial class MskTarjeta : MskBase
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Mask = "0000-0000-0000-0000";
        }
    }
    /// <summary>
    /// MaskedTextBox con mascara de cedula
    /// </summary>
    public partial class MskCedula : MskBase
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Mask = "000-0000000-0";
        }
    }
    /// <summary>
    /// MaskedTextBox con mascara de RNC
    /// </summary>
    public partial class MskRnc : MskBase
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Mask = "0-00-00000-0";
        }
    }
    /// <summary>
    /// MaskedTextBox con mascara de Cedula, que permite entrar RNC
    /// </summary>
    public partial class MskRncCedula : MskBase
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Mask = "000-0000000-0";
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (!string.IsNullOrEmpty(this.Text))
            {
                if (!this.MaskFull)
                {
                    if (this.Text.Length == 9)
                    {
                        this.Mask = "0-00-00000-0";
                        _LocalError.SetError(this, string.Empty);
                    }
                    else
                        _LocalError.SetError(this, "Información incompleta");
                }
            }
            else
                _LocalError.SetError(this, string.Empty);
            this.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

    }
    /// <summary>
    /// MaskedTextBox con mascara de Ncf (formato 01/03/2018)
    /// </summary>
    public partial class MskNCF : MskBase
    {
        public DateTime _Fecha = DateTime.Now;
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Mask = "A0000000000";
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            //if (_Fecha < new DateTime(2018, 3, 1))
            //    this.Mask = "A000000000000000000";
            //else
            //    this.Text = "";
        }
    }
    /// <summary>
    /// MaskedTexBox para Telefonos
    /// </summary>
    public partial class MskTelefono : MskBase
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Mask = "(000)-000-0000";
        }
    }

    #endregion

    #region Date
    /// <summary>
    /// Datetimepicker con navegabilidad, colores, font, formato dd/mm/yyyy
    /// </summary>
    public partial class DtpBase : DateTimePicker
    {

        private bool selectionComplete = false;
        private bool numberKeyPressed = false;

        private const int WM_KEYUP = 0x0101;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_REFLECT = 0x2000;
        private const int WM_NOTIFY = 0x004e;

        [StructLayout(LayoutKind.Sequential)]
        private struct NMHDR
        {
            public IntPtr hwndFrom;
            public IntPtr idFrom;
            public int Code;
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Font = new Font("Verdana", 9.75f);
            base.CustomFormat = "dd/MM/yyyy";
            base.Format = DateTimePickerFormat.Custom;
        }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            this.BackColor = Color.LightGoldenrodYellow;
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            this.BackColor = SystemColors.Window;
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            numberKeyPressed = (e.Modifiers == Keys.None && ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode != Keys.Back && e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)));
            selectionComplete = false;
            base.OnKeyDown(e);

            if (e.KeyData == Keys.Up)
            {
                SendKeys.Send("+{TAB}");
            }
            else if (e.KeyData == Keys.Down)
            {
                SendKeys.Send("{TAB}");
            }
            else
            {
                base.OnKeyDown(e);
            }

        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_REFLECT + WM_NOTIFY)
            {
                var hdr = (NMHDR)m.GetLParam(typeof(NMHDR));
                if (hdr.Code == -759) //date chosen (by keyboard)
                    selectionComplete = true;
            }
            base.WndProc(ref m);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (numberKeyPressed && selectionComplete &&
                (e.Modifiers == Keys.None && ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode != Keys.Back && e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))))
            {
                Message m = new Message();
                m.HWnd = this.Handle;
                m.LParam = IntPtr.Zero;
                m.WParam = new IntPtr((int)Keys.Right); //right arrow key
                m.Msg = WM_KEYDOWN;
                base.WndProc(ref m);
                m.Msg = WM_KEYUP;
                base.WndProc(ref m);
                numberKeyPressed = false;
                selectionComplete = false;
            }

        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }

    /// <summary>
    /// Datetimepicker al creado formato "  /  /   " luego formato dd/mm/yyyy
    /// </summary>
    public partial class DtpBlanco : DtpBase
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            base.CustomFormat = " ";
            base.Format = DateTimePickerFormat.Custom;
        }
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            SendKeys.Send("{RIGHT 1}");
            base.CustomFormat = "dd/MM/yyyy";
            base.Format = DateTimePickerFormat.Custom;
        }
    }

    /// <summary>
    /// Datetimepicker para la hora en hh:mm
    /// </summary>
    public partial class DtpHora : DtpBase
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            base.CustomFormat = "hh:mm tt";
            base.Format = DateTimePickerFormat.Custom;
            base.Value = DateTime.Now;
        }
    }
    #endregion

    #region Listview
    /// <summary>
    /// Listbox Para contabilidad, con funciones basicas
    /// </summary>
    public class LstBase : ListView
    {
        public LstBase()
        {
            this.View = View.Details;
            this.GridLines = true;
            this.FullRowSelect = true;
        }
        ColumnHeader columnHeader;
        public ArrayList Headers;
        ListViewItem listViewItem;
        public void SetDataSource(DataTable dataTable, ArrayList columnsToShow)
        {
            try
            {
                this.Clear();
                for (int i = 0; i < columnsToShow.Count; i++)
                {
                    columnHeader = new ColumnHeader();
                    columnHeader.Text = Headers[i].ToString();
                    this.Columns.Add(columnHeader);
                }

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    listViewItem = new ListViewItem();

                    for (int j = 0; j < columnsToShow.Count; j++)
                    {
                        listViewItem.SubItems[j].Text = dataTable.Rows[i][columnsToShow[j].ToString()].ToString();
                        listViewItem.SubItems.Add(dataTable.Rows[i][columnsToShow[j].ToString()].ToString());
                        this.AutoResizeColumn(j, ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                    this.Items.Add(listViewItem);
                }
            }
            catch (Exception exp)
            {
                throw exp;
            }
        }
    }
    #endregion

    #region Combo

    /// <summary>
    /// Combobox que permite agregar varias columnas
    /// </summary>
    public class CmbMultiColumn : ComboBox
    {
        public CmbMultiColumn()
        {
            DrawMode = DrawMode.OwnerDrawVariable;
            Font = new Font("Verdana", 9f);
        }
        public new DrawMode DrawMode
        {
            get
            {
                return base.DrawMode;
            }
            set
            {
                base.DrawMode = DrawMode.OwnerDrawVariable;
            }
        }

        public new ComboBoxStyle DropDownStyle
        {
            get
            {
                return base.DropDownStyle;
            }
            set
            {
                if (value == ComboBoxStyle.Simple)
                {
                    throw new NotSupportedException("ComboBoxStyle.Simple not supported");
                }
                base.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        protected override void OnDataSourceChanged(EventArgs e)
        {
            base.OnDataSourceChanged(e);
            InitializeColumns();
        }

        protected override void OnValueMemberChanged(EventArgs e)
        {
            base.OnValueMemberChanged(e);
            InitializeValueMemberColumn();
        }

        protected override void OnDropDown(EventArgs e)
        {
            base.OnDropDown(e);
            this.DropDownWidth = (int)CalculateTotalWidth();
        }

        const int columnPadding = 5;
        private float[] columnWidths = new float[0];
        private String[] columnNames = new String[0];
        private int valueMemberColumnIndex = 0;

        private void InitializeColumns()
        {
            PropertyDescriptorCollection propertyDescriptorCollection = DataManager.GetItemProperties();
            columnWidths = new float[propertyDescriptorCollection.Count];
            columnNames = new String[propertyDescriptorCollection.Count];

            for (int colIndex = 0; colIndex < propertyDescriptorCollection.Count; colIndex++)
            {
                String name = propertyDescriptorCollection[colIndex].Name;
                columnNames[colIndex] = name;
            }
        }

        private void InitializeValueMemberColumn()
        {
            int colIndex = 0;
            foreach (String columnName in columnNames)
            {
                if (String.Compare(columnName, ValueMember, true, CultureInfo.CurrentUICulture) == 0)
                {
                    valueMemberColumnIndex = colIndex;
                    break;
                }
                colIndex++;
            }
        }

        private float CalculateTotalWidth()
        {
            float totWidth = 0;
            foreach (int width in columnWidths)
            {
                totWidth += (width + columnPadding);
            }
            return totWidth + SystemInformation.VerticalScrollBarWidth;
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            base.OnMeasureItem(e);

            if (DesignMode)
                return;

            for (int colIndex = 0; colIndex < columnNames.Length; colIndex++)
            {
                string item = Convert.ToString(FilterItemOnProperty(Items[e.Index], columnNames[colIndex]));
                SizeF sizeF = e.Graphics.MeasureString(item, Font);
                columnWidths[colIndex] = System.Math.Max(columnWidths[colIndex], sizeF.Width);
            }

            float totWidth = CalculateTotalWidth();

            e.ItemWidth = (int)totWidth;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            if (DesignMode)
                return;

            e.DrawBackground();

            Rectangle boundsRect = e.Bounds;
            int lastRight = 0;

            using (Pen linePen = new Pen(SystemColors.GrayText))
            {
                using (SolidBrush brush = new SolidBrush(ForeColor))
                {
                    if (columnNames.Length == 0)
                    {
                        e.Graphics.DrawString("", Font, brush, boundsRect);
                    }
                    else
                    {
                        if (e.Index >= 0)
                        {
                            for (int colIndex = 0; colIndex < columnNames.Length; colIndex++)
                            {

                                string item = Convert.ToString(FilterItemOnProperty(Items[e.Index], columnNames[colIndex]));
                                boundsRect.X = lastRight;
                                boundsRect.Width = (int)columnWidths[colIndex] + columnPadding;
                                lastRight = boundsRect.Right;

                                if (colIndex == valueMemberColumnIndex)
                                {
                                    using (Font boldFont = new Font(Font, FontStyle.Regular))
                                    {
                                        e.Graphics.DrawString(item, boldFont, brush, boundsRect);
                                    }
                                }
                                else
                                {
                                    e.Graphics.DrawString(item, Font, brush, boundsRect);
                                }

                                if (colIndex < columnNames.Length - 1)
                                {
                                    e.Graphics.DrawLine(linePen, boundsRect.Right, boundsRect.Top, boundsRect.Right, boundsRect.Bottom);
                                }
                            }
                        }
                    }
                }
            }

            e.DrawFocusRectangle();
        }
    }

    /// <summary>
    /// Combobox base con readonly
    /// </summary>
    public class CmbBase : ComboBox
    {
        public CmbBase()
        {
            base.DropDownStyle = ComboBoxStyle.DropDownList;
            base.DrawMode = DrawMode.OwnerDrawFixed;
            this.Text = "Seleccione...";
        }
        private bool readOnly;
        protected override void OnClick(EventArgs e)
        {
            if (!ReadOnly)
                base.OnClick(e);
        }
        public bool ReadOnly
        {
            get { return readOnly; }
            set { readOnly = value; }
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            if (this.Items.Count > 0)
                this.SelectedIndex = 0;

            //this.TabStop = false;
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.State == DrawItemState.Focus)
                e.DrawFocusRectangle();
            var index = e.Index;
            if (index < 0 || index >= Items.Count) return;
            var item = Items[index];
            string text = (item == null) ? "(null)" : item.ToString();

            using (var brush = new SolidBrush(e.ForeColor))
            {
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
                e.Graphics.DrawString(text, e.Font, brush, e.Bounds);
            }

        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            
            if (!string.IsNullOrEmpty(this.Text.Trim()) || this.SelectedIndex != -1 || this.Text != "Seleccione" || this.Text != "Seleccione..." || this.Text != " ")
            {                
                Funciones_Duke4.Funciones._ErrorProvider.SetError(this, string.Empty);
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyData == System.Windows.Forms.Keys.Up)
            {
                SendKeys.Send("+{TAB}");
            }
            else if (e.KeyData == System.Windows.Forms.Keys.Down)
            {
                SendKeys.Send("{TAB}");
            }
            else
            {
                base.OnKeyDown(e);
            }
        }
    }

    /// <summary>
    /// Objeto de los Combobox
    /// </summary>
    public class CmbItem
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public CmbItem(string name, string value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            return Name;
        }
    }

    #endregion

    #region Gridview
    /// <summary>
    /// Datagridview que puede ser editado por el usuario
    /// </summary>
    public class GridBase : DataGridView
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.ReadOnly = false;
            this.MultiSelect = false;
            this.RowHeadersVisible = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = false;
            this.AllowUserToResizeColumns = false;
            this.AllowUserToResizeRows = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.BackgroundColor = SystemColors.GradientActiveCaption;
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.Cornsilk;
            this.DefaultCellStyle.BackColor = Color.White;
            this.DefaultCellStyle.ForeColor = Color.Black;
            this.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            this.DefaultCellStyle.SelectionBackColor = Color.MediumTurquoise;
            this.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.MediumTurquoise;
            this.DefaultCellStyle.SelectionForeColor = Color.White;
            this.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;
            this.DefaultCellStyle.Font = new Font("Verdana", 7.5f);
            autosize();
        }
        protected override void OnRowsAdded(DataGridViewRowsAddedEventArgs e)
        {
            base.OnRowsAdded(e);
            if (this.Rows.Count > 0)
                Funciones_Duke4.Funciones._ErrorProvider.SetError(this, string.Empty);

        }
     
        private void autosize()
        {
            for (int i = 0; i <= this.Columns.Count - 1; i++)
            {
                this.Columns[i].Resizable = DataGridViewTriState.False;
            }
        }
        protected override void OnSortCompare(DataGridViewSortCompareEventArgs e)
        {
            base.OnSortCompare(e);
            string value1 = e.CellValue1 != null ? e.CellValue1.ToString() : string.Empty;
            string value2 = e.CellValue2 != null ? e.CellValue2.ToString() : string.Empty;

            e.SortResult = String.Compare(value1, value2);
            e.Handled = true;
        }
        protected override void OnCellValueChanged(DataGridViewCellEventArgs e)
        {
            base.OnCellValueChanged(e);
            //Type cellType = this.Columns[e.ColumnIndex].CellType;
            //if (cellType == typeof(DoubleCell) || cellType.IsSubclassOf(typeof(DoubleCell)))
            //{
            //    if (this.SelectedRows.Count > 0)
            //    {

            //        int pos = this.CurrentCell.RowIndex;
            //        int cel = this.CurrentCell.ColumnIndex;
            //        if (!string.IsNullOrEmpty(this.Rows[pos].Cells[cel].Value.ToString()))
            //            this.Rows[pos].Cells[cel].Value = string.Format("{0:#,##0.00}", Funciones_Duke4.Funciones.Fun_Convierte_String_aDecimal(this.Rows[pos].Cells[cel].Value.ToString()));
            //    }
            //}
        }
        public class DoubleCell : DataGridViewTextBoxCell
        {
            public DoubleCell() : base() { }
            public override Type ValueType
            {
                get { return typeof(double); }
            }
            public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
            {
                base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
                Control ctl = DataGridView.EditingControl;
                ctl.KeyPress += new KeyPressEventHandler(IntegerGridCell_KeyPress);
                ctl.TextChanged += new EventHandler(IntegerGridCell_OnTextChanged);
            }
            private void IntegerGridCell_OnTextChanged(object sender, EventArgs e)
            {
                String ultimoCaracter = "";

                if ((sender as TextBox).Text.Trim() != "")
                    ultimoCaracter = (sender as TextBox).Text.Substring(0, 1);

                if (ultimoCaracter.Equals(","))
                {

                    (sender as TextBox).Text = (sender as TextBox).Text.Substring(1, (sender as TextBox).TextLength - 1);
                }
                else if (ultimoCaracter.Equals(".") && (sender as TextBox).Text.Length == 1)
                {
                    (sender as TextBox).Text = "0.";
                    (sender as TextBox).Select(2, 0);
                }


            }
            private void IntegerGridCell_KeyPress(object sender, KeyPressEventArgs e)
            {
                DataGridViewCell currentCell = ((IDataGridViewEditingControl)sender).EditingControlDataGridView.CurrentCell;
                if (currentCell is DoubleCell)
                {
                    e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.';


                }

                if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                {
                    e.Handled = true;
                }
                /*if( e.KeyChar=='.'&& string.IsNullOrEmpty((sender as TextBox).Text))
                    e.Handled = true;*/


            }
        }
        public class DoubleColumn : DataGridViewColumn
        {
            public DoubleColumn() : base(new DoubleCell())
            {
                this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.DefaultCellStyle.Format = "N2";
            }
            public override DataGridViewCell CellTemplate
            {
                get
                {
                    return base.CellTemplate;
                }
                set
                {
                    if (value != null &&
                        !value.GetType().IsAssignableFrom(typeof(DoubleCell)))

                        base.CellTemplate = value;
                }
            }
        }
        public class CalendarCell : DataGridViewTextBoxCell
        {
            public CalendarCell() : base()
            {
                this.Style.Format = "dd/MM/yyyy";
            }
            public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
            {
                // Set the value of the editing control to the current cell value.
                base.InitializeEditingControl(rowIndex, initialFormattedValue,
                    dataGridViewCellStyle);
                CalendarEditingControl ctl =
                    DataGridView.EditingControl as CalendarEditingControl;
                // Use the default row value when Value property is null.
                if (this.Value == null)
                {
                    ctl.Value = (DateTime)this.DefaultNewRowValue;
                }
                else
                {
                    ctl.Value = (DateTime)this.Value;
                }
            }
            public override Type EditType
            {
                get
                {
                    // Return the type of the editing control that CalendarCell uses.
                    return typeof(CalendarEditingControl);
                }
            }
            public override Type ValueType
            {
                get
                {
                    // Return the type of the value that CalendarCell contains.

                    return typeof(DateTime);
                }
            }
            public override object DefaultNewRowValue
            {
                get
                {
                    // Use the current date and time as the default value.
                    return DateTime.Now;
                }
            }
        }
        public class CalendarColumn : DataGridViewColumn
        {
            public CalendarColumn() : base(new CalendarCell())
            {
            }
            public override DataGridViewCell CellTemplate
            {
                get
                {
                    return base.CellTemplate;
                }
                set
                {
                    // Ensure that the cell used for the template is a CalendarCell.
                    if (value != null &&
                        !value.GetType().IsAssignableFrom(typeof(CalendarCell)))
                    {
                        throw new InvalidCastException("Must be a CalendarCell");
                    }
                    base.CellTemplate = value;
                }
            }
        }
        class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
        {
            DataGridView dataGridView;
            private bool valueChanged = false;
            int rowIndex;

            public CalendarEditingControl()
            {
                this.Format = DateTimePickerFormat.Short;
            }

            // Implements the IDataGridViewEditingControl.EditingControlFormattedValue 
            // property.
            public object EditingControlFormattedValue
            {
                get
                {
                    return this.Value.ToShortDateString();
                }
                set
                {
                    if (value is String)
                    {
                        try
                        {
                            // This will throw an exception of the string is 
                            // null, empty, or not in the format of a date.
                            this.Value = DateTime.Parse((String)value);
                        }
                        catch
                        {
                            // In the case of an exception, just use the 
                            // default value so we're not left with a null
                            // value.
                            this.Value = DateTime.Now;
                        }
                    }
                }
            }

            // Implements the 
            // IDataGridViewEditingControl.GetEditingControlFormattedValue method.
            public object GetEditingControlFormattedValue(
                DataGridViewDataErrorContexts context)
            {
                return EditingControlFormattedValue;
            }

            // Implements the 
            // IDataGridViewEditingControl.ApplyCellStyleToEditingControl method.
            public void ApplyCellStyleToEditingControl(
                DataGridViewCellStyle dataGridViewCellStyle)
            {
                this.Font = dataGridViewCellStyle.Font;
                this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
                this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
            }

            // Implements the IDataGridViewEditingControl.EditingControlRowIndex 
            // property.
            public int EditingControlRowIndex
            {
                get
                {
                    return rowIndex;
                }
                set
                {
                    rowIndex = value;
                }
            }

            // Implements the IDataGridViewEditingControl.EditingControlWantsInputKey 
            // method.
            public bool EditingControlWantsInputKey(
                Keys key, bool dataGridViewWantsInputKey)
            {
                // Let the DateTimePicker handle the keys listed.
                switch (key & Keys.KeyCode)
                {
                    case Keys.Left:
                    case Keys.Up:
                    case Keys.Down:
                    case Keys.Right:
                    case Keys.Home:
                    case Keys.End:
                    case Keys.PageDown:
                    case Keys.PageUp:
                        return true;
                    default:
                        return !dataGridViewWantsInputKey;
                }
            }

            // Implements the IDataGridViewEditingControl.PrepareEditingControlForEdit 
            // method.
            public void PrepareEditingControlForEdit(bool selectAll)
            {
                // No preparation needs to be done.
            }

            // Implements the IDataGridViewEditingControl
            // .RepositionEditingControlOnValueChange property.
            public bool RepositionEditingControlOnValueChange
            {
                get
                {
                    return false;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingControlDataGridView property.
            public DataGridView EditingControlDataGridView
            {
                get
                {
                    return dataGridView;
                }
                set
                {
                    dataGridView = value;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingControlValueChanged property.
            public bool EditingControlValueChanged
            {
                get
                {
                    return valueChanged;
                }
                set
                {
                    valueChanged = value;
                }
            }

            // Implements the IDataGridViewEditingControl
            // .EditingPanelCursor property.
            public Cursor EditingPanelCursor
            {
                get
                {
                    return base.Cursor;
                }
            }

            protected override void OnValueChanged(EventArgs eventargs)
            {
                // Notify the DataGridView that the contents of the cell
                // have changed.
                valueChanged = true;
                this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
                base.OnValueChanged(eventargs);
            }
        }

    }
    /// <summary>
    /// Datagridview, no permite navegar con flechas dependiendo del ActivateDisablingArrows
    /// </summary>
    public class GridNoArrow : GridBase
    {
        public bool ActivateDisablingArrows = false;
        public bool SelectedV = true;
        public bool EnterFired = true;
        public int MainColumnIndex = 0;
        public bool addrows = true;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down)
            {
                if (ActivateDisablingArrows && SelectedV)
                {
                    this.EndEdit();
                    SendKeys.Send("{DOWN}");
                    SelectedV = false;
                    return true;
                }
            }
            else if (keyData == Keys.Enter || keyData == Keys.Tab)
            {
                if (EnterFired && CurrentCell.ColumnIndex == MainColumnIndex && CurrentCell.IsInEditMode)
                {
                    SendKeys.Send("{RIGHT}");
                    EnterFired = false;
                }
                int col = this.CurrentCell.ColumnIndex;
                int row = this.CurrentCell.RowIndex;
                if (col == (this.Columns.Count - 1))
                {
                    col = -1;
                    if (!string.IsNullOrEmpty(this.Rows[row].Cells[MainColumnIndex].Value as string))
                    {
                        if (addrows)
                            this.Rows.Add();
                        row++;
                    }
                }
                this.CurrentCell = this[col + 1, row];
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.KeyData & Keys.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                    if (this.ActivateDisablingArrows && !SelectedV)
                    {
                        e.Handled = true;
                        e.SuppressKeyPress = true;
                        SelectedV = true;
                    }
                    break;
            }
            base.OnKeyDown(e);
        }

    }
    /// <summary>
    /// Datagridview que puede no ser editado por el usuario
    /// </summary>
    #endregion

    #region Checkbox and Radiobutton
    /// <summary>
    /// Radiobutton con ReadOnly
    /// </summary>
    public partial class RdbBase : RadioButton
    {
        private bool readOnly;
        public bool ReadOnly
        {
            get { return readOnly; }
            set { readOnly = value; }
        }
        protected override void OnClick(EventArgs e)
        {
            if (!ReadOnly)
                base.OnClick(e);
        }
    }
    /// <summary>
    /// Checkbox base
    /// </summary>
    public class CkbBase : CheckBox
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.TabStop = false;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
    /// <summary>
    /// 
    /// <param name="e"></param>
    public delegate void CheckBoxHeaderClickHandler(CheckBoxHeaderCellEventArgs e);
    /// <summary>
    /// Evento para el checkbox de grids
    /// </summary>
    public class CheckBoxHeaderCellEventArgs : EventArgs
    {
        private bool _isChecked;
        public bool IsChecked
        {
            get { return _isChecked; }
        }

        public CheckBoxHeaderCellEventArgs(bool _checked)
        {
            _isChecked = _checked;

        }

    }
    /// <summary>
    /// Celda de checkbox para los grids
    /// </summary>
    class CheckBoxHeaderCell : DataGridViewColumnHeaderCell
    {
        Size checkboxsize;
        bool ischecked;
        Point location;
        Point cellboundsLocation;
        CheckBoxState state = CheckBoxState.UncheckedNormal;

        public event CheckBoxHeaderClickHandler OnCheckBoxHeaderClick;

        public CheckBoxHeaderCell()
        {
            location = new Point();
            cellboundsLocation = new Point();
            ischecked = false;
        }

        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            Point clickpoint = new Point(e.X + cellboundsLocation.X, e.Y + cellboundsLocation.Y);

            if ((clickpoint.X > location.X && clickpoint.X < (location.X + checkboxsize.Width)) && (clickpoint.Y > location.Y && clickpoint.Y < (location.Y + checkboxsize.Height)))
            {
                ischecked = !ischecked;
                if (OnCheckBoxHeaderClick != null)
                {
                    OnCheckBoxHeaderClick(new CheckBoxHeaderCellEventArgs(ischecked));
                    this.DataGridView.InvalidateCell(this);
                }
            }
            base.OnMouseClick(e);
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds,
             Rectangle cellBounds, int rowIndex, DataGridViewElementStates dataGridViewElementState, object value, object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle
            advancedBorderStyle, DataGridViewPaintParts paintParts)
        {

            base.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState,
           value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            checkboxsize = CheckBoxRenderer.GetGlyphSize(graphics, CheckBoxState.UncheckedNormal);
            location.X = cellBounds.X + (cellBounds.Width / 2 - checkboxsize.Width / 2);
            location.Y = cellBounds.Y + (cellBounds.Height / 2 - checkboxsize.Height / 2);
            cellboundsLocation = cellBounds.Location;

            if (ischecked)
                state = CheckBoxState.CheckedNormal;
            else
                state = CheckBoxState.UncheckedNormal;

            CheckBoxRenderer.DrawCheckBox(graphics, location, state);
        }
    }

    #endregion

    #region Panel and Groupbox
    /// <summary>
    /// Groupbox 
    /// </summary>
    public class GrbBase : GroupBox
    {
        private Color borderColor;
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.borderColor = Color.Red;
        }
        public Color BorderColor
        {
            get { return this.borderColor; }
            set { this.borderColor = value; }
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
    #endregion

    #region TabControl
    /// <summary>
    /// TabControl con colores modificados
    /// </summary>
    public class TabCrtBase : TabControl
    {
        private Color nonactive_color1 = Color.Aquamarine;
        private Color nonactive_color2 = Color.MidnightBlue;
        private Color active_color1 = Color.Yellow;
        private Color active_color2 = Color.Orange;
        public Color forecolor = SystemColors.ActiveCaptionText;
        private Color bgColor = SystemColors.GradientInactiveCaption;
        private int color1Transparent = 150;
        private int color2Transparent = 150;
        private int angle = 90;

        //Create Properties to read values
        public Color ActiveTabStartColor
        {
            get { return active_color1; }
            set { active_color1 = value; Invalidate(); }
        }
        public Color bgColour
        {
            get { return bgColor; }
            set { bgColor = value; Invalidate(); }
        }
        public Color ActiveTabEndColor
        {
            get { return active_color2; }
            set { active_color2 = value; Invalidate(); }
        }
        public Color NonActiveTabStartColor
        {
            get { return nonactive_color1; }
            set { nonactive_color1 = value; Invalidate(); }
        }
        public Color NonActiveTabEndColor
        {
            get { return nonactive_color2; }
            set { nonactive_color2 = value; Invalidate(); }
        }
        public int Transparent1
        {
            get { return color1Transparent; }
            set
            {
                color1Transparent = value;
                if (color1Transparent > 255)
                {
                    color1Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }
        public int Transparent2
        {
            get { return color2Transparent; }
            set
            {
                color2Transparent = value;
                if (color2Transparent > 255)
                {
                    color2Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }
        public int GradientAngle
        {
            get { return angle; }
            set { angle = value; Invalidate(); }
        }
        public Color TextColor
        {
            get { return forecolor; }
            set { forecolor = value; Invalidate(); }
        }
        public TabCrtBase()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.Padding = new Point(22, 4);
            this.SizeMode = TabSizeMode.Fixed;
            this.ItemSize = new Size(250, 35);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        //method for drawing tab items 
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            Rectangle rc = GetTabRect(e.Index);

            //if tab is selected
            if (this.SelectedTab == this.TabPages[e.Index])
            {
                Color c1 = Color.FromArgb(color1Transparent, active_color1);
                Color c2 = Color.FromArgb(color2Transparent, active_color2);
                using (LinearGradientBrush br = new LinearGradientBrush(rc, c1, c2, angle))
                {
                    e.Graphics.FillRectangle(br, rc);
                }
            }
            else
            {
                Color c1 = Color.FromArgb(color1Transparent, nonactive_color1);
                Color c2 = Color.FromArgb(color2Transparent, nonactive_color2);
                using (LinearGradientBrush br = new LinearGradientBrush(rc, c1, c2, angle))
                {
                    e.Graphics.FillRectangle(br, rc);
                }
            }

            this.TabPages[e.Index].BorderStyle = BorderStyle.FixedSingle;
            this.TabPages[e.Index].ForeColor = SystemColors.ControlText;
            this.TabPages[e.Index].BackColor = bgColor;

            //draw close button on tabs

            Rectangle paddedBounds = e.Bounds;
            paddedBounds.Inflate(-5, -4);
            e.Graphics.DrawString(this.TabPages[e.Index].Text, this.Font, new SolidBrush(forecolor), paddedBounds);

            Point pad = this.Padding;
        }
    }
    #endregion

    #region Button

    public partial class BtnBase : Button
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.BackColor = Color.AliceBlue;
            this.Text = " ";
        }
    }
    public partial class BtnBuscar : BtnBase
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Size = new Size(24, 24);
            this.Image = Properties.Resources.search24;
            this.FlatStyle = FlatStyle.Flat;
            this.TabStop = false;
            this.FlatAppearance.BorderSize = 0;
        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(pevent);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Width = 24;
            this.Height = 24;
            this.Image = Properties.Resources.search24;

        }

        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            base.OnMouseMove(mevent);
            this.Width = 32;
            this.Height = 32;
            this.Image = Properties.Resources.search32;
            this.BringToFront();
        }



    }
    #endregion

    #region ListBox
    /// <summary>
    /// Listbox 
    /// </summary>
    public class LsbBase : ListBox
    {

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            base.OnMeasureItem(e);
            if (this.Items.Count > 0)
            {
                // Get the ListBox and the item.
                ListBox lst = this;
                string txt = (string)lst.Items[e.Index];

                // Measure the string.
                SizeF txt_size = e.Graphics.MeasureString(txt, this.Font);

                // Set the required size.
                e.ItemHeight = (int)txt_size.Height + (int)(2.5f * ItemMargin);
                e.ItemWidth = (int)txt_size.Width;

            }
        }
        private int ItemMargin = 5;
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            //Para cambiar el color del item seleccionado y el font
            base.OnDrawItem(e);
            if (this.Items.Count > 0)
            {
                // Get the ListBox and the item.
                ListBox lst = this;
                string txt = (string)lst.Items[e.Index];

                // Draw the background.
                e.DrawBackground();

                // See if the item is selected.
                if ((e.State & DrawItemState.Selected) ==
                    DrawItemState.Selected)
                {
                    // Selected. Draw with the system highlight color.
                    e = new DrawItemEventArgs(e.Graphics,
                                                   e.Font,
                                                   e.Bounds,
                                                   e.Index,
                                                   e.State ^ DrawItemState.Selected,
                                                   e.ForeColor,
                                                   Color.LightGoldenrodYellow);//Choose the color

                    e.DrawBackground();
                    //Text seleccionado
                    e.Graphics.DrawString(txt, this.Font,
                        SystemBrushes.WindowText, e.Bounds.Left,
                            e.Bounds.Top + ItemMargin);
                }
                else
                {
                    // Not selected. Draw with ListBox's foreground color.
                    using (SolidBrush br = new SolidBrush(e.ForeColor))
                    {
                        e.Graphics.DrawString(txt, this.Font, br,
                            e.Bounds.Left, e.Bounds.Top + ItemMargin);
                    }
                }

                // Draw the focus rectangle if appropriate.
                e.DrawFocusRectangle();
            }
        }
    }
    #endregion

    public class menuBase : MenuStrip
    {
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.BackColor =  Color.LightSteelBlue; 
            if(this.Enabled)
                this.Renderer = new MyRenderer();
            else
            {
                this.Renderer = new NotEnabledRenderer();
            }
        }
    }
    
    public class item : ToolStripMenuItem
    {
        private bool readOnly;
        public bool ReadOnly
        {
            get { return readOnly; }
            set { readOnly = value; }
        }
        protected override void OnClick(EventArgs e)
        {
            if (!ReadOnly)
                base.OnClick(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (!ReadOnly)
                base.OnMouseEnter(e);
            this.BackColor = Color.LightSteelBlue;
        }


    }

    public class MyRenderer : ToolStripProfessionalRenderer
    {
        public MyRenderer() : base(new MyColors()) { }
    }

    class MyColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.Yellow; }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.Orange; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.Yellow; }
        }
    }

    public class NotEnabledRenderer : ToolStripProfessionalRenderer
    {
        public NotEnabledRenderer() : base(new MyColors()) { }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            //  e.TextFont = textFont;
            if (!e.Item.Enabled)
            {
                e.TextColor = Color.Black;
                e.TextFont = new Font("Verdana", 10f, FontStyle.Bold);
            }
            base.OnRenderItemText(e);
        }

    }

    class NotEnabledColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.LightSteelBlue; }
        }
        public override Color MenuItemBorder
        {
            get { return Color.LightSteelBlue; }
        }
        //public override Color MenuItemSelectedGradientBegin
        //{
        //    get { return Color.Orange; }
        //}
        //public override Color MenuItemSelectedGradientEnd
        //{
        //    get { return Color.Yellow; }
        //}
    }





}
