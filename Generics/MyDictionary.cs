using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyDictionary<T,K>
    {
        KeyValuePair<T,K>[] items;

       public MyDictionary()
        {
            items = new KeyValuePair<T, K>[0];
        }

        public void Add(T key, K value)
        {
        
            if (Control(key))
            {
                KeyValuePair<T, K>[] tempArray = items;
                items = new KeyValuePair<T, K>[items.Count() + 1];

                for (int i = 0; i < tempArray.Length; i++)
                {
                    items[i] = tempArray[i];
                }
                items[items.Count() - 1] = new KeyValuePair<T, K>(key, value);
            }
            else
            {
                Console.WriteLine("Bu kayıt daha önceden eklenmiştir");
            }
            
        }

        public void List()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }
        }

        public bool Control(T key)
        {
            bool control = true;
            foreach (var item in items)
            {

                if (item.Key.ToString()==key.ToString())
                {

                     control = false;

                }
                
            }
            return control;
        }
       

        public int Count
        {
            get { return items.Count(); }
          
        }

    }
}
