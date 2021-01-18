using ConsoleTables;
using ProductCatalog.Core.Contracts;
using ProductCatalog.Infrastructure.Data.Model;
using ProductCatalog.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalog.Pages
{
    public class ProductPage
    {
        private readonly IProductService productService;

        public ProductPage(IProductService _productService)
        {
            productService = _productService;
        }
        public void Show(Menu menu)
        {
            bool running = true;

            while (running)
            {
                running = menu.ProductMenu();
            }
        }

        public void List()
        {
            var products = productService.GetProducts();

            ConsoleTable.From(products)
                .Configure(o => o.NumberAlignment = Alignment.Right).Write();
        }

        public void Add()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Quantity: ");
            string quantity = Console.ReadLine();
            Console.Write("Price: ");
            string price = Console.ReadLine();

            try
            {
                Product product = new Product()
                {
                    Name = name,
                    Price = decimal.Parse(price),
                    Quantity = int.Parse(quantity)
                };

                productService.Save(product);

                Console.WriteLine("Product added successfuly");
            }
            catch (Exception)
            {

                Console.WriteLine("Product is not addeds");
            }
        }
    }
}
