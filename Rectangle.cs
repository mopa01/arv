using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    class Rectangle:Shape
    {
        public Rectangle(int width, int height) : base( width, height)
        {
        }

        public int Area ()
        {
            return ( width * height);
        }

         public int Omkrets ()
        {
            return ( width * 2 + height * 2);
        }
    }
