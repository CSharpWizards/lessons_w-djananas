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
            Console.WriteLine("Привет! Наверняка ты зашел в мою супер-программу (ОТСТОЙ ПРОГРАММУ,КОТОРАЯ УМЕЕТ ТОЛЬКО ЭТО!) чтобы узнать: Подросток ты или нет ? Очень странно,ну ладно,вот тебе моё поручение. Введи свой возвраст (полных лет)");
            int age = int.Parse(Console.ReadLine());
            if (age >= 10)
            {

                if (age < 20)
                {
                    Console.WriteLine("Поздравляю,вы подросток,можете радоваться,или плакать..)");
                }
                else
                {
                    Console.WriteLine("Ты в самом расвете своих сил,поэтому кончай играть в доту и иди на работу в офис.. или на завод!");
                }

            }
            else 
            {
                

                Console.WriteLine("Ты малыш.....");
            }
            Console.ReadLine();





            
            
        }
    }
}
