using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IN710_4._1_Animal_Shelter_Solution_2014;



namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Critter test = new Critter("Bob", (ESpecies)1);


        }
    }
}
