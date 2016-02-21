using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    enum CardSuit { S, D, H, C};


namespace WindowsFormsApplication2
{



    class Card
    {
        private CardSuit suit;
        private int rank;

 

        public Card(CardSuit suit, int rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        internal CardSuit Suit
        {
            get { return suit; }
            set { suit = value; }
        }

        public int Rank
        {
            get { return rank; }
            set { rank = value; }
        }


        public int PoitValue()
        {
            int value = 0;

            switch (rank)
            {
                case 9: value = 1;
                    break;
                case 10: value = 2;
                    break;
                case 11: value = 3;
                    break;
                case 12: value = 4;
                    break;
                default : value = 0;
                    break;
            }

            return value;
        }

        public string faceRank()
        {

            string face;

            switch (rank)
            {
                case 0: face = "2";
                    break;
                case 1: face = "3";
                    break;
                case 2: face = "4";
                    break;
                case 3: face = "5";
                    break;
                case 4: face = "6";
                    break;
                case 5: face = "7";
                    break;
                case 6: face = "8";
                    break;
                case 7: face = "9";
                    break;
                case 8: face = "T";
                    break;
                case 9: face = "J";
                    break;
                case 10: face = "Q";
                    break;
                case 11: face = "K";
                    break;
                case 12: face = "A";
                    break;
                default: face = "invalid card";
                    break;

            }

            return face;
        }
    }
}
