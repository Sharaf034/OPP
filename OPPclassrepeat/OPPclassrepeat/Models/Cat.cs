using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPclassrepeat.Models
{
    internal class Cat
    {
        private int age;

        public void Test1()
        {
            Console.WriteLine("Test 1");
            Test2();
        }

        private void Test2()
        {
            Console.WriteLine("Test2");
        }
    }
}
