using System;
using VisioForge.Libs.MediaFoundation.OPM;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself
            string kategoriEtiketi = "Kategoriler"; //kategoriEtiketi = Değer tutucu,etiket
            int ogrenciSayısı = 3200;
            double notOrtalaması = 2.55;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            string nameOfStudents = "burak";
            char nameFirstCharacter = 'B';


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
            



        //Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(nameOfStudents);
            Console.WriteLine(dolarBugun);




        }
    }
}
