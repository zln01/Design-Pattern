using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavukDünyasi
{
    public abstract class chefPolo
    {
        protected double fiyat;

        public virtual double getFiyat()
        {
            return fiyat;
        }

        public virtual void Kes()
        {
            Console.WriteLine("Chef Polo kesildi");
        }

        public virtual void Pisir()
        {
            Ocak o = Ocak.ocakGetir();
            o.doldur();
            o.pisir();
            Console.WriteLine("Chef Polo pisirildi");
        }

        public virtual void servis_Et()
        {
            Console.WriteLine("Chef Polo servis edildi");
            Ocak o = Ocak.ocakGetir();
            o.bosalt();
        }
    }

    public class Kekiks : chefPolo
    {
       

        public override void Kes()
        {
            Console.WriteLine("Tavuklar küp küp kesildi");
        }

        public override void Pisir()
        {
            Ocak o = Ocak.ocakGetir();
            o.doldur();
            o.pisir();
            Console.WriteLine("Tavuklar güvecte pisirildi");
        }

        public override void servis_Et()
        {
            Console.WriteLine("Kekiks servis edildi");
            Ocak o = Ocak.ocakGetir();
            o.bosalt();
        }
    }

    public class Biberiye : chefPolo
    {
        public override void Kes()
        {
            Console.WriteLine("Tavuklar uzun uzun kesildi");
        }

        public override void Pisir()
        {
            Ocak o = Ocak.ocakGetir();
            o.doldur();
            o.pisir();
            Console.WriteLine("Tavuklar kisik ateste pisirildi");
        }

        public override void servis_Et()
        {
            Console.WriteLine("Biberiye servis edildi");
            Ocak o = Ocak.ocakGetir();
            o.bosalt();
        }
    }

    public class Anadolu : chefPolo
    {
        public override void Kes()
        {
            Console.WriteLine("Tavuklar kalın kalın kesildi");
        }

        public override void Pisir()
        {
            Ocak o = Ocak.ocakGetir();
            o.doldur();
            o.pisir();
            Console.WriteLine("Tavuklar harlı ateste pisirildi");
        }

        public override void servis_Et()
        {
            Console.WriteLine("Anadolu servis edildi");
            Ocak o = Ocak.ocakGetir();
            o.bosalt();
        }
    }

    public class Begendi : chefPolo
    {
        public override void Kes()
        {
            Console.WriteLine("Tavuklar begendiyle kesildi");
        }

        public override void Pisir()
        {
            Ocak o = Ocak.ocakGetir();
            o.doldur();
            o.pisir();
            Console.WriteLine("Tavuklar haslanarak pisirildi");
        }

        public override void servis_Et()
        {
            Console.WriteLine("Begendi servis edildi");
            Ocak o = Ocak.ocakGetir();
            o.bosalt();
        }
    }

    public class Kozbi : chefPolo
    {
        public override void Kes()
        {
            Console.WriteLine("Tavuklar ince ince kesildi");
        }

        public override void Pisir()
        {
            Ocak o = Ocak.ocakGetir();
            o.doldur();
            o.pisir();
            Console.WriteLine("Tavuklar fırında pisirildi");
        }

        public override void servis_Et()
        {
            Console.WriteLine("Közbi servis edildi");
            Ocak o = Ocak.ocakGetir();
            o.bosalt();
        }
    }

    public class Barbeku : chefPolo
    {
        public override void Kes()
        {
            Console.WriteLine("Tavuklar köfte gibi kesildi");
        }

        public override void Pisir()
        {
            Ocak o = Ocak.ocakGetir();
            o.doldur();
            o.pisir();
            Console.WriteLine("Tavuklar güvecte pisirildi");
        }

        public override void servis_Et()
        {
            Console.WriteLine("Barbeku servis edildi");
            Ocak o = Ocak.ocakGetir();
            o.bosalt();
        }
    }
}
