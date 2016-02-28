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

        public bool CheckYearInput(TextBox inputTextBox)
        {
            bool yearIsOk;
            int yearInput;
            
            try
            {
                yearInput = Convert.ToInt32(inputTextBox.Text);
            }
            catch(System.FormatException e)
            {
                Console.WriteLine(e.Message);
                yearIsOk = false;
            }
            catch(System.OverflowException e)
            {
                Console.WriteLine(e.Message);
                yearIsOk = false;
            }
            finally
            {
                yearInput = 0;
            }


            if(yearInput <= currentYear && yearInput > FirstOscarYear)
            {
                yearIsOk = true;
            }

            return yearIsOk;


        }
    }
}
