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
            //    //задача 3.1. 
            Console.WriteLine("Сейчас мы проверим четное или нечетное Ваше число \nВведите число для проверки");
            int number1 = Convert.ToInt32(Console.ReadLine());
            if (number1 % 2 == 0)
            {
                Console.WriteLine($"Число {number1} - четное");
            }
            else
            {
                Console.WriteLine($"Число {number1} - нечетное");
            }
            while (true)
            {
                Console.WriteLine("Хотите проверить еще число? Нажмите 1 - если да, 2 - нет");
                int sequel = Convert.ToInt32(Console.ReadLine());

                if (sequel == 1)
                {
                    Console.WriteLine("Введите число для проверки");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    if (number2 % 2 == 0)
                    {
                        Console.WriteLine($"Число {number2} - четное");
                    }
                    else
                    {
                        Console.WriteLine($"Число {number2} - нечетное");
                    }
                }
                else
                {
                    Console.WriteLine("Досвидания!");
                    Console.ReadKey();
                    break;
                }
            }

            //    //Задача 3.2
            Console.Clear();
            Console.WriteLine("Приветствую новый пользователь \nСейчас мы будем играть в \"Blackjack\" " +
                "\nВ игре существуют следующие номиналы карт  цифры 1 до 10\n" +
                    $"Для «картинок» следует принять обозначения латинскими буквами:" +
                    $"\nВалет = J или j\nДама = Q или q\nКороль = K или k\nТуз = T или t " +
                    $"\nНоминал картинки равен 10" +
                "\nКакое количество карт у Вас в руках?");
            int numCards = Convert.ToInt32(Console.ReadLine());
            int sumCards = 0;
            for (int i = 1; i <= numCards; i++)
            {
                Console.WriteLine($"Введите номинал {i} карты:");
                string valueCard = Console.ReadLine();
                int valueCard2;
                switch (valueCard)
                {
                    case "J":
                        sumCards += 10;
                        break;
                    case "j":
                        sumCards += 10;
                        break;
                    case "Q":
                        sumCards += 10;
                        break;
                    case "q":
                        sumCards += 10;
                        break;
                    case "K":
                        sumCards += 10;
                        break;
                    case "k":
                        sumCards += 10;
                        break;
                    case "T":
                        sumCards += 10;
                        break;
                    case "t":
                        sumCards += 10;
                        break;
                    default:
                        valueCard2 = Convert.ToInt32(valueCard);
                        sumCards += valueCard2;
                        break;
                }
            }
            Console.WriteLine($"Сумма Ваших карт {sumCards}");
            Console.ReadKey();


            //Задача 3.3
            Console.Clear();
            Console.WriteLine("Здравствуйте! Сейчас мы проверим ваше число на простоту\n" +
                "Простое число — число, которое делится само на себя и на единицу" +
                "\nВведите любое число");
            int number = Convert.ToInt32(Console.ReadLine()); //5
            int j = 1;
            int result;
            bool ez;
            do
            {
                j++;
                result = number % j;
                ez = result != 0;
            }
            while (j < number - 1 && ez == true);
            if (ez == true)
            {
                Console.WriteLine($"Число {number}  простое!");
            }
            else
            {
                Console.WriteLine($"Число {number} не простое!");
            }
            Console.ReadKey();
        }
            
    }
}