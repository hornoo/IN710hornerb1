using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenReporter2016
{
    public static class ReportGenerator
    {
        public static String OutStandingBal(Garden inGarden)
        {

            String reportString = null;
            String ownername = inGarden.OwnerName;
            double outStandingbal = inGarden.GetAccountBalance();

            reportString = String.Format("{0,-14}:{1,8:F2}", ownername, outStandingbal);


            return reportString;

        }
        public static String Area(Garden inGarden)
        {
            String reportString = null;
            String ownername = inGarden.OwnerName;
            double area = inGarden.GetArea();

            reportString = String.Format("{0,-14}:{1,8:F2}", ownername,area);


            return reportString;
        }
    }
}
