using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Objects_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel penthouseSuite = new Hotel();
            //Depending on this statement, it will change what the console says.
            penthouseSuite.IsAvailable = true;
            penthouseSuite.RoomNumber = "b7";
            penthouseSuite.NumRooms = 3;
            penthouseSuite.PrintNumber();
            penthouseSuite.CheckAvailability();

            Console.ReadLine();
        }
    }
}
