using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilioTextClient
{
    class TexterController
    {

        TwilioClient twilio = new TwilioClient();

        public string control (ENUMAPI api, string to, string from, string text)
        {

            string success = "";
            switch (api) 
            { 
                case ENUMAPI.Twilio:
                    success = "Status: " + twilio.SendMessage(from, to, text);
                    break;
                case ENUMAPI.smsglobal:

                    break;
                case ENUMAPI.Clockwork:

                    break;
                default:
                    return "Failed";
            }

            return success;
        }


    }
}
