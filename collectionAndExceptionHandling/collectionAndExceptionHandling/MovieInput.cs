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
        public bool CheckYearInput(TextBox inputTextBox, Label errorLabel)
        {
            bool yearIsOk = true;
            int yearInput = 0;
            errorLabel.Text = "";
            
            
            try
            {
                yearInput = Convert.ToInt32(inputTextBox.Text.Trim());
            }
            catch(System.FormatException e)
            {
                Console.WriteLine(e.Message);
                yearIsOk = false;
                errorLabel.Text = "Year must be a four digit number, eg \"2001\" is ok, \"2 thousand and 1\" not ok";
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
                    errorLabel.Text = "";
                    yearIsOk = true;
                    Console.WriteLine("movie year ok");
                }
                else
                {
                    errorLabel.Text = "Year must be between" + FirstOscarYear + " and " + currentYear;
                    yearIsOk = false;
                    Console.WriteLine("movie out of range");

                }

            }

            return yearIsOk;

        }

        //Check input from a textbox is a string and not over 50 charaters long, return if successful.
        public bool CheckStringInput(TextBox inputTextBox, Label errorLabel) 
        {
            
            
            int maxStringLength = 50;
            errorLabel.Text = "";

            if (inputTextBox.TextLength > maxStringLength)
            {
                errorLabel.Text = "Input to long, Max of 50 charaters";
                return false;
            }
            if (inputTextBox.TextLength < 1)
            {
                errorLabel.Text = "Field cannot be blank";
                return false;
            }
            else
            {
                errorLabel.Text = "";
                return true;
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
