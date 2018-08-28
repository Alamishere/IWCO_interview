using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace TestingStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Message.Sid: {SendMessage("+1 320-314-4048", "+1 320-223-4391", "Test for Alam", "AC039784a4e5c828ec4058989f632bbd90", "e59da03750c065e93943f8a218fc1830")}");
            Console.WriteLine();
        }

        public static string SendMessage(string from, string to, string msgBody, string accountSid, string authToken)
        {
            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: msgBody,
                from: new Twilio.Types.PhoneNumber(from),
                to: new Twilio.Types.PhoneNumber(to)
            );

            return message.Sid;
        }
    }
}
