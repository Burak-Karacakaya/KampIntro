using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "1234";
            musteri1.Adi = "Burak";
            musteri1.Soyadi = "Karacakaya";
            musteri1.TcNo = "123123123123";
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "3453";
            musteri2.SirketAdi = "Kodlama";
            musteri2.VergiNo = "1234123541345345";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);











        }
    }
}
