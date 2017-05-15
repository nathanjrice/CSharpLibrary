using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_ObjectArrays
{
    class Country
    {
        public Country(string name, string capital)
        {
            Name = name;
            Capital = capital;
        }


        public string Name { get; set; }
        public string Capital { get; set; }

        public void PrintCountryDetails()
        {
            Console.WriteLine("The Capital of {0} is {1}", Name, Capital);
        }
    }
}
