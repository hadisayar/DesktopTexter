using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwilioTextClient
{
    class Translation
    {

        public string translate_number(string input)
        {
            string finalNumber = "";
            string prefinalNumber = "";

            List<char> inputArray = input.ToList();
            int num = 0;
            foreach (char c in input)
            {
                if (c < 48 || c > 57)
                {
                    inputArray.RemoveAt(num);
                    Console.WriteLine(c);
                }
                else
                {
                    num++;
                }
            }
            foreach (char c in inputArray)
            {
                prefinalNumber = prefinalNumber + c;
            }

            Console.WriteLine(input);

            if (prefinalNumber.Length == 10)
            {
                finalNumber = "+1" + prefinalNumber;
            }
            else if (prefinalNumber.Length > 10)
            {
                finalNumber = "+1" + prefinalNumber.Substring(0, 10);
            }
            else
            {
                finalNumber = "+1" + prefinalNumber.PadRight(10, '3');
            }

            return finalNumber;
        }

    }
}
