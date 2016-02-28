using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionAndExceptionHandling
{
    class BestMovieDataBase
    {
        public Dictionary<int, Movie> MovieTable { get; set; }

        public BestMovieDataBase()
        {
            SeedDataBase();
        }

        public void SeedDataBase()
        {

            MovieTable = new Dictionary<int, Movie>();

            //Seed movies into table;
            Movie movie1 = new Movie(2000, "Gladiator", "Ridley Scott");
            Movie movie2 = new Movie(2001, "A Beautiful mind", "Ron Howard");
            Movie movie3 = new Movie(2002, "Chicago", "Rob Marshall");
            Movie movie4 = new Movie(2003, "The Lord of the rings: The return of the King", "Peter Jackson");

            //Add movies to database dictionary
            MovieTable.Add(movie1.Year, movie1);
            MovieTable.Add(movie2.Year, movie2);
            MovieTable.Add(movie3.Year, movie3);
            MovieTable.Add(movie4.Year, movie4);

        }

        public int AddMovie(int key, Movie movie)
        {
            int movieAdded;

            if (MovieTable.ContainsKey(key))
            {
                movieAdded = 0;
            }
            else
            {
                MovieTable.Add(key, movie);
                movieAdded = 1;
            }

            return movieAdded;
   
        }

        public void RemoveMovie(int key)
        {
            MovieTable.Remove(key);
        }



    }
}
