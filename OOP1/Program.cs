 u sing System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();//101
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 15 };

            //PascalCase (Class)    //camelCase
            ProductManager productManager  = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


            //c# case sensetive code language





        }
    }
}
