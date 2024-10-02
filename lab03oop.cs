using System;

namespace PositiveElementIndexes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ініціалізація масиву з 20 елементів
            int[] A = new int[20];
            Random rnd = new Random();

            // Заповнення масиву випадковими значеннями (-50 до 50)
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd.Next(-50, 51);
            }

            // Виведення масиву
            Console.WriteLine("Масив A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();

            // Пошук індексів додатних елементів
            Console.WriteLine("\nIндекси додатних елементiв масиву A:");
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    Console.WriteLine($"Iндекс {i}: значення {A[i]}");
                }
            }

            Console.ReadKey();
        }
    }
}