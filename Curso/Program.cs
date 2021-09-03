using System;
using System.Globalization;
using System.Collections.Generic;
using Curso.Entities;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax Payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, income, expenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, employees));
                }
            }

            double sum = 0.00;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayer tp in list)
            {
                double tax = tp.Tax();
                Console.WriteLine(tp.Name+": $ "+tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ "+ sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
