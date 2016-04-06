using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GardenReporter2016
{
    public delegate String RepotDelegate(Garden gardentToProcess);

    public class GardenManager
    {
        

        List<Garden> gardenList;

        public GardenManager()
        {
            gardenList = new List<Garden>();
        }

        public void AddGarden(Garden garden1)
        {
            gardenList.Add(garden1);
        }

        public List<String> ProcessGardens(RepotDelegate inputDel)
        {
            List<String> returnList = new List<string>();

            foreach (Garden currentgarden in gardenList)
            {
                returnList.Add(inputDel(currentgarden));
            }

            return returnList;
        }



    }
}
