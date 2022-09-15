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
        Console.WriteLine("Width;");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Height;");
        int height = int.Parse(Console.ReadLine());

        Triangle t = new Triangle (width,height); 

        Rectangle r = new Rectangle (width, height);  

        Console.WriteLine ("Rectangle or Triangle?");
        String Shape = Console.ReadLine();

        if( Shape == "Rectangle" )
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine ("Area; "+ r.Area() + "m²");
                Console.WriteLine ("Omkretsen; " + r.Omkretsen() + "m" );
                Console.WriteLine("-------------------------------------------------------------------");
            }
       
        if (Shape == "Triangle")
            {
                Console.WriteLine("-------------------------------------------------------------------");
                Console.WriteLine("Arean; " + t.Area() + "m²");
                Console.WriteLine ("Omkretsen; " + t.Omkretsen() + "m");
                Console.WriteLine("-------------------------------------------------------------------");
            }
        
        }
    }
}