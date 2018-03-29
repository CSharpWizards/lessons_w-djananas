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
            Console.WriteLine("Введите стиомость игры,которую желаете приобрести.");
            int bal = int.Parse(Console.ReadLine());
            Console.WriteLine ("Введите свой баланс");
            int c  = int.Parse(Console.ReadLine());
            if (c >= bal)
            {
                Console.WriteLine("Вам хватает денег на покупку игры,удачной игры!");
            }
            else
            {
                Console.WriteLine("Извините,вам не хваатет денег. Чтобы пополнить баланс,нажмите по ссылке (типа ссылка топ вахвах сcылка какой у меня). После пополнения вы сможете приобрести игру");
            
            }

            Console.ReadLine();
        }
    }
}
