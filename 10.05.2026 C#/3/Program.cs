using System;

namespace ConsoleNew
{
    class Programs
    {
        static void Main(string[] args)
        {
            //Заданные числа
            int a = 3;
            int b = 7;

            //Цикл: идем от а до b
            for(int i = a; i <= b; i++)
            {
                //Внутренний цикл: вывод выбранной цифры
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(i);
                }
                //Спуск на строку ниже
                Console.WriteLine();
            }
        }
    }
}