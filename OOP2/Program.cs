using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //MERT ORAK
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Mert";
            musteri1.Soyadi = "Orak";
            musteri1.TcNo = "333333";

            // Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "3467";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "22323";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


        }
    }
}
