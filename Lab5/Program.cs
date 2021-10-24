using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            int Sum = 0;
            int Sum2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                Sum += arr[i];
                Sum2 = Sum / 7;
            }
            Console.Write("Среднее арифметическое {0} ", Sum2);
            Console.ReadKey();
        }
    }
}
