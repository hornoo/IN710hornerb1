using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityData
{
    public partial class Form1 : Form
    {
        List<City> cityList;

        //this takes a search string and a list of city objects and returns a list of citry objects in which the search string matches the country name of the city object;
        Func<string,List<City>,List<City>> findCitiesInCountry = (countryName, citylist) => (citylist.FindAll(City => City.CountryName == countryName));
           

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cityList = new List<City>(){
                new City("Dunedin", "New Zealand", 10000),
                new City("Wanaka", "New Zealand", 5000),
                new City("Milton", "New Zealand", 20),
                new City("Sydney", "Australia", 4627345),
                new City("Melborne", "Australia", 4246375),
                new City("Brisbane", "Australia", 2189878),
                new City("Perth", "Australia", 1896548),

            };
        }


        private void searchCityInCountry()
        {
            String city = null;
            List<City> returnList = new List<City>();
            try
            {
                city = tbCity.Text;
            }
            catch
            {
            }

            returnList = findCitiesInCountry(city, cityList);
            
            foreach(City currentCity in returnList)
            {
                listBox1.Items.Add(currentCity.CityName + " of " + currentCity.CountryName + " with a population of " + currentCity.Population);
            }
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            searchCityInCountry();
        }

    }
}
