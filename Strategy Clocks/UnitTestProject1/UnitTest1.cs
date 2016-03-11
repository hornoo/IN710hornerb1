using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strategy_Clocks;
using System.Windows.Forms;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DigitalClock_StringOutPut_stringOfTimeCorrectFormatt()
        {
            Label testLable = new Label();
            Timer testTimer = new Timer();
            DigitalClock textclock = new DigitalClock(testLable, testTimer);
        }
    }
}
