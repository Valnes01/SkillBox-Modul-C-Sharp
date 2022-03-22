using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SkillBox_Modul_C_Sharp
{
    class Program
    {
        
        static void Main()
        {
            //Задача 4.1
            Console.WriteLine("Введите количество строк в матрице:");
            int lines = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в матрице:");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[lines, columns];
            Random num = new Random();
            int sum = 0;
            for (int i = 0; i < lines; i++)
            {

                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = num.Next(10);
                    Console.Write($"{matrix[i, j]}\t");
                    sum += matrix[i, j];
                }
                Console.WriteLine();

            }
            Console.WriteLine($"Сумма элементов = {sum}");
            Console.ReadKey();

            //Задача 4.2
            Console.Clear();

            Console.WriteLine("Введите размер последовательности");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int p = 0;
            int[] mass = new int[lenght];

            for (int k = 0; k < lenght; ++k)
            {
                Console.WriteLine($"Введите {++p} значение");

                int num1 = Convert.ToInt32(Console.ReadLine());
                mass[k] = num1;

            }
            int min = int.MaxValue;
            for (int i = 0; i < lenght; i++)
            {

                if (min > mass[i])
                {
                    min = mass[i];
                }
            }

            Console.WriteLine($"Ваш массив выглядит следующим образом:");
            foreach (int o in mass)
            {
                Console.Write($"{o}\t");
            }
            Console.WriteLine($"\nНаименьшее число {min}");

            Console.ReadKey();
        }
            
    }
}