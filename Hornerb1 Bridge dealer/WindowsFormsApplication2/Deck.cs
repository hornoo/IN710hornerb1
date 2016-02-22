using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Deck
    {
        const int DECKSIZE = 52;
        const int HANDSIZE = 13;
        const int CARDRANKRANGE = 13;
        const int HANDS = 4;
        Card[] cardstack;
        Hand[] bridgeHands;

        

        public Deck()
        {
            cardstack = new Card[DECKSIZE];
            bridgeHands = new Hand[HANDS];
            createDeck();
            createHands();
        }


        internal Hand[] BridgeHands
        {
            get { return bridgeHands; }
            set { bridgeHands = value; }
        }

        public Card[] Cardstack
        {
            get { return cardstack; }
            set { cardstack = value; }
        }

        public void createDeck()
        {
            for (int i = 0; i < 4; i++)
            {
                int count = 0;

                for(int j = i * CARDRANKRANGE; j < (i + 1) * CARDRANKRANGE; j++)
                {
                    cardstack[j] = new Card((CardSuit)i, count);
                    count++;

                    Console.WriteLine("Card #" + j +  " " + cardstack[j].Suit + cardstack[j].faceRank());

                }
            }
        }

        public void createHands()
        {
            for( int i = 0; i < bridgeHands.Length; i ++)
            {
                bridgeHands[i] = new Hand((PlayerHand)i); 
            
            }
        }


        public void shuffle()
        {
            Card temp;

            Random r = new Random();

            for(int i = 0; i < cardstack.Length; i++){

                int a = r.Next(cardstack.Length);

                temp = cardstack[i];
                cardstack[i] = cardstack[a];
                cardstack[a] = temp;


            }

            foreach(Card card in cardstack){

                Console.WriteLine(card.faceRank() + card.Suit);
            }
        }


        public void Deal()
        {
            int handIndex = 0;
            int handCount = 0;

            
            for (int i = 0; i < cardstack.Length; i++)
            {
                Console.WriteLine(i + " " + cardstack[i].faceRank());
                bridgeHands[handIndex].HandCards[handCount] = cardstack[i];
                handIndex++;

                if (handIndex == 4)
                {
                    handIndex = 0;
                    handCount++;
                }
            } 

        }



    }
}
