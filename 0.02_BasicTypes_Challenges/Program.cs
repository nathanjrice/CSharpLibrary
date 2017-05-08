using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypes_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int i;
        int t = 100;

        string name;
        string statement = "You feeling lucky, punk?";

        bool isSingle;
        bool isHappy = true;

        decimal studentLoanAmount;
        decimal bankAccount = 100;  //More expensive than a double.

        float degrees;
        float temperature = 69.5f;

        double number;
        double oneThird = 3.33333333d;

        name = "Nathan Rice";

            Console.WriteLine(temperature);
            Console.WriteLine(oneThird);

            /* SILVER */
            Console.WriteLine("{0} {1}", name, statement);

            /* GOLD */
            int bYear = Int32.Parse("1976");
        Console.WriteLine("I was born in {0}.", bYear);

            Console.WriteLine("Stop");
            Console.ReadLine();
        }
    }
}