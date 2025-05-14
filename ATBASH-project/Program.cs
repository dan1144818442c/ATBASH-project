using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ATBASH_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string level_of_danger(int point, string message)
            {
                if ((0 < point) && (point < 6))
                {
                    message += " WARRING";
                }
                else if ((5 < point) && (point < 11))
                {
                    message += " DANGER";
                }
                else if ((10 < point) && (point < 16))
                {
                    message += " ULTRA ALERT!";
                }

                string result = message +" " + point.ToString();
                Console.WriteLine(result);
                return result;
            }

 
        }
    }
}
