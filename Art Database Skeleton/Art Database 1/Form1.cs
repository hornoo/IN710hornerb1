using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Art_Database_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Artist> artists;
        public List<Painting> paintings;

        private void Form1_Load(object sender, EventArgs e)
        {
            artists = new List<Artist>();
            artists.Add(new Artist { Country = "France", FirstName = "Camille", LastName = "Pissarro", YearOfBirth = 1830, YearOfDeath = 1903 });
            artists.Add(new Artist { Country = "France", FirstName = "Claude", LastName = "Monet", YearOfBirth = 1840, YearOfDeath = 1926 });
            artists.Add(new Artist { Country = "England", FirstName = "John", LastName = "Constable", YearOfBirth = 1776, YearOfDeath = 1837 });
            artists.Add(new Artist { Country = "Netherlands", FirstName = "Jan", LastName = "Vermeer", YearOfBirth = 1632, YearOfDeath = 1675 });
            artists.Add(new Artist { Country = "Italy", FirstName = "Sanzio", LastName = "Raphael", YearOfBirth = 1483, YearOfDeath = 1520 });
            artists.Add(new Artist { Country = "Spain", FirstName = "Pablo", LastName = "Picasso", YearOfBirth = 1881, YearOfDeath = 1973 });
            artists.Add(new Artist { Country = "Norway", FirstName = "Edvard", LastName = "Munch", YearOfBirth = 1863, YearOfDeath = 1944 });
            artists.Add(new Artist { Country = "Italy", FirstName = "Leonardo", LastName = "da Vinci", YearOfBirth = 1452, YearOfDeath = 1519 });
            artists.Add(new Artist { Country = "Italy", FirstName = "Sandro", LastName = "Botticelli", YearOfBirth = 1445, YearOfDeath = 1510 });
            artists.Add(new Artist { Country = "France", FirstName = "Henri", LastName = "Matisse", YearOfBirth = 1869, YearOfDeath = 1954 });
            artists.Add(new Artist { Country = "Netherlands", FirstName = "Piet", LastName = "Mondrian", YearOfBirth = 1872, YearOfDeath = 1944 });
            artists.Add(new Artist { Country = "United States", FirstName = "Jackson", LastName = "Pollock", YearOfBirth = 1912, YearOfDeath = 1956 });
            artists.Add(new Artist { Country = "Netherlands", FirstName = "Vincent", LastName = "van Gogh", YearOfBirth = 1853, YearOfDeath = 1890 });

            paintings = new List<Painting>();
            paintings.Add(new Painting { Artist = "van Gogh", Title = "The Starry Night", Method = "Oil on canvas", Year = 1889, Width = 72, Height = 92 });
            paintings.Add(new Painting { Artist = "van Gogh", Title = "Village Street in Auvers ", Method = "Oil on canvas", Year = 1890, Width = 73, Height = 92 });
            paintings.Add(new Painting { Artist = "Pissarro", Title = "Gelee Blanche", Method = "Oil on canvas", Year = 1873, Width = 65, Height = 93 });
            paintings.Add(new Painting { Artist = "Pissarro", Title = "Village Path", Method = "Oil on canvas", Year = 1875, Width = 72, Height = 92 });
            paintings.Add(new Painting { Artist = "Monet", Title = "Fishing Boats Leaving the Harbor, Le Havre ", Method = "Oil on canvas", Year = 1874, Width = 60, Height = 101 });
            paintings.Add(new Painting { Artist = "Monet", Title = "Water Lilies ", Method = "Oil on canvas", Year = 1906, Width = 88, Height = 93 });
            paintings.Add(new Painting { Artist = "Constable", Title = "The Leaping Horse", Method = "Oil on canvas", Year = 1825, Width = 142, Height = 187 });
            paintings.Add(new Painting { Artist = "Vermeer", Title = "Girl with a Pearl Earring", Method = "Oil on canvas", Year = 1665, Width = 45, Height = 40 });
            paintings.Add(new Painting { Artist = "Raphael", Title = "Madonna dell Granduca ", Method = "Oil on wood", Year = 1505, Width = 84, Height = 55 });
            paintings.Add(new Painting { Artist = "Raphael", Title = "St. George Fighting the Dragon ", Method = "Oil on wood", Year = 1825, Width = 28, Height = 21 });
            paintings.Add(new Painting { Artist = "Munch", Title = "The Scream", Method = "Tempera on paper", Year = 1893, Width = 91, Height = 74 });
            paintings.Add(new Painting { Artist = "da Vinci", Title = "The Last Supper", Method = "Tempera on plaster", Year = 1498, Width = 460, Height = 880 });
            paintings.Add(new Painting { Artist = "Botticelli", Title = "The Birth of Venus", Method = "Tempera on canvas", Year = 1485, Width = 173, Height = 280 });
            paintings.Add(new Painting { Artist = "Matisse", Title = "La Musique", Method = "Oil on canvas", Year = 1939, Width = 115, Height = 115 });
            paintings.Add(new Painting { Artist = "Mondrian", Title = "Composition with Red, Yellow and Blue", Method = "Oil on canvas", Year = 1821, Width = 40, Height = 35 });
            paintings.Add(new Painting { Artist = "Pollock", Title = "The Key", Method = "Oil on canvas", Year = 1946, Width = 84, Height = 213 });
            paintings.Add(new Painting { Artist = "Picasso", Title = "The Three Musicians", Method = "Oil on canvas", Year = 1921, Width = 200, Height = 222 });

            

        }

        //------------------------------------------------------
        // btnAllPaintings
        //------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //Foreach through all paintings int he painting list using a lamba expression.
            paintings.ForEach(p => listBox1.Items.Add(p.ToString()));
        }


        //------------------------------------------------------
        // btnArtistsFromItaly
        //------------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //where LINQ method artist country equals Italy.
            IEnumerable<Artist> artistsFromItaly = artists.Where(a => a.Country.Equals("Italy"));

            foreach(Artist a in artistsFromItaly)
            {
                listBox1.Items.Add(a.ToString());
            }
        }

        //------------------------------------------------------
        // btnBefore1800
        //------------------------------------------------------
        private void btnBefore1800_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //Where LINQ method paiting years is less than or equal to 1800, order the returned list.
            IEnumerable<Painting> paintingBefore1800 = paintings.Where(p => p.Year <= 1800).OrderBy(p => p.Year);
            foreach(Painting p in paintingBefore1800)
            {
                listBox1.Items.Add(p.ToString());
            }
        }

        //------------------------------------------------------
        // btnOldest
        //------------------------------------------------------
        private void btnOldest_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //LINQ query operator syntax,return the painting that's year equals the painting in the set with the lowest year.
            IEnumerable<Painting> oldestPainting = from p in paintings
                                                   where p.Year == paintings.Min(y => y.Year)
                                                   select p;

            foreach(Painting p in oldestPainting)
            {
                listBox1.Items.Add(p.ToString());
            }
        }

        //------------------------------------------------------
        // byThisArtist
        //------------------------------------------------------
        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String inputArtist = textBox1.Text.Trim();
            //Save input name to a variable, return the painting where the paintings artist equals the input name.
            IEnumerable<Painting> searchedPainting = from p in paintings
                                                     where p.Artist == inputArtist
                                                     select p;

            foreach (Painting p in searchedPainting)
            {
                listBox1.Items.Add(p.ToString());
            }
        }

        //------------------------------------------------------
        // btnNbyCountry
        //------------------------------------------------------
        private void btnNbyCountry_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Join artist and painting on painting artist and artist lastname, group by coutry into a sub group, then order by a count of each country. Select the key and count of each key and return this as its own var type.
            var NumPaitingsfromCountry = from p in paintings
                                         join a in artists
                                         on p.Artist equals a.LastName
                                         group p by a.Country into cGroup
                                         orderby(cGroup.Count())
                                         select new
                                         {
                                             country = cGroup.Key,
                                             countryCount = cGroup.Count()
                                         };
                                         
                                         
                                      
            foreach(var p in NumPaitingsfromCountry)
            {
                listBox1.Items.Add(p.countryCount + " painting from " + p.country);
            }


            
        }

        //------------------------------------------------------
        // btnArtistGroupedByCountry
        //------------------------------------------------------
        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //Group whole Artists list by artist country
            var ArtistsGroupedByCountry = artists.GroupBy(a => a.Country);

            //Unwrap each var object, print key(country) then all artists in that group.
            foreach(var a in ArtistsGroupedByCountry)
            {
                listBox1.Items.Add(a.Key + ":");
                foreach(var b in a)
                {
                    listBox1.Items.Add("\t"+ b.FirstName + " " + b.LastName);
                }
            }

        }

        //------------------------------------------------------
        // btnDutchPainters
        //------------------------------------------------------
        private void button7_Click(object sender, EventArgs e)
        {


            listBox1.Items.Clear();

            //Join artists and paintings on last name and artist, return the joit items that have Netherlands as their country, and order by the painting year. return only the paintings.
            IEnumerable<Painting> dutchPaintings = from p in paintings
                                 join a in artists
                                 on p.Artist equals a.LastName
                                 where a.Country == "Netherlands"
                                 orderby p.Year
                                 select p;

            foreach(Painting p in dutchPaintings)
            {
                listBox1.Items.Add(p.ToString());
            }

        }

        //------------------------------------------------------
        // btnJoinTables
        //------------------------------------------------------
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //Join artists and paintings on last name and artist, order by artist last name and make new object with first and last name, country and paintint title to return.
            var paintingWithArtist = from p in paintings
                                     join a in artists
                                     on p.Artist equals a.LastName
                                     orderby a.LastName
                                     select new {a.FirstName, a.LastName, a.Country, p.Title};

            foreach(var pa in paintingWithArtist)
            {
                listBox1.Items.Add(pa.FirstName + " " + pa.LastName + "\t" + pa.Country + "\t\t" + pa.Title);
            }

        }

        //------------------------------------------------------
        // btnFrenchOrItalian
        //------------------------------------------------------
        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //Join artists and paintings on last name and artist, order by artist last name, returh where artist country == Italy or France, return custom object of Lastname, country and painting title.
            var fromFranceOrItlay = from p in paintings
                                    join a in artists
                                    on p.Artist equals a.LastName
                                    orderby a.LastName
                                    where a.Country == "Italy" || a.Country == "France"
                                    select new { a.LastName, a.Country, p.Title };
            
            foreach(var fi in fromFranceOrItlay)
            {
                listBox1.Items.Add(fi.LastName + "\t" + fi.Country + "\t" + fi.Title);
            }



        }

 
    }
}
