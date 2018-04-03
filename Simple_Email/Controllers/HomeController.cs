using Simple_Email.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Simple_Email.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DetailEmail model = new DetailEmail();
            return View(model);
        }
        public ActionResult SendEmail(DetailEmail detail)

        {
            string head = "<h1> Hello k." + "Test" + "</h1>";
            string message = "<h2>"+detail.Content+"</h1></h2> ";
            try
            {
                SmtpClient SmtpServer = new SmtpClient("smtp.live.com");
                var mail = new MailMessage();
                mail.From = new MailAddress(detail.EmailFrom, "Approvers");
                mail.To.Add(detail.EmailTo);//recipient
                mail.Subject = detail.Subject;
                mail.IsBodyHtml = true;
                mail.Body = head + message;
                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(detail.EmailFrom, detail.PasswordEmail);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                Console.Write("Error in Email" + ex);
            }
            return RedirectToAction("index");
        }
    }
}