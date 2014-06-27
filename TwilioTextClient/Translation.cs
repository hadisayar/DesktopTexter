using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilioTextClient
{
    class Translation
    {

        string translate_number(string input)
        {
            string finalNumber = "";
            foreach (char c in input) 
            {
                if (c < 48 || c > 57)
                {
                    input.Replace(c, '0');
                }
            }
            if (input.Length == 10)
            {
                finalNumber = "+1" + input;
            }
            else if (input.Length > 10)
            {
                finalNumber = "+1" + input.Substring(0, 10);
            }
            else 
            {
                finalNumber = "+1" + input.PadLeft(10, '3');
            }

            return finalNumber;
        }

    }
}
