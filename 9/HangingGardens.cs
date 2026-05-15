using System;

namespace SevenWonders
{
    public class HangingGardens : IWonder
    {
        private string name = "Висячие сады Семирамиды";
        private string location = "Вавилон, Ирак";
        private int yearBuilt = 600;
        private string description = "Легендарные сады, созданные царем Навуходоносором II";

        public void PrintInfo()
        {
            Console.WriteLine($"Чудо: {name}");
            Console.WriteLine($"Местоположение: {location}");
            Console.WriteLine($"Построено: {yearBuilt} г. до н.э.");
            Console.WriteLine($"Описание: {description}");
        }
    }
}
