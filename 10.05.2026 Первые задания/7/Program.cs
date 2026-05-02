using System;

namespace ConsoleNew
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод и преобразование первого числа
            Console.Write("Введите первый диапазон: ");
            string oneString = Console.ReadLine();
            int one = Convert.ToInt32(oneString);

            //Ввод и преобразование второго числа
            Console.Write("Введите второй диапазон: ");
            string twoString = Console.ReadLine();
            int two = Convert.ToInt32(twoString);

            //Условие если первый диапазон больше второго
            if(one > two)
            {
                //Обмен местами
                int temp;
                temp = one;
                one = two;
                two = temp;
                
                //Перебирание четных чисел и вывод
                for(int i = one; i <= two; i++)
                {
                    if(i % 2 == 0)
                    {
                        Console.WriteLine(i);       
                    }
                }
            }

            else
            {
                //Перебирание четных чисел и вывод
                for(int i = one; i <= two; i++)
                {
                    if(i % 2 == 0)
                    {
                        Console.WriteLine(i);       
                    }
                }
            }
        }
    }
}