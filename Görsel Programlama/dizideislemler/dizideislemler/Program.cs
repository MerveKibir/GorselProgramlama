using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizideislemler
{
    class Program
    {
        static void Main(string[] args)
        {
            int uzunluk=0;
            string enuzun = "";
            int adres = 0;

            string[] dizi = new string[10];
            for( int i = 0; i<10; i++)
            {
                Console.Write("{0}. elemani girin:", i + 1);
                dizi[i] = Convert.ToString(Console.ReadLine());
            }
            for(int i=0; i<10;i++)
            {
                if(dizi[i].Length>uzunluk)
                {
                    uzunluk = dizi[i].Length;
                    enuzun = dizi[i];
                    adres = i;
                }
            }

            Console.WriteLine("========================");
            Console.WriteLine("en uzun metin:" + enuzun) ;
            Console.WriteLine("uzunlugu:" + uzunluk);
            Console.WriteLine("bulundugu indis:" + adres);
            Console.ReadKey();
        }
    }
}
