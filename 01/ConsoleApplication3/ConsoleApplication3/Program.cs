using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            int r = int.Parse(Console.ReadLine()); 
       
            Console.WriteLine (r*r*3);
            Console.ReadLine();
        }
    }
}
