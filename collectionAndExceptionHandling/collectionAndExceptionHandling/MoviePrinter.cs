using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collectionAndExceptionHandling
{
    class MoviePrinter
    {
        public MoviePrinter()
        {

        }

        public int printSearchedMovie(Movie movie, ListBox listBoxToPrintTo)
        {
            listBoxToPrintTo.Items.Clear();

            if (movie == null)
            {
                return 10;
            }
            else
            {
                listBoxToPrintTo.Items.Add(movie.ToString());
                return 0;
            }
        }

        public void printAllMovies(Dictionary<int,Movie> Movies, ListBox listBoxToPrintTo)
        {
            //Clear items from list box
            listBoxToPrintTo.Items.Clear();

            //Print each item out to list box
            foreach(KeyValuePair<int, Movie> CurrentMovie in Movies)
            {
                listBoxToPrintTo.Items.Add(CurrentMovie.Value.ToString());
            }
        }


    }
}
