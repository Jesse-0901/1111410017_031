using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111410017_王議揚031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入文字，以空格分隔，最少1字最大50字：");

            string userInput = Console.ReadLine();
            if (userInput.Length < 1 || userInput.Length > 50)
            {
                Console.WriteLine("輸入的文字必須介於1到50字。");
                return;
            }
            string[] words = userInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("請輸入文字，限定1字：");
            string userInput2 = Console.ReadLine();
            if (userInput2.Length < 1 || userInput2.Length > 1)
            {
                Console.WriteLine("只能輸入1個字。");
                return;
            }
            string CheckWord = userInput2.ToLower();

            List<int> indexes = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains(CheckWord))
                {
                    indexes.Add(i);
                }
            }

            if (indexes.Count > 0)
            {
                string result = "[" + String.Join(", ", indexes) + "]";
                Console.WriteLine(result);
            }
            else
            {
                string result = "[" + String.Join(", ", indexes) + "]";
                Console.WriteLine(result);
            }
        }
    }
}
