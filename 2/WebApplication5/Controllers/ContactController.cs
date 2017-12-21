using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Send(MessageModel message)
        {
            try
            {
                var emailMessage = new MailMessage(SMTPModel.Email, message.Email, message.Topic, message.Text);
              
                using (var client = new SmtpClient(SMTPModel.Host, SMTPModel.Port))
                {

                    client.Credentials = new NetworkCredential(SMTPModel.Login, SMTPModel.Password);
                    client.EnableSsl = true;
                    client.Send(emailMessage);
                   
                }

                ViewBag.SuccessMessage = "Сообщение успешно отправлено!";
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
            }

            return View("Index");
        }
    }
}