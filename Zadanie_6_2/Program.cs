using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение, без знаков припинания:");
            string predlozh = Console.ReadLine();
            Console.WriteLine();
            string pal1 = predlozh.ToLower().Replace(" ", "");
            string pal2 = "";
            //переворот!!!
            for (int i = pal1.Length-1; i >=0; i--)
            {
                pal2 += pal1[i];
            }
            //Console.WriteLine(pal1);
            //Console.WriteLine(pal2);
            Console.WriteLine();
            if (pal1==pal2)
            {
                Console.WriteLine("Введенная строка - палиндром !!!");
            }
            else
            {
                Console.WriteLine("Введенная строка не является палиндромом. (((");
            }
            Console.ReadKey();
        }
    }
}
