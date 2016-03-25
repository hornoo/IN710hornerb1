using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WeatherStation
{
    public class ForcastObserver : SensorObserver
    {

        public ForcastObserver(ListBox outputDisplay, SensorSubject subject)
        : base(outputDisplay, subject)
        {

        }

        public override void Update(int tempData, int HumidData, int barData)
        {
            currentDatareadingBar = barData;

            Display();

        }

        public override void Display()
        {
            dataDisplay.Items.Clear();


            if (currentDatareadingBar > 1020)
            {
                dataDisplay.Items.Add("Fine Dry Weather");
            }
            else if((currentDatareadingBar <= 1020) && (currentDatareadingBar > 1000))
            {
                dataDisplay.Items.Add("Change coming.");
            }
            else if ((currentDatareadingBar <= 1000) && (currentDatareadingBar > 920))
            {
                dataDisplay.Items.Add("Wet weather coming");
            }
            else
            {
                dataDisplay.Items.Add("The atmosphere has collapsed, death is imminent");
            }



        }
    }
}
