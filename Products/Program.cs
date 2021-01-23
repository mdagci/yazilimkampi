using System;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Products television = new Products();
            television.Name = "Awox";
            television.Price = 499.99;
            television.Id = 10;
            television.Stock = 12;

            ProductManager productManager = new ProductManager();
            productManager.Add(television);
            productManager.Remove(television);


        }
    }
}
