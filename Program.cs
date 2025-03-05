namespace LaptopRecommedationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] processes = {"1 - Add Laptop","2 - Display Laptop","3 - Recommend Laptop","4 - Remove Laptop","5 - Exit"};
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

                switch(ProcessChoice)
                {
                    case 1:
                        Console.WriteLine("Adding laptop...");
                        Console.WriteLine("-------------------------");
                        break;
                    case 2:
                        Console.WriteLine("Displaying laptop");
                        Console.WriteLine("-------------------------");
                        break;
                    case 3:
                        Console.WriteLine("Recommeding laptop...");
                        Console.WriteLine("-------------------------");
                        break;
                    case 4:
                        Console.WriteLine("Removing laptop");
                        Console.WriteLine("-------------------------");
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        Console.WriteLine("Thank you for using");
                        Console.WriteLine("-------------------------");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
