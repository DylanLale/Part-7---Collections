namespace Part_7___Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            int addlist;
            Random generator = new Random();
            List<double> numbers = new List<double>();
            for(int i = 0; i < 25; i++) 
                numbers.Add(generator.Next(10, 21));

            List<double> numbers2 = new List<double>();
            for (int i = 0; i < 25; i++)
                numbers.Add(generator.Next(10, 21));

            while (choice != "8")
            {
                for(int i = 0; i < 25; i++) 
                    Console.Write($"{numbers[i]},");
                Console.WriteLine();
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
           
                    Console.WriteLine("You chose option 1");
                    Console.WriteLine(numbers.Sort());
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
            
                    Console.WriteLine("You chose option 2");
                    for (int i = 0; i < 25; i++)
                        Console.Write($"{numbers2[i]},");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                  
                    Console.WriteLine("You chose option 3");
                    Console.WriteLine("Enter a number to remove from the list");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();

                }
                else if (choice == "4")
                {
                    
                    Console.WriteLine("You chose option 4");
                    Console.WriteLine("Add a number to the list");
                    addlist = Convert.ToInt32(Console.ReadLine());
                    numbers.Add(addlist);
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "5")
                {
                   
                    Console.WriteLine("You chose option 5");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "6")
                {
               
                    Console.WriteLine("You chose option 6");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "7")
                {
                
                    Console.WriteLine("You chose option 7");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
               
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
        }
    }
}