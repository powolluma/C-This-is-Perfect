using System;

namespace SevenWonders
{
    public class PyramidOfGiza : IWonder
    {
        private string name = "Пирамида Хеопса";
        private string location = "Гиза, Египет";
        private int yearBuilt = 2560;
        private string description = "Самая древняя и единственная сохранившаяся из 7 чудес";

        public void PrintInfo()
        {
            Console.WriteLine($"Чудо: {name}");
            Console.WriteLine($"Местоположение: {location}");
            Console.WriteLine($"Построено: {yearBuilt} г. до н.э.");
            Console.WriteLine($"Описание: {description}");
        }
    }
}
