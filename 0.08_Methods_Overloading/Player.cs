﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Methods_Overloading
{
    class Player
    {
        public string Name { get; set; }


        public void Attack()
        {
            Console.WriteLine(this.Name + " attacked for 5 points");
        }
        public void Attack(string weapon)
        {
            Console.WriteLine(this.Name + " attacked with a rusty " + weapon);
        }
        public void Attack(string weapon, int attackPoints)
        {
            Console.WriteLine(this.Name + " attacked with a rusty " + weapon + " for " + attackPoints + " points of damage.");
        }
    }
}

