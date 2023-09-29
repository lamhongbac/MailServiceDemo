using MailServiceDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace MailServiceDemo.Controllers
{
    public class SendMailDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SendMail()
        {
            SendMailModel model = new SendMailModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult SendMail(SendMailModel model)
        {
            return View();
        }
    }
}
