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
        const int PETBOT_SPACER = 30;
        
        Random rand;
        
        Graphics mainCanvas;
        List<PetrolBot> botList;
        List<Ship> shipList;
        int numberOfShips;
        Brush backGroundBroush;
        Brush dockBrush;

        Point petBotInitalLocation;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();
            botList = new List<PetrolBot>();
            shipList = new List<Ship>();
            mainCanvas = CreateGraphics();
            Rectangle boundsRectangle = new Rectangle(0, 0, Width - 25, Height -100 );
            backGroundBroush = new SolidBrush(Color.Blue);
            dockBrush = new SolidBrush(Color.LawnGreen);
            numberOfShips = 5;
            
            petBotInitalLocation.X = 30;
            petBotInitalLocation.Y = Height - 75 ;

            for(int i =0; i < numberOfShips; i ++)
            {

              

                shipList.Add(new Ship(mainCanvas, SHIP_SIZE, boundsRectangle, rand));

                petBotInitalLocation.X += PETBOT_SPACER;

                botList.Add(new PetrolBot(shipList[i], mainCanvas, rand, petBotInitalLocation));
            }


            timer1.Interval = 100;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mainCanvas.FillRectangle(backGroundBroush, 0, 0, Width, Height);
            mainCanvas.FillRectangle(dockBrush, 0, Height - 100, Width, 100);
            int count = 0;

            for (int i = 0; i < shipList.Count; i ++ )
            {
                shipList[i].ShipCycle();
                botList[i].drawBot();

                Console.WriteLine(count);

                count++;
            }


        }


    }
}
