using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleCastDelegatewithparameters
{
    class Test
    {
        public void Print(string str)
        {
            Console.WriteLine("Passed Message:" + str);
        }

    }

    //Delegate Syntax
    public delegate void xyz(string str);
    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            t.Print("Welcome to Delegates Class");
            xyz x = new xyz(t.Print);
            x("Welcome");
            Console.ReadKey();
        }
    }
}
