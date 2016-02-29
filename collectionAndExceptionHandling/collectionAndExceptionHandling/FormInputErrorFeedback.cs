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
	Description: This FormInputErrorFeedback class takes a code passed into it along with a label to print back to. Prints the assicated error fromt he lst back to the label as feed back.
    
*/

namespace collectionAndExceptionHandling
{
    class FormInputErrorFeedback
    {
        // set dates required for feedback
        const int FirstOscarYear = 1927;
        int currentYear;


        //error messages stored in strings
        string intContainsString = "Year must be a four digit number, eg \"2001\" is ok, \"2 thousand and 1\" not ok"; //0
        string intOutOfyearRange; //1
        string stringToLong = "Input to long, Max of 50 charaters"; //2
        string fieldLeftBlank = "Field cannot be blank"; //3
        string movieaAddSucessful = "Movie added Sucessfully"; //4
        string movieNotAddedExisits = "Movie aleady exists in database at year."; //5
        string noError = ""; //6
        string undefiledError = "Error Undefined"; //7
        string movieDeleted = "Movie Deleted from database"; //8
        string MovieDoesntExistdelete = "Movie does not exist in database to delete"; //9
        string MovieDoesntExistSearch = "Movie search did not return a movie"; //10

        List<string> errorStringlist;

        public FormInputErrorFeedback()
        {
            //Set variables and load error messages into error string list.
            currentYear = DateTime.Now.Year;
            intOutOfyearRange = "Year must be between" + FirstOscarYear + " and " + currentYear;

            errorStringlist = new List<string>(){
            noError,
            intContainsString,
            intOutOfyearRange,
            stringToLong,
            fieldLeftBlank,
            movieaAddSucessful,
            movieNotAddedExisits,
            undefiledError,
            movieDeleted,
            MovieDoesntExistdelete,
            MovieDoesntExistSearch

            };

        }

        //check error passed in and display appropriate error message on label that was also passed in. Return if it was and erro messafe on not.
        public bool DisplayErrorMessage(int errorCode, Label errorOutPutLabel)
        {
            bool isAnError = false;

            //set return message, all message above 0 index of list are errors or required feedback. 
            if(errorCode > 0)
            {
                isAnError = true;
            }
            else
            {
                isAnError = false;
            }

            //Print error message to label at index of stringlist fromm erro code that was passed in.
            errorOutPutLabel.Text = errorStringlist[errorCode];


            return isAnError;
        }
        


    }
}
