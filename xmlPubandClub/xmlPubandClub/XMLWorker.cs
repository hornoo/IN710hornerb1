using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xmlPubandClub
{
    class XMLWorker
    {
        XDocument gigSchedual;
        XElement gigXmlElement;

        public XMLWorker(String pathToXML)
        {
            gigSchedual = XDocument.Load(pathToXML);
            gigXmlElement = gigSchedual.Element("Event_Guide");
        }

        public List<String[]> currentMonthGigs()
        {
            DateTime currentDate = DateTime.Now;

            List<String[]> returnList = new List<string[]>();

            foreach (XElement gig in gigXmlElement.Elements("Gig"))
            {
                int year, month, day;

                year = parese(gig.Element("Date").Attribute("year").Value;

                DateTime gigDate = new DateTime(gig.Element("Date").Attribute("year").Value, gig.Element("Date").Attribute("month").Value, gig.Element("Date").Attribute("day").Value);

                if (gig.Element("Date").Attribute("month").Value.Trim().Equals(month))
                {
                    returnList.Add(formatOutPutStringArray(gig));
                }
            }

            return returnList;

        }

        public List<String[]> HardRockGigs()
        {
            List<String[]> returnList = new List<string[]>();

            foreach (XElement gig in gigXmlElement.Elements("Gig"))
            {
                if (gig.Element("Band").Element("Genre").Value.Trim().Equals("Hard Rock"))
                {
                    returnList.Add(formatOutPutStringArray(gig));
                }
            }

            return returnList;

        }



        public List<String[]> UpcommingGigs()
        {
            
            List<String[]> returnList = new List<string[]>();

            foreach(XElement gig in  gigXmlElement.Elements("Gig"))
            {
                returnList.Add(formatOutPutStringArray(gig));
            }

            return returnList;
        }


        private String[] formatOutPutStringArray(XElement inputElement)
        {
            String bandName = inputElement.Element("Band").Element("Name").Value;
            String bandGenre = inputElement.Element("Band").Element("Genre").Value;
            String gigVenue = inputElement.Element("Venue").Value;
            String gigDate = inputElement.Element("Date").Attribute("day").Value + "/" + inputElement.Element("Date").Attribute("month").Value + "/" + inputElement.Element("Date").Attribute("year").Value;
            String gigTime = inputElement.Element("Time").Value;

            return new String[] { bandName, bandGenre, gigVenue, gigDate, gigTime };
        }
    }
}
