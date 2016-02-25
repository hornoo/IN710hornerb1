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
            //Assert.AreEqual("Two of Spades", card1.ToString());
            Assert.AreEqual("T", card1.Rank);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CompareToTest()
        {
            Assert.Fail();
        }
    }
}
