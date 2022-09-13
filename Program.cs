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
        

        Console.WriteLine ( "Arean För Rectangle; " + width * height + "m²");

        Console.WriteLine("Arean För Triangle; " + width * height / 2 + "m²");

        Console.WriteLine("Omkretsen för Triangel; " + width * 3 + "cm");

        }
    }
}