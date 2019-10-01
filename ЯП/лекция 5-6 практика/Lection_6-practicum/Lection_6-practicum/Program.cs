using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection_6_practicum
{
    class Person
    {
        private string _FName;
        private string _LName;
        private DateTime _DateOfBirth;
        public Person(string FName, string LName, DateTime dateOfBirth)
        {
            _FName = FName;
            _LName = LName;
            _DateOfBirth = dateOfBirth;
        }
        public Person()
        {
            _FName = null;
            _LName = null;
            _DateOfBirth = new DateTime (0,0,0);
        }
        string GetFName() { return _FName; }
        string GetLName() { return _LName; }
        DateTime GetDateOfBirth() { return _DateOfBirth; }
        int GetYearOfBirth() { return _DateOfBirth.Year; }
        int SetYearOfBirth(int x)
        { int year = x, month =_DateOfBirth.Month, day = _DateOfBirth.Day;
          _DateOfBirth = new DateTime(year, month, day);
          return 0;
        }
        public override string ToString()
        {
            return _FName + " " + _LName + " was born on " + _DateOfBirth.ToShortDateString();
        }
        public string ToShortString()
        {
            return _FName + " " + _LName;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person ps=new Person("Dima","Popov",new DateTime(2000,07,10));
            Console.WriteLine("Введите количество рядов и столбцов");
            int nrow = int.Parse(Console.ReadLine());
            int ncolumn = int.Parse(Console.ReadLine());
        }
    }
}
