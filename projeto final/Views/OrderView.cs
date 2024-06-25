using System;
using System.Collections.Generic;
using FoodApp.Models;

#pragma warning disable IDE0130 
namespace FoodApp
#pragma warning restore IDE0130 

{
    public class OrderView(List<Order> orders, List<Customer> customers, List<Product> products)
    {
        private readonly List<Order> orders = orders;
#pragma warning disable IDE0052 

        private readonly List<Customer> customers = customers;
#pragma warning restore IDE0052 

        private readonly List<Product> products = products;

        public void DisplayMenu()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("euComida - Pedidos");
            Console.WriteLine("**********************");
            Console.WriteLine("1 - Adicionar Pedido");
            Console.WriteLine("2 - Listar Pedidos");
            Console.WriteLine("0 - Voltar");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddOrder();
                    break;
                case 2:
                    ListOrders();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        private void AddOrder()
        {
            Console.WriteLine("\nCriar Novo Pedido:");
            Console.Write("ID do Pedido: ");
            int orderId = Convert.ToInt32(Console.ReadLine());
            Console.Write("ID do Cliente: ");
            int customerId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome do Cliente: ");
#pragma warning disable CS8600 

            string customerName = Console.ReadLine();
#pragma warning restore CS8600 


            List<int> productIds = new List<int>();
            Console.WriteLine("IDs dos Produtos (separados por espaço): ");
#pragma warning disable CS8602 

            string[] productIdStrings = Console.ReadLine().Split(' ');
#pragma warning restore CS8602 

            foreach (var id in productIdStrings)
            {
                productIds.Add(Convert.ToInt32(id));
            }

#pragma warning disable CS8601 

            orders.Add(new Order { OrderId = orderId, CustomerId = customerId, CustomerName = customerName, ProductIds = productIds, OrderDate = DateTime.Now });
#pragma warning restore CS8601 

            Console.WriteLine("Pedido criado com sucesso!\n");
        }

        private void ListOrders()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Lista de Pedidos");
            Console.WriteLine("**********************");
            foreach (var order in orders)
            {
                Console.WriteLine($"ID do Pedido: {order.OrderId}, ID do Cliente: {order.CustomerId}, Nome do Cliente: {order.CustomerName}, Data: {order.OrderDate}");
                Console.WriteLine("Produtos:");
#pragma warning disable CS8602 

                foreach (var productId in order.ProductIds)
                {
                    var product = products.Find(p => p.ProductId == productId);
                    if (product != null)
                    {
                        Console.WriteLine($"- {product.Name} (R$ {product.Price})");
                    }
                }
#pragma warning restore CS8602 

            }
        }
    }
}
