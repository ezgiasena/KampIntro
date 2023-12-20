namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int, decimal, float, double, bool -> deger tipler
            //array, class, interface -> referans tipler
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = ?
        }
    }
}