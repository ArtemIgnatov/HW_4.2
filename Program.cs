using System;


namespace HW_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину последовательности: ");
            int lng = int.Parse(Console.ReadLine()); //Определяем длину массива

            int[] a = new int[lng]; //Создаем наш массив 

            Console.WriteLine("Введите числа в данной последовательности: ");

            for (int i = 0; i < lng; i++)
            {
                a[i] = int.Parse(Console.ReadLine()); //Записываем введенное значение в ячейку массива
            }
            foreach (int num in a) //Выводим массив на экран
            {
                Console.Write($"{num} ");
            }

            int min = int.MaxValue; //Задаем значение для сравнения

            for (int i = 0; i < lng; i++)
            {
                min = (a[i] < min) ? a[i] : min; 
                //Сравниваем кадое значение с минимальным, если условие верно, то присваиваем новое значение
                //в противном случае возвращаем предыдущее
            }
            Console.WriteLine();
            Console.WriteLine($"Минимальное значение в последовательности: {min}");
            Console.ReadKey();
        }
    }
}
