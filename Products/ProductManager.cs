using System;
using System.Collections.Generic;
using System.Text;

namespace Products
{
    public class ProductManager
    {
        //CRUD operations (C:Create, R:Read, U:Update, D:Delete)
        public void Add(Products products)
        {
            Console.WriteLine(products.Name + " eklendi.");
        }

        public void Remove(Products products)
        {

            products.Stock -= 1;
            Console.WriteLine(products.Stock + " çıkarıldı.");
        }


    }
}
