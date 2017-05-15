using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_ObjectArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Country[] countries = new Country[10];
            countries[0] = new Country("Hounduras", "Tegucigalpa");
            countries[1] = new Country("Italy", "Rome");
            countries[2] = new Country("USA", "D.C.");
            countries[3] = new Country("Israel", "Jerusalem");
            countries[4] = new Country("Peru", "lima");
            countries[5] = new Country("Japan", "Tokyo");
            countries[6] = new Country("Australia", "Sydney");
            countries[7] = new Country("China", "Beijing");
            countries[8] = new Country("Mexico", "Mexico City");
            countries[9] = new Country("Canada", "Toronto");

            foreach (var country in countries)
            {
                country.PrintCountryDetails();

            }

            Console.ReadLine();
        }
    }
}
