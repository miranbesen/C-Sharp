using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs_İnterface_MirasAlma_GenelExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Araba araba_nesne = new Araba(); //abstract classimizin nesnesi olusturulamaz.
            //Araba araba_nesne2 = new Araba("mercedes", "a180d", 180, "kırmızı");
            Mercedes araba_nesne3 = new Mercedes("mercedes","a200",180,"kirmizi","ankara");
            Araba araba_nesne4 = new Mercedes();

           araba_nesne3.Calistir();
           araba_nesne4.hizlan();
            

            Console.ReadLine();
            
        
        }
    }

   
}
