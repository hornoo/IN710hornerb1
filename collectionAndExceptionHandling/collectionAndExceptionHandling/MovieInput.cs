using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
	
	Name: Richard Horne
	Title: Best Movie Database
	Date: 29/02/2016
	Description: TThis movieInput class checks form input, and returns an approprate error code.
    
*/


namespace collectionAndExceptionHandling
{
    class MovieInput
    {
        //set up popertires for year inout to be checked agains
        const int FirstOscarYear = 1927;
        int currentYear;

        public MovieInput()
        {   //set current year when instantiated.
            currentYear = DateTime.Now.Year;
        }

        //Check year input from form is valid return true if number between 1927 and current year. Check for non numeric charaters and present errors where required
        public int CheckYearInput(TextBox inputTextBox)
        {
            bool yearIsOk = true;
            int yearInput = 0;
            int yearErrorForReturn = 0;
            
            //try to copy string from form into int variable, catch it it contains a string or spaces and set error with out crashing application.
            try
            {
                yearInput = Convert.ToInt32(inputTextBox.Text.Trim());
            }
            catch(System.FormatException e)
            {   
                //set error to be passed back its contains string or not numeric charaters
                Console.WriteLine(e.Message);
                yearIsOk = false;
                yearErrorForReturn = 1;
                
            }
            //Catch if number is to big for int, show unfiendly message box.
            catch(System.OverflowException e)
            {

                MessageBox.Show(e.Message);
                yearIsOk = false;
            }


            //it number makes it through to being stored in and int, check if it meets requirments to be an oscar year.
            if (yearIsOk)
            {

                if ((yearInput <= currentYear) && (yearInput >= FirstOscarYear))
                {
                    yearErrorForReturn = 0;
                    yearIsOk = true;
                    Console.WriteLine("movie year ok");
                }
                else
                {
                    yearErrorForReturn = 2;
                    yearIsOk = false;
                    Console.WriteLine("movie out of range");

                }

            }

            //if this point is reached with out year is ok is still false set undefined error, return code
            if((!yearIsOk) && (yearErrorForReturn == 0))
            {
                yearErrorForReturn = 7;
            }

            return yearErrorForReturn;

        }

        //Check input from a textbox is a string and not over 50 charaters long, return if successful.
        public int CheckStringInput(TextBox inputTextBox) 
        {
                     
            int maxStringLength = 50;

            Console.WriteLine(inputTextBox.TextLength);
            
            //check stink is not empty and pass back appropriate erro code.
            if (inputTextBox.TextLength > maxStringLength)
            {
                return 3;
            }
            if (inputTextBox.TextLength < 1)
            {
               
                return 4;
            }
            else
            {
                return 0;
            }
            
        }


        

        //Create a movie from supplied textboxs, return movie.
        public Movie CreateMovie(TextBox yearTextbox, TextBox titletextBox, TextBox directortextbox)
        {
            int movieYear;
            
            movieYear = Convert.ToInt32(yearTextbox.Text.ToString().Trim());

            Movie newMovie = new Movie(movieYear, titletextBox.Text.ToString().Trim(),directortextbox.Text.ToString().Trim());

            return newMovie;
        }


    }
}
