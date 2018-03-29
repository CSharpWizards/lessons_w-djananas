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
            Console.WriteLine("Введите длины сторон треугольника.");
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse (Console.ReadLine());
            int c = int.Parse (Console.ReadLine()); 
            if (a1 * a1 + a2 * a2 == c * c) {
                Console.WriteLine("Ваш треугольник прямоугольный");
            }
             
            
            else {
            Console.WriteLine ("Ваш треугольник не прямоугольный"); 
            } 
                Console.ReadLine();
        }
    }
}
