using System;

namespace ConsoleNew
{
    class Program
    {
        //Метод фильтрации метода
        public static int[] Filter(int[] oldArray, int[] newArray)
        {
            //Временный массив
            int[] temp = new int[oldArray.Length];
            int index = 0;

            //Цикл перебора оригинального массива
            for (int i = 0; i < oldArray.Length; i++)
            {
                bool found = false;

                //Цикл поиска совпадений с новый массивом
                for (int j = 0; j < newArray.Length; j++)
                {
                    if (oldArray[i] == newArray[j])
                    {
                        found = true;
                        break;
                    }
                }

                //Условие ненайденных чисел в старом массиве
                if (!found)
                {
                    temp[index] = oldArray[i];
                    index++;
                }
            }

            int[] result = new int[index];

            //Цикл запизи результата
            for (int i = 0; i < index; i++)
            {
                result[i] = temp[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
            //Массивы
            int[] oneArray = { 1, 2, 3, 4, 5 };
            int[] twoArray = { 1, 5 };

            //Отфильтрованный массив
            int[] result = Filter(oneArray, twoArray);

            //Цикл вывода
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
