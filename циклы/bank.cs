using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work
{
    internal class Calculator
    {
        static void Main(string[] args)
        {

            byte time; decimal money; decimal total_money;
            Console.WriteLine("Добро пожаловать в калькулятор вклада под 7%");
            time = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("теперь сумму: ");
            money = Convert.ToDecimal(Console.ReadLine());
            total_money = money;
            for (int i = 0; i < time; i++)
            {
                total_money += total_money / 100 * 7;
            }
            Console.WriteLine($"За {time} месяцев вы заработаете:");
            Console.WriteLine($"Всего: {Convert.ToInt16(total_money)}");
        }
        
        /* 
        
        технологии:
        
        цикл счетчик, вод с консоли
        
        */
    }
}
