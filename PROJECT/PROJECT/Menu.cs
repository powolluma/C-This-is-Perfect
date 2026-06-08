using System;
using System.IO;

namespace PROJECT
{
    public class DictionaryApp
    {
        private MyDictionary currentDict = null;    //Текущий словарь

        //Метод вывода меню
        public void Start()
        {
            while (true)
            {
                try
                {
                    //Главное меню
                    Console.Clear();
                    Console.WriteLine("ПРОГРАММА");
                    Console.WriteLine("1. Создать новый словарь");
                    Console.WriteLine("2. Выбрать существующий словарь");
                    Console.WriteLine("3. Работать со словарём");
                    Console.WriteLine("0. Выход");
                    Console.Write("Выбери номер: ");
                    string choice = Console.ReadLine();

                    //Условие выбора 
                    if (choice == "1") CreateDictionary();
                    else if (choice == "2") SelectDictionary();
                    else if (choice == "3")
                    {
                        if (currentDict != null)
                            WorkWithCurrentDictionary();
                        else
                            Console.WriteLine("Нужно создать или выбрать словарь!");
                    }
                    else if (choice == "0")
                    {
                        break;
                    }
                    else
                        Console.WriteLine("Неправильный выбор!");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.ReadKey();
                }
            }
        }

        //Метод создания словаря
        private void CreateDictionary()
        {
            try
            {
                //Второе меню программы
                Console.Clear();
                Console.WriteLine("СОЗДАНИЕ СЛОВАРЯ");
                Console.WriteLine("1. Русско-Английский");
                Console.WriteLine("2. Англо-Русский");
                Console.Write("Выбор: ");
                string choice = Console.ReadLine();

                //Создание словаря
                currentDict = new MyDictionary();

                if (choice == "1") currentDict.Name = "Русско-Английский";
                else if (choice == "2") currentDict.Name = "Англо-Русский";
                else
                {
                    Console.WriteLine("Неверный выбор!");
                    currentDict = null;
                    return;
                }
                currentDict.Save();
                Console.WriteLine($"Словарь '{currentDict.Name}' создан");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка!: {ex.Message}");
                currentDict = null;
            }
        }

        //Выбор словаря
        private void SelectDictionary()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("ВЫБОР СЛОВАРЯ");

                string[] files = Directory.GetFiles(".", "*.txt"); //Поиск файлов с расширением

                //Проверка на пустоту
                if (files.Length == 0)
                {
                    Console.WriteLine("Словари не найдены.");
                    return;
                }

                //Вывод словарей
                Console.WriteLine("Словари:");
                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine((i + 1) + ". " + Path.GetFileName(files[i]));
                }

                //Ввод номера словаря
                Console.Write("\nНомер: ");
                string input = Console.ReadLine();

                int num = 0;
                int.TryParse(input, out num);

