using System;

namespace SevenWonders
{
    public class Mausoleum : IWonder
    {
        private string name = "Мавзолей в Галикарнасе";
        private string location = "Бодрум, Турция";
        private int yearBuilt = 350;
        private string description = "Гробница царя Мавсола, от которой произошло слово 'мавзолей'";

        public void PrintInfo()
        {
            Console.WriteLine($"Чудо: {name}");
            Console.WriteLine($"Местоположение: {location}");
            Console.WriteLine($"Построено: {yearBuilt} г. до н.э.");
            Console.WriteLine($"Описание: {description}");
        }
    }
}
