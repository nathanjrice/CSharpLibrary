using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Methods_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Strawbs = new Player();
            Strawbs.Name = "Strawbs the Mighty";
            Strawbs.Attack();
            Strawbs.Attack("Chrimson Steel");
            Strawbs.Attack("Chrimson Steel", 17);
            Console.ReadLine();

        }
    }
    
}
