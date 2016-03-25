using System;
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

            String output = testListbox.Items[0].ToString();

            String expectedOutput = "Temperature:\t10.00";

            Assert.AreEqual(expectedOutput, output);


        }

        [TestMethod]
        public void CuttentTempObserver_DisplayOutput_HumidINputShouldEqualOutput()
        {
            SensorSubject testSubject = new SensorSubject();

            ListBox testListbox = new ListBox();

            CurrentReadingsObserver CReadOb = new CurrentReadingsObserver(testListbox, testSubject);


            testSubject.InputTrigger("10", " 20", "30");

            String output = testListbox.Items[1].ToString();

            String expectedOutput = "Humidity:\t20.00";

            Assert.AreEqual(expectedOutput, output);


        }

        [TestMethod]
        public void CuttentTempObserver_DisplayOutput_PressureINputShouldEqualOutput()
        {
            SensorSubject testSubject = new SensorSubject();

            ListBox testListbox = new ListBox();

            CurrentReadingsObserver CReadOb = new CurrentReadingsObserver(testListbox, testSubject);


            testSubject.InputTrigger("10", " 20", "30");

            String output = testListbox.Items[2].ToString();

            String expectedOutput = "Pressure:\t30.00";

            Assert.AreEqual(expectedOutput, output);


        }

    [TestMethod]
        public void AverageConditionObserver_DisplayOutput_PresAverageOutputShouldBeAverageOFInputs()
        {
        SensorSubject testSubject = new SensorSubject();
        ListBox testListbox = new ListBox();

        AverageReadingObserver testAverageObserver = new AverageReadingObserver(testListbox, testSubject);

        testSubject.InputTrigger("10", " 20", "30");
        testListbox.Items.Clear();
        testSubject.InputTrigger("10", " 20", "30");
        testListbox.Items.Clear();
        testSubject.InputTrigger("30", " 20", "10");
        


       

        String output = testListbox.Items[2].ToString();

        String expectedOutput = "Pressure:\t23.33";

        Assert.AreEqual(expectedOutput, output);


        }

    [TestMethod]
    public void AverageConditionObserver_DisplayOutput_TempAverageOutputShouldBeAverageOFInputs()
    {
        SensorSubject testSubject = new SensorSubject();
        ListBox testListbox = new ListBox();

        AverageReadingObserver testAverageObserver  = new AverageReadingObserver(testListbox, testSubject);

        testSubject.InputTrigger("10", " 20", "30");
        testListbox.Items.Clear();
        testSubject.InputTrigger("10", " 20", "30");
        testListbox.Items.Clear();
        testSubject.InputTrigger("30", " 20", "10");


        // testSubject.InputTrigger("16.66", " 20", "23.33");

        String output = testListbox.Items[0].ToString();

        String expectedOutput = "Temperature:\t16.66";

        Assert.AreEqual(expectedOutput, output);


    }
    [TestMethod]
    public void AverageConditionObserver_DisplayOutput_HumidAverageOutputShouldBeAverageOFInputs()
    {
        SensorSubject testSubject = new SensorSubject();
        ListBox testListbox = new ListBox();

        AverageReadingObserver testAverageObserver = new AverageReadingObserver(testListbox, testSubject);

        testSubject.InputTrigger("10", "1", "30");
        testListbox.Items.Clear();
        testSubject.InputTrigger("10", "1", "30");
       


        

        String output = testListbox.Items[1].ToString();

        String expectedOutput = "Humidity:\t20.00";

        Assert.AreEqual(expectedOutput, output);


    }
    }
}
