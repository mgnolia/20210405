using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swh_ldj_210412
{
    class Dog
    {
        public string name = "이동준";
        public int age = 33;
        public static int count = 0;

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            count++;
        }
    }
}
