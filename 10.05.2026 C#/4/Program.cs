using System;

namespace ConsoleNew
{
    class Programs
    {
        static void Main(string[] args)
        {
            //Получение числа и преобразование строки в число
            Console.Write("Введите N: ");
            string nString = Console.ReadLine();
            int n = Convert.ToInt32(nString);

            if(n <= 0)
            {
                Console.WriteLine("Ошибка! Число должно быть больше нуля!");
            }
            else
            {
                //переменная для перевернутого числа
                int reverse = 0;
                
                //цикл: переворот числа
                while(n > 0)
                {
                    reverse = reverse * 10 + n % 10;
                    n /= 10;
                }           

                Console.WriteLine("Результат: " + reverse);     
            }
        }
    }
}