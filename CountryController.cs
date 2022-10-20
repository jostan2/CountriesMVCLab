using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CountriesMVCLab.Country;

namespace CountriesMVCLab
{
    public class CountryController
    {
        List<Country> CountryDb { get; set; } = new List<Country>();

        public CountryController()
        {
            CountryDb.Add(new Country("CountryA", Continent.ContinentA, new List<string> { "Blue", "Green", "Red" }));
            CountryDb.Add(new Country("CountryB", Continent.ContinentB, new List<string> { "Purple", "White" }));
            CountryDb.Add(new Country("CountryC", Continent.ContinentC, new List<string> { "Black", "Yellow", "Green" }));
            CountryDb.Add(new Country("CountryD", Continent.ContinentD, new List<string> { "Blue", "Violet" }));
            CountryDb.Add(new Country("CountryE", Continent.ContinentE, new List<string> { "Red", "Cyan", "Orange" }));
        }

        public void CountryAction(Country c)
        {
            CountryView cView = new CountryView(c);
            cView.Display();
        }

        public void WelcomeAction()
        {
            bool start = true;
            while (start == true)
            {
                CountryListAction();
                Console.Write("Hello, welcome to the country app. Please select a country from the following list to learn about: ");

                int userChoice;

                try
                {
                    userChoice = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (userChoice > 0 && userChoice <= CountryDb.Count)
                    {
                        CountryAction(CountryDb[userChoice - 1]);
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, please enter a number within the index, from 1-{CountryDb.Count}.");
                        Console.WriteLine();
                        continue;
                    }
                    
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Sorry, that is not a valid input. Please try again.");
                    continue;
                }

                Console.WriteLine();
                start = Repeat();
            }

        }

        public void CountryListAction()
        {
            CountryListView cList = new CountryListView(CountryDb);
            cList.Display();
            Console.WriteLine();
        }

        public bool Repeat()
        {
            Console.Write("Do you want to learn about another country? Y/N: ");
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    Console.WriteLine("Resetting...");
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------------------------------------------------------------------\n");
                    return true;
                }
                else if (input == "n")
                {      
                    Console.WriteLine("Goodbye!");
                    Console.WriteLine();
                    return false;
                }
                else
                {
                    Console.WriteLine("Please only enter Y or N:");
                }
            }
        }
    }
}
