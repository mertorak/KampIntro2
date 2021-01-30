using System;
using System.Collections.Generic;
using System.Text;

namespace OOP33
{
    class IhtiyacKredisi : IKrediYonetimi
    {
        public void BirSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Ihtiyaç kredisi hesaplandı");
        }
    }
}
