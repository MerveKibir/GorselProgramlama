using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tahminoyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, tahmin, sayac = 0;
            Random rast = new Random();
            sayi = rast.Next(1, 11);
            do
            {
                sayac++;
                Console.Write("tahmininizi giriniz:");
                tahmin = int.Parse(Console.ReadLine());
                if (tahmin < sayi)
                {
                    Console.WriteLine("daha büyük değer girin");
                }
                else
                    Console.WriteLine("daha kücük değer girin");
            } while (tahmin != sayi);
            Console.WriteLine(sayac + " defada buldunuz");
        }
    }
}
