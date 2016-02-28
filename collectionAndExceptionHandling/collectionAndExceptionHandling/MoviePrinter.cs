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
            //Clear items from list box
            listBoxToPrinto.Items.Clear();

            //Print each item out to list box
            foreach(KeyValuePair<int, Movie> CurrentMovie in Movies)
            {
                listBoxToPrinto.Items.Add(CurrentMovie.Value.ToString());
            }
        }


    }
}
