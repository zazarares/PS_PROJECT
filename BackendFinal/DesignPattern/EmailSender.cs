using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SendGrid.Helpers.Mail;
using SendGrid;
namespace BackendFinal.DesignPattern
{
    public static class EmailSender
    {
        public static async Task sendEmail(string From,string To,string subject,string content,string PatientName)
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);

            var _from = new EmailAddress("clinicadesange@gmail.com", From);
            var _subject = subject;
            var _to = new EmailAddress(To, PatientName);
            var _plainTextContent = "";
            var _htmlContent = content;
            var msg = MailHelper.CreateSingleEmail(_from, _to, _subject, _plainTextContent, _htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
