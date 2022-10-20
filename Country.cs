using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesMVCLab
{
    public class Country
    {
        public string Name { get; set; }
        public Continent continent { get; set; }
        public List<string> Colors { get; set; }

        public Country(string Name, Continent continent, List<string> Colors)
        {
            this.Name = Name;
            this.continent = continent;
            this.Colors = Colors;
        }

        public enum Continent
        {
            ContinentA,
            ContinentB,
            ContinentC,
            ContinentD,
            ContinentE,
        }
    }
}
