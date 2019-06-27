namespace Duke4.CXC.Archivo
{
    partial class Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(1, 130);
            // 
            // LblEstado
            // 
            this.LblEstado.Size = new System.Drawing.Size(0, 23);
            this.LblEstado.Text = "";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Size = new System.Drawing.Size(851, 11);
            // 
            // LblAlerta
            // 
            this.LblAlerta.Location = new System.Drawing.Point(5, 451);
            this.LblAlerta.Size = new System.Drawing.Size(0, 23);
            this.LblAlerta.Text = "";
            // 
            // LblFunctionName
            // 
            this.LblFunctionName.Location = new System.Drawing.Point(641, 101);
            this.LblFunctionName.Size = new System.Drawing.Size(158, 32);
            this.LblFunctionName.Text = "Creando...";
            // 
            // Form
            // 
            this.ClientSize = new System.Drawing.Size(849, 482);
            this.Name = "Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
