using System;

namespace FindNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arr = new int [10];
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(10);                 
                Console.WriteLine("Число массива: " + arr[i]);
            }

            int sort;

            Console.WriteLine("Отсортированный массив: ");

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        sort = arr[i];
                        arr[i] = arr[j];
                        arr[j] = sort;
                    }
                }

                 Console.WriteLine("Число массива: " + arr[i]);

            }

            Console.Write("Введите число, которое нужно найти ");

            int findNum = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i ++)
            {
                if (findNum == arr[i])
                {
                    Console.WriteLine("Заданное число найдено ");
                }
                else
                {
                   Console.WriteLine("Заданное число не найдено ");
                }
                
            }
            Console.ReadLine(); 
        }
    }
}
