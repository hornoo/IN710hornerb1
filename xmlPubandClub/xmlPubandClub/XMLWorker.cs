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
            //Load xml file into memory.
            gigSchedual = XDocument.Load(pathToXML);

            //get Root element and save it so it can be worked with with out repeating code.
            gigXmlElement = gigSchedual.Element("Event_Guide");
        }


        public List<String[]> currentMonthGigs()
        {
            //get instance of current date time
            DateTime currentDate = DateTime.Now;

            //create lst to return
            List<String[]> returnList = new List<string[]>();

            //For each gig element in gig xmlelements
            foreach (XElement gig in gigXmlElement.Elements("Gig"))
            {
                //create another date time object from current gig
                DateTime gigDate = new DateTime(int.Parse(gig.Element("Date").Attribute("year").Value), int.Parse(gig.Element("Date").Attribute("month").Value), int.Parse(gig.Element("Date").Attribute("day").Value));

                //check it year and month match and it so pass gig to formatOutPutStringArray to extract data.
                if (gigDate.Month.Equals(currentDate.Month) && gigDate.Year.Equals(currentDate.Year))
                {
                    returnList.Add(formatOutPutStringArray(gig));
                }
            }

            return returnList;

        }

        public List<String[]> AlabamaShakes()
        {
            List<String[]> returnList = new List<string[]>();

            foreach (XElement gig in gigXmlElement.Elements("Gig"))
            {
                //Find gig that has Alamaba Shakes asband name 
                if (gig.Element("Band").Element("Name").Value.Trim().Equals("Alabama Shakes"))
                {
                    //get members element from gig
                    XElement bandMembers = gig.Element("Band").Element("Band_Members");

                    foreach(XElement member in bandMembers.Elements("Member"))
                    {
                        //Extract values
                        String firstName = member.Element("First_Name").Value.Trim();
                        String lastName = member.Element("Last_Name").Value.Trim();
                        String role = "";
                        //Check if role exists if it does get it value.
                        if (member.Element("Role") != null)
                        {
                            role = member.Element("Role").Value.Trim();
                        }

                        //get instiment elements
                        XElement instruments = member.Element("Instruments");

                        String memberInstruments = "";

                        foreach(XElement instrument in instruments.Elements("Instrument"))
                        {
                            //extract data and buld up string
                            memberInstruments += instrument.Value.Trim() + " ";
                        }

                        returnList.Add(new String[] {firstName, lastName, role, memberInstruments });

                    }
                }
            }

            return returnList;

        }



        public List<String[]> UpcommingGigs()
        {
            
            List<String[]> returnList = new List<string[]>();

            foreach(XElement gig in  gigXmlElement.Elements("Gig"))
            {
                //Resturn each gig to formatOutPutStringArray to  then extract data
                returnList.Add(formatOutPutStringArray(gig));
            }

            return returnList;
        }

        public List<string[]> HardRockGigs()
        {
            List<String[]> returnList = new List<string[]>();

            foreach (XElement gig in gigXmlElement.Elements("Gig"))
            {
                //return gig if its genre element value is Hard rock
                if (gig.Element("Band").Element("Genre").Value.Trim().Equals("Hard Rock"))
                {
                    returnList.Add(formatOutPutStringArray(gig));
                }
            }

            return returnList;
        }

        public void addGig(String bandName, String Genre, String Venue, String Time, int Day, int Month, int Year)
        {
            //pass in gig values, and build up to match xml structure. then pass in as new element
            XElement gig = new XElement("Gig",
                                        new XElement("Venue", Venue),
                                        new XElement("Date",
                                                            new XAttribute("day",Day),
                                                            new XAttribute("month",Month),
                                                            new XAttribute("year",Year)),
                                        new XElement("Time",Time),
                                        new XElement("Band",
                                                            new XElement("Name", bandName),
                                                            new XElement("Genre", Genre)
                                            )


                                        );

            gigSchedual.Element("Event_Guide").Add(gig);
        }

        //Extrack values from element and pass back a string array of the values.
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
