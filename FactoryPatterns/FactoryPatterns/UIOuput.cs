using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms

namespace FactoryPatterns
{
   public class UIOuput
    {
       const int INIIAL_IMAGE_XPOS = 20;
       const int INITIAL_IMAGE_YPOS = 20;
       Graphics canvas;
       ListBox outPutListbox;

       public UIOuput(Graphics canvas, ListBox outPutListbox )
       {
           this.canvas = canvas;
           this.outPutListbox = outPutListbox;
       }


       public void drawAndlistAnimal(List<Animal> inputAnimalList)
       {
           int xpos = INIIAL_IMAGE_XPOS;
           int ypos = INITIAL_IMAGE_YPOS;

           foreach(Animal currentAnimal in inputAnimalList)
           {
               canvas.DrawImage(currentAnimal.Image,xpos,ypos);
               outPutListbox.Items.Add(currentAnimal.ToString());
               ypos += currentAnimal.Image.Height;

           }

       }




    }
}
