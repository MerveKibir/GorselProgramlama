using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıflarAraba
{
    class Araba
    {
        private string renk;
        public Araba(string Renk)//KURUCU FONKSİYON OLUŞTURULDU. BUNUNLA NESNE OLUŞTURURKEN PARAMETREE GİRİLCEK.
        {
            this.renk = Renk;
        }
        public string renkNe ()
        {
            return "Bu araba " + renk;
        }

        public string Renk
        {
            get { return renk;}
            set { renk = value;}
        }
    }
}
