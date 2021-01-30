using System;
using System.Collections.Generic;

namespace OOP33
{
    class Program
    {
        static void Main(string[] args)
        {
           // KonutKredisi konutKredisi = new KonutKredisi();
           // konutKredisi.Hesapla();
           // IhtiyacKredisi ihtiyacKredisi = new IhtiyacKredisi();
           // ihtiyacKredisi.Hesapla();
           // TasitKredisi tasitKredisi = new TasitKredisi();
            

            IKrediYonetimi tasitKredisi = new TasitKredisi();
            IKrediYonetimi ihtiyacKredisi = new IhtiyacKredisi();
            IKrediYonetimi konutKredisi = new KonutKredisi();


            CreditApplication creditApplication = new CreditApplication();
            // creditApplication.BasvuruYap(tasitKredisi);


            List<IKrediYonetimi> krediler = new List<IKrediYonetimi>() {ihtiyacKredisi,tasitKredisi };
            creditApplication.OnBilgilendirmesiYap(krediler);

        }
    }
}
