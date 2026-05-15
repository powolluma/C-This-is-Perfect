using System;
using France;
using Japan;
using Russia;

namespace ConsoleNew
{
    class Program
    {
        static void Main(string[] args)
        {
            //Объекты столиц
            Russia.Moscow moscow = new Russia.Moscow();
            France.Paris paris = new France.Paris();
            Japan.Tokyo tokyo = new Japan.Tokyo();

            //Вывод
            Console.WriteLine("Страна: Россия");
            Console.WriteLine("Столица: Москва");
            Console.WriteLine("Население: " + moscow.GetPopulation() + " человек");
            Console.WriteLine();

            Console.WriteLine("Страна: Франция");
            Console.WriteLine("Столица: Париж");
            Console.WriteLine("Население: " + paris.GetPopulation() + " человек");
            Console.WriteLine();

            Console.WriteLine("Страна: Япония");
            Console.WriteLine("Столица: Токио");
            Console.WriteLine("Население: " + tokyo.GetPopulation() + " человек");
            Console.WriteLine();

            //Сравнение
            int moscowPop = moscow.GetPopulation();
            int parisPop = paris.GetPopulation();
            int tokyoPop = tokyo.GetPopulation();

            if (moscowPop > parisPop && moscowPop > tokyoPop)
            {
                Console.WriteLine("Москва - самая населённая столица (" + moscowPop + " чел.)");
            }
            else if (parisPop > moscowPop && parisPop > tokyoPop)
            {
                Console.WriteLine("Париж - самая населённая столица (" + parisPop + " чел.)");
            }
            else if (tokyoPop > moscowPop && tokyoPop > parisPop)
            {
                Console.WriteLine("Токио - самая населённая столица (" + tokyoPop + " чел.)");
            }
        }
    }
}
