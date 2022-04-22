using ExerciceMethodsAbstract.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExerciceMethodsAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> payers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int taxPayers = int.Parse(Console.ReadLine());

            for (int i = 0; i < taxPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");

                Console.Write("Individual or company (i/c)?");
                char option = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string Name = Console.ReadLine();

                Console.Write("Anual income: ");
                double AnualIncome = double.Parse(Console.ReadLine());

                if (option == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    Individual l = new Individual(Name, AnualIncome, healthExpenditures);
                    payers.Add(l);
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    Company j = new Company(Name, AnualIncome, numberOfEmployees);
                    payers.Add(j);
                }
            }

            Console.WriteLine();


            double totalTaxes = 0;
           foreach (TaxPayer payer in payers)
            {
                Console.WriteLine($"{payer.Name}: $ {payer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");

                totalTaxes += payer.Tax();
            }

            Console.WriteLine();

            Console.WriteLine($"TOTAL TAXES: {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
