using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Changecode
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"z:\newfile.txt");
            StreamWriter sw = new StreamWriter("newfile-utf-7", false, Encoding.ASCII);
            sw.WriteLine(sr.ReadToEnd());
            sw.Close();
            sr.Close();

        }
    }
}
