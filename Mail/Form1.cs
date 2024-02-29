using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace Mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MailMessage msg = new MailMessage("brijeshdungrani303@gmail.com", txtTo.Text, txtSubjext.Text, txtMessage.Text);
            msg.IsBodyHtml = true;
            SmtpClient sc = new SmtpClient("smtp.gmail.com",587);
            sc.UseDefaultCredentials = false;
            NetworkCredential cre = new NetworkCredential("brijeshdungrani303@gmail.com",txtPass.Text);
            sc.Credentials = cre;
            sc.EnableSsl = true;
            sc.Send(msg);
            MessageBox.Show("SEND");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                MailMessage mail = new MailMessage();
              //  mail.To.Add(email);
                mail.To.Add("brijeshdungrani303@gmail.com");
                mail.From = new MailAddress("brijeshdungrani303@gmail.com");
                mail.Subject = "sub";

                mail.Body = "<h1>hello</h1>";

                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.Credentials = new System.Net.NetworkCredential
                     ("brijeshdungrani303@gmail.com", ""); // ***use valid credentials***
                smtp.Port = 587;

                //Or your Smtp Email ID and Password
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show("success");
           
        }
    }
}
