using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifOgrenci
{

    public class Ogrenci
    {
        public int ONo;
        public string OAdSoyad;
    }
    class Program
    {
        static void Main(string[] args)

        {
            Ogrenci Ogr1 = new Ogrenci();
            Ogr1.ONo = 10;
            Ogr1.OAdSoyad = "Sedef KILIÇÇEKEN";
            Console.WriteLine("No={0},AdSoyad={1}", Ogr1.ONo, Ogr1.OAdSoyad);
            //yeni ogrenci
            Ogrenci ogr2 = new Ogrenci();
            ogr2 = Ogr1;
            Console.WriteLine("No={0},AdSoyad={1}", ogr2.ONo, ogr2.OAdSoyad);
            Console.ReadKey();
        }
    }
}
