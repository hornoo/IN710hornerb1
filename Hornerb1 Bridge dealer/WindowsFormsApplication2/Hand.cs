using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum PlayerHand { N,S,E,W};

namespace WindowsFormsApplication2
{
    class Hand
    {
        private Card[] handCards;
        private int handSize = 13;
        private PlayerHand player;

        public Hand(PlayerHand player)
        {
            this.player = player;
            Card[] handCards = new Card[handSize];
        }

        public PlayerHand Player
        {
            get { return player; }
            set { player = value; }
        }

        public int HandSize
        {
            get { return handSize; }
            set { handSize = value; }
        }


        public Card[] HandCards
        {
            get { return handCards; }
            set { handCards = value; }
        }





        // Return High card Points value of the hand.
        public int highCardPoint()
        {
            int hcp = 0;

            foreach(Card card in handCards)
            {
                hcp += card.PoitValue();
            }

            return hcp;
        }


        //Sort array of cards by suit
        public void sortHand()
        {
            for (int i = 0; i < handCards.Length; i++)
            {
                for(int j = 0; j < handCards.Length - 1; j ++)
                {
                    Card temp;

                    if(handCards[j].Suit > handCards[j + 1].Suit)
                    {
                        temp = handCards[j + 1];
                        handCards[j + 1] = handCards[j];
                        handCards[j] = temp;
                    }

                }
            }
        }


    }
}
