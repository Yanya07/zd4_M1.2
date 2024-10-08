using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива (K): ");
            int K = int.Parse(Console.ReadLine());
            Console.Write("Введите начальное значение диапазона (A): ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите конечное значение диапазона (B): ");
            int B = int.Parse(Console.ReadLine());
            int[] array = new int[K];// Инициализация массива из K элементов
            Random rand = new Random();// Генератор случайных чисел

            for (int i = 0; i < K; i++)// Заполнение массива случайными числами из диапазона [A, B)
            {
                array[i] = rand.Next(A, B);
            }

            Console.WriteLine("Сгенерированный массив:");// Вывод массива
            for (int i = 0; i < K; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            // Нахождение индексов минимального и максимального элементов
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < K; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }

                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }     
            int startIndex = Math.Min(minIndex, maxIndex);// Определение начала и конца диапазона для вывода
            int endIndex = Math.Max(minIndex, maxIndex);
            Console.WriteLine("Элементы между минимальным и максимальным (включая их):");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите Enter, чтобы закрыть программу.");
            Console.ReadLine();
        }
    }
}
