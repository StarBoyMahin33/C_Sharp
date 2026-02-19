using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOutput
{
    internal class Program : teacher
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("ENTERED NAME : " + name);

            Console.Write("ENTER NUMBER 1 : ");
            string num1 = Console.ReadLine();
            int n1 = int.Parse(num1);

            Console.Write("ENTER NUMBER 2 : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("ENTER NUMBER 3 : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            //string concatenation
            Console.WriteLine("Sum/Addition of " + num1+ " , " +num2+ " and " +num3+ " is = " +(n1+num2+num3) );
            //placeholder indexing
            Console.WriteLine("Sum of {0} and {1} is : {2} ", n1,num2, n1+num2 );
            //using dollar sign
            Console.WriteLine($"Sum of {n1} and {num2} is :  {n1+num2}");


            Console.WriteLine("Subtraction of " + num1 + " , " + num2 + " and " + num3 + " is = " + (n1 - num2 - num3));
            Console.WriteLine("Multipication of " + num1 + " , " + num2 + " and " + num3 + " is = " + (n1 * num2 * num3));
            Console.WriteLine("Division of " + num1 + " , " + num2 + " and " + num3 + " is = " + (n1 / num2 ));

            teacher t = new teacher();
            t.Setsalary(2000.00);
            Console.WriteLine(t.GetSalary());

            Program p = new Program();
            p.Setsalary(3000.00);
            Console.WriteLine(p.GetSalary());


            
            


            Console.ReadKey();
        }
    }
}
