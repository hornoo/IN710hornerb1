using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        Deck gameDeck;

        public Form1()
        {
            InitializeComponent();
        }



        private void dealButton_Click(object sender, EventArgs e)
        {
            gameDeck = new Deck();
            gameDeck.shuffle();
            gameDeck.Deal();

            clearFormlists();

            for(int i = 0; i < gameDeck.BridgeHands.Length; i++){
                    gameDeck.BridgeHands[i].sortHand();

                }

            printScoresToList();
            HandWin();
                
            }



        

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HandWin()
        {
            Hand temp = gameDeck.BridgeHands[0];

            foreach(Hand hand in gameDeck.BridgeHands)
            {
                if(hand.highCardPoint() > temp.highCardPoint())
                {
                    temp = hand;
                }
            }

            topScoreTextBox.Text = "Hand " + temp.Player;

        }

        private void clearFormlists()
        {
            scoreListBox.Items.Clear();
            playerScoreList.Items.Clear();
        }

        private void printScoresToList() 
        {

            for(int i = 0; i < gameDeck.BridgeHands.Length; i++)
            {
            scoreListBox.Items.Add("Hand " + gameDeck.BridgeHands[i].Player);

            string diamonds = "D \t";
            string hearts = "H \t";
            string clubs = "C \t";
            string spades = "S \t";

                foreach (Card card in gameDeck.BridgeHands[i].HandCards)
                {
                    switch (card.Suit)
                    {
                        case CardSuit.D: diamonds += card.faceRank();
                            break;
                        case CardSuit.H: hearts += card.faceRank();
                            break;
                        case CardSuit.C: clubs += card.faceRank();
                            break;
                        case CardSuit.S: spades += card.faceRank();
                            break;
                        default:
                            break;
                    }
                }

                scoreListBox.Items.Add(diamonds);
                scoreListBox.Items.Add(hearts);
                scoreListBox.Items.Add(clubs);
                scoreListBox.Items.Add(spades);

                scoreListBox.Items.Add("HCP: " + gameDeck.BridgeHands[i].highCardPoint());
                playerScoreList.Items.Add("Hand " + gameDeck.BridgeHands[i].Player + " " + gameDeck.BridgeHands[i].highCardPoint());
   
             }

            
        }
    }
}
