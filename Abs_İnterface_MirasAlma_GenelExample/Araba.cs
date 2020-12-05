using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs_İnterface_MirasAlma_GenelExample
{
    abstract class Araba : Iaraba
    {
        //private string marka = ""; //bu sekilde de yazabiliriz.
        public string marka { get; set; }
        public string model { get; set; }
        public int beygir_Gucu { get; set; }
        public string renk { get; set; }



        //public string MARKA
        //{
        //    set 
        //    {
        //        this.marka = value;
            
        //    }

        //    get
        //    {
        //        return this.marka; 
        //    }
        //}



        public Araba() //ctor yazıp taba basarsak eger otomatik açıyor.
        {
            Console.WriteLine("Arac 1 in yapıcısı cagrıldı.");

        }
        public Araba(string marka, string model, int beygir_guc, string renk)
        {
            Console.WriteLine("Arac 2 in yapıcısı cagrıldı.");
            this.marka = marka;
            this.model = model;
            this.beygir_Gucu = beygir_guc;
            this.renk = renk;
        }


        public virtual void Calistir()
        {
            Console.WriteLine("arabamiz calistiriliyor.");
        }

        public virtual void hizlan()
        {
            Console.WriteLine("arabamiz hızlanmaktadır.");
        }

        public abstract void dur();


        ~Araba()
        {
            Console.WriteLine("Aracın yıkıcısı cagrıldı");
        } 
    }
}
