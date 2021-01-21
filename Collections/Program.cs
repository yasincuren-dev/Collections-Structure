using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Biz string değişkenli "isimler" adlı dizi oluşturduk. Daha sonra bunun içine 3 tane veri attık.
            //Biz daha sonra bu array'e eleman eklediğimizde hata veriyor. 
            //Yani arrayler oluşturulduktan sonra eleman ekleyemiyoruz. 
            //Bu yüzden bizde genelde C#'ta Collections yapısını kullanırız. Aşağıdaki List yapısını yani.

            string[] isimler = new string[] {"Kerem","Yasin","Ecem","Ender"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5]; //Biz böyle yaparak yukarıdaki array'i 5 elemanlı yapmayız da referansı değiştirerek başka bir array oluştururuz.
            isimler[4] = "İlker"; //Yeni oluşturduğumuz referansa da sadece 4. indekse "İlker" i attık.
            Console.WriteLine(isimler[4]); //İlker basar.
            Console.WriteLine(isimler[0]);//Fakat bu boş basar. Çünkü referansımızı değiştirdik. Yeni bir array oluşturduk gibi düşün.

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("\n");


            List<string> isimler2 = new List<string> {"Kerem","Yasin","Ecem","Ender"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);

        }
    }
}
