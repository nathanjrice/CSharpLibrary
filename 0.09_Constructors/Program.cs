using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student();
            studentOne.name = "Nathan";

            Student studentTwo = new Student();
            studentTwo.name = "Quinn";
            Console.WriteLine("{0} and {1} are great students.", studentOne.name, studentTwo.name);

            StudentClassTwo s1 = new StudentClassTwo();
            s1.name = "Nahan";

            StudentClassTwo s2 = new StudentClassTwo();
            s2.name = "Quinn";  
            Console.WriteLine("Great job, {0} and {1}", s1.name, s2.name);
            Console.WriteLine(s1.name.Length + "" + s2.name.Length);

            StudentClassThree student1 = new StudentClassThree("Evan");
            StudentClassThree student2 = new StudentClassThree("Ethan");

            Console.WriteLine("{0} and {1} are making big changes in coding education.", student1.Name, student2.Name);
            Console.ReadLine();


        }
    }
}
