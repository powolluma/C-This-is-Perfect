using System;

namespace SevenWonders
{
    public class TempleOfArtemis : IWonder
    {
        private string name = "Храм Артемиды в Эфесе";
        private string location = "Эфес, Турция";
        private int yearBuilt = 550;
        private string description = "Огромный мраморный храм, посвященный богине Артемиде";

        public void PrintInfo()
        {
            Console.WriteLine($"Чудо: {name}");
            Console.WriteLine($"Местоположение: {location}");
            Console.WriteLine($"Построено: {yearBuilt} г. до н.э.");
            Console.WriteLine($"Описание: {description}");
        }
    }
}
