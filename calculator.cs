using System;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a % b);
            Console.WriteLine(a / b);  
            Console.WriteLine(a * b);
            Console.WriteLine(a++);
            Console.WriteLine(a--);
            Console.WriteLine(b++);
            Console.WriteLine(b--);
            
        }
    }
}
