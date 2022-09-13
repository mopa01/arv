using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


class Triangle : Shape
{
        public Triangle(int width, int height) : base( width, height)
        {
        }

        public int Area()
        {
            return ( width * height / 2 );
        }
}

