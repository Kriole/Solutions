using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            string name;

            Console.WriteLine($"Enter Path:");
            name = Console.ReadLine();
            UnixName(name);
        }

        public static void UnixName(string name)
        {
            List<string> UnixStack = new List<string>();
            char[] delimiterChars = { '/' };
            string[] words = name.Split(delimiterChars);

            foreach (var word in words)
            {
                //if (word == "."){}
                if (word == "..")
                {
                    if (UnixStack.Count != 0)
                    UnixStack.RemoveAt(UnixStack.Count - 1);
                }
                else
                    UnixStack.Add(word);
            }
            PrintValues(UnixStack);
        }

        public static void PrintValues(IEnumerable UnixPath)
        {           

            foreach (Object obj in UnixPath)
            {
                Console.Write("{0}\\", obj);
            }
        }

    }


}
