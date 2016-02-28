using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collectionAndExceptionHandling
{
    public partial class Form1 : Form
    {
        BestMovieDataBase movieDataBase; 
        MovieInput InputWorker;
        MoviePrinter OutputWorker;
        FormInputErrorFeedback ErrorFeedBackWorker;
        

        public Form1()
        {
            InitializeComponent();
            movieDataBase = new BestMovieDataBase();
            InputWorker = new MovieInput();
            OutputWorker = new MoviePrinter();
            ErrorFeedBackWorker = new FormInputErrorFeedback();
        }


        private void butAddMovie_Click(object sender, EventArgs e)
        {


           // movieDateBase.AddMovie(InputWorker.insertMovie(textBoxInputMovieYear,labelIAddYearError,textBoxMovieTitleInput, labelTitleInputError, textBoxMovieDirectorInput, labelDirectorInputError);

            //Check format of year, and text input, present warning if invalid. If all inputs ok create movie object and add to database\dictionary.
            if(ValidateAllFieldInputs())
            {
                ErrorFeedBackWorker.DisplayErrorMessage(movieDataBase.AddMovie(InputWorker.CreateMovie(textBoxInputMovieYear, textBoxMovieTitleInput, textBoxMovieDirectorInput)),labelDirectorInputError);
            }
          

        }

        private void butDelMovie_Click(object sender, EventArgs e)
        {


        }

        private void butSearchYear_Click(object sender, EventArgs e)
        {


        }

        private void butPrintAllMov_Click(object sender, EventArgs e)
        {
            //Print contents of data base to listbox.
            OutputWorker.printAllMovies(movieDataBase.MovieTable, listBoxPrintMoviesResults);
        }

        private void clearAllFormInputs()
        {
            labelIAddYearError.Text = "";
            labelTitleInputError.Text = "";
            textBoxInputMovieYear.Clear();
            textBoxMovieDirectorInput.Clear();
            textBoxMovieTitleInput.Clear();
        }

        private bool ValidateAllFieldInputs ()
        {
            bool allFieldsOk = false;
            List<bool> listBoolTextFieldValidates = new List<bool>();

            listBoolTextFieldValidates.Add(ErrorFeedBackWorker.DisplayErrorMessage(InputWorker.CheckYearInput(textBoxInputMovieYear),labelIAddYearError));
            listBoolTextFieldValidates.Add(ErrorFeedBackWorker.DisplayErrorMessage(InputWorker.CheckStringInput(textBoxMovieTitleInput), labelTitleInputError));
            listBoolTextFieldValidates.Add(ErrorFeedBackWorker.DisplayErrorMessage(InputWorker.CheckStringInput(textBoxMovieDirectorInput), labelDirectorInputError));

            if (listBoolTextFieldValidates.Contains(true))
            {
                allFieldsOk = false;
            }
            else
            {
                allFieldsOk = true;
            }

            return allFieldsOk;

        }

        
    }
}
