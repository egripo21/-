using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work
{
    internal class CalculatorV2
    {
        static void Main(string[] args)
        {

            byte time; decimal money; decimal total_money; byte total;
            Console.WriteLine("Введите время вашего вклада (В месяцах): ");
            time = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("теперь сумму: ");
            money = Convert.ToDecimal(Console.ReadLine());
            total = 0;
            total_money = money;
            while (total < time)
            {
                total_money += total_money / 100 * 7;
                total += 1;
            }


            Console.WriteLine($"За {time} месяцев вы заработаете:");
            Console.WriteLine($"Всего: {Convert.ToInt16(total_money)}");
            
        /* 
        
        Как работает и технологии:
        
        Цикл While с условием пока не пройдет весь срок 

        */
        }
    }
}
