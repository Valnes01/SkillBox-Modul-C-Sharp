using System;
using System.IO;
using System.Text;

namespace SkillBox_Modul_C_Sharp
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Что вы собираетесь сделать?" +
                "\n 1. Вывести данные о сотрудниках на экран?" +
                "\n 2. Вывести конкретного сотрудника(По порядковому номеру)"+
                "\n 3. Добавить нового сотрудника." +
                "\n 4. Загрузка записей в " +
                "\n 5. Закрыть программу");

            string path = @"Справочник сотрудники.txt";
            //if (!File.Exists(path)) Console.WriteLine("");

            Console.ReadKey();
            Repository rep = new Repository(path);
            rep.Load();
            rep.PrintDbToConsole();
            Console.WriteLine(rep.Number);
            rep.Add(new Worker(rep.Number+1, DateTime.Now, "Федченко", 30, 178, "20.09.1992", "Акмола"));
            rep.AddWorker(path);
            Console.ReadKey();
        }
    }
}