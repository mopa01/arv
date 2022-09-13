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


        Console.WriteLine ( "Arean För Rectangle; " + r.Area() + "m²");

        Console.WriteLine("Arean För Triangle; " + t.Area() + "m²");

        Console.WriteLine ("Omkretsen för Rectangle; " + r.Omkrets() + "m" );

        Console.WriteLine ("Omkretsen för Triangle; " + t.Omkrets() + "m");


        }
    }
}