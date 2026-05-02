using System;
using System.Diagnostics.Contracts;

namespace NewConsole
{
    class Programs
    {
        static void Main(string[] args)
        {
            //Получение и преобразование числа
            Console.Write("Введите шестизначное число: ");
            string numberString = Console.ReadLine();
            int number = Convert.ToInt32(numberString);            

            //Проверка диапазона числа
            if(number < 100000 || number > 999999)
            {
                Console.WriteLine("Число вне диапазона!");
            }
            else
            {
                //Получение и преобразование числа
                Console.Write("Введите первый номер цифры:");
                string firstNumberString = Console.ReadLine();
                int firstNumber = Convert.ToInt32(firstNumberString);

                //Проверка диапазона первого номера цифры
                if(firstNumber < 1 || firstNumber > 6)
                {
                    Console.WriteLine("Неверный номер цифры!");
                }
                else
                {
                    //Получение и преобразование числа
                    Console.Write("Введите второй номер цифры:");
                    string secondNumberString = Console.ReadLine();
                    int secondNumber = Convert.ToInt32(secondNumberString);

                    //Проверка диапазона второго номера цифры
                    if(secondNumber < 1 || secondNumber > 6)
                    {
                        Console.WriteLine("Неверный номер цифры!");
                    }
                    else if(secondNumber == firstNumber)
                    {
                        Console.WriteLine("Ошибка! Вы ввели тот же номер, что и первый!");
                    }
                    else
                    {
                        //Вычисление каждой цифры отдельно
                        int one = number / 100000;
                        int two = number / 10000 % 10;
                        int three = number / 1000 % 10;
                        int four = number / 100 % 10;
                        int five = number / 10 % 10;
                        int six = number % 10;

                        //Запоминаем цифры на выбранных позициях
                        int firstDigit = 0;
                        int secondDigit = 0;

                        if (firstNumber == 1) firstDigit = one;
                        if (firstNumber == 2) firstDigit = two;
                        if (firstNumber == 3) firstDigit = three;
                        if (firstNumber == 4) firstDigit = four;
                        if (firstNumber == 5) firstDigit = five;
                        if (firstNumber == 6) firstDigit = six;

                        if (secondNumber == 1) secondDigit = one;
                        if (secondNumber == 2) secondDigit = two;
                        if (secondNumber == 3) secondDigit = three;
                        if (secondNumber == 4) secondDigit = four;
                        if (secondNumber == 5) secondDigit = five;
                        if (secondNumber == 6) secondDigit = six;

                        //Обмен местами
                        if (firstNumber == 1) one = secondDigit;
                        if (firstNumber == 2) two = secondDigit;
                        if (firstNumber == 3) three = secondDigit;
                        if (firstNumber == 4) four = secondDigit;
                        if (firstNumber == 5) five = secondDigit;
                        if (firstNumber == 6) six = secondDigit;

                        if (secondNumber == 1) one = firstDigit;
                        if (secondNumber == 2) two = firstDigit;
                        if (secondNumber == 3) three = firstDigit;
                        if (secondNumber == 4) four = firstDigit;
                        if (secondNumber == 5) five = firstDigit;
                        if (secondNumber == 6) six = firstDigit;

                        //Вывод результата
                        Console.WriteLine("Результат: " + one + two + three + four + five + six);
                    }
                }
            }
        }
    }
}