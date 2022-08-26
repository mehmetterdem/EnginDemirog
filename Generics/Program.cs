using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Gamze");
            myList.Add("Mehmet");
            Console.WriteLine(myList.Count);
            
        }
    }
}
