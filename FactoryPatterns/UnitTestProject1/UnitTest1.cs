using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FactoryPatterns;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Kandaroo_FromanimalFactory_kangarooObject()
        {
            AustralianAnimalFactory testFact = new AustralianAnimalFactory();

            Kangaroo testRoo = new Kangaroo();

            Animal testAnimal = null;

            testAnimal = testFact.createAnimal(3);

            Assert.AreEqual(testAnimal, testRoo);

        }
    }
}
