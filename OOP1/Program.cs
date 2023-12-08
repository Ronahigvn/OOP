using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            Product product2 = new Product{ Id=2,CategoryId=5,UnitsInStock=5,ProductName="Kalem",UnitPrice=55};
           //PascalCase:Vocubulary first character is big
           //camelCase
           //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            productManager.Topla2(3, 6);
            int toplamaSonuc = productManager.Topla(3, 6);
            Console.WriteLine(toplamaSonuc*2);
            Console.ReadLine();


        }
    }
}
