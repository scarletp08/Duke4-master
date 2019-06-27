using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomListBox
{
    public class sListBox: ListBox
    {

        #region Procedure Statiques

        /// <summary>
        /// Dublique et redimensione une Image 
        /// </summary>
        /// <param name="pImage">Image à redimensioner</param>
        /// <param name="pWidth">Nouvelle largeur de l'image en pixel</param>
        /// <param name="pHeight">Nouvelle hauteur de l'image en pixel</param>
        /// <param name="pBackColor">Couleur de fond de l'image</param>
        /// <param name="pPosition"> centrage de l'image source dans son nouveau cadre</param>
        /// <returns></returns>
        public static Bitmap ResizeImage(Bitmap pImage, int pWidth, int pHeight, Color pBackColor, ContentAlignment pPosition)
        {
            if (pImage == null) return null;
            Bitmap lResult = default(Bitmap);
            Graphics lGraphic = default(Graphics);
            int lX = 0;
            int lY = 0;
            int lWidth = 0;
            int lHeight = 0;
            float lCoef = 0;

            lResult = new Bitmap(pWidth, pHeight);
            //Creation de l'image de sortie
            lGraphic = Graphics.FromImage(lResult);
            //Creation de l'objet graphics qui nous permettra de dessiner sur le bitmap
            lGraphic.FillRectangle(new SolidBrush(pBackColor), 0, 0, pWidth, pHeight);
            //Remplissage du fond
            lWidth = pWidth;
            lHeight = pHeight;

           

            lX = 0;
            lY = 0;
            // Calcule de la position départ de l'image
            switch (pPosition)
            {
                case ContentAlignment.BottomCenter:
                    lY = pHeight - lHeight;
                    lX = (pWidth - lWidth) / 2;
                    break;
                case ContentAlignment.BottomLeft:
                    lY = pHeight - lHeight;
                    lX = 0;
                    break;
                case ContentAlignment.BottomRight:
                    lY = pHeight - lHeight;
                    lX = pWidth - lWidth;

                    break;
                case ContentAlignment.MiddleRight:
                    lY = (pHeight - lHeight) / 2;
                    lX = pWidth - lWidth;

                    break;
                case ContentAlignment.MiddleCenter:
                    lY = (pHeight - lHeight) / 2;
                    lX = (pWidth - lWidth) / 2;
                    break;
                case ContentAlignment.MiddleLeft:
                    lY = (pHeight - lHeight) / 2;
                    lX = 0;
                    break;
                case ContentAlignment.TopCenter:
                    lY = 0;
                    lX = (pWidth - lWidth) / 2;

                    break;
                case ContentAlignment.TopLeft:
                    lY = 0;
                    lX = 0;

                    break;
                case ContentAlignment.TopRight:
                    lY = 0;
                    lX = pWidth - lWidth;

                    break;
            }


            lGraphic.DrawImage(pImage, lX, lY, lWidth, lHeight);
            return lResult;

        }
        // ==============================================================================
        public static Color ChangeLight(float pCoef, Color pColor)
        {
            pCoef = pCoef / 100;
            double dR = (double)pColor.R;
            double dG = (double)pColor.G;
            double dB = (double)pColor.B;
            dR = dR * pCoef;
            dG = dG * pCoef;
            dB = dB * pCoef;

            if (dG > 255) dG = 255;
            if (dR > 255) dR = 255;
            if (dB > 255) dB = 255;
            return Color.FromArgb((int)dR, (int)dG, (int)dB);
        }
        // ==============================================================================
        public static PointF GetPosition(ContentAlignment pAlign, RectangleF pContainer, float pWidth, float pHeight)
        {
            float lTop = pContainer.Top;
            float lLeft = pContainer.Left;
            switch (pAlign)
            {
                case ContentAlignment.BottomLeft:
                case ContentAlignment.BottomRight:
                case ContentAlignment.BottomCenter:
                    lTop += pContainer.Height - pHeight;
                    break;
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.MiddleRight:
                case ContentAlignment.MiddleLeft:
                    lTop += (pContainer.Height - pHeight) / 2;
                    break;
            }
            switch (pAlign)
            {
                case ContentAlignment.BottomCenter:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.TopCenter:
                    lLeft += ((pContainer.Width - pWidth) / 2);
                    break;
                case ContentAlignment.BottomRight:
                case ContentAlignment.MiddleRight:
                case ContentAlignment.TopRight:
                    lLeft += pContainer.Width - pWidth;
                    break;
            }
            return new PointF(lLeft, lTop);

        }
        // ==============================================================================
        public static GraphicsPath GetTopRoundedRect(RectangleF baseRect, float radius, bool pUp)
        {
            // if corner radius is less than or equal to zero, 
            // return the original rectangle 
            if (radius <= 0.0F)
            {
                GraphicsPath mPath = new GraphicsPath();
                mPath.AddRectangle(baseRect);
                mPath.CloseFigure();
                return mPath;
            }

            // if the corner radius is greater than or equal to 
            // half the width, or height (whichever is shorter) 
            // then return a capsule instead of a lozenge 
            if (radius >= (Math.Min(baseRect.Width, baseRect.Height)) / 2.0)
                return GetCapsule(baseRect);

            // create the arc for the rectangle sides and declare 
            // a graphics path object for the drawing 
            float diameter = radius * 2.0F;
            SizeF sizeF = new SizeF(diameter, diameter);
            RectangleF arc = new RectangleF(baseRect.Location, sizeF);
            GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            //      X0  X1          X2   X3
            // Y0       --------------
            //        .                .
            // Y1   |                    |
            //      |                    |
            // Y2   |                    |
            //        .                .
            // Y3       --------------


            float X0 = baseRect.Left;
            float X1 = baseRect.Left + diameter;
            float X2 = baseRect.Right - diameter;
            float X3 = baseRect.Right;
            float Y0 = baseRect.Top;
            float Y1 = baseRect.Top + diameter;
            float Y2 = baseRect.Bottom - diameter;
            float Y3 = baseRect.Bottom;


            // top left arc 

            if (pUp)
            {
                arc.X = X0;
                arc.Y = Y0;
                path.AddArc(arc, 180, 90);
                path.AddLine(X1, Y0, X2, Y0);

                arc.X = X2;
                arc.Y = Y0;
                path.AddArc(arc, 270, 90);
                path.AddLine(X3, Y1, X3, Y3);
                path.AddLine(X3, Y3, X0, Y3);
                path.AddLine(X0, Y3, X0, Y1);
            }
            else
            {
                arc.X = X2;
                arc.Y = Y2;
                path.AddArc(arc, 0, 90);
                path.AddLine(X2, Y3, X1, Y3);

                arc.X = X0;
                arc.Y = Y2;
                path.AddArc(arc, 90, 90);
                path.AddLine(X0, Y2, X0, Y0);
                path.AddLine(X0, Y0, X3, Y0);
                path.AddLine(X3, Y0, X3, Y2);
            }
            path.CloseFigure();
            return path;
        }
        // ==============================================================================
        public static GraphicsPath GetRoundedRect(RectangleF baseRect, float radius)
        {
            // if corner radius is less than or equal to zero, 
            // return the original rectangle 
            if (radius <= 0.0F)
            {
                GraphicsPath mPath = new GraphicsPath();
                mPath.AddRectangle(baseRect);
                mPath.CloseFigure();
                return mPath;
            }

            // if the corner radius is greater than or equal to 
            // half the width, or height (whichever is shorter) 
            // then return a capsule instead of a lozenge 
            if (radius >= (Math.Min(baseRect.Width, baseRect.Height)) / 2.0)
                return GetCapsule(baseRect);

            // create the arc for the rectangle sides and declare 
            // a graphics path object for the drawing 
            float diameter = radius * 2.0F;
            SizeF sizeF = new SizeF(diameter, diameter);
            RectangleF arc = new RectangleF(baseRect.Location, sizeF);
            GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            // top left arc 
            path.AddArc(arc, 180, 90);

            // top right arc 
            arc.X = baseRect.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc 
            arc.Y = baseRect.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc
            arc.X = baseRect.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }
        // ==============================================================================
        public static GraphicsPath GetCapsule(RectangleF baseRect)
        {
            float diameter;
            RectangleF arc;
            GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            try
            {
                if (baseRect.Width > baseRect.Height)
                {
                    // return horizontal capsule 
                    diameter = baseRect.Height;
                    SizeF sizeF = new SizeF(diameter, diameter);
                    arc = new RectangleF(baseRect.Location, sizeF);
                    path.AddArc(arc, 90, 180);
                    arc.X = baseRect.Right - diameter;
                    path.AddArc(arc, 270, 180);
                }
                else if (baseRect.Width < baseRect.Height)
                {
                    // return vertical capsule 
                    diameter = baseRect.Width;
                    SizeF sizeF = new SizeF(diameter, diameter);
                    arc = new RectangleF(baseRect.Location, sizeF);
                    path.AddArc(arc, 180, 180);
                    arc.Y = baseRect.Bottom - diameter;
                    path.AddArc(arc, 0, 180);
                }
                else
                {
                    // return circle 
                    path.AddEllipse(baseRect);
                }
            }
            catch (Exception ex)
            {
                path.AddEllipse(baseRect);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                path.CloseFigure();
            }
            return path;
        }

        #endregion

        #region Enum
        /// <summary>
        /// Defini l'apparence des lignes de la liste
        /// </summary>
        public enum Style { Flat, XP, Bump, MacStyle, Standard}
        #endregion

        #region Constructeurs
        // Summary:
        // Initialises la nouvelle instance de la classe sListBox .
        public sListBox()
            : base()
        {
            try
            {

                this.SetStyle(ControlStyles.DoubleBuffer, true);
                this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            }
            catch { }
            base.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            _InitBlend();
            this.FontChanged += new EventHandler(_FontChanged);
        }
  
        #endregion
        
        
        private int _GetFontHeigt()
        {
            return this.Font.Height + 6;
        }
        void _FontChanged(object sender, EventArgs e)
        {
            ItemHeight = _GetFontHeigt();
            Refresh();
        }

        #region Variables Privèes
        private bool _ShowScroll;
     
        private Color _LightedColor = Color.FromArgb(195, 214, 255);
        private Color _LightedFocusColor = Color.Aqua;
        private Color _DarkFocusColor = Color.Green;
        private Color _LightedSelectedColor = Color.Aqua;
        private Color _DarkSelectedColor = Color.Blue;
        private Color _BorderColor = Color.Gray;

        private Style _Style = Style.MacStyle;
        private ContentAlignment _TextAlignment = ContentAlignment.MiddleCenter;


        private Blend _BlendBump = new Blend(3);
        private Blend _BlendBumpLighted = new Blend(3);
        private Blend _BlendBumpPushed = new Blend(3);
        private Blend _BlendMacStyle = new Blend(4);
        private Blend _BlendMacStyleLighted = new Blend(4);
        private Blend _BlendMacStylePushed = new Blend(4);
        private Blend _BlendPen = new Blend(4);
        private Blend _BlendXP = new Blend(5);
        private Blend _BlendXPPushed = new Blend(6);

        private Image _CheckedIcon = null;

      

        #endregion

        #region Propriétés

      public Image CheckedIcon
        {
            get { return _CheckedIcon; }
            set { 
                
                if(value!= _CheckedIcon) 
                { 
                    if(value==null)
                            _CheckedIcon = value;
                    else 
                    { 
                        Bitmap lNewImage= new Bitmap (value);
                        if (value.Height >24 || value.Width >24)
                        {
                            Bitmap lResizedImage= ResizeImage( lNewImage,24,24,Color.Transparent , ContentAlignment.MiddleCenter); 
                            lNewImage.Dispose();
                            lNewImage= null;
                          
                            lNewImage = lResizedImage;
                        }
                        if (_CheckedIcon != null)
                        {
                            _CheckedIcon.Dispose();
                            _CheckedIcon = null;
                        } 
                        GC.Collect();
                        _CheckedIcon = lNewImage;
                    }
                    Refresh();
                }
            }
        } 
  
        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if (!_ShowScroll)
                    cp.Style = cp.Style & ~0x200000;
                return cp;
            }
        }
        public bool ShowScrollbar
        {
            get { return _ShowScroll; }
            set
            {
                if (value == _ShowScroll)
                    return;
                _ShowScroll = value;
                if (Handle != IntPtr.Zero)
                    RecreateHandle();
            }
        }
        [Browsable(true)]
        public Color LightedColor
        {
            get { return _LightedColor; }
            set
            {
                _LightedColor = value;
                Invalidate();
            }
        }
        [Browsable(true)]
        public Color LightedFocusColor
        {
            get { return _LightedFocusColor; }
            set
            {
                _LightedFocusColor = value;
                Invalidate();
            }
        }
        [Browsable(true)]
        public Color DarkFocusColor
        {
            get { return _DarkFocusColor; }
            set
            {
                _DarkFocusColor = value;
                Invalidate();
            }
        }
        [Browsable(true)]
        public Color LightedSelectedColor
        {
            get { return _LightedSelectedColor; }
            set
            {
                _LightedSelectedColor = value;
                Invalidate();
            }
        }
        [Browsable(true)]
        public Color DarkSelectedColor
        {
            get
            {
                return _DarkSelectedColor;

            }
            set
            {
                _DarkSelectedColor = value;
                Invalidate();
            }
        }
        [Browsable(true)]
        public Color BorderColor
        {
            get { return _BorderColor; }
            set
            {
                _BorderColor = value;
                Invalidate();
            }
        }
        [Browsable(true)]
        public Style ItemStyle
        {
            get { return _Style; }
            set
            {
                _Style = value;
                if (_Style == Style.Standard )
                    base.DrawMode = System.Windows.Forms.DrawMode.Normal;
                else
                    base.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
       
                Invalidate();
            }
        }
        [Browsable(true)]
        public ContentAlignment TextAlignment
        {
            get { return _TextAlignment; }
            set
            {
                _TextAlignment = value;
                Invalidate();
            }
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override DrawMode DrawMode
        {
            get
            {
                return base.DrawMode;
            }
            set
            {
            }
        }
        #endregion
     
     
        #region Methodes Privées
        private void _InitBlend()
        {
            _BlendXP.Factors = new float[] { 1.0F, 0.8F, 1.1F, 0.1F, 0.0F };
            _BlendXP.Positions = new float[] { 0.0F, 0.3F, 0.4F, 0.45F, 1.0F };

            _BlendXPPushed.Factors = new float[] { 0.7F, 0.8F, 1.15F, 1.1F, 0.1F, 0.0F };
            _BlendXPPushed.Positions = new float[] { 0.0F, 0.08F, 0.33F, 0.6F, 0.65F, 1.0F };


            _BlendBump.Factors = new float[] { 0.0F, 1.0F, 0.0F };
            _BlendBump.Positions = new float[] { 0.0F, 0.3F, 1.0F };

            _BlendBumpLighted.Factors = new float[] { 0.0F, 1.0F, 0.0F };
            _BlendBumpLighted.Positions = new float[] { 0.0F, 0.2F, 1.0F };

            _BlendBumpPushed.Factors = new float[] { 0.0F, 1.0F, 0.0F };
            _BlendBumpPushed.Positions = new float[] { 0.0F, 0.4F, 1.0F };

            _BlendMacStyle.Factors = new float[] { 1.0F, 0.0F, 0.8F, 1.0F };
            _BlendMacStyle.Positions = new float[] { 0.0F, 0.3F, 0.8F, 1.0F };

            _BlendMacStylePushed.Factors = new float[] { 1.0F, 0.8F, 0.1F, 0.0F };
            _BlendMacStylePushed.Positions = new float[] { 0.0F, 0.3F, 0.4F, 1.0F };

            _BlendMacStyleLighted.Factors = new float[] { 1.0F, 0.0F, 0.8F, 1.0F };
            _BlendMacStyleLighted.Positions = new float[] { 0.0F, 0.3F, 0.7F, 1.0F };

            _BlendPen.Factors = new float[] { 0.0F, 0.6F, 0.95F, 1.0F };
            _BlendPen.Positions = new float[] { 0.0F, 0.5F, 0.51F, 1.0F };


        }
        // ==============================================================================
        private GraphicsPath _GetPath(int pCount, System.Drawing.Rectangle pRect, int pIndex)
        {
            GraphicsPath lPath = null;

            if (pCount <= 1)
                lPath = GetRoundedRect(pRect, 4);
            else if (pIndex == 0)
                lPath = GetTopRoundedRect(pRect, 4, true);
            else if (pIndex == pCount - 1)
                lPath = GetTopRoundedRect(pRect, 4, false);
            return lPath;
        }
        // ==============================================================================
        private Brush _GetBrush(Style _Style, Rectangle pRect, Color pLighted, Color pDarken)
        {
            LinearGradientBrush lReturn = new LinearGradientBrush(pRect, pLighted, pDarken, LinearGradientMode.Horizontal);
            switch (_Style)
            {
                case Style.Flat:
                    lReturn = new LinearGradientBrush(pRect, pLighted, pDarken, LinearGradientMode.Horizontal);
                    break;
                case Style.Bump:
                    lReturn = new LinearGradientBrush(pRect, pLighted, pDarken, 90, true);
                    lReturn.Blend = _BlendBump;

                    break;
                case Style.MacStyle:
                    lReturn = new LinearGradientBrush(pRect, pLighted, pDarken, 90, true);
                    lReturn.Blend = _BlendMacStyle;

                    break;
                case Style.XP:
                    lReturn = new LinearGradientBrush(pRect, pLighted, pDarken, 90, true);
                    lReturn.Blend = _BlendXP;
                    break;
            }
            return lReturn;
        }
        // ==============================================================================
        private Brush _GetNormalBrush(Style _Style, Rectangle pRect)
        {
            return _GetBrush(_Style, pRect, _LightedColor, BackColor);
        }
        // ==============================================================================
        private Brush _GetSelectedBrush(Style _Style, Rectangle pRect)
        {
            return _GetBrush(_Style, pRect, _LightedSelectedColor, _DarkSelectedColor);
        }
        // ==============================================================================
        private Brush _GetFocusBrush(Style _Style, Rectangle pRect)
        {
            return _GetBrush(_Style, pRect, _LightedFocusColor, _DarkFocusColor);
        }
        // ==============================================================================
        private Pen _GetPen(Rectangle pRect, Color pLightBorderColor, Color pDarkBorderColor)
        {
            double lAngle = Math.Atan2(Width, Height);
            lAngle = lAngle * 180 / Math.PI;
            lAngle += 180;
            LinearGradientBrush lBorderBrush = new LinearGradientBrush(pRect, pDarkBorderColor, pLightBorderColor, (float)lAngle);
            lBorderBrush.Blend = _BlendPen;
            Pen lReturn = new Pen(lBorderBrush);
            return lReturn;
        }
        // ==============================================================================
        private Pen _GetUpPen(Rectangle pRect, Color pBorderColor)
        {
            Color lDarkBorderColor = ChangeLight(65, pBorderColor);
            Color lLightBorderColor = ChangeLight(112, pBorderColor);
            return _GetPen(pRect, lLightBorderColor, lDarkBorderColor);
        }
        // ==============================================================================
        private Pen _GetDownPen(Rectangle pRect, Color pBorderColor)
        {
            Color lDarkBorderColor = ChangeLight(74, pBorderColor);
            Color lLightBorderColor = ChangeLight(110, pBorderColor);
            return _GetPen(pRect, lLightBorderColor, lDarkBorderColor);
        }

        // ==============================================================================
        private void _DrawBackground(System.Windows.Forms.DrawItemEventArgs e, Rectangle pBounds)
        {
            Graphics lGraphics = e.Graphics;
            GraphicsPath lPath = null;
            Rectangle lBounds = pBounds;
            DrawItemState lChecked = e.State;
            lPath = _GetPath(this.Items.Count, lBounds, e.Index);
            Brush lBrush = null;
            if ((e.State & DrawItemState.Disabled) == DrawItemState.Disabled)
                lBrush = new SolidBrush(SystemColors.InactiveBorder);
            else if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                lBrush = _GetSelectedBrush(_Style, lBounds);
                if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)
                    lBrush = _GetFocusBrush(_Style, lBounds);
            }
            else if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)
                lBrush = _GetFocusBrush(_Style, lBounds);
            else
                lBrush = _GetNormalBrush(_Style, lBounds);
            lGraphics.FillRectangle(new SolidBrush(BackColor), e.Bounds);
            if (lPath != null)
                lGraphics.FillPath(lBrush, lPath);
            else
                lGraphics.FillRectangle(lBrush, lBounds);
        }
       // ==============================================================================
        private void _DrawBorder(System.Windows.Forms.DrawItemEventArgs e, Rectangle pBounds)
        {
            Graphics lGraphics = e.Graphics;
            GraphicsPath lPath = null;
            Rectangle lBounds = pBounds;
            DrawItemState lChecked = e.State;
            lPath = _GetPath(this.Items.Count, lBounds, e.Index);


            Pen lPen;
            if ((e.State & DrawItemState.Disabled) == DrawItemState.Disabled)
                lPen = new Pen(SystemColors.GrayText);
            else if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                lPen = _GetUpPen(lBounds, _BorderColor);
                if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)
                    lPen = _GetDownPen(lBounds, Color.Blue);
            }
            else if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)
                lPen = _GetDownPen(lBounds, Color.Blue);
            else
                lPen = new Pen(_BorderColor);
            if (lPath != null)
                lGraphics.DrawPath(lPen, lPath);
            else
                lGraphics.DrawRectangle(lPen, pBounds);
        }
        // ==============================================================================
        private void _DrawText(System.Windows.Forms.DrawItemEventArgs e, Rectangle pBounds)
        {
            string lText = string.Empty;
            // Je redefini la fonc si elle n'est déjà défini
            if (this.Font.Height < 0)
                this.Font = System.Windows.Forms.Control.DefaultFont;
            if (e.Index >= 0)
            {

                object lSelectemItem = null;
                if (e.Index < this.Items.Count)
                    lSelectemItem = this.Items[e.Index];
                if (lSelectemItem != null)
                    lText = this.GetItemText(lSelectemItem);
            }
            
            RectangleF lRectContener = new RectangleF(pBounds.X, pBounds.Y, pBounds.Width, pBounds.Height);
            SizeF lTextSize = e.Graphics.MeasureString(lText, Font);
            PointF lPoint = GetPosition(TextAlignment , lRectContener, lTextSize.Width, lTextSize.Height);

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
               if(_CheckedIcon!=null)
               {
                    if (lPoint.X < (lRectContener.X + 4 + Font.Height))
                        lPoint.X += 4 + Font.Height;
                    RectangleF lRectImage = new RectangleF(lRectContener.X + 2, lPoint.Y, Font.Height, Font.Height);
                    e.Graphics.DrawImage(_CheckedIcon, lRectImage);
                }
            }
            Brush lBrush = new SolidBrush(ForeColor);
            e.Graphics.DrawString(lText, Font, lBrush, lPoint);
        }
        // ==============================================================================
        private void _DoScroll(int delta)
        {
            if (delta == 0)
                return;
            _CheckTime();
            TopIndex += delta;
        }
        // ==============================================================================
        private void _DoInertion()
        {
            Timer inertionTimer = new Timer();
            inertionTimer.Interval = 25;
            inertionTimer.Tick += _InertionTimer_Tick;
            inertionTimer.Start();
        }
        // ==============================================================================
        private void _CheckTime()
        {
            if (_StartTime == DateTime.MinValue)
                _StartTime = DateTime.Now;
        }
        // ==============================================================================
        private void _TestInertion()
        {
            if (_StartTime == DateTime.MinValue)
                return;
            DateTime currentTime = DateTime.Now;
            TimeSpan delta = currentTime - _StartTime;
            _TopRowDelta = TopIndex - topRowIndex;
            int absValue = Math.Abs(_TopRowDelta);
            if (delta.TotalMilliseconds < 300 && absValue > 15)
            {
                _DoInertion();
            }


        }
        #endregion


        #region Evenements
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (ItemStyle == Style.Standard)
            {
                base.OnDrawItem(e);
                return;
            }
            if (Items.Count == 0) return;
            Rectangle lMainRect = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1, e.Bounds.Width - 3, e.Bounds.Height - 2);
            e.DrawBackground();
            _DrawBackground(e, lMainRect);
            _DrawBorder(e, lMainRect);
            _DrawText(e, lMainRect);
        }
        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            base.OnMeasureItem(e);
            //e.ItemHeight = _GetFontHeigt();
        }

        #region Souris et Gestes



        int startDragRowHandle = -1;
        int topRowIndex = -1;
        DateTime _StartTime;

        private int _TopRowDelta;
        private bool _IsDragging;
        [Browsable(false)]
        public bool IsDragging
        {
            get { return _IsDragging; }
            set
            {
                _IsDragging = value;
                _StartTime = DateTime.MinValue;
            }
        }
        private void _InertionTimer_Tick(object sender, EventArgs e)
        {
            TopIndex += _TopRowDelta;
            Timer timer = sender as Timer;
            timer.Interval += 25;
            if (timer.Interval == 200)
                timer.Stop();
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            //IsDragging = false;
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            //this.Focus();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            //base.OnMouseMove(e);
            //if (IsDragging)
            //{
            //    int newRow = IndexFromPoint(e.Location);
            //    if (newRow < 0)
            //        return;
            //    int delta = startDragRowHandle - newRow;
            //    _DoScroll(delta);
            //}
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            //IsDragging = true;
            //startDragRowHandle = IndexFromPoint(e.Location);
            //topRowIndex = TopIndex;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _TestInertion();
            //IsDragging = false;
        }
        #endregion
        #endregion
    }
}
