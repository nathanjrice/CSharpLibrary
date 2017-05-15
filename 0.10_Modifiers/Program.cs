using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Lotus lotus = new Lotus("Elise", 2016, 125000);

            lotus.LotusDetails();

            Console.ReadLine();
        }
    }
}
