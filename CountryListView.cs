using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesMVCLab
{
    public class CountryListView
    {
        public List<Country> Countries { get; set; }

        public CountryListView (List<Country>countries)
        {
            Countries = countries;
        }

        public void Display()
        {
            int index = 0;

            foreach (Country c in Countries)
            {
                index++;
                Console.WriteLine(index + ") " + c.Name);
            }


        }
    }
}
