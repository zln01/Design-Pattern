using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavukDünyasi
{
    public abstract class Icecekler
    {
        protected string isim = "isimsiz";
        protected double fiyat;

        public virtual string getIsım()
        {
            return isim;
        }

        public virtual double getFiyat()
        {
            return fiyat;
        }
    }

     public class turkKahvesi : Icecekler
    {
        public turkKahvesi()
        {
            isim = "turk kahvesi ";
            fiyat = 3;
        }

        public override double getFiyat()
        {
            return fiyat;
        }

        public override string getIsım()
        {
            return isim;
        }
    }

    public class milkShake : Icecekler
    {
        public milkShake()
        {
            isim = " milk shake";
            fiyat = 4;
        }

        public override double getFiyat()
        {
            return fiyat;
        }

        public override string getIsım()
        {
            return isim;
        }
    }

    public class salgam : Icecekler
    {
        public salgam()
        {
            isim = "salgam";
            fiyat = 2;
        }

        public override double getFiyat()
        {
            return fiyat;
        }

        public override string getIsım()
        {
            return isim;
        }
    }

    public abstract class katkilar : Icecekler
    {
        protected double katkiFiyat = 0;
    }

    public class seker : katkilar
    {
        Icecekler ıcecek;
        public seker(Icecekler yeniIcecek)
        {
            ıcecek = yeniIcecek;
            katkiFiyat = 0.25;
        }

        public override double getFiyat()
        {
            return this.ıcecek.getFiyat()+ katkiFiyat;
        }

        public override string getIsım()
        {
            return this.ıcecek.getIsım()+ "seker";
        }
    }

    public class damlaSakızı : katkilar
    {
        Icecekler ıcecek;
        public damlaSakızı(Icecekler yeniIcecek)
        {
            ıcecek = yeniIcecek;
            katkiFiyat = 0.50;
        }

        public override double getFiyat()
        {
            return this.ıcecek.getFiyat() + katkiFiyat;
        }

        public override string getIsım()
        {
            return this.ıcecek.getIsım() + "damla sakızı";
        }
    }

    public class cikolata : katkilar
    {
        Icecekler ıcecek;
        public cikolata(Icecekler yeniIcecek)
        {
            ıcecek = yeniIcecek;
            katkiFiyat = 1.0;
        }

        public override double getFiyat()
        {
            return this.ıcecek.getFiyat() + katkiFiyat;
        }

        public override string getIsım()
        {
            return this.ıcecek.getIsım() + "cikolata";
        }
    }

    public class havuc : katkilar
    {
        Icecekler ıcecek;
        public havuc(Icecekler yeniIcecek)
        {
            ıcecek = yeniIcecek;
            katkiFiyat = 1.0;
        }

        public override double getFiyat()
        {
            return this.ıcecek.getFiyat() + katkiFiyat;
        }

        public override string getIsım()
        {
            return this.ıcecek.getIsım() + "havuc";
        }
    }

    public class acili : katkilar
    {
        Icecekler ıcecek;
        public acili(Icecekler yeniIcecek)
        {
            ıcecek = yeniIcecek;
            katkiFiyat = 1.0;
        }

        public override double getFiyat()
        {
            return this.ıcecek.getFiyat() + katkiFiyat;
        }

        public override string getIsım()
        {
            return this.ıcecek.getIsım() + "acili";
        }
    }
}
