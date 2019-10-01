using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;

namespace Serialize_People
{
    [Serializable]
    public class Person : IDeserializationCallback
    {
        public string name;
        public DateTime dateOfBirth;
        [NonSerialized] public int age;
        public static void Serialize(Person sp)
        {
            // Создаем файл для сохранения данных
            FileStream fs = new FileStream("Person.XML", FileMode.Create);

            // Создаем объект XmlSerializer для выполнения сериализации 
            XmlSerializer xs = new XmlSerializer(typeof(Person));

            // Используем объект XmlSerializer для сериализации данных в файл
            xs.Serialize(fs, sp);

            // Закрываем файл
            fs.Close();
        }
        public static Person Deserialize()
        {
            Person dsp = new Person();

            // Создаем файл для сохранения данных
            FileStream fs = new FileStream("Person.XML", FileMode.Open);

            // Создаем объект XmlSerializer для выполнения десериализации
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            // Используем объект XmlSerializer для десериализации данных в файл
            dsp = (Person)xs.Deserialize(fs);

            // Закрываем файл 
            fs.Close(); 
            return dsp;
        }

        public Person(string _name, DateTime _dateOfBirth)
        {
            name = _name;
            dateOfBirth = _dateOfBirth;
            CalculateAge();
        }

        public Person()
        {
        }

        public override string ToString()
        {
            return name + " was born on " + dateOfBirth.ToShortDateString() + " and is " + age.ToString() + " years old.";
        }

        private void CalculateAge()
        {
            age = DateTime.Now.Year - dateOfBirth.Year;

            // If they haven't had their birthday this year, 
            // subtract a year from their age
            if (dateOfBirth.AddYears(DateTime.Now.Year - dateOfBirth.Year) > DateTime.Now)
            {
                age--;
            }
        }

        void IDeserializationCallback.OnDeserialization(Object sender)
        {
            // After deserialization, calculate the age
            CalculateAge();
        }
    }
}
