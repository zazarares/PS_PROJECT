using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendFinal.DesignPattern;
namespace BackendFinal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageSender : ControllerBase
    {
        private readonly ILogger<MessageSender> _logger;
        public MessageSender(ILogger<MessageSender> logger)
        {
            _logger = logger;
        }
        [Route("/SMS")]
        [HttpPost]
        public void Post_SMS(SMS S)
        {
            SMSSender.SendSMS(S.To, S.Content);   
        }

        [Route("/Email")]
        [HttpPost]
        public async Task Post_Email(Email E)
        {
            await EmailSender.sendEmail(E.From,E.To,E.subject, E.Content,E.PatientName);
        }
    }
}
