using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace araba
{
    class araba
    {

        protected string renk;
        protected string model;
        protected byte vites;
        public araba()
        {
            renk = model = " ";
            vites = 0;
        }
        public araba(string r, string m, byte v)
        {
            renk = r;
            model = m;
            vites = v;
        }
        public void Yaz()
        {
            Console.WriteLine("Renk={0}", renk);
            Console.WriteLine("Model={0}", model);
            Console.WriteLine("Vites={0}", vites);
        }
    }
    class kamyon : araba
    {
        bool damper;
        public kamyon(string r, string m, byte v, bool d) : base(r, m, v)
        {
            damper = d;
        }
        public void Yaz2()
        {
            base.Yaz();
            Console.WriteLine("Damper={0}", damper);

        }
        class Program
        {

            static void Main(string[] args)
            {
                araba A1 = new araba("Gri", "Ford Fiesta", 5);
                A1.Yaz();
                kamyon K1 = new kamyon("Sarı", "Fatih", 8, true);
                K1.Yaz2();
                Console.ReadKey();
            }
        }
    }
}
