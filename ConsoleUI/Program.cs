using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Product();

            //Category();


        }

        private static void Category()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void Product()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var i in productManager.GetProductDetails())
            {
                Console.WriteLine(i.ProductName + "/" + i.CategoryName);
            }
        }
    }
}
