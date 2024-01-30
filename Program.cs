using System;
using System.Diagnostics.CodeAnalysis;

namespace lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАНИЕ 1

            for (int number = 1; number <= 99; number++)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine($"Нечетное число:{number}");
                }
            }

          //  ЗАДАНИЕ 2

            //for (int number = 5; number >= 1; number--)
            //{
            //    {
            //        Console.WriteLine($"Число:{number}");
            //    }
            //}

            //ЗАДАНИЕ 3

            //uint number;
            //uint sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Введите целое положительное число:");
            //    if (!uint.TryParse(Console.ReadLine(), out number))
            //    {
            //        Console.WriteLine("Ошибка ввода, введите целое положительное число!");
            //        continue;
            //    }        
            //    for (uint i = 1; i <= number; i++)
            //         sum += i;
            //    {
            //        Console.WriteLine($"Сумма: {sum}");
            //        break;
            //    }
            //}

            //ЗАДАНИЕ 4

            //int num = 0;
            //while (num < 98)
            //{
            //    Console.WriteLine($"{num+=7}");
            //}

            //ЗАДАНИЕ 5 

            //int arraySize = 5;
            //int minValue = 1;
            //int maxValue = 10;
            //double[] nums1 = new double[arraySize];
            //double[] nums2 = new double[arraySize];

            //Random nums = new Random(); 

            //for (int i = 0; i < arraySize; i++) 
            //{
            //    nums1[i] = nums.Next(minValue, maxValue + 1);
            //    nums2[i] = nums.Next(minValue, maxValue + 1);
            //}
            //Console.WriteLine(string.Join(" ", nums1));
            //Console.WriteLine(string.Join(" ", nums2));
            //double sr1 = nums1.Sum() / 5;
            //double sr2 = nums2.Sum() / 5;
            //Console.WriteLine("Среднее арифметическое значение элементов первого массива: " + sr1);
            //Console.WriteLine("Среднее арифметическое значение элементов второго массива: " + sr2);
            //if (sr1 > sr2)
            //{
            //    Console.WriteLine("Среднее арифметическое значение элементов первого массива больше, чем у второго");
            //}
            //else if
            //    (sr1 < sr2)
            //{
            //    Console.WriteLine("Среднее арифметическое значение элементов первого массива меньше, чем у второго");
            //}
            //else
            //{
            //    Console.WriteLine("Среднее арифметическое значение элементов двух массивов равны");
            //}
        }
    }
}
