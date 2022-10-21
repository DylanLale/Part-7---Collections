using System;
using System.Linq;

namespace Part_7___Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            int addlist;
            int removelist;
            double countlist;
            string addveggie;
            string veggiesvalue;
            int veggiesindex;
            int occurance;
            string veggiesearch;
            Random generator = new Random();
            List<double> numbers = new List<double>();
            for (int i = 0; i < 25; i++)
                numbers.Add(generator.Next(10, 21));

            List<double> numbers2 = new List<double>();
            for (int i = 0; i < 25; i++)
                numbers2.Add(generator.Next(10, 21));

            while (choice != "8")
            {
                for (int i = 0; i < numbers.Count; i++)
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
                    numbers.Sort();

                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {

                    Console.WriteLine("You chose option 2");
                    for (int i = 0; i < 25; i++)
                        Console.Write($",{numbers2[i]}");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "3")
                {

                    Console.WriteLine("You chose option 3");
                    Console.WriteLine("Enter a number to remove from the list");
                    removelist = Convert.ToInt32(Console.ReadLine());
                    numbers.Remove(removelist);
                    Console.WriteLine("Number sucessfully removed.");
                    Console.WriteLine();
                    Thread.Sleep(2000);
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
                    occurance = 0;
                    Console.WriteLine("You chose option 5");
                    Console.WriteLine("Choose a number in the list and this will count the number of occurances of that number");
                    countlist = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < numbers.Count; i++)
                    {


                        if (numbers[i] == countlist)
                        {
                            occurance += 1;
                        }
                    }
                    Console.WriteLine($"The number of occurances of the number " + countlist + " is " + occurance);



                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "6")
                {

                    Console.WriteLine("You chose option 6");
                    Console.WriteLine("Maximum Value in list is: " + numbers.Max());
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "7")
                {

                    Console.WriteLine("You chose option 7");
                    Console.WriteLine("Minimum Value in list is: " + numbers.Min());
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }
            List<string> veggies = new List<string>() {"Vegetables"};
            veggies.Add("1 – CARROT");
            veggies.Add("2 – BEET");
            veggies.Add("3 – CELERY");
            veggies.Add("4 – RADISH");
            veggies.Add("5 – CABBAGE");


            while (choice != "q")
            {
                for (int i = 0; i < veggies.Count; i++)
                    Console.Write($"{veggies[i]},");

                Console.WriteLine("Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 – Remove a vegetable by index");
                Console.WriteLine("2 – Remove a vegetable by value");
                Console.WriteLine("3 – Search for a vegetable");
                Console.WriteLine("4 – Add a vegetable");
                Console.WriteLine("5 – Sort list");
                Console.WriteLine("6 – Clear the list");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    //Do option 1
                    Console.WriteLine("You chose option 1");
                    veggiesindex = Convert.ToInt32(Console.ReadLine());
                    veggies.Remove(veggies[veggiesindex]);
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 2");
                    veggiesvalue = Console.ReadLine();
                    veggies.Remove(veggiesvalue);
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
                    Console.WriteLine("You chose option 4");
                    addveggie = Console.ReadLine();
                    veggies.Add(addveggie);
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "5")
                {
                    // Do option 2
                    Console.WriteLine("You chose option 5");
                    veggies.Sort();
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
