namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Donguler bir seyleri tekrar etmek icin kullanilan yapilardir
            // i=sayac. 
            //i++ bir bir arttir demek 
            // i=i+2 veya i+=2 ikiser arttir demek 

            // Array []  = dizi 
            //birden fazla stringi ayni anda tutmak icin array[] kullan 

            string kurs1 = "yazilim";
            string kurs2 = "programlama";
            string kurs3 = "java";
          
            //array-dizi asagidaki gibidir.
            string[] kurslar = new string[] {"yazilim" , "programlama", " java" , "python" };

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitisi");

            //dizi temelli yapilari tek tek donmeye yarar
            foreach (string kurs  in kurslar) //kurslari tek tek dolas diyorum
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu - footer");

        }
    }
}