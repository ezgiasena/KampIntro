using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //naming convention = isimlendirme
        // () -> gorursen orada metot calisiyor demektir
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi: " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("sepete eklendi:" + urunAdi);
        }

    }
}
