﻿using System;
using System.IO.IsolatedStorage;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IsolatedStorageDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IsolatedStorageFile userStore =
            IsolatedStorageFile.GetUserStoreForAssembly();
            IsolatedStorageFileStream userStream = new
            IsolatedStorageFileStream("UserSettings.set",FileMode.Create, userStore);
            StreamWriter userWriter = new StreamWriter(userStream); userWriter.WriteLine("User Prefs"); userWriter.Close();
            string[] files = userStore.GetFileNames("UserSettings.set");
if (files.Length == 0)
            {
                // ...
            }
            userStream = new
            IsolatedStorageFileStream("UserSettings.set",
            FileMode.Open, userStore); StreamReader userReader = new StreamReader(userStream); string contents = userReader.ReadToEnd();
            System.Console.WriteLine(contents);
        }
    }
}
