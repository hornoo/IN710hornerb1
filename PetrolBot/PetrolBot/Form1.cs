using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolBot
{
    public partial class Form1 : Form
    {
        const int SHIP_SIZE = 50;
        
        
        Graphics mainCanvas;
        List<PetrolBot> botList;
        List<Ship> shipList;
        int numberOfShips;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            botList = new List<PetrolBot>();
            shipList = new List<Ship>();
            mainCanvas = CreateGraphics();
            Rectangle boundsRectangle = new Rectangle(0, 0, Width, Height);
            
            numberOfShips = 5;

            for(int i =0; i < numberOfShips; i ++)
            {
                shipList.Add(new Ship(mainCanvas, SHIP_SIZE, boundsRectangle));
                botList.Add(new PetrolBot(shipList[i], mainCanvas));
            }


            timer1.Interval = 500;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            int count = 0;
            foreach(Ship currentShip in shipList)
            {
                currentShip.ShipCycle();

                Console.WriteLine(count);

                    count ++;
            }


        }


    }
}
