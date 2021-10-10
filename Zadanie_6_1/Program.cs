using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение, без знаков припинания:");
            string predlozh = Console.ReadLine();
            Console.WriteLine();
            string[] strArray = predlozh.Split();
            int maxLenght = strArray[0].Length;
            string longestWord = strArray[0];
            foreach (var item in strArray)
            {
                //Console.Write(item + "\t");
                //Console.WriteLine(item.Length);
                if (item.Length>maxLenght)
                {
                    maxLenght = item.Length;
                    longestWord = item;
                }
            }
            Console.WriteLine("{0} - самое длинное слово в вашем предложении.",longestWord.ToUpper());
            Console.ReadKey();
        }
    }
}
