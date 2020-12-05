using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace WinProg_Week8_Generics_Sablon_
{
    class Program
    {
        static void Main(string[] args)
        {
            Metot2();
            Metot1();

        }

    private static void Metot2()
    {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            List<int> list = new List<int>();

            for(int i = 0; i < 100000; i++)
            {
                list.Add(i);
            }
            foreach(int item in list)
            {
                int sayi = item;
            }
            watch.Stop();
            Console.WriteLine("Geçen Zaman(Sablonlu Hali):" + watch.Elapsed.TotalMilliseconds);
        
        }
        private static void Metot1()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            ArrayList list = new ArrayList();

            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            foreach (int item in list)
            {
                int sayi = item;
            }
            watch.Stop();
            Console.WriteLine("Geçen Zaman:" + watch.Elapsed.TotalMilliseconds);

        }

    }

}
