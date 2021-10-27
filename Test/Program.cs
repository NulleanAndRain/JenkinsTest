using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //A b = new B();
            //b.Foo();
            //Console.Read();
            int a = 10;
            object obj = (object)a;
            long b = (long)obj;
        }
    }
    class A
    {
        virtual public void Foo()
        {
            Console.WriteLine("A class");
        }
    }

    class B : A
    {
        public new void Foo()
        {
            Console.WriteLine("B class");
        }
    }
}

