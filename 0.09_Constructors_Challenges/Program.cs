using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string natesPhone = "I own the ";
            MobilePhone myPhone = new MobilePhone("iPhone", "6");
            Console.WriteLine(natesPhone + myPhone.Brand + " " + myPhone.Version + ".");
            Console.ReadLine();
        }
    }
}
