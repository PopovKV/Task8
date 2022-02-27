using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:/Курсы/2035_АВТОМАТИЗАЦИЯ BIM ПРОЕКТИРОВАНИЯ/Task8/Task8.3/Task8-3.txt";
            string s;
            int symb = 0;
            int str = 0;
            int slv = 0;
            StreamReader sr = new StreamReader(path);
            s = sr.ReadLine();
            while (s != null)
            {
                string[] Array = s.Split();
                foreach (string word in Array)
                {
                    slv++;
                }
                symb += s.Length;
                str++;
                s = sr.ReadLine();
            }
            Console.WriteLine("Количество символов = {0}", symb);
            Console.WriteLine("Количество строк = {0}", str);
            Console.WriteLine("Количество слов = {0}", slv);
            Console.ReadKey();
        }
    }
}
