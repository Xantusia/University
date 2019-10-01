using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowFilesDemo
{
    class Program
    {
        static void ShowDirectory(DirectoryInfo dir)
        {
            // Показать все файлы
            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine("File: {0}", file.FullName);
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(Environment.SystemDirectory); ShowDirectory(dir);
        }
    }
}
