using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int bankAccount = 50000;
            int debt = 13500;
            int difference = bankAccount - debt;

            Console.WriteLine("I have $" + bankAccount + " in my bank account, and I am $" + debt + " in debt.");
            if (difference >= 7000)
            {
                Console.WriteLine("Yay money!");
            }
            else if (difference < 6999 && difference > 2000)
            {
                Console.WriteLine("Nope, save up youngin");
            }
            Console.ReadLine();
        }
    }
}