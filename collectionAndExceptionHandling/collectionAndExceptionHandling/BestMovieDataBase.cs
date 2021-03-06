﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
	
	Name: Richard Horne
	Title: Best Movie Database
	Date: 29/02/2016
	Description: This Best move database creates a sorted dictionary of movies, it handels movies being added , removed and searched.
    
*/

namespace collectionAndExceptionHandling
{
    class BestMovieDataBase
    {
        //not sure if this needs to be public
        public SortedDictionary<int, Movie> MovieTable { get; set; }

        public BestMovieDataBase()
        {
            //Seed database when instantiated
            SeedDataBase();
        }

        //method to seed database with movies initially.
        public void SeedDataBase()
        {

            MovieTable = new SortedDictionary<int, Movie>();

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

        //Add movie to data base, return is if was added sucessfully or not.
        public int AddMovie(Movie movie)
        {
           
            //dont think i need to check for null, this for was when code was different.
            if (movie == null)
            {   
                return 7;
            }
            //  Check if movie/key already in dictionary/database, return 6 if it is else add to database and return 1.
            else if (MovieTable.ContainsKey(movie.Year))
            {
                return 6;
            }
            else
            {
                MovieTable.Add(movie.Year, movie);
                return 5;
            }

   
        }

        //Check if moveie for year is in data base if it isreturn 9 otherwise remove movie from dictionary.
        public int RemoveMovie(int key)
        {
            if (MovieTable.ContainsKey(key))
            {
                MovieTable.Remove(key);
                return 8;
            }
            else
            {
                return 9;
            }
        }

        //check if movie exists  in data base if it does, retuen the movie otherwise return null movie object.
        public Movie SearchForMovie(int movieYear)
        {
            if (MovieTable.ContainsKey(movieYear))
            {
                return MovieTable[movieYear];
            }
            else
            {
                return null;
            }
        }


    }
}
