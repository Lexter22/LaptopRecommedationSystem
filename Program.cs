using System.Diagnostics;

namespace LaptopRecommedationSystem
{
    internal class Program
    {
        // John Lexter Reyes
        public static List<string>LaptopBrands = new List<string>();
        static void Main(string[] args)
        {
            string[] processes = { "1 - Add Brand", "2 - Display Brands", "3 - Recommend Brand", "4 - Remove Brand", "5 - Exit" };
            Boolean loop = true;
            
            while (loop)
            {
                Formatter();
                Console.WriteLine("Welcome to Laptop Brand Recommendations!\n" +
                    "Choose process");
                foreach (string process in processes)
                {
                    Console.WriteLine(process);
                }
                int ProcessChoice = Convert.ToInt16(Console.ReadLine());
                
                switch (ProcessChoice)
                {
                    case 1:
                        AddBrand();
                        break;
                    case 2:
                        DisplayBrands();
                        break;
                    case 3:
                        RecommendBrand();
                        break;
                    case 4:
                        RemoveBrand();
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
        // Add
        static string AddBrand()
        {
            Formatter();
            Console.Write("Enter brand name: ");
            string brand = Console.ReadLine().ToUpper();
            bool BrandExists = LaptopBrands.Contains(brand);
            if (!BrandExists)
            {
                LaptopBrands.Add(brand);
                Console.WriteLine($"{brand} added");
            }
            else
            {
                Console.WriteLine($"{brand} already exists");

            }
            return brand;
        }
        // Display
        static void DisplayBrands()
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
        // Recommend
        static string RecommendBrand()
        {
            // basta dito matanong mga requirements
            //Formatter();
            //int purpose;
            //Console.WriteLine("For what use do you want your computer?\n1 - Productivity 2 - Gaming 3 - Basic Browsing");
            //purpose = Convert.ToInt16(Console.ReadLine());
            //switch(purpose)
            //{
            //    case 1:
            //        return "ASUS";
            //    case 2:
            //        return "ACER";
            //    case 3:
            //        return "APPLE";
            //    default:
            //        return "HP";
            //}
            return "HP";
        }
        // Remove
        static string RemoveBrand()
        {
            Formatter();
            Console.WriteLine("Enter brand name to remove");
            string brand = Console.ReadLine().ToUpper();
            LaptopBrands.Remove(brand);
            return brand;
        } 
        static void Formatter()
        {
            Console.WriteLine("---------------------------------------------");
        }
    }
}