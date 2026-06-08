using System;
using System.Collections.Generic;
using System.IO;

namespace PROJECT
{
    public class MyDictionary
    {
        public string Name { get; set; } //Название словаря
        public Dictionary<string, List<string>> Words { get; set; } = new Dictionary<string, List<string>>(); //Коллекция

        //Метод сохранения
        public void Save()
        {
            //Условие при отсуствии названия
            if (Name == null || Name == "") return;

            //Создание файла
            string fileName = Name + ".txt";   

            try
            {
                StreamWriter sw = new StreamWriter(fileName);   //Открытие файла
                sw.WriteLine(Name); //Название словаря

                //Цикл по всем словам
                foreach (var pair in Words)
                {

                    string translations = "";
                    //Цикл по всем переводам
                    for (int i = 0; i < pair.Value.Count; i++)
                    {
                        //Проверка >1 перевода 
                        if (i > 0) translations = translations + ", ";
                        translations = translations + pair.Value[i];
                    }
                    //Вывод слова и перевода
                    sw.WriteLine(pair.Key + " = " + translations);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        //Метод загрузки словаря
        public static MyDictionary Load(string fileName)
        {
            try
            {
                MyDictionary dict = new MyDictionary(); //Создание словаря
                StreamReader reader = new StreamReader(fileName);   //Чтение файла
                string line;
                bool isFirstLine = true;    //Первая строка

                //Цикл до конца файла
                while ((line = reader.ReadLine()) != null)
                {
                    if (line == "") continue;   //Пустая строка

                    //Условие первой строки
                    if (isFirstLine)
                    {
                        dict.Name = line;
                        isFirstLine = false;
                        continue;
                    }

                    //Слово и перевод
                    if (line.Contains("="))
                    {
                        string[] parts = line.Split('=');   //Разделение по =

                        string word = parts[0]; //Первое слово
                        string translationsText = parts[1]; //Второе перевод

                        List<string> translations = new List<string>(); //Список переводов

                        string[] transArray = translationsText.Split(',');  //Массив переводов через запятую

                        //Цикл записи слов и переводов
                        for (int i = 0; i < transArray.Length; i++)
                        {
                            string t = transArray[i];
                            if (t != "")    //Проверка на перевод
                            {
                                translations.Add(t);
                            }
                        }

                        //Условие наличия перевода
                        if (translations.Count > 0)
                        {
                            dict.Words[word] = translations;
                        }
                    }
                }
                reader.Close();
                return dict;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка загрузки: " + ex.Message);
                return null;
            }
        }
    }
}