using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class Test
    {
        public void P1()
        {
            Console.WriteLine("GD");
        }
        public void P2()
        {
            Console.WriteLine("GA");
        }
    }

    //Declaration of Delegate
    public delegate void Dname();

    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            Dname d1, d2, d3, d4, d5;
            d1 = new Dname(t.P1);
            d2 = new Dname(t.P2);
            d3 = d1 + d2;

            Console.WriteLine("From D3:");
            d3();

            d4 = d3 + d3;
            Console.WriteLine("From D4:");
            d4();

            d5 = d3 - d1;
            Console.WriteLine("From D5:");
            d5();

            Console.ReadKey();
        }
    }
}
