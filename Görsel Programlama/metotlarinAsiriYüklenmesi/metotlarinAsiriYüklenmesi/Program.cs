using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlarinAsiriYüklenmesi
{
    class Program
    {
        static int toplam(int a, int b)
            {
                return a + b;
            }
            static int toplam(int a, int b, int c)
            {
                return a + b + c;
            }
            static double toplam(double a, double b)
            {
                return a + b;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Sonuç=" + toplam(5.8, 6.3));
                Console.WriteLine("Sonuç=" + toplam(5, 6, 7));
                Console.WriteLine("Sonuç={0}", toplam(3, 4));
                Console.ReadKey();
            }

        }
    }

