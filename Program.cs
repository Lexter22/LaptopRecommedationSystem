using System.Diagnostics;

namespace LaptopRecommedationSystem
{
    internal class Program
    {
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
        static void RecommendBrand()
        {
            Formatter();
            List<string> RecommendedBrands = new List<string>();
            Console.WriteLine("For what use do you want your computer?\n1 - Productivity 2 - Gaming 3 - Basic Browsing");
            int purpose = Convert.ToInt16(Console.ReadLine());

            switch(purpose)
            {
                case 1:
                    if(LaptopBrands.Contains("DELL")) RecommendedBrands.Add("DELL");
                    if (LaptopBrands.Contains("APPLE")) RecommendedBrands.Add("APPLE");
                    if (LaptopBrands.Contains("HP")) RecommendedBrands.Add("HP");
                    break;
                case 2:
                    if(LaptopBrands.Contains("ASUS")) RecommendedBrands.Add("ASUS");
                    if (LaptopBrands.Contains("MSI")) RecommendedBrands.Add("MSI");
                    if (LaptopBrands.Contains("ACER")) RecommendedBrands.Add("ACER");
                    break;
                case 3:
                    if(LaptopBrands.Contains("LENOVO")) RecommendedBrands.Add("LENOVO");
                    if (LaptopBrands.Contains("SAMSUNG")) RecommendedBrands.Add("SAMSUNG");
                    if (LaptopBrands.Contains("MICROSOFT")) RecommendedBrands.Add("MICROSOFT");
                    break;
                default:
                    Console.WriteLine("Please read and try again");
                    break;
            }
            if(RecommendedBrands.Count > 0) // to check if may recommended brands
            {
                Console.WriteLine($"Recommended brands: {String.Join("," ,RecommendedBrands)}");
            }
            else
            {
                Console.WriteLine("No recommended brands");
            }
        }
        // Remove
        static string RemoveBrand()
        {
            Formatter();
            Console.Write("Enter brand name to remove: ");
            string brand = Console.ReadLine().ToUpper();
            if (LaptopBrands.Contains(brand))
            {
                LaptopBrands.Remove(brand);
                Console.WriteLine($"{brand} removed");
            }
            else
            {
                Console.WriteLine($"{brand} does not exist");
            }
            return brand;
        } 
        static void Formatter()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }
    }
}
