using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var ch in "Hello World")
            {
                Console.WriteLine("{0}", ch);   // strings are just linked lists of chars
            }


            foreach (char ch in "Hello World") Console.WriteLine("{0}", ch); // single lines can omit braces

            Console.WriteLine(" ");


            char[] chars = new char[4];

            //List of UTF-16 Symbols and Letters http://www.fileformat.info/info/charset/UTF-16/list.htm

            chars[0] = '\x004E';
            chars[1] = '\x0061';
            chars[2] = '\x0074';
            chars[3] = '\x0065';

            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();

        }
    }
}
       