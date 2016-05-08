using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORMandLINQ{

    //Worker class to handle extraction of data from Lightning Strike database, and then present in a list box.
    public class DataBaseWorker
    {
        //Allocating address for reference to list box and database reference that are passed in and instantiation. 
        ListBox outputListBox;
        LightningStriksDBDataContext db;

        //Constructor
        public DataBaseWorker(ListBox listBoxFromForm)
        {
            db = new LightningStriksDBDataContext();
            outputListBox = listBoxFromForm;
        }

        public void AverageIntensityOfAllStrikes()
        {
            outputListBox.Items.Clear();

            //Average intensity of all lightning strikes in tblStrikes, 
            double aveOfAllStrikes = db.tblStrikes.Average(s => s.strikeIntensity);

            outputListBox.Items.Add(aveOfAllStrikes.ToString("F2"));

        }

        public void RecordsOfThreeLargestFires()
        {
            outputListBox.Items.Clear();

            //Order tblFire  by fireArea in descending order then take the top 3 items from the ordered collection.
            var largestFires = db.tblFires.OrderByDescending(f => f.fireArea).Take(3);

            foreach (var lf in largestFires)
            {
                outputListBox.Items.Add("ID " + lf.fireID + " Date " + lf.fireDate + " Latitude " + lf.fireLatitude + " Longitude " + lf.fireLongitude + " Area " + lf.fireArea);
            }

        }


        public void LatLongFilenameOfEachPicture()
        {
            outputListBox.Items.Clear();

            //Join tblStrikes and tblPictures on strikeID create a new object of latitude, longitude and picture name the return.
            var pictureDetails = from ls in db.tblStrikes
                                 join p in db.tblPictures
                                 on ls.strikeID equals p.strikeID
                                 select new { ls.strikeLatitude, ls.strikeLongitude, p.pictureFileName };

            foreach (var lsp in pictureDetails)
            {
                outputListBox.Items.Add("Latitude " + lsp.strikeLatitude + " Longitude " + lsp.strikeLongitude + " Picture filename " + lsp.pictureFileName);
            }

        }

        public void FireByLightningSrike()
        {
            outputListBox.Items.Clear();


            //From tablStrikes and tblFires, where lat , long and date are equal return the row from the fire table.
            var fireByStrike = from ls in db.tblStrikes
                               from f in db.tblFires
                               where ls.strikeLongitude == f.fireLongitude &&
                               ls.strikeLatitude == f.fireLatitude &&
                               ls.strikeDate == f.fireDate
                               select f;
                
                /*this Query does not work, unsure why. I think it read nicer than the above query.
                  var testQuery = from ls in db.tblStrikes
                               join f in db.tblFires
                               on new { ls.strikeDate, ls.strikeLatitude, ls.strikeLongitude } 
                               equals new { f.fireDate, f.fireLatitude, f.fireLongitude }
                              select f;      
                */
                

            foreach (var f in fireByStrike)
            {
                outputListBox.Items.Add("ID " + f.fireID + " Fire date " + f.fireDate + " Latitude " + f.fireLatitude + " Longitude " + f.fireLongitude + " area " + f.fireArea);
            }
                               

                               
        }


    }
}
