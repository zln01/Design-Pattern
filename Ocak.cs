using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavukDünyasi
{
    class Ocak
    {
        
        private Boolean bos;
        private Boolean pisirmek;
        private static Ocak ocak;
        private Ocak()
        {
            bos = true;
            pisirmek = false;
        }

        public static Ocak ocakGetir()
        {
            if (ocak == null)
            {
                ocak = new Ocak();
            }
            return ocak;
        }

        private Boolean bosMu()
        {
            return bos;
        }

        private Boolean pisiyorMu()
        {
            return pisirmek;
        }

        public void doldur()
        {
            if (bosMu())
            {
                bos = false;
                Console.WriteLine("ocak dolu...");
            }
        }

        public void pisir()
        {
            if (!bosMu() && !pisiyorMu())
            {
                pisirmek = true;
                Console.WriteLine("pisiriliyor...");
            }
        }

        public void bosalt()
        {
            bos = true;
            pisirmek = false;
        }
    }
}
