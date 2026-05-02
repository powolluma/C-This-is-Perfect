using System;
using System.Xml.Serialization;

namespace ConsolePrograms
{
    class Programs
    {
        static void Main(string[] args)
        {
            //Получение числа
            Console.Write("Введите первое число: ");
            //Преобразование строки в число
            string firstString = Console.ReadLine();
            double firstNumber = Convert.ToInt32(firstString);
        
            Console.Write("Введите второе число: ");
            string secondString = Console.ReadLine();
            double secondNumber = Convert.ToInt32(secondString);

            //Результат 
            double result = (firstNumber * secondNumber) / 100;


            //Вывод результата
            Console.WriteLine("Число: " + firstNumber);
            Console.WriteLine(secondNumber + "% от числа = " + result);
        }
    }
}