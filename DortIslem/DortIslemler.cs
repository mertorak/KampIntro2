using System;
using System.Collections.Generic;
using System.Text;

namespace DortIslem
{
    class DortIslemler
    {
        public void Topla(int sayi1, int sayi2) 
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç:" + toplam);
        }

        internal void Topla()
        {
            throw new NotImplementedException();
        }
    }
}
