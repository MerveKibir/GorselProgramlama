using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{

    class Program
    {
        static int SayiBul(string gelen)
        {
            int kac = 0;
            string sayilar = "0123456789";
            for (int i = 0; i < gelen.Length; i++)
            {
                for (int j = 0; j < sayilar.Length; j++)
                {
                    if (gelen.Substring(i, 1) == sayilar.Substring(j, 1))
                    {
                        Console.WriteLine("Sayi={0}", gelen.Substring(i, 1));
                        kac++;
                    }
                }
            }
            return kac;
        }
        static void Main(string[] args)
        {
            Console.Write("Metin Giriniz:");
            string metin = Console.ReadLine();
            Console.WriteLine("{0} icerisinde {1} sayi vardir.", metin, SayiBul(metin));
            Console.ReadKey();
        }
    }
}
