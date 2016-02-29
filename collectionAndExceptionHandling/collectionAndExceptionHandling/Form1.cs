using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
	
	Name: Richard Horne
	Title: Best Movie Database
	Date: 29/02/2016
	Description: This form class handles events from user and passes them to the appropriate class to handle input validation, passing feedback and data manipulation.
    
*/

namespace collectionAndExceptionHandling
{
    public partial class Form1 : Form
    {
        //Declaire form Fields
        BestMovieDataBase movieDataBase; 
        MovieInput InputWorker;
        MoviePrinter OutputWorker;
        FormInputErrorFeedback ErrorFeedBackWorker;
        
        

        public Form1()
        {
            //Assign memory to obkects that form interacts with.
            InitializeComponent();
            movieDataBase = new BestMovieDataBase();
            InputWorker = new MovieInput();
            OutputWorker = new MoviePrinter();
            ErrorFeedBackWorker = new FormInputErrorFeedback();
        }


        //Add movies to database
        private void butAddMovie_Click(object sender, EventArgs e)
        {

            clearAllFormInputs("add");

            //Check format of year and text input, present warning if invalid. If all inputs ok, call for creation of movie tobkect to be stored on movie database object
            if(ValidateAllFieldInputsForAddingMovie())
            {
                //Create movie object from text fields on form, pass movie to moviedatabase object to add into database, moviedatabase will try add move to database and pass back a code for the feedbackworker
                //to display a message on the label that was also passed in.
                ErrorFeedBackWorker.DisplayErrorMessage(movieDataBase.AddMovie(InputWorker.CreateMovie(textBoxInputMovieYear, textBoxMovieTitleInput, textBoxMovieDirectorInput)),labelDirectorInputError);         
            }
          

        }
        //Delete movies from database by year entered
        private void butDelMovie_Click(object sender, EventArgs e)
        {
            clearAllFormInputs("del");

            //Validate input field passed in, display error message to label and return if input is valid
            if (ValidateYearField(textBoxDeleteByYearMovieInput, labelDeleteMovieError))
            {
                //if input is valid, pass index\int of movie yeat in from text  to remove method of movie database, the remove method will try remove movie and a code to the 
                //error feekback worked to present and error back to the user.
                ErrorFeedBackWorker.DisplayErrorMessage(movieDataBase.RemoveMovie(Convert.ToInt32(textBoxDeleteByYearMovieInput.Text.Trim())), labelDeleteMovieError);   
            }

        }

        //Search for a movie my year and present in lis box.
        private void butSearchYear_Click(object sender, EventArgs e)
        {
            clearAllFormInputs("search");
            
            //Check if year input is valid,  print message to label and return if input from form is valid
            if (ValidateYearField(textBoxYearSearchInput, labelSearchErrorInput))
            {
                //Display error depening on freed back for outputworker.
                ErrorFeedBackWorker.DisplayErrorMessage(
                                                        // Try Print movie to form list box, return error code to Error feed back worker. 
                                                        OutputWorker.printSearchedMovie(
                                                                                         //Get year from form, return movie object to move printer.   
                                                                                        movieDataBase.SearchForMovie(Convert.ToInt32(textBoxYearSearchInput.Text.Trim()))
                                                                                       //List box passed into printSearched movie
                                                                                        , listBoxPrintMoviesResults)
                                                        //Lable to print error to.
                                                       , labelSearchErrorInput);
            }

        }

        //Print contents of database to listbox.
        private void butPrintAllMov_Click(object sender, EventArgs e)
        {
            clearAllFormInputs("printall");
            //Print contents of database to listbox. Pass in Dictionary and list box to print to.
            OutputWorker.printAllMovies(movieDataBase.MovieTable, listBoxPrintMoviesResults);
        }

        //clear contends of all fields and labels
        private void clearAllFormInputs(string button)
        {

            if(button == "add")
            {
                labelSearchErrorInput.Text = "";
                textBoxYearSearchInput.Clear();

                textBoxDeleteByYearMovieInput.Clear();
                labelDeleteMovieError.Text = "";



            }else if(button == "del")
            {

                labelSearchErrorInput.Text = "";
                textBoxYearSearchInput.Clear();

                labelIAddYearError.Text = "";
                labelTitleInputError.Text = "";
                textBoxInputMovieYear.Clear();
                textBoxMovieDirectorInput.Clear();
                textBoxMovieTitleInput.Clear();
                labelDirectorInputError.Text = "";

                listBoxPrintMoviesResults.Items.Clear();

            }else if(button == "search")
            {
                labelIAddYearError.Text = "";
                labelTitleInputError.Text = "";
                textBoxInputMovieYear.Clear();
                textBoxMovieDirectorInput.Clear();
                textBoxMovieTitleInput.Clear();           
                labelDirectorInputError.Text = "";

                textBoxDeleteByYearMovieInput.Clear();
                labelDeleteMovieError.Text = "";



            }else if (button == "printall")
            {
                labelIAddYearError.Text = "";
                labelTitleInputError.Text = "";
                textBoxInputMovieYear.Clear();
                textBoxMovieDirectorInput.Clear();
                textBoxMovieTitleInput.Clear();
                labelDirectorInputError.Text = "";

                labelSearchErrorInput.Text = "";
                textBoxYearSearchInput.Clear();

                textBoxDeleteByYearMovieInput.Clear();
                labelDeleteMovieError.Text = "";
            }


        }

        //Validate input from from and return if it is valid or not.
        private bool ValidateAllFieldInputsForAddingMovie ()
        {
            bool allFieldsOk = false;
            //list to record results from form validation.
            List<bool> listBoolTextFieldValidates = new List<bool>();

            //Validate field and pass in to validation list, check input from field and pass eny erros to Error feeebackwork to display to label that was passed in.
            listBoolTextFieldValidates.Add(ErrorFeedBackWorker.DisplayErrorMessage(InputWorker.CheckYearInput(textBoxInputMovieYear),labelIAddYearError));
            listBoolTextFieldValidates.Add(ErrorFeedBackWorker.DisplayErrorMessage(InputWorker.CheckStringInput(textBoxMovieTitleInput), labelTitleInputError));
            listBoolTextFieldValidates.Add(ErrorFeedBackWorker.DisplayErrorMessage(InputWorker.CheckStringInput(textBoxMovieDirectorInput), labelDirectorInputError));

            //Check if any errors were found in list if so return result.
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

        //Check  year input fiel on its own and return if it was valid or not.
        private bool ValidateYearField(TextBox inputYearTextBox, Label Outputlabel)
        {
            return !ErrorFeedBackWorker.DisplayErrorMessage(InputWorker.CheckYearInput(inputYearTextBox), Outputlabel);
        }

        
    }
}
