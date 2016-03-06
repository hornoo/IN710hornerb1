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


        [TestMethod]
        public void Count_ofAStackWith1ItemAfterPeek_Returns1()
        {
            Stack testStack = new Stack();

            StringNode testStringNodeOne = new StringNode("this is a testString 1");


            testStack.push(testStringNodeOne);

            int oneCount = 1;

            int CountResult = testStack.Count();

            string stringFromPeek = testStack.Peek();

            Assert.AreEqual(oneCount, CountResult);

        }

        [TestMethod]
        public void Peekstring_ofAStackWith1ItemAfterPeek_ReturnsPeekString()
        {
            Stack testStack = new Stack();

            string testString = "this is a testString 1";

            StringNode testStringNodeOne = new StringNode(testString);

            testStack.push(testStringNodeOne);


            string stringFromPeek = testStack.Peek();

            Assert.AreEqual(stringFromPeek, testString);
        }

        [TestMethod]
        public void Peekstring_ofAStackWith2ItemAfterPeek_ReturnslastPeekString()
        {
            Stack testStack = new Stack();

            string testString = "this is a testString 1";
            string testString2 = "this is the 2nd test String";

            StringNode testStringNodeOne = new StringNode(testString);
            StringNode testStringNodeTwo = new StringNode(testString2);


            testStack.push(testStringNodeOne);
            testStack.push(testStringNodeTwo);

            string stringFromPeek = testStack.Peek();

            Assert.AreEqual(stringFromPeek, testString2);
        }

        [TestMethod]
        public void Peekstring_ofAStackWith3ItemAfterPeek_ReturnslastPeekString()
        {
            Stack testStack = new Stack();

            string testString = "this is a testString 1";
            string testString2 = "this is the 2nd test String";
            string testString3 = "this is the 3rd test String";

            StringNode testStringNodeOne = new StringNode(testString);
            StringNode testStringNodeTwo = new StringNode(testString2);
            StringNode testStringNodethree = new StringNode(testString3);


            testStack.push(testStringNodeOne);
            testStack.push(testStringNodeTwo);
            testStack.push(testStringNodethree);

            string stringFromPeek = testStack.Peek();

            Assert.AreEqual(stringFromPeek, testString3);
        }


        //https://msdn.microsoft.com/en-us/library/microsoft.visualstudio.testtools.unittesting.expectedexceptionattribute.aspx
        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException),"fgisghiuos")]
        public void Peekstring_ofAStackWith0ItemAfterPeek_ThrowsExcption()
        {

            //test passes but doesnt seem to check output error message
            Stack testStack = new Stack();

            testStack.Peek();
           
        }

    }
}
