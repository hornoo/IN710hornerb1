using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace collectionAndExceptionHandling
{
    class MovieInput
    {
        const int FirstOscarYear = 1927;
        int currentYear;

        public MovieInput()
        {
            currentYear = DateTime.Now.Year;
        }

        //Check year input from form is valid return true if number between 1927 and current year. Check for non numeric charaters and present errors where required
        public int CheckYearInput(TextBox inputTextBox)
        {
            bool yearIsOk = true;
            int yearInput = 0;
            int yearErrorForReturn = 0;
            
            
            try
            {
                yearInput = Convert.ToInt32(inputTextBox.Text.Trim());
            }
            catch(System.FormatException e)
            {
                Console.WriteLine(e.Message);
                yearIsOk = false;
                yearErrorForReturn = 1;
                
            }
            catch(System.OverflowException e)
            {
                MessageBox.Show(e.Message);
                yearIsOk = false;
            }



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


        // should I be adding movie to data base here? and covering all error messages in here as well?

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
