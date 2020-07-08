using System;
using System.Transactions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("First number is  " + firstNumber);

            Console.WriteLine("Enter an operator you want to use");
            string c = Console.ReadLine();

            Console.WriteLine("Enter the next number");
            double nextNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Next number is  " + nextNumber);

            double a=firstNumber;
            double b=nextNumber;
            string formula = "acb";
            formula = formula.Replace("a", a.ToString()).Replace("b", b.ToString()).Replace("c", c.ToString());

            var calc = new System.Data.DataTable();
            Console.WriteLine(calc.Compute(formula, ""));

        }
    }
}
