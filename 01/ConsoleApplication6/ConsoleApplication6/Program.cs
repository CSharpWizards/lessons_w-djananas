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
            int A = 2;
            int B = 9;
            int C = A;
            
            A =B ;
            B = C; 


            Console.WriteLine("А = " + A + ", В =" + B);
            Console.ReadLine();
            
        }
    }
}
