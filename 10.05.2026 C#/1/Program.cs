using System;

namespace ConsoleNew
{
    class Programs
    {
        static void Main(string [] args)
        {
            //Запрос чисел у пользователя
            Console.Write("Введите число А: ");
            string aString = Console.ReadLine();
            int a = Convert.ToInt32(aString);
        
            Console.Write("Введите число B: ");
            string bString = Console.ReadLine();
            int b = Convert.ToInt32(bString);

            Console.Write("Введите число C: ");
            string cString = Console.ReadLine();
            int c = Convert.ToInt32(cString);
        
            //Проверка на ввод положительного числа
            if(a < 1 || b < 1 || c < 1)
            {
                Console.WriteLine("Ошибка! Не все числа положительные!");
            }
            else
            {
                //Подсчет, сколько квадратов влезет по длине и ширине
                int squaresWidth = a / c;
                int squaresHeight = b / c;

                //Условие если квадрат не влазит в прямоугольник
                if(squaresHeight == 0 || squaresWidth == 0)
                {
                    Console.WriteLine("Квадрат не влазит в прямоугольник!");
                }
                else
                {
                    //Вывод результата
                    int result = squaresHeight * squaresWidth;
                    Console.WriteLine("В прямоугольнике может поместиться " + result + " квадратов");
                }
            }
        }
    }
}