﻿using Business.Concrete;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{   //SOLID
    /* Open Closed Principle--yeni bir özellik ekliyorsan
     mevcuttaki hiç bir koduna dokunamazsın */
    class Program
    {
        static void Main(string[] args)
        {
           // ProductTest();
            //IoC
            //CategoryTest();
            //GetAllByCategoryIdTest();

            GetById(); //çalışmıyor

        }

        private static void GetById()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetById(5);

            Console.WriteLine(result.Data);
            Console.WriteLine(productManager.GetById(5).Data);
        }
      
        private static void GetAllByCategoryIdTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));
            foreach (var product in productManager.GetAllByCategoryId(2).Data)
            {
                Console.WriteLine(product.ProductName + " / " + product.CategoryId);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " / " + 
                        product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
