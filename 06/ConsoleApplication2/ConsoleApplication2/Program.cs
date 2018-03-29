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
            Console.WriteLine("ПРЫВЕТ МЕДВЕД (Ака 2007)Сегодня я такому неудачнегу как ты Я??? ТЫЫЫ!ОККККККККК,КАРОЧИ ТЫ ЗАШЕЛ ЧТОБЫ УЗНАТЬ КАК ОБЫГРАТЬ ДРУГА В ШАХМАТЫ , А ТЫ НЕУДАЧНЕГ ЯЯЯЯ??? ДААААА ТЫЫЫ!!! НЕ УМЕЕШЬ ИГРАТЬ В ШАХМАТЫ И ЗАШЕЛ КО МНЕ СПРОСИТЬ,СМОЖЕТ ЛИ ТВОЙ КОНЬ ПЕРЕЙТИ С ОДНОЙ КЛЕТКИ НА ДРУГУЮ ОДНИМ ХОДОМ! (ДААА ИМЕННО ДЛЯ ЭТОГО..) МОЛЧАТЬ! ПИШИ СТОЛБЫ И СТРОЧКИ,А Я ТАК УЖ И БЫТЬ ТЕБЕ ПОМОГУ,НЕЕЕУДАЧНЕГ (ЯЯЯ) ПОШЕЛ НАХ**");
            int strok1 = int.Parse(Console.ReadLine());
            int stolb1 = int.Parse(Console.ReadLine());
            int strok2 = int.Parse(Console.ReadLine());
            int stolb2 = int.Parse(Console.ReadLine());

            if (strok1 - 2 == strok2 && stolb1 + 1 == stolb2)
            {


                Console.WriteLine("ОК");
            }
            else
            {
                Console.WriteLine("НОУ");
            }

            Console.ReadLine();

            {
            
            }
         
            

        }
    }
}
