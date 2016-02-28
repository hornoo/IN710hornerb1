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
        int currentYear = DateTime.Now.Year;

        public MovieInput()
        {
            
        }

        public bool CheckYearInput(TextBox inputTextBox, Label errorLabel)
        {
            bool yearIsOk = true;
            int yearInput = 0;
            errorLabel.Text = "";
            
            
            try
            {
                yearInput = Convert.ToInt32(inputTextBox.Text);
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

        public void insertMovie(TextBox yearTextbox, TextBox titletextBox, TextBox directortextbox, BestMovieDataBase moviedatabase)
        {
            int year = Convert.ToInt32(yearTextbox);

            Movie newMovie = new Movie(year, titletextBox.ToString(),directortextbox.ToString());

            moviedatabase.AddMovie(year,newMovie);
        }


    }
}
