using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace Duke4
{
    public partial class Enviar_Mail : Duke4.MainBar
    {
        public Enviar_Mail()
        {
            InitializeComponent();
        }
        public string attachment;
        public MailMessage mail;
        string fromMail = Properties.Settings.Default.usuarioEmail;
        string password = Properties.Settings.Default.usuarioEmail;
        
        private void SendMailFact(List<string> destinatario)
        {
            if(destinatario != null)
            {
                foreach (string item in destinatario)
                {
                    mail.To.Add(item);
                }
                mail.From = new MailAddress(fromMail);
                mail.Subject = txtBase1.Text;
                mail.Body = txtBase2.Text;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.live.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(fromMail, password);
                smtp.EnableSsl = true;

                try
                {
                    smtp.Send(mail);
                    MessageBox.Show("Correo enviado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void BtnElegir_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BtnElegir_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
        EmailAddressAttribute checkmail = new EmailAddressAttribute();

        public bool IsEmailValid(string emailaddress)
        {
            return checkmail.IsValid(emailaddress);
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        List<string> correctMail;
        string incorrectMail;

        private List<string> deconstructEmail()
        {
            correctMail = new List<string>();
            incorrectMail = "";
            foreach (string item in txtEmail.Text.Split(';'))
            {
                if (IsEmailValid(item))
                    correctMail.Add(item);
                else
                    incorrectMail += item;
            }
            if(incorrectMail!="")
            {
                Clipboard.SetText(incorrectMail);
                MessageBox.Show("Correos incorrectos, " + incorrectMail + Environment.NewLine + "Estos fueron copiados en el portapapeles", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return correctMail;
        }

        private void Enviar_Mail2_Load(object sender, EventArgs e)
        {
            Fun_Set_Nombre_Formulario("Enviar Correo", this);
            TxtAttachments.Text = attachment;
        }

        private void menuStrip1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2),
                                     this.DisplayRectangle);
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if(fromMail ==""  || password == "")
                MessageBox.Show("Correo electrónico no configurado, diríjase a Configuración", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(txtBase1.Text == "")
                MessageBox.Show("Complete el destinatario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var list = deconstructEmail();
                if(list != null)
                {
                    SendMailFact(list);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void BtnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
