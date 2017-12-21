using System;
using Microsoft.AspNetCore.Mvc;

using WebApplication5.Models;
using System.Diagnostics;
using MailKit.Security;
using System.Net.Mail;
using System.Net;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Queries()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Resources()
        {
            ViewData["Message"] = "";

            return View();
        }

        public IActionResult Security()
        {
            ViewData["Message"] = "";

            return View();
        }

        

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
