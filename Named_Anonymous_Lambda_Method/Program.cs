using System;
using System.Linq;

namespace WinProg_Week7_Named_Anonymous_Lambda_Method
{
    class Program
    {
        public static bool FindBurhan(Employee b2)
        {
            return b2.Name == "Burhan";
        }

        static void Main(string[] args)
        {

            Employee[] employees = new Employee[]
            {
                new Employee{ID=1,Name="Utku"},
                new Employee{ID=2,Name="Bora"},
                //new Employee{ID=3,Name="Gencer"},
                //new Employee{ID=4,Name="Burhan"},
                //new Employee{ID=5,Name="Serdar"}
            };

            var query = from m in employees where m.Name == "Bora" select m.ID;

        ////alternatif1: Named Method
        //    var query = Array.Find(calisanlar, FindBurhan);
        //    Console.WriteLine("Query1 kismi: " + "ID:" + query.ID + " Name:" + query.Name);

        ////alternatif2: Anonuymous Method
        //    var query2 = Array.Find(calisanlar, delegate (Employee b1)
        //     {
        //         return b1.Name == "Bora";
        //     });

        //    Console.WriteLine("Query2 kismi: " + "ID:" + query2.ID + " Name:" + query2.Name);
        ////alternatif3: Lambda Expression(İfade)

        //    var query3 = Array.Find(calisanlar, m =>
        //    {
        //        return m.Name == "Mert";
        //    });
        //    Console.WriteLine("Query3 kismi: " + "ID:" + query3.ID + " Name:" + query3.Name);

        ////alternatif4: linq sorguları
        //    var query4 = from g in calisanlar
        //                 where g.Name == "Mert"
        //                 select g;
        //    //Bu soruguda query4'e mert in adını ve id sini atama yapar fakat ekrana basmayı yapamaz.
        //    //Console.WriteLine("Query4 kismi: " + "ID:" + query4.ID + " Name:" + query4.Name);

        //    //alternatif4.2: linq sorgu2
        //    var query5 = calisanlar.Where(s => s.Name == "Serdar")
        //            .Select(s => s);
            
            //Burdada linq sorgusu olduğu için ekrana basmıyor ama değerleri atamaya yapıyor query5'e
            //Console.WriteLine("Query5 kismi: " + "ID:" + query5.ID + " Name:" + query5.Name);

        
        }
    }
}
