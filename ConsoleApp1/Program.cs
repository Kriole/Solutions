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
            Console.WriteLine($"Enter Path:");
            string name = Console.ReadLine();
            Console.Write(UnixName(name));
        }

       public static string UnixName(string name)
        {
            char[] delimiterChars = { '/' };
            string[] words = name.Split(delimiterChars);

            List<string> UnixStack = new List<string>();
            foreach (var word in words)
            {
                if (word == ".." && UnixStack.Count != 0)
                {
                    UnixStack.RemoveAt(UnixStack.Count - 1);
                }
                else if (word != ".") {
                    UnixStack.Add(word);
                }
            }
            return string.Join("\\", UnixStack);
        }
    }


}
