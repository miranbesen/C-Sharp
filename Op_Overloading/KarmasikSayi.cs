using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Op_Overloading
{
    class KarmasikSayi
    {
        private double mGercek { get; set; }
        private double mSanal { get; set; }

        public KarmasikSayi(double x,double y)
        {
            mGercek = x;
            mSanal = y;
        }
        public KarmasikSayi()
        {
            mGercek = 0;
            mSanal = 0;
        }

        public KarmasikSayi(KarmasikSayi k)
        {
            mGercek = k.mGercek;
            mSanal = k.mSanal;
        }
     
        public void yaz()
        {
            if (mSanal > 0)
                Console.WriteLine("{0}+{1}i", mGercek, mSanal);
            else
                Console.WriteLine("{0}-{1}i", mGercek, -mSanal);
        }

        public static KarmasikSayi operator +(KarmasikSayi a, KarmasikSayi b)
        {
            double gt = a.mGercek + b.mGercek;
            double st = a.mSanal + b.mSanal;
            return new KarmasikSayi(gt, st);
        }
        public static KarmasikSayi operator +(KarmasikSayi a,double b)
        {
            double gt = a.mGercek+b;
            return new KarmasikSayi(gt, a.mSanal);
        }
        public static KarmasikSayi operator +(double a, KarmasikSayi b)
        {
            return b + a;
        }
        public static KarmasikSayi operator *(KarmasikSayi a,KarmasikSayi b)
        {
            double sanal1 = a.mSanal * b.mGercek;
            double sanal2 = b.mSanal * a.mGercek;
            double sc = sanal1 + sanal2;

            double gercek1 = a.mGercek * b.mGercek;
            double gercek2 = a.mSanal * b.mSanal;

            //Console.WriteLine("{0}", gercek2);

            double gc = gercek1 - gercek2;
            return new KarmasikSayi(gc, sc);
        }
        public static KarmasikSayi operator /(KarmasikSayi a, KarmasikSayi b)
        {
            KarmasikSayi b_eslenik = new KarmasikSayi(b.mGercek, -b.mSanal);
            KarmasikSayi pay = a * b_eslenik;
            double gercek1 = b.mGercek * b_eslenik.mGercek;
            double gercek2 = b.mSanal * b_eslenik.mSanal;
            double payda = gercek1 - gercek2;
            //Console.WriteLine("{0}", payda);
            double bolumGercek = pay.mGercek /payda;
            double bolumSanal = pay.mSanal / payda;

            return new KarmasikSayi(bolumGercek, bolumSanal);
        }




    }

}
