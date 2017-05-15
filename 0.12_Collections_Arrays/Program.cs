using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //The index starts at 0. 0, 1, 2, 3, 4
            int[] ages = new int[5];
            ages[0] = 37;
            ages[1] = 40;
            ages[2] = 41;
            ages[3] = 35;
            ages[4] = 26;

            //To print one specific number:
            Console.WriteLine(ages[2]);

            //To print the whole array use a foreach:
            foreach (var age in ages.Take(2))
            {
                Console.WriteLine(age);
            }

            //Arrays are strongly typed. You can't add a string to an int array and vice versa.
            
            Console.ReadLine();
        }
    }
}
