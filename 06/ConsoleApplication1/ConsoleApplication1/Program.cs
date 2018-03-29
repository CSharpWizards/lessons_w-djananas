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
            Console.WriteLine("Дороу! Сегодня помогу тебе определить кто ты по жизни. Ребенок,взрослый или старик!Все что необходимо ввести свой возвраст! Ну что уселся,пиши возвраст!");
            int age = int.Parse(Console.ReadLine());
            if (age <= 18)
            {
                Console.WriteLine("Ты ребенок! Можешь кушать леденцы на палочке");
            }
            else if (age < 70  )
            {
                Console.WriteLine("Ты взрослый!");
            }
            else if (age > 70)
            {
                Console.WriteLine("Ты старик! Иди в собес,бери пенсию,и сиди у подъезда на лавочке");
            }
            Console.WriteLine("Ну как помог? Если да,то оставь оценку на joycasino.net");
            Console.ReadLine();
            Console.WriteLine("Че ты тут тыкаешь? Помог,иди гуляй!!!!!!!!!!!!!!!!!!!!!");
            Console.ReadLine();
           



        }
    }
}
