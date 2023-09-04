using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor
{
    internal class Rectangle
    {
        private int width;
        private int height;
        private Color color;
        private bool isTransparent;
        public Rectangle(int width, int height)
        {
            Console.WriteLine()
            this.width = width;
            this.height = height;
        }
        //Konstruktoren kette
        public Rectangle(int width, int height, Color color) : this(width, height)
        {
            this.width = width;
        }
        public Rectangle(int width,int height, Color Color)
        {
            Console.WriteLine("Ich bin ein Rechteck und wurde instanziert");
            this.width = width;
            this.height = height;
            this.color = color;

        }
        public Rectangle(int width, int height, bool isTransparent)
        {
            Console.WriteLine("Ich bin ein Rechteck und wurde instanziert");
            this.width = width;
            this.height = height;
            this.isTransparent = false;

        }
         
        public void WriteWidthAndHeightToConsole()
        {
     
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Hight: {0}", height);
        }
    }
}