                if (num >= 1 && num <= files.Length)
                {
                    currentDict = MyDictionary.Load(files[num - 1]);    //Загрузка словаря из класса
                    Console.WriteLine("Загружен: " + currentDict.Name);
                }
                else
                {
                    Console.WriteLine("Неправильный номер!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при выборе словаря: " + ex.Message);
            }
        }

        //Метод работы со словарем
        private void WorkWithCurrentDictionary()
        {
            while (true)
            {
                try
                {
                    //Меню работы со словарем
                    Console.Clear();
                    Console.WriteLine($"РАБОТА СО СЛОВАРЕМ: {currentDict.Name}");
                    Console.WriteLine("1. Добавить слово + перевод");
                    Console.WriteLine("2. Заменить слово");
                    Console.WriteLine("3. Удалить слово или перевод");
                    Console.WriteLine("4. Найти перевод");
                    Console.WriteLine("5. Экспорт слова в файл");
                    Console.WriteLine("0. Вернуться в главное меню");
                    Console.Write("Выбор: ");
                    string choice = Console.ReadLine();

                    //Условие выбора действия
                    if (choice == "1") AddWord();
                    else if (choice == "2") ReplaceWord();
                    else if (choice == "3") DeleteWordOrTranslation();
                    else if (choice == "4") SearchWord();
                    else if (choice == "5") ExportWord();
                    else if (choice == "0") return;
                    else Console.WriteLine("Неверный выбор!");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                    Console.ReadKey();
                }
            }
        }

        //Метод добавления слова
        private void AddWord()
        {
            try
            {
                Console.Write("Введите слово: ");
                string word = Console.ReadLine();

                if (string.IsNullOrEmpty(word)) return;

                if (!currentDict.Words.ContainsKey(word))
                {
                    currentDict.Words[word] = new List<string>();
                }
                    
                Console.Write("Перевод через запятую: ");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) return;

                string[] translations = input.Split(',');

                foreach (string t in translations)
                {
                    //Условие: проверка на пустую строку перевода и наличие перевода
                    if (t != "" && !currentDict.Words[word].Contains(t))
                    {
                        currentDict.Words[word].Add(t);
                    }
                }
                currentDict.Save();
                Console.WriteLine("Слово и переводы добавлены");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при добавлении слова: {ex.Message}");
            }
        }

        //Метод замены слова 
        private void ReplaceWord()
        {
            try
            {
                //Старое слово
                Console.Write("Какое слово заменить: ");
                string oldWord = Console.ReadLine();

                //Проверка наличия слова
                if (!currentDict.Words.ContainsKey(oldWord))
                {
                    Console.WriteLine("Такого слова нет");
                    return;
                }

                //Новое слово
                Console.Write("Новое слово: ");
                string newWord = Console.ReadLine();

                if (string.IsNullOrEmpty(newWord)) return;

                currentDict.Words[newWord] = currentDict.Words[oldWord];
                currentDict.Words.Remove(oldWord);

                currentDict.Save();
                Console.WriteLine("Слово успешно заменено");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при замене слова: {ex.Message}");
            }
        }

        //Метод удаления
        private void DeleteWordOrTranslation()
        {
            try
            {
                Console.Write("Введите слово: ");
                string word = Console.ReadLine();

                if (!currentDict.Words.ContainsKey(word))
                {
                    Console.WriteLine("Слово не найдено.");
                    return;
                }

                Console.WriteLine("1. Удалить слово");
                Console.WriteLine("2. Удалить перевод");
                Console.Write("Выбор: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    currentDict.Words.Remove(word);
                    Console.WriteLine("Слово удалено");
                }
                else if (choice == "2")
                {
                    if (currentDict.Words[word].Count <= 1)
                    {
                        Console.WriteLine("Нельзя удалить последний перевод!");
                        return;
                    }

                    Console.Write("Какой перевод удалить: ");
                    string trans = Console.ReadLine();

                    if (currentDict.Words[word].Remove(trans))
                        Console.WriteLine("Перевод удалён");
                    else
                        Console.WriteLine("Такого перевода нету");
                }
                currentDict.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        //Метод поиска слова
        private void SearchWord()
        {
            try
            {
                Console.Write("Какое слово найти: ");
                string word = Console.ReadLine();

                if (currentDict.Words.TryGetValue(word, out List<string> translations))
                {
                    Console.WriteLine($"Слово: {word}");
                    foreach (string t in translations)
                        Console.WriteLine(t);
                }
                else
                    Console.WriteLine("Слово не найдено");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        //Экспорт слова
        private void ExportWord()
        {
            try
            {
                Console.Write("Какое слово экспортировать: ");
                string word = Console.ReadLine();

                if (currentDict.Words.TryGetValue(word, out List<string> translations))
                {
                    string fileName = $"{word}.txt";

                    StreamWriter writer = new StreamWriter(fileName);   //Открытие файла для записи

                    writer.WriteLine("Слово: " + word);
                    writer.WriteLine("Переводы:");

                    foreach (string t in translations)
                    {
                        writer.WriteLine(" - " + t);
                    }

                    Console.WriteLine($"Экспортировано: {fileName}");
                }
                else
                    Console.WriteLine("Слово не найдено");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}