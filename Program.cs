using System.Diagnostics;

namespace LaptopRecommedationSystem
{
    internal class Program
    {
        // John Lexter Reyes
        public static List<string>LaptopBrands = new List<string>();
        static void Main(string[] args)
        {
            string[] processes = { "1 - Add Brand", "2 - Display Brands", "3 - Edit", "4 - Recommend Brand", "5 - Exit" };
            Boolean loop = true;
            
            while (loop)
            {
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

                        break;
                    case 4:

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
        // methods
        static string AddBrand()
        {
            Console.WriteLine("Enter brand name");
            string brand = Console.ReadLine().ToUpper();
            LaptopBrands.Add(brand);
            return brand;
        }
        static string DisplayBrands()
        {
            Console.WriteLine("Brands");
            foreach (string brand in LaptopBrands)
            {
                Console.WriteLine(brand);
            }
            return "";
        }
    }
}