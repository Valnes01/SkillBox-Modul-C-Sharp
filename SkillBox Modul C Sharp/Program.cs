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
            Console.WriteLine("Введите предложние:");
            string text = Console.ReadLine();
            Console.WriteLine("Задача №1");
            string[] separation = GetSeparationText(text);
            GetEnumerationText(separation);
            Console.ReadKey();
            Console.WriteLine("Задача №2");
            GetInvertText(separation, text);
            Console.ReadKey();
        }
        static string[] GetSeparationText(string text) //метод для разделения строки на массив слов
        {
            string[] separation = text.Split(' ');
            return separation;
        }
        static void GetEnumerationText(string [] separationA) //метод выведения на консоль массива слов
        {
            for(int i =0; i < separationA.Length; i++)
            {
                Console.WriteLine(separationA[i]);
            }
        }
        static void GetInvertText(string [] separationA, string text) //метод инверсии
        {
            GetSeparationText(text);
            for (int i = 0, j = separationA.Length-1; i < j; i++, j--)
            {
                string A = separationA[i];
                separationA[i] = separationA[j];
                separationA[j] = A;
            }
            for (int j = 0; j <=separationA.Length - 1; j++) 
            {
                Console.Write(separationA[j] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Объединение в строку массива слов:");
            var newString = string.Join(" ", separationA);
            Console.WriteLine(newString);  
        }
    }
}