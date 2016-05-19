using MVCPractical1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractical1.Controllers
{
    public class HolidayController : Controller
    {
        // GET: Holiday
        public ActionResult Index()
        {
            Random rand = new Random();
            //Instantiate Holiday data bucket
            HolidayData holidayDetails = new HolidayData();
            //get todays date
            DateTime currentdate = DateTime.Today;

            //generate a random number to create data for page;
            int holidayIndex = rand.Next(3);

            //based on random generate data bucket
            switch (holidayIndex)
            {
                case 0:
                    holidayDetails.HolidayName = "Queens Birthday";
                    //Generate queens birthday, check it has been or not and return the days until.
                    holidayDetails.DaysTo = DaysUntil(getQueensBirthday());
                    holidayDetails.PathToImage = "../../content/queen.jpg";
                    break;
                case 1:
                    holidayDetails.HolidayName = "Halloween";
                    //Pass in the date of current years Halloween, check if it has been or not and pass back the days until.
                    holidayDetails.DaysTo = DaysUntil(new DateTime(currentdate.Year, 10, 31));
                    holidayDetails.PathToImage = "./../content/halloween.jpg";
                    break;
                case 2:
                    holidayDetails.HolidayName = "Boxing day";
                    //Pass in the date of current years BoxingDay, check if it has been or not and pass back the days until.
                    holidayDetails.DaysTo = DaysUntil(new DateTime(currentdate.Year, 12, 26));
                    holidayDetails.PathToImage = "../../content/boxing.jpg";
                    break;

            }

            return View(holidayDetails);
        }

        private int DaysUntil(DateTime UntilThisDate)
        {
            DateTime currenDate = DateTime.Today;
            int returnDays = 0;

            //Check if the holiday has been or not, if it has add on a year to the date
            if (currenDate.CompareTo(UntilThisDate) > 0)
            {
                UntilThisDate = UntilThisDate.AddYears(1);
            }

            //Calculate the days between current date and the holidays date.
            returnDays = (int)(UntilThisDate - currenDate).TotalDays;

            return returnDays;

        }

        private DateTime getQueensBirthday()
        {
            DateTime currenDate = DateTime.Today;

            //Set the date id f the first date in June for this year
            DateTime FirstDayOfJune = new DateTime(currenDate.Year, 6, 1);

            //Work out the date for the fist Monday in June and store that in return date.
            DateTime returnDate = computeFirstMondayOfJune(FirstDayOfJune);

            //if the current date is less than or equal to queens birthday return the generated date
            if (currenDate.CompareTo(returnDate) <= 0)
            {
                return returnDate;

            }
            //Else work out next years queens birthday and return that.
            else
            {
                FirstDayOfJune.AddYears(1);
                return computeFirstMondayOfJune(FirstDayOfJune);
            }

        }


        private DateTime computeFirstMondayOfJune(DateTime FirstDayOfJuneForYear)
        {
            //set the return date to the first day of June for the passed in year.
            DateTime returnDate = FirstDayOfJuneForYear;

            //while the date does not equal a Monday add on one day to the date and test again
            while (returnDate.DayOfWeek != DayOfWeek.Monday)
            {
                Console.WriteLine(returnDate);
               returnDate = returnDate.AddDays(1);
            }

            //return the date of the first Monday in June for that year that was passed in.
            return returnDate;
        }
​
    }
}