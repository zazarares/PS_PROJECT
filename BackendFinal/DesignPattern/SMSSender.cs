using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
namespace BackendFinal.DesignPattern
{
    public class SMSSender
    {
        public static void SendSMS(string To,string Content)
        {
            string accountSid = "ACcf57723b4afd14bbfd834dc768fd1c50";
            string authToken = "75c04edb5275feefbd17207ecfba8b68";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: Content,
                from: new Twilio.Types.PhoneNumber("+13464724383"),
                to: new Twilio.Types.PhoneNumber(To)
        );
        }


    }
}
