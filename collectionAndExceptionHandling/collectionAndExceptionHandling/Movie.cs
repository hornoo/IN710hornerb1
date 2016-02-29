using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
	
	Name: Richard Horne
	Title: Best Movie Database
	Date: 29/02/2016
	Description: This Movie class is the skelleton for a movie to that we want to record in the data base.
    
*/


namespace collectionAndExceptionHandling
{
    class Movie
    {
        public int Year { get; set; }
        public String Title { get; set; }
        public String Director { get; set; }

        public Movie(int year, String title, String director)
        {
            Year = year;
            Title = title;
            Director = director;
        }

        public override string ToString()
        {
            return Year.ToString() + ", "  + Title + ", "  + Director;
        }
    }
}
