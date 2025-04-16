using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int[] tags = new int[n + 1];

            tags[1] = 1;
            if (n >= 2)
                tags[2] = 1;

            for (int i = 3; i <= n; i++)
            {
                tags[i] = tags[i - 1] + tags[i - 2];
            }

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += tags[i];
            }

            Console.WriteLine(sum);


        }
    }
}
