using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FactoryPatterns
{
    //This class handles ui output to the form, Text and Images
   public class UIOuput
    {
       //Initial staring point for drawing images
       const int INIIAL_IMAGE_XPOS = 20;
       const int INITIAL_IMAGE_YPOS = 20;

       //Reference of Listbox and canvas to draw to.
       Graphics canvas;
       ListBox outPutListbox;

       //Constructor with canvas and lost box to draw to passed in.
       public UIOuput(Graphics canvas, ListBox outPutListbox )
       {
           this.canvas = canvas;
           this.outPutListbox = outPutListbox;
       }

       //Draw and out put to listbox from List of passed in animals
       public void drawAndlistAnimal(List<Animal> inputAnimalList)
       {
           //Get inital drawing positions
           int xpos = INIIAL_IMAGE_XPOS;
           int ypos = INITIAL_IMAGE_YPOS;

           //iterate through each anima in the list, print tostring to list box and picture to canvas.
           foreach(Animal currentAnimal in inputAnimalList)
           {
               //draw image
               canvas.DrawImage(currentAnimal.Image,xpos,ypos,currentAnimal.Image.Width,currentAnimal.Image.Height);
               //pint to list box
               outPutListbox.Items.Add(currentAnimal.ToString());
               //add current puctures height to the ypos ready to draw the next picture.
               ypos += currentAnimal.Image.Height;
               Console.WriteLine(ypos);

           }

       }

       public void clearListbox(ListBox boxToClear)
       {
           boxToClear.Items.Clear();
       }

       public void clearCanvasImages(Graphics canvasToClear)
       {
           canvas.Clear(Color.FromName("Control"));
       }




    }
}
