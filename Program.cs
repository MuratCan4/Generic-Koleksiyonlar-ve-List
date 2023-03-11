using System;

namespace generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayi_Listesi = new List<int>();

            sayi_Listesi.Add(22);
            sayi_Listesi.Add(2);
            sayi_Listesi.Add(95);
            sayi_Listesi.Add(48);

            List<string> isim_Listesi = new List<string>();

            isim_Listesi.Add("Ahmet");
            isim_Listesi.Add("Mehmet");
            isim_Listesi.Add("Bahadır");
            isim_Listesi.Add("Serhat");

            Console.WriteLine(sayi_Listesi.Count);
            Console.WriteLine(isim_Listesi.Count);

            foreach (int sayilar in sayi_Listesi)
                Console.WriteLine(sayilar);

            foreach (string isimler in isim_Listesi)
                Console.WriteLine(isimler);

            sayi_Listesi.Remove(22);
            isim_Listesi.Remove("Ahmet");
            sayi_Listesi.RemoveAt(2);
            isim_Listesi.RemoveAt(2);

            sayi_Listesi.ForEach(sayilar => Console.WriteLine(sayilar));
            isim_Listesi.ForEach(isimler => Console.WriteLine(isimler));

            if (sayi_Listesi.Contains(95))
            Console.WriteLine("95 sayısı bulundu");

            string[] hayvan = {"Kedi,Köpek,İnek,Maymun"};
            List<string> hayvanListesi = new List<string>(hayvan);
            hayvanListesi.Clear();

            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Murat";
            kullanici1.Soyİsim = "Can";
            kullanici1.Yas = 28;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Meltem";
            kullanici2.Soyİsim = "Daglaroglu";
            kullanici2.Yas = 26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar(){
                Isim = "Hakan",
                Soyİsim = "Deniz",
                Yas = 22,
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı = "+kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı = "+kullanici.Soyİsim);
                Console.WriteLine("Kullanıcı Yaşı = "+kullanici.Yas);
            }
        }

        public class Kullanicilar
        {
            private string isim;
            private string soyİsim;
            private int yas;

            public string Isim { get => isim; set => isim = value; }
            public string Soyİsim { get => soyİsim; set => soyİsim = value; }
            public int Yas { get => yas; set => yas = value; }
        }
    }
}