using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CannonGame
{
    public partial class Form1 : Form
    {
        Brush backgroundBrush;
        Random rGen;
        Graphics mainCanvas;

        public Form1()
        {
            InitializeComponent();
            mainCanvas = CreateGraphics();
            Rectangle boundsRectangle = new Rectangle(0, 0, Width, Height);
            backgroundBrush = new SolidBrush(Color.DodgerBlue);
        }
    }
}
