using System;

namespace SevenWonders
{
    public class StatueOfZeus : IWonder
    {
        private string name = "Статуя Зевса в Олимпии";
        private string location = "Олимпия, Греция";
        private int yearBuilt = 435;
        private string description = "Огромная статуя Зевса из золота и слоновой кости";

        public void PrintInfo()
        {
            Console.WriteLine($"Чудо: {name}");
            Console.WriteLine($"Местоположение: {location}");
            Console.WriteLine($"Построено: {yearBuilt} г. до н.э.");
            Console.WriteLine($"Описание: {description}");
        }
    }
}
