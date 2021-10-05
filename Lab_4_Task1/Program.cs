using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число");
            int N = Convert.ToInt32(Console.ReadLine());
            int b = 1;

            for (int i = 0; i <= N; i++)
            {
                b = b + (2 * i - 1);
                Console.WriteLine("Квадрат {0} равен {1}", i, b); 
            }

            Console.ReadKey();
        }
    }
}
