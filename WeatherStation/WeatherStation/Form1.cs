﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public partial class Form1 : Form
    {
        //Set references for sensor and observers
        SensorSubject weatherSensors;

        AverageReadingObserver AverageWeatherObserver;
        CurrentReadingsObserver CurrentWeatherObserver;
        ForcastObserver ForcasterObserver;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instantiate sensor
            weatherSensors = new SensorSubject();

            //Instantiate observers, pass in subject and listbox.
            AverageWeatherObserver = new AverageReadingObserver(lbaverage, weatherSensors);
            CurrentWeatherObserver = new CurrentReadingsObserver(lbcurrent, weatherSensors);
            ForcasterObserver = new ForcastObserver(lbforecast,weatherSensors);
        }

        private void btUpdateM_Click(object sender, EventArgs e)
        {
            //call input trigger on subject, pass in values.
            weatherSensors.InputTrigger(textBox1.Text.ToString().Trim(), tbHumid.Text.ToString().Trim(), tbbPres.Text.ToString().Trim());
        }


    }
}
