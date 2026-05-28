using System;

namespace ConsoleNew
{
    //делегат
    public delegate void PropertyEventHandler(object sender, PropertyEventArgs e);

    //класс определения измененного свойства
    public class PropertyEventArgs : EventArgs
    {
        //переменная измененного свойства
        public string PropertyName { get; } 

        //метод присвоения
        public PropertyEventArgs(string propertyName)
        {
            PropertyName = propertyName;
        }
    }

    //интерфейс
    interface IPropertyChanged
    {
        event PropertyEventHandler PropertyChanged;
    }

    //класс для реализации интерфейса
    public class Person : IPropertyChanged
    {
        //событие
        public event PropertyEventHandler PropertyChanged;

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                //условие проверки изменения свойства
                if (name != value)
                {
                    name = value;
                    PropertyChanged?.Invoke(this, new PropertyEventArgs("Name"));
                }
            }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                //условие проверки изменения свойства
                if (age != value)
                {
                    age = value;
                    PropertyChanged?.Invoke(this, new PropertyEventArgs("Age"));
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Тест изменения свойств ===\n");

            //объект
            Person person = new Person();

            //вызов метода при событии
            person.PropertyChanged += Person_PropertyChanged;

            //изменение свойств
            person.Name = "Алексей";
            person.Age = 30;
            person.Name = "Максим"; 
            person.Age = 30;        
            Console.ReadLine();
        }

        //обработчик события
        private static void Person_PropertyChanged(object sender, PropertyEventArgs e)
        {
            Console.WriteLine($"Изменилось свойство: {e.PropertyName}");
        }
    }
}