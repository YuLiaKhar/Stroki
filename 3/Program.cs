using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "123{{4}567{8901}2345";
            Console.WriteLine(s);
            // 1 вариант
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '{')
                {
                    for (int k = i; k < s.Length; k++)
                    {
                        if (s[k++] == '{')
                        {
                            continue;
                        }
                        else
                        {
                            for (int j = k++; j != '}'; j++)
                            {
                                s = s.Remove(s[j]);
                            }
                        }
                    }
                }
            }
            // 2 вариант
            //char t1 = '{';
            //char t2 = '}';
            //char probel = ' ';
            //int n = s.Substring(0).Length;
            //string[] m = s.Split();
            //bool a = s.Contains(t1);
            //bool b = s.Contains(t2);
            //if (a == true)
            //{
            //    for (int i = 0; b == true; i++)
            //    {
            //        s = s.Replace(s[i], probel);
            //    }
            //}

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
