namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Metotlar tekrar tekrar kullanilabilirligi saglayan kod bloglaridir..

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 56;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------");

            }

            Console.WriteLine("----------METOTLAR-----------------");

            //instance = ornek
            //encapsulation deniyomus ekle2deki gibi yapmamalisin cunku yeni bir sey eklemeye karar verirsen tek tek degistirmen gerekli bu bir amelelik ve sen amele degilsin sevgiler 
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", "Yesil Armut", 12 ,3);
            sepetManager.Ekle2("Elma", "Yesil Elma", 12,8);
            sepetManager.Ekle2("Karpuz", "Yesil Karpuz", 12,6);

        }
    }
}