using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();

            isimler.Add("Mert");
            Console.WriteLine(isimler.Length);

            isimler.Add("Maral");

            Console.WriteLine(isimler.Length);

            foreach (var aaa in isimler.Items)
            {
                Console.WriteLine(aaa);
            }

        }
    }
}
