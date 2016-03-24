﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherStation;
using System.Windows.Forms;

namespace sensorTestUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CuttentTempObserver_DisplayOutput_tempINputShouldEqualOutput()
        {
            SensorSubject testSubject = new SensorSubject();

            ListBox testListbox = new ListBox();

            CurrentReadingsObserver CReadOb = new CurrentReadingsObserver(testListbox, testSubject);


            testSubject.InputTrigger("10"," 20", "30");

            String output = testListbox.Items[2].ToString();

            String expectedOutput = "10";

            Assert.AreEqual(expectedOutput, output);


        }
    }
}
