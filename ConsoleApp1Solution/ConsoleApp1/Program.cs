using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class MidDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public MidDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
    public abstract class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public MidDate JoiningDate { get; set; }
        protected Employee(string id, string name, decimal salary, MidDate joiningDate)
        {
            Id = id;
            Name = name;
            Salary = salary;
            JoiningDate = joiningDate;
        }
        public abstract void ShowInfo();
        public abstract decimal GrossIncome();
    }
    public class Fulltime : Employee
    {
        public decimal Bonus { get; set; }
        public Fulltime(string id, string name, decimal salary, MidDate joiningDate, decimal bonus)
            : base(id, name, salary, joiningDate)
        {
            Bonus = bonus;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Full-Time Employee: {Id}, Name: {Name}, Salary: {Salary}, Joining Date: {JoiningDate}, Bonus: {Bonus}");
        }
        public override decimal GrossIncome()
        {
            decimal totalIncome = (Salary * 12) + (Bonus * 2);
            Console.WriteLine($"Gross Income for {Name}: {totalIncome}");
            return totalIncome;
        }
    }
    public class Parttime : Employee
    {
        public decimal Commission { get; set; }
        public Parttime(string id, string name, decimal salary, MidDate joiningDate, decimal commission)
            : base(id, name, salary, joiningDate)
        {
            Commission = commission;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Part-Time Employee: {Id}, Name: {Name}, Salary: {Salary}, Joining Date: {JoiningDate}, Commission: {Commission}");
        }
        public override decimal GrossIncome()
        {
            decimal totalIncome = (Salary * 12) + (Commission * 12);
            Console.WriteLine($"Gross Income for {Name}: {totalIncome}");
            return totalIncome;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[2];
            emp[0] = new Fulltime("E-001", "Saef", 30000, new MidDate(12, 09, 2013), 15000);
            emp[1] = new Parttime("E-002", "Kawsar", 12000, new MidDate(23, 07, 2019), 1300);
            foreach (Employee e in emp)
            {
                e.ShowInfo();
                e.GrossIncome();
            }
        }
    }
}
