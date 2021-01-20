using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                Id = 1,
                CategoryId = 2,
                ProductName = "Masa",
                UnitPrice = 500,
                UnitInStock = 3
            };
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice=35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            Console.WriteLine(product1.ProductName);

        }
    }
}
