namespace Part_7___Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intlist;
            string choice = "";
            Random generator = new Random();
            intlist = (generator.Next(10, 21)); Console.Write(generator.Next(10, 21));
            List<int> numbers = new List<int>();
            while (choice != "8")
            {
                Console.Clear(); // Optional
                Console.WriteLine("Welcome to my list menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Sort List");
                Console.WriteLine("2 - Make a new list of random numbers");
                Console.WriteLine("3 - Remove a number");
                Console.WriteLine("4 - Add value to list");
                Console.WriteLine("5 - Count the number of occurances of a certain number");
                Console.WriteLine("6 - Print largest value");
                Console.WriteLine("7 - Print lowest value");
                Console.WriteLine("...");
                Console.WriteLine("8 - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    //Do option 1
                    Console.WriteLine("You chose option 1");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 3");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();

                }
                else if (choice == "4")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 4");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "5")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 5");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "6")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 6");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "7")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 7");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                // Add an else if for each valid choice...
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
    }
}