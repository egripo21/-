using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work
{
    internal class tablica
    {
        static void Main(string[] args)
        {
            for (int first_digit = 1; first_digit < 10; first_digit++)
            {
                for (int second_digit = 1; second_digit < 10; second_digit++)
                {
                    Console.WriteLine($"{first_digit} * {second_digit} = {first_digit * second_digit}");
                }
            }
        }
        /* 
        
        Как работает и технологии:
        
        Вложенный цикл

        */
    }
}