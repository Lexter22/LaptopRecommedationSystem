using System.Diagnostics;

namespace LaptopRecommedationSystem
{
    internal class Program
    {

        static List<Laptop> laptops = new List<Laptop>();
        static void Main(string[] args)
        {
            string[] processes = { "1 - Add Laptop", "2 - Display Laptop", "3 - Update","4 - Remove Laptop", "5 - Exit" };
            Boolean loop = true;

            while (loop)
            {
                Console.WriteLine("Welcome to Laptop Recommender!\n" +
                    "Choose process");
                foreach (string process in processes)
                {
                    Console.WriteLine(process);
                }
                int ProcessChoice = Convert.ToInt16(Console.ReadLine());

                switch (ProcessChoice)
                {
                    case 1:
                        AddLaptop();
                        break;
                    case 2:
                        DisplayLaptop();
                        break;
                    case 3:
                        UpdateLaptop();
                        break;
                    case 4:
                        RemoveLaptop();
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
        static void AddLaptop() // add laptop method
        {
            Console.Write("Enter brand: ");
            string brand = Console.ReadLine();
            Console.Write("Enter model: ");
            string model = Console.ReadLine();
            Console.Write("Enter processor: ");
            string processor = Console.ReadLine();
            Console.Write("(8,16,32) GB Enter ram: ");
            int ram = Convert.ToInt16(Console.ReadLine());
            Console.Write("(256,512,1024) GB Enter storage: ");
            double storage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            laptops.Add(new Laptop(brand, model, processor, ram, storage, price));

            Console.WriteLine("Laptop Added");
            Console.WriteLine("-------------------------");
        }
        static void DisplayLaptop() // display laptop method
        {
            foreach (Laptop laptop in laptops)
            {
                Console.WriteLine($"Brand: {laptop.Brand}");
                Console.WriteLine($"Model: {laptop.Model}");
                Console.WriteLine($"Processor: {laptop.Processor}");
                Console.WriteLine($"Ram: {laptop.Ram}");
                Console.WriteLine($"Storage: {laptop.Storage}");
                Console.WriteLine($"Price: {laptop.Price}");
                Console.WriteLine("-------------------------");
            }
            
        }
        static void RemoveLaptop() // remove laptop 
        {
            Console.Write("Enter laptop model to delete: ");
            string model = Console.ReadLine();
            bool found = false;
            foreach (Laptop RemoveLaptop in laptops)
            {
                if (RemoveLaptop.Model == model)
                {
                    laptops.Remove(RemoveLaptop);
                    Console.WriteLine("Laptop Removed");
                    Console.WriteLine("-------------------------");
                    found = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Laptop Model not found");
                    found = false;
                }
            }
        }
        static void UpdateLaptop() // update laptop
        {
            Console.Write("Enter laptop model to update: ");
            string model = Console.ReadLine();
            Laptop LaptopUpdate = null;
            foreach(Laptop UpdateLaptop in laptops)
            {
                if (UpdateLaptop.Model == model)
                {
                    LaptopUpdate = UpdateLaptop;
                    break;
                }
            }
            if (LaptopUpdate != null)
            {
                string[] processes = { "1 - Update Brand", "2 - Update Processor", "3 - Update Ram", "4 - Update Storage", "5 - Update Price" };
                foreach (string process in processes)
                {
                    Console.WriteLine(process);
                }
                int ProcessChoice = Convert.ToInt16(Console.ReadLine());
                switch (ProcessChoice)
                {
                    case 1:
                        Console.Write("Update brand: ");
                        string brand = Console.ReadLine();
                        LaptopUpdate.Brand = brand;
                        break;
                    case 2:
                        Console.Write("Update Processor: ");
                        string NewProcessor = Console.ReadLine();
                        LaptopUpdate.Processor = NewProcessor;
                        break;
                    case 3:
                        Console.WriteLine("(8,16,32) GB Enter ram: ");
                        LaptopUpdate.Ram = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("(256,512,1024) GB Enter storage: ");
                        LaptopUpdate.Storage = Convert.ToDouble(Console.ReadLine());
                        break;
                    case 5:
                        Console.Write("Enter new price: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        LaptopUpdate.Price = price;
                        break;
          
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Laptop Updated");
            }
            else
            {
                Console.WriteLine("Laptop not found");

            }
        }
        public class Laptop
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Processor { get; set; }
            public int Ram { get; set; }
            public double Storage { get; set; }
            public double Price { get; set; }
            public Laptop(string Brand, string Model, string Processor, int Ram, double Storage, double Price)
            {
                this.Brand = Brand;
                this.Model = Model;
                this.Processor = Processor;
                this.Ram = Ram;
                this.Storage = Storage;
                this.Price = Price;
            }
        }
    }
}