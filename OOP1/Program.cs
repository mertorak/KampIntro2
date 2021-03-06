﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Masa";
            product1.CategoryId = 2;
            product1.UnitPrice = 400;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName="Kalem", UnitInStock=5 , UnitPrice=35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            Console.WriteLine("-----------");

            productManager.Topla2(2, 3);
            int toplamaSonuc = productManager.Topla(25, 43);
            Console.WriteLine(toplamaSonuc*2);
        }
    }
}
