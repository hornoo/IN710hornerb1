using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestVS2015;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestVS2015.Tests
{
    [TestClass()]
    public class CardTests
    {
        [TestMethod()]
        public void CardTest()
        {
            Card card1 = new Card((SuitValue)0, (RankValue)8);
            Assert.AreEqual("T", card1.ShortRank);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Card card1 = new Card((SuitValue)0, (RankValue)8);
            
            Assert.AreEqual("Ten of Spades", card1.ToString());

        }

        [TestMethod()]
        public void CompareToTest()
        {
            
            Card card1 = new Card((SuitValue)(0),(RankValue)1);
            Card card2 = new Card((SuitValue)(1),(RankValue)1);
            Card card3 = new Card((SuitValue)(2),(RankValue)1);
            Card card4 = new Card((SuitValue)(3),(RankValue)2);
            Card card5 = new Card((SuitValue)(0),(RankValue)3);


            List<Card> sortedCardList = new List<Card>() { card5, card4, card1, card2, card3 };
            List<Card> cardList = new List<Card>() { card2, card4, card1, card3, card5 };

            cardList.Sort();
            

            for (int i = 0; i < sortedCardList.Count; i ++)
            {
                //Console.WriteLine("sorted " + sortedCardList[i].ToString() + " | unsorted" + cardList[i].ToString());
                Assert.AreEqual(sortedCardList[i].ToString(), cardList[i].ToString());
            }
  
        }
    }
}
