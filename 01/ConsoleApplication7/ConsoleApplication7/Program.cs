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
            Console.WriteLine("Введите возвраст Тани (Полных лет)");
            Console.WriteLine("Введите возвраст Мити (Полных лет)");
            int ageOfTanya =  int.Parse (Console.ReadLine());
            int ageOfMitya = int.Parse(Console.ReadLine());
            Console.WriteLine((ageOfTanya + ageOfMitya) / 2 );
            Console.ReadLine();
            
     
        }
    }
}
