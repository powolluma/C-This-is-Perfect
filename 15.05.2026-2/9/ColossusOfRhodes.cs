using System;

namespace SevenWonders
{
    public class ColossusOfRhodes : IWonder
    {
        private string name = "Колосс Родосский";
        private string location = "Родос, Греция";
        private int yearBuilt = 280;
        private string description = "Огромная бронзовая статуя бога Гелиоса";

        public void PrintInfo()
        {
            Console.WriteLine($"Чудо: {name}");
            Console.WriteLine($"Местоположение: {location}");
            Console.WriteLine($"Построено: {yearBuilt} г. до н.э.");
            Console.WriteLine($"Описание: {description}");
        }
    }
}
