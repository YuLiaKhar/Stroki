using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            int n = 0;
            int m = 0;
            foreach (string s in stringArray)
            {
                m = s.Substring(0).Length;
                if (m > n)
                {
                    n = m;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
