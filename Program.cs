using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TavukDünyasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HOŞGELDİNİZ...");C:\Users\userpc\Desktop\Nihan\TavukDünyasi\TavukDünyasi\Program.cs
            int secim;
            Console.WriteLine("LÜTFEN KONUM SEÇİNİZ\n 1- ISTANBUL\n 2- KOCAELI\n 3- YALOVA");

            secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                Frachising frachising = new Istanbul_Polo();
                Console.WriteLine("KEKIKLI VE BARBEKÜLÜ MENÜLERDEN BİRİNİ SEÇİNİZ\n 1- KEKIKLI\n 2- BARBEKU\n");
                int menu;
                menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                    frachising.Chef_Polo("kekikli");
                    Console.WriteLine(string.Format("{0} TL", frachising.getFiyat()));
                }

                else if (menu == 2)
                {
                    frachising.Chef_Polo("barbekulu");
                    Console.WriteLine(string.Format("{0} TL", frachising.getFiyat()));
                }

                else
                    Console.WriteLine("LUTFEN TEKRAR GIRINIZ.");
            }

            else if (secim == 2)
            {
                Frachising frachising = new Kocaeli_Polo();
                Console.WriteLine("KARISIK VE ACILI MENÜLERDEN BİRİNİ SEÇİNİZ\n 1- KARISIK\n 2- ACILI");
                int menu;
                menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                    frachising.Chef_Polo("karisik");
                    Console.WriteLine(string.Format("{0} TL", frachising.getFiyat()));
                }

                else if (menu == 2)
                {
                    frachising.Chef_Polo("acili");
                    Console.WriteLine(string.Format("{0} TL", frachising.getFiyat()));
                }

                else
                    Console.WriteLine("LUTFEN TEKRAR GIRINIZ.");

            }
            else if (secim == 3)
            {
                Frachising frachising = new Yalova_Polo();
                Console.WriteLine("BIBERLI VE BEGENDİLİ MENÜLERDEN BİRİNİ SEÇİNİZ\n 1- BIBERLI\n 2- BEGENDILI");
                int menu;
                menu = Convert.ToInt32(Console.ReadLine());

                if (menu == 1)
                {
                    frachising.Chef_Polo("biberli");
                    Console.WriteLine(string.Format("{0} TL", frachising.getFiyat()));
                }

                else if (menu == 2)
                {
                    frachising.Chef_Polo("begendili");
                    Console.WriteLine(string.Format("{0} TL", frachising.getFiyat()));
                }

                else
                    Console.WriteLine("LUTFEN TEKRAR GIRINIZ.");
            }
            else
                Console.WriteLine("LÜTFEN TEKRAR GİRİNİZ");

            Console.WriteLine("ICECEK OLARAK NE ALIRSINIZ\n 1- TURK KAHVESI\n 2- MILKSHAKE\n 3- SALGAM\n 4-HICBIRSEY");
            int icecek;
            icecek = Convert.ToInt32(Console.ReadLine());

            if (icecek == 1)
            {
                Icecekler kahve = new turkKahvesi();
                Console.WriteLine("SEKERLİ VEYA DAMLA SAKIZLI TURK KAHVESİ ISTER MISINIZ\n 0-SADE\n 1- SEKERLI\n 2- DAMLA SAKIZLI");
                int katki;
                katki = Convert.ToInt32(Console.ReadLine());

                if (katki == 0)
                {
                    Console.WriteLine("SEKERSIZ KAHVE HAZIR");
                    Console.WriteLine(string.Format("{0} ,{1}", kahve.getIsım(), kahve.getFiyat()));
                }

                if (katki == 1)
                {
                    kahve = new seker(kahve);
                    Console.WriteLine("SEKERLI KAHVE HAZIR");
                    Console.WriteLine(string.Format("{0} ,{1}", kahve.getIsım(), kahve.getFiyat()));
                }

                if (katki == 2)
                {
                    kahve = new damlaSakızı(kahve);
                    Console.WriteLine("DAMLA SAKIZLI KAHVE HAZIR");
                    Console.WriteLine(string.Format("{0} ,{1}", kahve.getIsım(), kahve.getFiyat()));
                }
            }

            if (icecek == 2)
            {
                Icecekler milkshake = new milkShake();
                Console.WriteLine("CİKOLATALI MILKSHAKE ISTER MISINIZ\n 0-SADE 1- CIKOLATALI");
                int katki;
                katki = Convert.ToInt32(Console.ReadLine());

                if (katki == 0)
                {
                    Console.WriteLine("CIKOLATASIZ MILKSHAKE HAZIR");
                    Console.WriteLine(string.Format("{0} ,{1}", milkshake.getIsım(), milkshake.getFiyat()));
                }

                if (katki == 1)
                {
                    milkshake = new cikolata(milkshake);
                    Console.WriteLine("CIKOLATALI MILKSHAKE HAZIR");
                    Console.WriteLine(string.Format("{0} ,{1}", milkshake.getIsım(), milkshake.getFiyat()));
                }
            }

            if (icecek == 3)
            {
                Icecekler salgam = new salgam();
                Console.WriteLine("ACILI VEYA HAVUCLU SALGAM ISTER MISINIZ ISTER MISINIZ\n 0-SADE\n 1- ACILI\n 2- HAVUCLU");
                int katki;
                katki = Convert.ToInt32(Console.ReadLine());

                if (katki == 0)
                {
                    Console.WriteLine("STANDART SALGAM HAZIR");
                    Console.WriteLine(string.Format("{0} ,{1}", salgam.getIsım(), salgam.getFiyat()));
                }

                if (katki == 1)
                {
                    salgam = new acili(salgam);
                    Console.WriteLine("ACILI SALGAM HAZIR");
                    Console.WriteLine(string.Format("{0} ,{1}", salgam.getIsım(), salgam.getFiyat()));
                }

                if (katki == 2)
                {
                    salgam = new havuc(salgam);
                    Console.WriteLine("HAVUCLU SALGAM HAZIR");
                    Console.WriteLine(string.Format("{0} ,{1}", salgam.getIsım(), salgam.getFiyat()));
                }

                if (icecek==4)
                {
                    Console.WriteLine("ICECEK YOK.");
                }
            }
        }
    }
}
