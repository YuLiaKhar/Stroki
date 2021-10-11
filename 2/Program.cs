using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            bool b = true;
            startString = startString.Replace(" ", string.Empty);
            for (int i = 0; i < startString.Length / 2; i++)
            {
                if (startString[i] != startString[startString.Length - i - 1])
                    b = false;
            }
            if (b == true)
            {
                Console.WriteLine("Предложение является палиндромом");
            }
            else
            {
                Console.WriteLine("Предложение НЕ является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
