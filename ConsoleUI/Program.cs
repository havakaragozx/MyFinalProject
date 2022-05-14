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
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var i in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(i.ProductName);
            }
        }
    }
}
