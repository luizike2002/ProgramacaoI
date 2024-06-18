using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp
{
    public class ProductView
    {
        
        private List<Product> products;

        public ProductView(List<Product> products)
        {
            this.products = products;
        }

        public void DisplayMenu()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("euComida - Produtos");
            Console.WriteLine("**********************");
            Console.WriteLine("1 - Adicionar Produto");
            Console.WriteLine("2 - Listar Produtos");
            Console.WriteLine("0 - Voltar");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    ListProducts();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        private void AddProduct()
        {
            Console.WriteLine("\nAdicionar Novo Produto:");
            Console.Write("ID do Produto: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome do Produto: ");
            string? name = Console.ReadLine();
            Console.Write("Preço do Produto: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            products.Add(new Product { ProductId = id, Name = name, Price = price });
            Console.WriteLine("Produto adicionado com sucesso!\n");
        }

        private void ListProducts()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Lista de Produtos");
            Console.WriteLine("**********************");
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.ProductId}, Nome: {product.Name}, Preço: {product.Price}");
            }
        }
    
    }
}