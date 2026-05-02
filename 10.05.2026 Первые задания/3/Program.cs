using System;

namespace NewConsole
{
    class Programs
    {
        static void Main(string[] args)
        {
            //Ввод и получение чисел
            Console.Write("Введите первую цифру: ");
            string oneString = Console.ReadLine();
            Console.Write("Введите вторую цифру: ");
            string twoString = Console.ReadLine();
            Console.Write("Введите третью цифру:");
            string threeString = Console.ReadLine();
            Console.Write("Введите четвертую цифру:");
            string fourString = Console.ReadLine();

            //Вывод полного числаы
            Console.WriteLine("Полученное число: " + oneString + twoString + threeString + fourString);
        }
    }
}