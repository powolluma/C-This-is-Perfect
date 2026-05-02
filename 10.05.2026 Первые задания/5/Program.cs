using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ConsoleProgram
{
    class Programs
    {
        static void Main(string[] args)
        {
            //Ввод строки
            Console.Write("Введите дату (В формате XX.XX.XXXX: )");
            //Считывание строки
            string date = Console.ReadLine();
            string temp = ""; //Временная переменная для вывода
            string day = ""; //День
            string month = ""; //Месяц
            string year = ""; //Год
            int count = 0; //Счетчик


            //Цикл для разбиения чисел для даты
            for(int i = 0; i < date.Length; i++)
            {
                if(date[i] == '.')
                {
                    if(count == 0)
                    {
                        day = temp;
                    }
                    else if(count == 1)
                    {
                        month = temp;
                    }
                    count++;
                    temp = "";
                }
                else
                {
                    temp = temp + date[i];
                }
            }
            year = temp;

            //Преобразование строк в числа
            int dayInt = Convert.ToInt32(day);
            int monthInt = Convert.ToInt32(month);
            int yearInt = Convert.ToInt32(year);

            string season = ""; //Сезон

            //Выявление сезона
            if(monthInt == 12 || monthInt == 1 || monthInt == 2)
            {
                season = "Зима";
            }
            else if(monthInt == 3 || monthInt == 4 || monthInt == 5)
            {
                season = "Весна";
            }
            else if(monthInt == 6 || monthInt == 7 || monthInt == 8)
            {
                season = "Лето";
            }
            else if(monthInt == 9 || monthInt == 10 || monthInt == 11)
            {
                season = "Осень";
            }

            //Создание даты и получение дня недели
            DateTime dateDay = new DateTime(yearInt, monthInt, dayInt);
            string dayWeek = dateDay.DayOfWeek.ToString();

            //Вывод результата
            Console.WriteLine(season + " " + dayWeek);
        }
    }
}