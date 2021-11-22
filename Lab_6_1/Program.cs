using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string Long = " ";
            int a = 1;
            foreach (string s in stringArray)
            {
                if (s.Length>a)
                {
                    a = s.Length;
                    Long = s;
                }
            }
            Console.WriteLine(Long);
            Console.ReadKey();
        }
    }
}
