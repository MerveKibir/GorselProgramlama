using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıflarFatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Fatura f1 = new Fatura();
            Console.WriteLine(f1.Ad);
            Console.WriteLine(f1.Adres);
            Console.WriteLine(f1.No);
            Console.WriteLine(f1.Tutar);

            Fatura f2 = new Fatura();
            f2.Ad = "merve";
            f2.No = "05412587412";
            f2.Adres = "bilecik";
            //f2.Tutar = f2.toplam();
            // Console.WriteLine(f2.Ad);
            // Console.WriteLine(f2.Adres);
            // Console.WriteLine(f2.No);
            //Console.WriteLine(f2.Tutar);
            //Console.WriteLine(f2.toplam());
            f2.yaz();
            
            Console.ReadKey();
        }
    }
}
