using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = EnterText();

            string[] words = SplitText(text1);
            PrintWords(words);
            Console.ReadKey();

            string text2 = EnterText();

            Console.WriteLine(Reverse(text2));
            Console.ReadKey();
        }

        static string EnterText()
        {
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            return text;
        }

        static string[] SplitText(string text)
        {
            return text.Split(' ');
        }

        static void PrintWords(string[] str)
        {
            Console.WriteLine("");
            foreach (var el in str) Console.WriteLine(el);
        }

        static string Reverse(string text)
        {
            string[] words = SplitText(text);
            string str = "";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                str+= words[i] + " ";
            }
            return str;
        }
    }
}
