using System;

namespace odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.urunAdi = "Sus Barbatus";
            urun1.urunYazari = "Faruk Duman";
            urun1.urunFiyati = 29.40;

            Urun urun2 = new Urun();
            urun2.urunAdi = "Bizans Kaçkınları";
            urun2.urunYazari = "Muzaffer Özgüleş";
            urun2.urunFiyati = 11.20;

            Urun urun3 = new Urun();
            urun3.urunAdi = "Aşk İçin";
            urun3.urunYazari = "Robert Creeley";
            urun3.urunFiyati = 16.80;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.urunAdi + ":" + urun.urunYazari + ":" + urun.urunFiyati);
            }
            Console.WriteLine("-------------------------------------------------");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunAdi+":"+urunler[i].urunYazari+":"+urunler[i].urunFiyati);
            }
            Console.WriteLine("-------------------------------------------------");

            int j = 0;
            while (j<urunler.Length)
            {
                Console.WriteLine(urunler[j].urunAdi + ":" + urunler[j].urunYazari + ":" + urunler[j].urunFiyati);
                j++;
            }
        }
    }
    class Urun
    {
        public string urunAdi { get; set; }
        public string urunYazari { get; set; }
        public double urunFiyati { get; set; }
    }
}
