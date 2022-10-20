using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CountriesMVCLab.Country;

namespace CountriesMVCLab
{
    public class CountryView
    {
        public Country DisplayCountry {get; set;}

        public CountryView (Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.Name},\nContinent: {DisplayCountry.continent},\nColors:");
            foreach (string color in DisplayCountry.Colors)
            {
                Console.WriteLine($"{color}");
            }
        }
    }
}
