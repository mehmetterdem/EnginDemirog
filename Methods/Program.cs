using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.ProductName = "Elma";
            product.Price = 15;
            product.Description = "Amasya elması";

            Product product2 = new Product();
            product2.ProductName = "Karpuz";
            product2.Price = 20;
            product2.Description = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product,product2 };

            foreach (var item in products)
            {
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Description);
                Console.WriteLine("-------------------");
            }
            



            Console.WriteLine("----------Methodlarr-----------");

            SepetManager manager = new SepetManager();
            manager.Add(product);
            manager.Add(product2);

        }
    }
}
