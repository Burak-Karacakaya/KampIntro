using System;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself
            string kategoriEtiketi = "Kategoriler"; //kategoriEtiketi = Değer tutucu, alias, etiket
            int ogrenciSayısı = 3200;
            double notOrtalaması = 2.55;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");


            }



            if (sistemeGirisYapmisMi == true)
                {
                    Console.WriteLine("Kullanıcı ayarları butonu");

                }
                else
                {
                    Console.WriteLine("Giriş yap butonu");

                }
            



        Console.WriteLine(kategoriEtiketi);




        }
    }
}
