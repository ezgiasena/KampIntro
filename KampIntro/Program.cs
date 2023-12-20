namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolarDun = 7.45;
            double dolarBugun = 7.67;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalis");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artis");
            }
            else
            {
                Console.WriteLine("degisim yok");
            }
        }
    }
}