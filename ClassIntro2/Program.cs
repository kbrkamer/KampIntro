using System;

namespace ClassIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Bilgisayar";
            urun1.FirmaAdi = "HepsiBurada";
            urun1.UrunFiyati = 7000;

            Urun urun2 = new Urun();
            urun2.UrunAdi = " Telefon";
            urun2.FirmaAdi = "GittiGidiyor";
            urun2.UrunFiyati = 5000;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Tablet";
            urun3.FirmaAdi = "Trendyol";
            urun3.UrunFiyati = 2000;

            Urun[] urunler = new Urun [] {urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.FirmaAdi + " : " + urun.UrunFiyati );
            }



              
        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }

        public string FirmaAdi { get; set; }

        public int UrunFiyati { get; set; }

    }
}
