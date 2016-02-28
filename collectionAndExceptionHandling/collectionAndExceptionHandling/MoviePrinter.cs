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

        public void printAllMovies(Dictionary<int,Movie> Movies, ListBox listBoxToPrinto)
        {
            foreach(KeyValuePair<int, Movie> CurrentMovie in Movies)
            {
                listBoxToPrinto.Items.Add(CurrentMovie.Value.ToString());
            }
        }


    }
}
