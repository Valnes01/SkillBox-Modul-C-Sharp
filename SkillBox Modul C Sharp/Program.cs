using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


    public class Program
    {
        public static void Main(string[] args)
        {
            //задача 1. (Вариант 1)
            string FullName = "Федченко Иван Василеьвич";
            byte age = 29;
            string EMail = "paladin7701@gmail.com";
            float InfoPoints = 4.4F;
            float MathsPoints = 5.0F;
            float PhysicsPoints = 4.6F;

            Console.WriteLine("Ф.И.О.: {0} \nВозраст: {1} \nEmail: {2} " +
                "\nБаллы по программированию: {3} \nБаллы по математике: {4}" +
                " \nБаллы по физике: {5}", FullName, age, EMail, InfoPoints, MathsPoints, PhysicsPoints);
            Console.ReadKey();

            //задача 1. (Вариант 2)
            Console.Write("Введите ФИО: ");
            string FullName2 = Console.ReadLine();
            Console.Write("Введите возраст: ");
            byte age2 = Convert.ToByte(Console.ReadLine());
            Console.Write("Введите EMail: ");
            string EMail2 = Console.ReadLine();
            Console.Write("Введите кол-во баллов по информатике: ");
            float InfoPoints2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите кол-во баллов по математике: ");
            float MathsPoints2 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите кол-во баллов по физике: ");
            float PhysicsPoints2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Анкета участинка опроса \nФ.И.О.: {0} \nВозраст: {1} " +
            "\nEmail: {2} \nБаллы по программированию: {3} " +
            "\nБаллы по математике: {4} \nБаллы по физике: {5}", FullName2, age2, EMail2, InfoPoints2, MathsPoints2, PhysicsPoints2);
            Console.ReadKey();

            //Задача №2.
            float Score = InfoPoints2 + MathsPoints2 + PhysicsPoints2;
            float AverageScore = Score / 3;
            Console.WriteLine(AverageScore);
            Console.ReadKey();
    }
}