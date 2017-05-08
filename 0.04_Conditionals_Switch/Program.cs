using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            string friend = "Quinn";

            switch (friend)
            {
                case "Fred":
                    Console.WriteLine("Hey Fred");
                    break;
                case "Nathan":
                    Console.WriteLine("Hey Quinn");
                    break;
                default:
                    Console.WriteLine("Hey " + friend + " can I call you back in a minute?");
                    break;
            }
            Console.ReadLine();
        }
    }
}