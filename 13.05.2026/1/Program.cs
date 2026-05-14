using System;

namespace ConsoleNew
{
    class Programm
    {
        public void Square()
        {
            //Ввод числа
            Console.Write("Введите сторону квадрата: ");
            string sqStr = Console.ReadLine();
            int sq = Convert.ToInt32(sqStr);

            //Проверка числа
            if (sq <= 0)
            {
                Console.WriteLine("Неверный диапазон!");
                return;
            }
            else
            {
                //Вложенный цикл: вывод квадрата
                for (int i = 0; i <= sq; i++)
                {
                    for (int j = 0; j <= sq; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            Programm square = new Programm(); //Создание объекта
            square.Square(); //Вызов объекта
        }
    }
}
