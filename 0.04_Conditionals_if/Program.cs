using System;

namespace _0._04_Conditionals_if
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOn = true;
            bool isHot = false;

            if (isOn)
            {
                Console.WriteLine("The light is on. It's bright.");
            }

            if (isOn == true)
            {
                Console.WriteLine("The light is on");
            }

            if (isOn && isHot)
            {
                Console.WriteLine("Lights on and it's hot");
            }

            if (isOn || isHot)
            {
                Console.WriteLine("lights on or it is hot");
            }

            if (!isHot)
            {
                Console.WriteLine("it is not hot");
            }

            Console.ReadKey();
        }
    }
}