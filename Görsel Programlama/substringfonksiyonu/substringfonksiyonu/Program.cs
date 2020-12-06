using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substringfonksiyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            string metin = "www.mervekibirmervemermermerve.com";
            string aranan = "merve";
            int metinuzunluk = metin.Length;
            int arananuzunluk = aranan.Length;
            for(int i=0; i<(metinuzunluk-arananuzunluk);i++)//metin uzunluğundan arananın uzunluğunu ıkardık çünkü gerek yok daha sonrasında aradığımızın olamayacğını biliyoruz
            {
                if(metin.Substring(i,arananuzunluk)==aranan)//i.indisten itibaren aranan uzunluk kadar ilerleyecek, bir nevi seçme işlemi
                {//seçilen kısım aranan ile eşitse sayaç bir artsın
                    sayac++;
                }
            }
            Console.WriteLine(sayac);
            Console.ReadKey();
        }
    }
}
