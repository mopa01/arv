using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    class Rectangle: IShape
    {
        int width;
        int height; 
        public  Rectangle(int width, int height)
        {
        }

        public int Area ()
        {
            return ( width * height);
        }

         public  int Circumferance ()
        {
            return ( width * 2 + height * 2);
        }
        
    }
