using System;

namespace Consoles
{
    class Programs
    {
        static void Main(string[] args)
        {
            //Написание числа пользователем
            Console.Write("Введите число от 1 до 100: ");
            
            //Преобразование строки в число
            string numberString = Console.ReadLine();
            int number = Convert.ToInt32(numberString);

            //Проверка диапазона числа
            if(number < 1 || number > 100)
            {
                Console.WriteLine("Число мне диапазона!");
            }
            else
            {
                if(number % 3 == 0 && number % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(number % 5 == 0 && number % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}