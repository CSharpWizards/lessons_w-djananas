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
            Console.WriteLine("Привет! Я помогу определить,сможет ли твоя ладья попасть с первой на вторую одним ходом,тебе нужно ввести :Введи мне 4 числа от 1 до 8 (ПОЛНЫМИ ЧИСЛАМИ) u номер строки ");
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());
            int row2 = int.Parse(Console.ReadLine());
            int column2 = int.Parse(Console.ReadLine());
            if (row == row2 || column == column2)
            {
                Console.WriteLine("Все ок,ходи");
            }
            else
            {
                Console.WriteLine("Жизнь боль! Сиди на месте");
            }
            Console.ReadLine();


        }
    }
}
