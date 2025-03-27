﻿using System.Diagnostics;
using DataBusiness;
namespace LaptopRecommedationSystem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] processes = { "1 - Add Brand", "2 - Display Brands", "3 - Recommend Brand", "4 - Remove Brand", "5 - Exit" };
            Boolean loop = true;

            // ui logic
            while (loop)
            {
                Formatter();
                DisplayMenu(processes);
                int ProcessChoice = Convert.ToInt16(Console.ReadLine());
                
                switch (ProcessChoice)
                {
                    case 1:
                        Console.Write("Enter brand: ");
                        string NewBrand = GetUserInput();
                        Console.WriteLine(LaptopProcess.AddBrand(NewBrand.ToUpper()));
                        break;
                    case 2:
                        DisplayBrands(LaptopProcess.LaptopBrands);
                        break;
                    case 3:
                        Console.WriteLine("For what use do you want your computer?\n1 - Productivity 2 - Gaming 3 - Basic Browsing");
                        int use = Convert.ToInt16(Console.ReadLine());
                        Formatter();
                        Console.WriteLine(LaptopProcess.RecommendBrand(use));
                        break;
                    case 4:
                        Console.Write("Enter brand: ");
                        string Remove = GetUserInput();
                        Console.WriteLine(LaptopProcess.RemoveBrand(Remove.ToUpper()));
                        break;
                    case 5:
                        Console.WriteLine("Thank you for using");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }        
        }
        // Menu
        static void DisplayMenu(string[] processes) // ui logic
        {
            Console.WriteLine("Welcome to Laptop Brand Recommendations!\n" +
                               "Choose process");
            foreach (string process in processes)
            {
                Console.WriteLine(process);
            }
        }
        public static void DisplayBrands(List<string> LaptopBrands) // ui logic
        {
            Formatter();
            Console.WriteLine("Brands");
            Formatter();
            foreach (string brand in LaptopBrands)
            {
                Console.Write($"{brand} | ");
            }
            Console.WriteLine();
        }
        static void Formatter()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }
        public static string GetUserInput()
        {
            return Console.ReadLine();
        }
    }
}
