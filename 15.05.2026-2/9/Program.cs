using System;
using SevenWonders;

namespace ConsoleNew
{
    class Program
    {
        static void Main(string[] args)
        {
            //Массив
            IWonder[] wonders = new IWonder[]
            {
                new PyramidOfGiza(),
                new HangingGardens(),
                new StatueOfZeus(),
                new TempleOfArtemis(),
                new Mausoleum(),
                new ColossusOfRhodes(),
                new LighthouseOfAlexandria(),
            };

            //Вывод
            foreach (var wonder in wonders)
            {
                wonder.PrintInfo();
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
