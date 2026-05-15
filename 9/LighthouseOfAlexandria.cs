using System;

namespace SevenWonders
{
    public class LighthouseOfAlexandria : IWonder
    {
        private string name = "Александрийский маяк";
        private string location = "Александрия, Египет";
        private int yearBuilt = 280;
        private string description =
            "Один из самых высоких маяков древности, высотой до 150 метров";

        public void PrintInfo()
        {
            Console.WriteLine($"Чудо: {name}");
            Console.WriteLine($"Местоположение: {location}");
            Console.WriteLine($"Построено: {yearBuilt} г. до н.э.");
            Console.WriteLine($"Описание: {description}");
        }
    }
}
