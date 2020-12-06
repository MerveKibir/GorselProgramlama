using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizisiralama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizinin boyutunu giriniz:");
            byte N = Convert.ToByte(Console.ReadLine());
            int[] dizi = new int[N];
            for(int i =0;i<N;i++)
            {
                Console.WriteLine("dizi[{0}])=", i);
                dizi[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Dizi yazdirma:");
            foreach(int i in dizi)
            {
                Console.WriteLine(i);
            }
            int byk = dizi[0];
            int j = 1;
            int sira = 0;
            while(j<N)
            {
                if(dizi[j]>byk)
                {
                    byk = dizi[j];
                    sira = j;
                }
                j++;
            }
            Console.WriteLine("dizinin en büyük degeri " + byk + "indisi ise " + sira + " dir.");
            Console.ReadKey();
        }
    }
}
