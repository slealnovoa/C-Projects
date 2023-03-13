using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("This is to test whether the extension method count can return a right answer or not");
            int wordCount = sb.CountWords();
            Console.WriteLine(wordCount);
            Console.ReadKey();
        }
    }
}
