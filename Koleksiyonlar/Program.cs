using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
            //ctrl+k+c yorum satiri yaoar 
            //ctrl+ k+u yorum satirindan cikartir
        {
            /*string[] isimler = new string[] { "ezgi", "asena", "aygul", "findik" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);*/

            /*isimler = new string[5];
            isimler[4] = "tuna";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);*/

            

            List<string> isimler2 = new List<string>("ezgi", "asena", "aygul", "findik");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("tuna");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);




        }
    }
}