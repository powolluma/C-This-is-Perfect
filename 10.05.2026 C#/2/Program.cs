using System;

namespace ConsolePrograms
{
    class Proggrams
    {
        static void Main(string[] args)
        {
            //первоначальный вклад
            double sum = 10000;

            //ввод пользователем процента и преобразование строки в число
            Console.Write("Введите число P (Процент):");
            string pString = Console.ReadLine();
            double p = Convert.ToDouble(pString);
        
            //проверка диапазона
            if(p < 0 || p > 25)
            {
                Console.WriteLine("Ошибка! Правильный диапазон: 0 < P < 25");
            }
            else
            {
                //месяцы
                int month = 0;
                //текущая сумма
                double currentSum = sum;

                //цикл для подсчета времени накопления
                while(currentSum < 11000.0)
                {
                    currentSum += currentSum / 100 * p;
                    month++;
                }
                //вывод результата
                Console.WriteLine("Понадобится " + month + " месяцев");
                Console.WriteLine("Итоговая сумма: " + currentSum);
            }
        }
    }
}