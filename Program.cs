
using System;

namespace novela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine($"Привет, {name}! \nТы проснулся в палатке посреди леса. Всё было странно тихо. Что ты будешь делать?");
            Console.WriteLine("1: Осмотрюсь снаружи\n2: Останусь в палатке\n3: Пойду вглубь леса");
            byte action_1 = Convert.ToByte(Console.ReadLine());
            if (action_1 == 1)
            {
                Console.WriteLine("Ты вышел из палатки, но увидел странный свет вдалеке...\nВдруг послышался шорох в кустах. Твои действия?\n1: Побегу оттуда\n2: Подойду ближе");
                byte run_attack = Convert.ToByte(Console.ReadLine());
                if (run_attack == 1)
                {
                    Console.WriteLine("Ты побежал, но наткнулся на старую хижину. Что будешь делать?\n1: Постучу в дверь\n2: Зайду без стука");
                    byte open_or_no = Convert.ToByte(Console.ReadLine());
                    if (open_or_no == 1)
                    {
                        Console.WriteLine("Ты постучал, дверь открыл старик и дал тебе карту выхода из леса. Хэпи хэпи хэпи");
                    }
                    else {
                        Console.WriteLine("Ты зашёл, но хижина оказалась ловушкой... Но вдруг появился тот же старик и сказал: 'Ты прошёл испытание леса'. Хэпи хэпи");
                    }
                }
                else
                {
                    Console.WriteLine("Ты подошёл ближе и увидел существо с рогами. Что будешь делать?\n1: Сразиться\n2: Попробовать заговорить");
                    byte atack = Convert.ToByte(Console.ReadLine());
                    if (atack == 1)
                    {
                        Console.WriteLine($"Ты бросился в бой, но существо оказалось иллюзией. Ты упал и потерял сознание...\nТы прожил {age} лет. Press F.");
                    }
                    else
                    {
                        Console.WriteLine("Ты заговорил с существом, оно оказалась духом леса и проводило тебя к выходу. Хоть и потерял рюкзак — но жив. Хэпи?");
                    }
                }
            }
            else if (action_1 == 2)
            {
                Console.WriteLine("Ты остался в палатке.");
                Console.WriteLine("Вдруг услышал волчий вой. Пойдешь проверять?\n1: Пойду\n2: Нет");
                byte toulet = Convert.ToByte(Console.ReadLine());
                if (toulet == 1) {
                    Console.WriteLine("Ты вышел и наткнулся на стаю волков, но один из них оказался приручённым псом и вывел тебя из леса.");
                }
                else {
                    Console.WriteLine("Ты остался в палатке и спрятался. Прошло время. Ты решил выйти.");
                    Console.WriteLine("Куда пойдешь?\n1: К свету на востоке\n2: К реке");
                    byte lets_go = Convert.ToByte(Console.ReadLine());
                    if (lets_go == 1)
                    {
                        Console.WriteLine("Ты пошёл на восток и вышел на дорогу. Там тебя подобрали туристы.");
                    }
                    else { 
                        Console.WriteLine("Ты пошёл к реке, нашёл лодку и уплыл. По пути тебя подобрал рыбак. Хэпи финал!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Ты пошёл вглубь леса и увидел древнюю статую. Что будешь делать?\n1: Дотронусь\n2: Уйду");
                byte run_attack2 = Convert.ToByte(Console.ReadLine());
                if (run_attack2 == 1)
                {
                    Console.WriteLine("Ты дотронулся, и лес ожил. Вокруг всё стало ярким. Это был портал домой. Ты спасён! Хэпи хэпи хэпи");
                }
                else { 
                    Console.WriteLine("Ты ушёл, но заблудился. Очнулся у костра с шаманом. Он рассказал тебе о духах леса и подарил амулет. Хэпи или не хэпи — выбирай сам");
                }
            }
        }
    }
}
