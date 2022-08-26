using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 2;
            product.ProductName = "Masa";
            product.UnitPrice = 1000;
            product.UnitInStock = 3;

            Product product1 = new Product
            {
                Id = 2,
                CategoryId = 3,
                ProductName = "Sandalye",
                UnitPrice = 250,
                UnitInStock = 25
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product);
            productManager.Add(product1); 
        }
    }
}
