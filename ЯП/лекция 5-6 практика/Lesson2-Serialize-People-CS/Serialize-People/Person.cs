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
            // ������� ���� ��� ���������� ������
            FileStream fs = new FileStream("Person.XML", FileMode.Create);

            // ������� ������ XmlSerializer ��� ���������� ������������ 
            XmlSerializer xs = new XmlSerializer(typeof(Person));

            // ���������� ������ XmlSerializer ��� ������������ ������ � ����
            xs.Serialize(fs, sp);

            // ��������� ����
            fs.Close();
        }
        public static Person Deserialize()
        {
            Person dsp = new Person();

            // ������� ���� ��� ���������� ������
            FileStream fs = new FileStream("Person.XML", FileMode.Open);

            // ������� ������ XmlSerializer ��� ���������� ��������������
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            // ���������� ������ XmlSerializer ��� �������������� ������ � ����
            dsp = (Person)xs.Deserialize(fs);

            // ��������� ���� 
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
