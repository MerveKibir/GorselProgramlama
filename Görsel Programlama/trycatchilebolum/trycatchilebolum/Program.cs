using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatchilebolum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("bolunen sayiyi girin:");
            int bolunen = Convert.ToInt16(Console.ReadLine());
            Console.Write("bolen sayiyi girin:");
            int bolen = Convert.ToInt16(Console.ReadLine());
            try
            {
                Console.WriteLine("{0}/{1}={2}", bolunen, bolen, bolunen / bolen);
            }
            catch(Exception e)
            {
                Console.WriteLine("hata olustu:{0}", e);
            }
            finally
            {
                Console.WriteLine("basarili");
            }
            Console.ReadKey();
        }
    }
}
