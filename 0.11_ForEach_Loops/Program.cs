using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_ForEach_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;
            int[] lottoNums = new int[] { 4, 8, 15, 16, 23, 42 };

            Console.WriteLine(numbers[0]);

            Console.WriteLine(lottoNums[5]);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            foreach (int lottoNum in lottoNums)
            {
                Console.WriteLine(lottoNum);
            }


            string[] names = new string[] { "Nathan", "Quinn", "Truman", "Sam", "Jayla" };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();




        }
    }
}
  