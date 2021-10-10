using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку с фигурными скобками");
            string str1 = Console.ReadLine();
            Console.WriteLine();

            while (str1.Contains("{"))
            {
                string subStr1 = str1.Substring((str1.LastIndexOf("{")));
                string subStr2 = subStr1.Substring(0, subStr1.IndexOf("}") + 1);
                //Console.WriteLine(subStr2);
                str1 = str1.Replace(subStr2, "");
                Console.WriteLine();
            }

            Console.WriteLine("Строка после преобразования: ");
            Console.WriteLine(str1);
            Console.ReadKey();
        }
    }
}
