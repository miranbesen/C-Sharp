using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs_İnterface_MirasAlma_GenelExample
{
    class Mercedes: Araba 
    {
        public string uretimYeri { get; set; }

        public Mercedes()
        {

        }
        public Mercedes(string marka,string model,int beygir_guc,string renk,string uretim_yeri):
            base(marka,model,beygir_guc,renk)
        {
            this.uretimYeri = uretim_yeri; 
        }
        public override void Calistir() //bu sekilde cok bicimlilik ile yazdıgımız nesnemizde 
        {
            Console.WriteLine("mercedes arabamiz calistiriliyor.");
        }

        public override void hizlan()
        {
            Console.WriteLine("mercedes arabamiz hızlanmaktadır.");
        }

        public override void dur()
        {
            Console.WriteLine("mercedes arabamiz yavaslayıp durmaktadır.");
        }

    }
}
