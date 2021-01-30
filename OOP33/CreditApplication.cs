using System;
using System.Collections.Generic;
using System.Text;

namespace OOP33
{
    class CreditApplication
    {
        public void BasvuruYap(IKrediYonetimi krediYonetimi)
        {
            krediYonetimi.Hesapla();
        }
        public void OnBilgilendirmesiYap(List<IKrediYonetimi> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }

        }
    }
}
