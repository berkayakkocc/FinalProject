﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
            //GetProductDetails();
        }

        private static void GetProductDetails()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + " / " + item.CategoryName);
                }
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll().Data)
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetAll();
            Console.WriteLine(result.Data);
            //if (result.Success)
            //{
            //    foreach (var item in result.Data)
            //    {
            //        Console.WriteLine(item.ProductName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


        }
    }
}
