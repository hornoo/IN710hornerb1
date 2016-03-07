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

            testStack.Peek();

            string stringFromPeek = testStack.Peek();

            Assert.AreEqual(stringFromPeek, testString3);
        }


        [TestMethod]
        public void Peekstring_ofAStackWith3ItemAfterPeekPopedToFirst_ReturnslastPeekString()
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

            testStack.Pop();
            testStack.Pop();

            string stringFromPeek = testStack.Peek();

            Assert.AreEqual(stringFromPeek, testString);
        }


        //https://msdn.microsoft.com/en-us/library/microsoft.visualstudio.testtools.unittesting.expectedexceptionattribute.aspx
        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void Peekstring_ofAStackWith0ItemAfterPeek_ThrowsExcption()
        {

            
            Stack testStack = new Stack();

            testStack.Peek();
           
        }

        [TestMethod]
        public void PopString_ofAStackWith3ItemAfterPop_CountReturn2()
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

            string stringFromPeek = testStack.Pop();
            int popCount = testStack.Count();
            int expectPopcount = 2;

            Assert.AreEqual(popCount, expectPopcount);
        }

        [TestMethod]
        public void PopString_ofAStackWith3ItemAfterPop_PopreturnslastString()
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

            string stringFromPop = testStack.Pop();
            

            Assert.AreEqual(stringFromPop, testString3);
        }

        [TestMethod]
        public void PopAllString_ofAStackWith3ItemAfterPop_PopreturnslastStringWhichWasTheFirst()
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

            string stringFromPop = testStack.Pop();
            stringFromPop = testStack.Pop();
            stringFromPop = testStack.Pop();

            Assert.AreEqual(stringFromPop, testString);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void PopAllString_ofAStackWith3ItemAfterPop_returnexception()
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

             testStack.Pop();
             testStack.Pop();
             testStack.Pop();
             testStack.Pop();
 
        }


        [TestMethod]
        public void PopString_ofAStackWith3ItemsPopTo0ThenBackto3_CountReturn3()
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

            testStack.Pop();
            testStack.Pop();
            testStack.Pop();

            testStack.push(testStringNodeOne);
            testStack.push(testStringNodeTwo);
            testStack.push(testStringNodethree);

            int popCount = testStack.Count();
            int expectPopcount = 3;

            Assert.AreEqual(popCount, expectPopcount);
        }

        [TestMethod]
        public void PopString_ofAStackWith3ItemsPopTo0_CountReturn0()
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

            testStack.Pop();
            testStack.Pop();
            testStack.Pop();



            int popCount = testStack.Count();
            int expectPopcount = 0;

            Assert.AreEqual(popCount, expectPopcount);
        }

        [TestMethod]
        public void isEmpty_ofAStackWith3ItemsPopTo0_isEmptyTrue()
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

            testStack.Pop();
            testStack.Pop();
            testStack.Pop();



            bool result = testStack.isEmpty();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void isEmpty_ofAStackWith3ItemsPopTo1_isEmptyfalse()
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

            testStack.Pop();
            testStack.Pop();
            



            bool result = testStack.isEmpty();

            Assert.IsTrue(!result);
        }

        [TestMethod]
        public void isEmpty_ofAnewStack_isEmptyfalse()
        {
            Stack testStack = new Stack();

            bool result = testStack.isEmpty();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ToString_StackTostring1item_string()
        {
            Stack testStack = new Stack();

            string testString = "this is a testString 1";

            StringNode testStringNodeOne = new StringNode(testString);

            testStack.push(testStringNodeOne);



            string toStringString = testStack.ToString();

            string expectedString = "0 this is a testString 1, ";

            Assert.AreEqual(toStringString, expectedString);
           
        }

        [TestMethod]
        public void ToString_StackTostring3item_string()
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



            string toStringString = testStack.ToString();

            string expectedString = "0 this is a testString 1, 1 this is the 2nd test String, 2 this is the 3rd test String, ";

            Assert.AreEqual(expectedString, toStringString);

        }

        [TestMethod]
        public void ToString_StackTostring0item_string()
        {
            Stack testStack = new Stack();

            string toStringString = testStack.ToString();

            string expectedString = "Stack is empty.";

            Assert.AreEqual(expectedString, toStringString);

        }



    }
}
