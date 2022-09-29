using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


class Triangle : IShape
{
    int width;
    int height; 
        public Triangle(int width, int height)
        {
        }

        public int Area()
        {
            return ( width * height / 2 );
        }

        public int Circumferance()
        {
            return ( height * 3 );
        }
}

