using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Int16 i16 = 1; Int32 i32 = 1; double db = 1;
            i16 = 132;
            i16 = db;
            i32 = i16;
            i32 = db;
            db = 116; db = i32;
            //double в short не преобразовывается без потерь, также может быть выход за пределы значений
        }
    }
}
