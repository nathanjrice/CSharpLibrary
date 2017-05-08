﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods
{
    class Customer
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public bool AppearWealthy { get; set; }

        public void PrintCustomer()
        {
            Console.WriteLine("His name is {0} {1}", FirstName, LastName);
        }


        public void AssessWealth()
        {

            if (AppearWealthy == true)
            {
                Console.WriteLine("He does appear wealthy.");
            }
            else
            {
                Console.WriteLine("He doesn't appear wealthy.");
            }
        }
        public string GetCustomer()
        {
            return FirstName + LastName;
        }
        public int GetAge()
        {
            return Age;
        }
        public bool GetWealthStatus()
        {
            return AppearWealthy;
        }
        //Parameters
        public string PostInterest(string interest)
        {
            var message = FirstName + " appears interested in a " + interest;
            return message;
        }
        public int PostID(int id)
        {
            var idString = FirstName + " is number " + id;
            return id;
        }


        



    }
}
