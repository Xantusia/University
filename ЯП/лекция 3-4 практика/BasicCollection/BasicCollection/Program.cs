using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BasicCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Clear();
            myList.Add("First");
            myList.Add("Second");
            myList.Add("Third");
            myList.Add("Fourth");

            myList.Sort();
            foreach (string item in myList)
            {
                Console.WriteLine("   Sorted: {0}", item);

            }
        }
    }
}
