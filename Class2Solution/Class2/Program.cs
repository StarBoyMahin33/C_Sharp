using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class1 p = class1;
            Console.WriteLine(p.Salary);
            p.Salary = 3000.00;
            Console.ReadKey();



        }
    }
}
