﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            //product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName + "eklendi . ");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi . ");

        }

        //test
        //public void BiSeyYap(int sayi)
        //{
        //sayi = 99;
        //}

    }
}
