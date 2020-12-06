using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sesliharfbulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet = 0;
            string cumle = Convert.ToString(Console.ReadLine());
            for (int i = 0; i< cumle.Length;i++)
                {
                if (cumle[i] == 'a'|| cumle[i] == 'e'  || cumle[i] == 'i' || cumle[i] == 'o' || cumle[i] == 'ö' || cumle[i] == 'u' || cumle[i] == 'ü')
                { adet++; }
                }
            Console.WriteLine("sesli harf sayısı=" + adet);
        }
    }
}
