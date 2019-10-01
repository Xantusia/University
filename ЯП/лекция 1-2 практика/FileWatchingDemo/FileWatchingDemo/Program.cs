using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatchingDemo
{
    class Program
    {
        static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Changed: {0}", e.FullPath);
        }

        static void Main(string[] args)
        {
            FileSystemWatcher watcher =
   new FileSystemWatcher(Environment.SystemDirectory);
            watcher.Changed +=
new FileSystemEventHandler(watcher_Changed);

            watcher.Filter = "*.ini";
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size;

        }
    }
}
