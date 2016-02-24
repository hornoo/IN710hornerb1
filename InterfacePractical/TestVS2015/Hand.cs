using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestVS2015
{
    public class Hand
    {
        public List<Card> CardsInHand { get; set; }
        public int TotalHCP
        {
            get; set;
        }

        public Hand()
        {
            CardsInHand = new List<Card>();
        }

        public void AddCard(Card card)
        {
            CardsInHand.Add(card);
        }


        //why does this return 0? maybe to confirm it has run?
        public int ComputeHCP()
        {
            TotalHCP = 0;
            foreach (Card c in CardsInHand)
                TotalHCP += c.HCP;
            
            //CardsInHand.Sort();
            
            return 0;
        }
    }
}