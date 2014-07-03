using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;

namespace TwilioTextClient
{

    class TwilioClient
    {
        //Find account sid and token on TWILIO account       
        static string AccountSid = "";
        static string AuthToken = "{{ }}";
        string message = "This is an empty body";

        public bool SendMessage(string from, string to, string message)
        {
            this.message = message;
            var twilio = new TwilioRestClient(AccountSid, AuthToken);
            var failure = twilio.SendMessage(from, to, this.message);

            if (failure.ErrorMessage != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
