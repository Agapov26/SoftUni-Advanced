using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : ICaller, IInternetBrowser
    {
        public void CallNumber(string number)
        {
            if (!number.All(char.IsNumber))
            {
                throw new ArgumentException("Invalid number!");
            }

            if (number.Length == 10)
            {
                Console.WriteLine($"Calling... {number}");
            }

            else if (number.Length == 7)
            {
                Console.WriteLine($"Dialing... {number}");
            }
        }

        public void BrowseWebsite(string website)
        {
            if (website.Any(char.IsNumber))
            {
                throw new ArgumentException("Invalid URL!");
            }

            Console.WriteLine($"Browsing: {website}!");
        }
    }
}
