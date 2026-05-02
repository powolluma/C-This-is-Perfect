using System;
using System.Diagnostics;
using System.Xml.XPath;

namespace ConsoleNew
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод температуры
            Console.Write("Введите показатель температуры: ");
            //Преобразование строки в число
            string tepmeraturaString = Console.ReadLine();
            double tepmeratura = Convert.ToDouble(tepmeraturaString);

            //Выбор типа температуры
            Console.WriteLine("Выберите тип температуры");
            Console.WriteLine("1.Цельсия");
            Console.WriteLine("2.Фаренгейта");
            Console.Write("Ответ: ");

            //Преобразование типа температуры
            string viewString = Console.ReadLine();
            int view = Convert.ToInt32(viewString);

            //Выбор преобразовани типа температуры
            Console.WriteLine("Выберите тип температуры");
            Console.WriteLine("1.Цельсия");
            Console.WriteLine("2.Фаренгейта");
            Console.Write("Ответ: ");

            //Преобразование строки в число
            string chooseString = Console.ReadLine();
            int choose = Convert.ToInt32(chooseString);

            //Выбор действия
            //Из цельсия 
            if(view == 1)
            {
                if(choose == 1)
                {
                    Console.WriteLine(tepmeratura + " градусов по Цельсию");
                }
                else if(choose == 2)
                {
                    double result = (tepmeratura * 9 / 5) + 32;
                    Console.WriteLine(result + " градусов по Фаренгейту");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода!");
                }
            }
            //Из фаренгейта
            else if(view == 2)
            {
                if (choose == 1)
                {
                    double result = (tepmeratura - 32) * 5 / 9;
                    Console.WriteLine(result + " градусов по Цельсию");
                }
                else if(choose == 2)
                {
                    Console.WriteLine(tepmeratura + " градусов по Фаренгейту");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода!");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода!");
            }
        }
    }
}