using System;
using System.IO;
using System.Text;

namespace SkillBox_Modul_C_Sharp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Что Вы собираетесь сделать?\n 1. Вывести данные о сотрудниках на экран.\n 2. Добавить нового сотрудика. \n 3. Для закрытия программы.");
            string numberRegime = Console.ReadLine();
            if (Int32.TryParse(numberRegime, out int i))
            {
                if (i == 1 | i == 2 | i == 3) switch (i)
                    {
                        case 1: ReadingFile(); break;
                        case 2: InputFile(); break;
                        case 3: Console.ReadKey(); break;
                    }
                else
                {
                    Console.WriteLine("Нужно ввести цифру 1 или 2");
                    Main();
                }
            }
            else
            { 
                Console.WriteLine("Нужно ввести цифру 1 или 2"); 
                Main(); 
            }
        }

        static void ReadingFile() // метод чтения файла
        {
            if (File.Exists("Справочник сотрудники.csv"))
            {
                using (StreamReader directory = new StreamReader("Справочник сотрудники.csv", Encoding.Unicode))
                {
                    string line;
                    Console.WriteLine($"{"Порядковый номер"}{" Время добавления",20}{"ФИО",20} {"Возраст",25} {"Рост",10}{"Дата рождения",20}{"Место рождения",20}");
                    while ((line = directory.ReadLine()) != null)
                    {
                        string[] column = line.Split('\t');
                        Console.WriteLine($"{column[0]}{column[1],35}{column[2],30}{column[3],15}{column[4],10}{column[5],20}{column[6],20}");
                    }
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Вы еще не создали справочник, нажмите цифру 2 в меню для внесения данных о сотрудниках");
                Main();
            }
        }

        static void InputFile() // метод ввода нового сотрудника
        {
            using (StreamWriter newPerson = new StreamWriter("Справочник сотрудники.csv", true, Encoding.Unicode))
            {
                char key = 'е';
                do
                {
                    string note = string.Empty;
                    Console.WriteLine("\nВведите порядковый номер сотрудника: ");
                    note = $"{Console.ReadLine()}\t";
                    string dataAndTime = DateTime.Now.ToString();
                    Console.WriteLine($"Дата и время добавления записи {dataAndTime}");
                    note += $"{dataAndTime}\t";
                    Console.WriteLine("\nВведите Ф.И.О. сотрудника: ");
                    note += $"{Console.ReadLine()}\t";
                    Console.WriteLine("Введите возраст сотрудника: ");
                    note += $"{Console.ReadLine()}\t";
                    Console.WriteLine("Введите рост сотрудника: ");
                    note += $"{Console.ReadLine()}\t";
                    Console.WriteLine("Введите дату рождения сотрудника: ");
                    note += $"{Console.ReadLine()}\t";
                    Console.WriteLine("Введите место рождения сотрудника: ");
                    note += $"{Console.ReadLine()}\t";
                    newPerson.WriteLine(note);
                    Console.WriteLine("Чтобы внести данные еще одного сотрудника нажмите:\"е\""); 
                    key = Console.ReadKey(true).KeyChar;
                } while (char.ToLower(key) == 'е');
            }
        }
    }
}