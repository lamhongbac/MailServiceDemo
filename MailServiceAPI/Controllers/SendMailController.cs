using MailServiceAPI.Interfaces;
using MailServiceAPI.Logic;
using MailServiceAPI.Models;
using MailServiceDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace MailServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMailController : ControllerBase
    {
        ISendMailService sendmailservice;
        public SendMailController(ISendMailService sendmailservice)
        {
            this.sendmailservice = sendmailservice;
        }
        public async Task<bool> SendGMail (SendMailModel model)
        {
            MailContent content = new MailContent
            {
                To = model.To,
                Subject = model.Subject,
                Body = model.Body
            };

            await sendmailservice.SendMail(content);
            return true;
        }
    }
}
