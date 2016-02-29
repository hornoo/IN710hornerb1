using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collectionAndExceptionHandling
{
    class FormInputErrorFeedback
    {
        const int FirstOscarYear = 1927;
        int currentYear;


        //error messages
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

        public bool DisplayErrorMessage(int errorCode, Label errorOutPutLabel)
        {
            bool isAnError = false;

            if(errorCode > 0)
            {
                isAnError = true;
            }
            else
            {
                isAnError = false;
            }
            errorOutPutLabel.Text = errorStringlist[errorCode];


            return isAnError;
        }
        


    }
}
