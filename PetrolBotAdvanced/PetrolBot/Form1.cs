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

        Bitmap offScreenBitMap;
        Graphics offScreenGraphics;
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

            mainCanvas = this.CreateGraphics();
            offScreenBitMap = new Bitmap(this.Width, this.Height);
            offScreenGraphics = Graphics.FromImage(offScreenBitMap);

            Rectangle boundsRectangle = new Rectangle(0, 0, Width - 25, Height -100 );
            backGroundBroush = new SolidBrush(Color.Blue);
            dockBrush = new SolidBrush(Color.LawnGreen);
            numberOfShips = 5;
            
            petBotInitalLocation.X = 30;
            petBotInitalLocation.Y = Height - 75 ;

            for(int i =0; i < numberOfShips; i ++)
            {

              
                //Instiantiateing ships
                shipList.Add(new Ship(offScreenGraphics, SHIP_SIZE, boundsRectangle, rand));

                petBotInitalLocation.X += PETBOT_SPACER;
                //instantiating petrolbots and passing in ship as the subject.
                botList.Add(new PetrolBot(shipList[i], offScreenGraphics, rand, petBotInitalLocation));

                //passing in the bot so the ship can subscrib to  when the bot has arrivedat the ships location event.
                shipList[i].addPetrolbot(botList[i]);

            }


            timer1.Interval = 100;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            offScreenGraphics.FillRectangle(backGroundBroush, 0, 0, Width, Height);
            offScreenGraphics.FillRectangle(dockBrush, 0, Height - 100, Width, 100);

            for (int i = 0; i < shipList.Count; i ++ )
            {
                shipList[i].ShipCycle();
                botList[i].drawBot();

            }

            mainCanvas.DrawImage(offScreenBitMap, 0, 0);
        }

       

    }
}
