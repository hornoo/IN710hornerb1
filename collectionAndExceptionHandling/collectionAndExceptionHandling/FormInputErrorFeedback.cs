using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collectionAndExceptionHandling
{
    class FormInputErrorFeedback
    {
        const int FirstOscarYear = 1927;
        int currentYear;


        //error messages
        string intContainsString = "Year must be a four digit number, eg \"2001\" is ok, \"2 thousand and 1\" not ok";
        string intOutOfyearRange;
        string stringToLong = "Input to long, Max of 50 charaters";
        string fieldLeftBlank = "Field cannot be blank";

        public FormInputErrorFeedback()
        {
            currentYear = DateTime.Now.Year;
            intOutOfyearRange = "Year must be between" + FirstOscarYear + " and " + currentYear;
        }




    }
}
