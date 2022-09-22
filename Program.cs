using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace arv
{
    public class Program
    {
        public static void Main()
        {
            Shape shape = null;
        Console.WriteLine("Width;");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Height;");
        int height = int.Parse(Console.ReadLine());

        //Triangle t = new Triangle (width,height); 

        //Rectangle r = new Rectangle (width, height);  

        Console.WriteLine ("Rectangle or Triangle?");
        string Shape = Console.ReadLine();

        if( Shape == "Rectangle" )
            {
                shape = new Rectangle (width, height);
            }
       
        else if (Shape == "Triangle")
            {
                shape = new Triangle (width, height);
            }
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine ("Area; "+ shape.Area() + "m²");
                Console.WriteLine ("Omkretsen; " + shape.Omkretsen() + "m" );
                Console.WriteLine("-------------------------------------------------------------------");
        }
    }
}