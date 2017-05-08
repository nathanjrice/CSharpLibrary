using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer nate = new Customer();
            nate.FirstName = "Nathan";
            nate.LastName = "Rice";
            nate.AppearWealthy = true;
            nate.PrintCustomer();
            nate.Age = 25;
            nate.GetAge();
            Console.WriteLine(nate.PostInterest("Lotus Elise"));
            

            Car newCar = new Car();
            newCar.Automatic = true;
            newCar.IsFast = true;
            newCar.Name = "Corolla";
            newCar.Price = 6000;

            Console.WriteLine("{0} owns a {1}, and it's in bad shape.", nate.FirstName, newCar.Name);  //In bad shape could be a bool.
            Console.WriteLine("I think it is worth about a ${0} bucks for a trade in.", newCar.Price);

            //A little bit of inheritance.
            SportsCar sportsCar = new SportsCar();
            sportsCar.MadeInUSA = false;
            sportsCar.Name = "Lotus Elise";

            //NEEDS REFACTORING HERE VVVV
            if (sportsCar.MadeInUSA == false)
            {
                Console.WriteLine("He says he wouldn't mind owning a {0}, especially since it is an import", sportsCar.Name);
            }
            else
            {
                Console.WriteLine("He has no interest in owning a {0}, mostly because it was made in the USA", sportsCar.Name);
            }

            Console.ReadLine();
        }
    }
}
