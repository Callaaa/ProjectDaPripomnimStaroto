using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputtingAWordByDescendingOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadacha 12
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            char[] theWord = word.ToCharArray();
            Array.Reverse(theWord);
            Console.WriteLine("Reversed: " + string.Join("", theWord));
        }
    }
}
