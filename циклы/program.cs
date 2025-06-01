using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work
{
    internal class xz
    {
        static void Main(string[] args)
        {
            byte first_digit; byte second_digit;
            while (true)
            {

                Console.WriteLine("Введите первое число: ");
                first_digit = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                second_digit = Convert.ToByte(Console.ReadLine());
                if (first_digit > 0 && first_digit < 11 && second_digit > 0 && second_digit < 11)
                {
                    Console.WriteLine("Итого: " + (first_digit * second_digit));
                    continue;
                }
                else
                {
                    Console.WriteLine("Числа должны быть больше 0 и меньше 10. Попробуйте снова.");
                    continue;
                }   
                        /* 
        
        Как работает и технологии:
        
        Ветвление

        */
            }
        }
    }
}
