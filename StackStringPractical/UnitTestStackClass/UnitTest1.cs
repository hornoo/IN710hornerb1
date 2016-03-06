using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackStringPractical;



namespace UnitTestStackClass
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void  Count_ofAnEmptyStack_Returns0()
        {
            Stack testStack;
            
            testStack = new Stack();

            int zeroCount = 0;

            int result = testStack.Count();

            Assert.AreEqual(zeroCount, result); 

        }

        [TestMethod]
        public void Count_ofAStackWith1Item_Returns1()
        {
            Stack testStack = new Stack();

            StringNode testStringOne = new StringNode("this is a testString");

            testStack.push(testStringOne);

            int oneCount = 1;

            int result = testStack.Count();

            Assert.AreEqual(oneCount, result);

        }

        [TestMethod]
        public void Count_ofAStackWith4Item_Returns4()
        {
            Stack testStack = new Stack();

            StringNode testStringOne = new StringNode("this is a testString 1");
            StringNode testStringTwo = new StringNode("this is a testString 2");
            StringNode testStringThree = new StringNode("this is a testString 3");
            StringNode testStringFour = new StringNode("this is a testString 4");

            testStack.push(testStringOne);
            testStack.push(testStringTwo);
            testStack.push(testStringThree);
            testStack.push(testStringFour);

            int oneCount = 4;

            int result = testStack.Count();

            Assert.AreEqual(oneCount, result);

        }
    }
}
