using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 20;
            urun1.Aciklama = "Amasya Elmasi";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Product[] products = new Product[] { urun1, urun2 };
            foreach (var urun in products)

            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");
            }
            Console.WriteLine("-----Metodlar-----");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
        }
    }
}
