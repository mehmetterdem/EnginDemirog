using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList<string> myList = new MyList<string>();
            //myList.Add("Gamze");
            //myList.Add("Mehmet");
            //Console.WriteLine(myList.Count);


            //Dictionary<int, string> keyValues = new Dictionary<int, string>();
            //keyValues.Add(1, "mehmet");
            //foreach (var item in keyValues)
            //{
            //    Console.WriteLine(item.Key + ") " + item.Value);
            //}
            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();
            dictionary.Add(1, "Mehmet");
            dictionary.Add(2, "Feride");
            Console.WriteLine(dictionary.Count);
            dictionary.List();
        }


      
    }



}
