using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Objects_Challenge
{
    class Hotel
    {
        public string RoomNumber { get; set; }
        public bool IsAvailable { get; set; }
        public int NumRooms { get; set; }

        public void CheckAvailability()
        {
            if (IsAvailable)
                Console.WriteLine("{0} is available!", RoomNumber);
            else
                Console.WriteLine("Doesn't look like {0} is available.", RoomNumber);
        }

        public void PrintNumber()
        {
            Console.WriteLine("Hello, your room number is {0}", RoomNumber);
        }
    }
}
