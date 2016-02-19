using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class THand
    {
        private TCard[] cards;
        private int privatePoints;
        private int numCards;

        public int points
        {
            get
            {
                return privatePoints;
            }

            set
            {
                privatePoints = value;
            }
        }

        public THand()
        {
            cards = new TCard[13];
        }

        public THand(TCard[] cardArray)
        {
            cards = new TCard[13];

            for (int i = 0; i < 13; i++)
            {
                cards[i] = cardArray[i];
            }
        }

        public void addCard(TCard newCard)
        {
            cards[numCards++] = newCard;
        }

        public int calcPoints()
        {
            privatePoints = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                switch (cards[i].number)
                {
                    case 14:
                        privatePoints += 4;
                        break;

                    case 11:
                        privatePoints += 1;
                        break;

                    case 12:
                        privatePoints += 2;
                        break;

                    case 13:
                        privatePoints += 3;
                        break;
                }
            }

            return privatePoints;
        }

        public void sortHand()
        {
            for (int i = 0; i < cards.Length; i++)
            {
                TCard minCard = cards[i];
                int minPos = i;
                for (int j = i; j < cards.Length; j++)
                {
                    //RH reversed < to > to change sort orde
                    if (cards[j].suit > minCard.suit)
                    {
                        minCard = cards[j];
                        minPos = j;
                    }
                    else if (cards[j].suit == minCard.suit)
                    {
                        //RH reversed < to > to change sort order
                        if (cards[j].number > minCard.number)
                        {
                            minCard = cards[j];
                            minPos = j;
                        }
                    }
                }
                TCard tempCard = cards[minPos];
                cards[minPos] = cards[i];
                cards[i] = tempCard;
            }
        }

        public override string ToString()
        {
            //RH added four suit string vatiables
            string spades = "S:\t";
            string diamonds = "D:\t";
            string hearts = "H:\t";
            string clubs = "C:\t";

            String myHand = "";
            for (int i = 0; i < 13; i++)
            {
                //RH Removed this -> myHand += cards[i].ToString();
                //Rh Removed this -> myHand += "test";
                
                //Rh Created this swithch  to build up string for each suit.
                switch (cards[i].suit)
                {
                    case 0:
                        spades += cards[i].ToString();
                        break;
                    case 1:
                        diamonds += cards[i].ToString();
                        break;
                    case 2:
                        hearts += cards[i].ToString();
                        break;
                    case 3:
                        clubs += cards[i].ToString();
                        break;
                }

            }

            myHand += spades + "\r\n";
            myHand += diamonds + "\r\n";
            myHand += hearts + "\r\n";
            myHand += clubs + "\r\n";

            return myHand + "\r\n";
        }

    }
}
