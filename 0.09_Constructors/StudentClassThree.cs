using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors
{
    class StudentClassThree
    {
        public StudentClassThree()
        {
            this.Name = "";
        }

        
        public StudentClassThree(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
