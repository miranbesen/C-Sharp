using System;

namespace WinProg_Week7_FuncAndAction
{
    class Program
    {
        static void Main(string[] args)
        {                                  
        //                                 -----> alacagı parametreler.
        //                                 |
            Func<int, int, int> metot1 = (x, y) => x*y; //=> sonraki kısımda ise gövde kismidir.İşlemlerin yapılcagı yer.
            Console.WriteLine(metot1(4, 5));
            
            Func<string, int, string> metot2 = (x, y) =>"merhaba";
            Console.WriteLine(metot2("denemestr", 5));
     
            Func<string, string, int> metot3 = (x, y) =>
              {
                  return 33;
              };
            Console.WriteLine(metot3("3","3"));

            //Action printEmptyLine = () =>
            //{
            //    Console.WriteLine(); //actionda geriye değer donduremez.
            //};
            //    printEmptyLine();

            Action<int> metot4 = x =>
            {
                Console.WriteLine(x);
            };
             metot4(5);
            Action<int, int> metot5 = (x, y) => Console.WriteLine(String.Format("{0}\n{1}", x, y));
            metot5(21, 07);

        }
    }
}
