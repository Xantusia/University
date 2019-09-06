using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Lab1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string path=null, filename=null;
            Console.WriteLine("Введите путь: ");
            path=Console.ReadLine();
            Console.WriteLine("Введите полное имя файла: ");
            filename=Console.ReadLine();
            string[] findFiles = System.IO.Directory.GetFiles(@path, filename, System.IO.SearchOption.AllDirectories);
            foreach (string file in findFiles)
            {
                string pathfile=path;
                pathfile+="\\"+ filename;
                Console.WriteLine("Найдено: "+file);

                using (FileStream fs = File.OpenRead(pathfile))
                {
                    byte[] b = new byte[1024];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (fs.Read(b, 0, b.Length) > 0)
                    {
                        Console.WriteLine(temp.GetString(b));
                    }
                }
                Console.WriteLine("Введите имя сжатого файла");
                string pathzipfile=path+"\\"+ Console.ReadLine(); 
                {
                    FileStream sourceFile = File.OpenRead(pathfile);
                    FileStream destFile = File.Create(pathzipfile);
                    GZipStream compStream =
                    new GZipStream(destFile, CompressionMode.Compress);
                    int theByte = sourceFile.ReadByte();
                    while (theByte != -1)
                    {
                        compStream.WriteByte((byte)theByte); theByte = sourceFile.ReadByte();
                    }
                    compStream.Close();
                }
            }
            Console.WriteLine("Поиск Закончен");
        }
    } 
}
