using System;
using System.Security.Cryptography.X509Certificates;

namespace Op_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //KarmasikSayi k = new KarmasikSayi(5, -6);
            //k.yaz();
            KarmasikSayi k1 = new KarmasikSayi(1,-3);
            KarmasikSayi k2 = new KarmasikSayi(2,5);
            //KarmasikSayi t = k1 + k2;
            KarmasikSayi t2 = k1 + 10f;
             //KarmasikSayi t3 = 10 + k1;
            //KarmasikSayi t4 = k1 * k2;
            //KarmasikSayi t5 = k1 / k2;
            //t.yaz();
             t2.yaz();
            //t3.yaz();
            //t4.yaz();
            //t5.yaz();
                    
        }
    }
}
