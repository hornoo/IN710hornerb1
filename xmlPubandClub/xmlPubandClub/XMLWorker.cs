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

        public XMLWorker(String pathToXML)
        {
            gigSchedual = XDocument.Load(pathToXML);
        }


        public List<String[]> upcommingGigs()
        {
            XElement gigXmlElement = gigSchedual.Element("Event_Guide");

            List<String[]> returnList = new List<string[]>();

            foreach(XElement gig in  gigXmlElement.Elements("Gig"))
            {
                String bandName = gig.Element("Band").Element("Name").Value;
                String bandGenre = gig.Element("Band").Element("Genre").Value;
                String gigVenue = gig.Element("Venue").Value;
                String gigDate = gig.Element("Date").Attribute("day").Value + "/" + gig.Element("Date").Attribute("month").Value + "/" + gig.Element("Date").Attribute("year").Value;
                String gigTime = gig.Element("Time").Value;

                returnList.Add(new String[] {bandName,bandGenre,gigVenue,gigDate,gigTime});
            }

            return returnList;
        }

    }
}
