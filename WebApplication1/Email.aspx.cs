using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Email : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //send email
            string Subject = "This is test mail using smtp settings";
            string Body = "Hello this is a test";
            string ToEmail = "unic_patrick@hotmail.com";
            string SMTPUser = "istbarp@gmail.com", SMTPPassword = "";
            SmtpClient smtp = new SmtpClient();

            smtp.UseDefaultCredentials = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            MailMessage mail = new MailMessage();
            mail.To.Add(ToEmail);
            mail.From = new MailAddress(SMTPUser);
            mail.Subject = Subject;
            mail.Body = Body;
            mail.IsBodyHtml = true;

            //domain (can be changed from gmail to whatever
            smtp.Host = "smtp.gmail.com";
            //change your port for your host
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential(SMTPUser, SMTPPassword);
            //smtp.Host = "smtp.gmail.com";

            //try catch for no errors.

            smtp.Send(mail);              
           

        }
    }
}