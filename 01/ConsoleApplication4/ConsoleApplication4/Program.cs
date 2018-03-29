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
            Console.WriteLine("Введите количество сантиметров");
            int santimetr = int.Parse(Console.ReadLine());
            Console.WriteLine(santimetr / 100 );
            Console.ReadLine();
        }
    }
}
