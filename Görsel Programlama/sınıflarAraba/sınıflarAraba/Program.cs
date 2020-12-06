using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıflarAraba
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba;
            araba = new Araba("kırmızı");
            Console.WriteLine(araba.renkNe());
            araba = new Araba("sarı");
            Console.WriteLine(araba.Renk);
            araba.Renk = "yesil";
            Console.WriteLine(araba.Renk);
            Console.ReadLine();
        }
    }
}
