using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


class Triangle : Shape
{
        public Triangle(int width, int height) : base( width, height)
        {
        }

        public override int Area()
        {
            return ( width * height / 2 );
        }

        public override int Omkretsen()
        {
            return ( height * 3 );
        }
}

