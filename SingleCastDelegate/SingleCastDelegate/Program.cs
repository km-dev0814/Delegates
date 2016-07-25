using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleCastDelegate
{
    class Test
    {
        public void Print()
        {
            Console.WriteLine("This is from Print method");
        }

    }

    //Delegate Syntax
    public delegate void xyz();


    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            xyz x = new xyz(t.Print);
            x();
            Console.ReadKey();
        }
    }
}
