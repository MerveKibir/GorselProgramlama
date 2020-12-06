using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface Seriler//rehber sınıf
    {
        int BirSonraki();
        void reset();
        void BasAyarla(int x);
    }
    class Uygulama : Seriler//arayüzden kalıtım alan sınıf içinde fonksiyonlar tanımlandı
    {
        int ilk, deger;
        public Uygulama()//kurucu fonksiyon
        {
            ilk = deger = 0;
        }
        public int BirSonraki()//sonraki değeri bulduran  fonksiyon
        {
            deger += 2;
            return deger;
        }
        public void reset()//yapılanı sıfırlıyor
        {
            deger = ilk;
        }
        public void BasAyarla(int x)//parametreyi ilk değer olarak ayarlıyor
        {
            ilk = x;
            deger = ilk;

        }
    }
    public interface S : Seriler//ilk arayüzden kalıtım alan ikinci bir arayüz tanımladık
    {
        int met1();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uygulama u = new Uygulama();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Bir Sonraki=" + u.BirSonraki()); //bir sonraki fonksiyonu ile 5 değer yazdırılacak
            }
            Console.WriteLine("--------------");
            u.reset();//değer 0 oldu
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Bir Sonraki=" + u.BirSonraki());
            }
            Console.WriteLine("--------------");
            u.BasAyarla(100); //değer direk 100 yapıldı
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Bir Sonraki=" + u.BirSonraki());
            }
            Console.ReadKey();
        }
    }
}
