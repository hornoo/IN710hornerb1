using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORMandLINQ
{
    public class DataBaseWorker
    {
        ListBox outputListBox;
        LightningStriksDBDataContext db;

        public DataBaseWorker(ListBox listBoxFromForm)
        {
            db = new LightningStriksDBDataContext();
            outputListBox = listBoxFromForm;
        }

        public void AverageIntensityOfAllStrikes()
        {
            outputListBox.Items.Clear();

            double aveOfAllStrikes = db.tblStrikes.Average(s => s.strikeIntensity);

            outputListBox.Items.Add(aveOfAllStrikes.ToString("F2"));

        }

        public void RecordsOfThreeLargestFires()
        {
            outputListBox.Items.Clear();

            var largestFires = db.tblFires.OrderByDescending(f => f.fireArea).Take(3);

            foreach (var lf in largestFires)
            {
                outputListBox.Items.Add("ID " + lf.fireID + " Date " + lf.fireDate + " Latitude " + lf.fireLatitude + " Longitude " + lf.fireLongitude + " Area " + lf.fireArea);
            }

        }


        public void LatLongFilenameOfEachPicture()
        {
            outputListBox.Items.Clear();

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

            var fireByStrike = from ls in db.tblStrikes
                               from f in db.tblFires
                               where ls.strikeLongitude == f.fireLongitude &&
                               ls.strikeLatitude == f.fireLatitude &&
                               ls.strikeDate == f.fireDate
                               select f;
                
                
                               var testQuery = from ls in db.tblStrikes
                               join f in db.tblFires
                               on new { ls.strikeDate, ls.strikeLatitude, ls.strikeLongitude } equals new { f.fireDate, f.fireLatitude, f.fireLongitude }
                               select f;
                                
                
                

            foreach (var f in fireByStrike)
            {
                outputListBox.Items.Add("ID " + f.fireID + " Fire date " + f.fireDate + " Latitude " + f.fireLatitude + " Longitude " + f.fireLongitude + " area " + f.fireArea);
            }
                               

                               
        }


    }
}
