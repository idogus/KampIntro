using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product apple = new Product();
            apple.Name = "Elma";
            apple.Price = 15;
            apple.Description = "Amasya Elması";

            Product watermelon = new Product
            {
                Name = "Karpuz",
                Price = 80,
                Description = "Velimeşe Karpuzu"
            };

            Product[] products = new Product[] { apple, watermelon };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("================");
            }
        }
    }
}