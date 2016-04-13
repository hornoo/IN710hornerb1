using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityData
{
    public class City
    {
        public String CityName {get; set;}
        public String CountryName {get; set;}

        public int Population {get; set;}

        public City(String cityName, String countryName, int population)
        {
            CityName = cityName;
            CountryName = countryName;
            Population = population;
        }
    }
}
