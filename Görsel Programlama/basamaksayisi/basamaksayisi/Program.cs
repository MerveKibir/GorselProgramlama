using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basamaksayisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, sayac=1, b=1;
            sayi = int.Parse(Console.ReadLine());
            while((sayi/b)>9)
            {
                b *= 10;
                sayac++;
            }
            Console.WriteLine("sayi {0} basamaklı", sayac);
            Console.ReadKey();
        }
    }
}
