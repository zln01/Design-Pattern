using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavukDünyasi
{
    public abstract class Frachising
    {
        protected double fiyat;

        public virtual double getFiyat()
        {
            return fiyat;
        }

        protected chefPolo chefMenu;

        public virtual void Chef_Polo(string tip)
        {
            chefPolo chef = this.chefSiparis(tip);
            chef.Kes();
            chef.Pisir();
            chef.servis_Et();
        }

        protected abstract chefPolo chefSiparis(string tip);
    }


    public class Istanbul_Polo : Frachising
    {
         public Istanbul_Polo()
        {
            fiyat = 10;
        }

        public override double getFiyat()
        {
            return fiyat;
        }
        protected override chefPolo chefSiparis(string tip)
        {
            if (tip == "kekikli")
            {
                chefMenu = new Kekiks();
            }
            else if (tip == "barbekulu")
            {
                chefMenu = new Barbeku();
            }

            return chefMenu;
        }
    }

    public class Yalova_Polo : Frachising
    {
        public Yalova_Polo()
        {
            fiyat = 15;
        }

        public override double getFiyat()
        {
            return fiyat;
        }

        protected override chefPolo chefSiparis(string tip)
        {
            if (tip == "biberli")
            {
                chefMenu = new Biberiye();
            }
            else if (tip == "begendili")
            {
                chefMenu = new Begendi();
            }

            return chefMenu;
        }
    }

    public class Kocaeli_Polo : Frachising
    {
        public Kocaeli_Polo()
        {
            fiyat = 13;
        }

        public override double getFiyat()
        {
            return fiyat;
        }

        protected override chefPolo chefSiparis(string tip)
        {
            if (tip == "karısık")
            {
                chefMenu = new Anadolu();
            }
            else if (tip == "acili")
            {
                chefMenu = new Kozbi();
            }

            return chefMenu;
        }
    }
}
