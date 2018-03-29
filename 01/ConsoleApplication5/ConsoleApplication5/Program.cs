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
            Console.WriteLine("Привет! Я бот,который сможет вычислить твой процент победы!");
            Console.WriteLine("Напиши количество сыгранных побед и сколько ты из них выиграл");
            double win = double.Parse (Console.ReadLine());
            double all = double.Parse(Console.ReadLine());
            Console.WriteLine(all / win );
            Console.ReadLine();
            
        }
    }
}
