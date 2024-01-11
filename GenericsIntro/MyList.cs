using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor :ctor yazdigiinda altttaki yapi calisiyor. newledigin adna calisan yapidir.
        public MyList()
        {
            items = new T[0];  
        }
        public void Add (T item) 
        {
            //yeni eleman eklemek icin newlemek zorundasin,  eklediginde bir artar ama referans no 0 length yapinca 1 arttirabilirsin. boylece dinamik yapmis olursun. 
            //add ekleyip bir eleman daha eklersen 2 olouyor ama refasni tturman lazim o yuzden de gecici dizi yapmalisin bu da tempArray olur.
            //newledigin an referans numarasi alir yeni referans numarasi almasi eski referasnlarin ucmasi demek
            T[] tempArray = items;  //tempArray=gecici elemann
            items =new T[items.Length+1];

            //
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length -1] = item; 
        }    
    }
}
