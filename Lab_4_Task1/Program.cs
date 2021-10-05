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
            int n = Convert.ToInt32(Console.ReadLine());
            int b=0

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Квадрат {0} равен {1}", i, i+=1 + (i*2-1));
            }

            Console.ReadKey();
        }
    }
}
