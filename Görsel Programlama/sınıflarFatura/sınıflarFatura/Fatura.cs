using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıflarFatura
{
    class Fatura
    {
        public string Ad;
        public string No;
        public string Adres;
        public int Tutar;
        public Fatura()//kurucu fonksiyon
        {
            this.Ad = "Ankara yayınevi";
            this.Adres = "kızılay/ankara";
            this.No = "03125412875";
            this.Tutar = 30;
        }
        public int toplam()
        {
            int konusma, mesaj, diger;
            Console.WriteLine("konuşma tutarı:");
            konusma = int.Parse(Console.ReadLine());
            Console.WriteLine("mesaj tutarı:");
            mesaj = int.Parse(Console.ReadLine());
            Console.WriteLine("diğer tutar:");
            diger = int.Parse(Console.ReadLine());
            return konusma + mesaj + diger;
        }
        public void yaz()
        {
            Console.WriteLine(Ad);
            Console.WriteLine(Adres);
            Console.WriteLine(No);
            Console.WriteLine("fatura toplamı: " + toplam());
        }
    }
}
