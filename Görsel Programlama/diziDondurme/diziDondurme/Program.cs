using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziDondurme
{
    class Program
    {
        static int[] diziislem(int[] dizi1)
        {
            int[] dizi2 = new int[dizi1.Length];
            
            for (int i = 0; i < dizi2.Length; i++)
            {
                dizi2[i] = dizi1[i] + 5;
            }
            return dizi2;
        }
        static void Main(string[] args)
        {
            int[] dizi1 = { 3, 5, 7, 7, 65 };

            foreach (int i in diziislem(dizi1))
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
