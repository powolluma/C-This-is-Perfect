using System;

namespace ConsoleNew
{
    class Program
    {
        //Метод палиндрома
        public void Palindrom(int n)
        {
            //Проверка диапазона числа
            if (n < 99999 || n > 999999)
            {
                Console.WriteLine("Число вне диапазона!");
                return;
            }
            else
            {
                //Вычисление каждой цифры отдельно
                int one = n / 100000;
                int two = n / 10000 % 10;
                int three = n / 1000 % 10;
                int four = n / 100 % 10;
                int five = n / 10 % 10;
                int six = n % 10;

                //Преобразование целого числа
                int first =
                    one * 100000 + two * 10000 + three * 1000 + four * 100 + five * 10 + six;
                int second =
                    six * 100000 + five * 10000 + four * 1000 + three * 100 + two * 10 + one;

                //Провека на палиндром
                if (first == second)
                {
                    Console.WriteLine("Палиндром");
                }
                else
                {
                    Console.WriteLine("Не палиндром");
                }
            }
        }

        static void Main(string[] args)
        {
            //Создание объекта
            Program number = new Program();

            //Ввод и преобразование числа
            Console.Write("Введите число: ");
            string numStr = Console.ReadLine();
            int num = Convert.ToInt32(numStr);

            //Вызов метода
            number.Palindrom(num);
        }
    }
}
