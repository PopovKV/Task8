using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Task8-2.txt";
            Random rnd = new Random();
            int a = 0;
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    a = rnd.Next();
                    sw.WriteLine(a);
                }                
            }
            a = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {                    
                    a+=Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine("Сумма чисел = {0}",a);
            Console.ReadKey();
        }
    }
}
