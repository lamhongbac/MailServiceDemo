﻿using MailServiceAPI.Interfaces;
using MailServiceAPI.Logic;
using MailServiceAPI.Models;
using MailServiceDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace MailServiceDemo.Controllers
{
    public class SendMailDemoController : Controller
    {
        ISendMailService sendmailservice;
        public SendMailDemoController(ISendMailService sendmailservice)
        {
            this.sendmailservice = sendmailservice;
        }
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
        public async Task<IActionResult> SendMail(SendMailModel model)
        {
            MailContent content = new MailContent
            {
                To = model.To,
                Subject = model.Subject,
                Body = model.Body
            };

            await sendmailservice.SendMail(content);
            return View(model);
        }
    }
}
