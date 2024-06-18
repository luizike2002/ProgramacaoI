using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp
{
    public class OrderView
    {
        private List<Order> orders;
        private List<Customer> customers;
        private List<Product> products;

        public OrderView(List<Order> orders, List<Customer> customers, List<Product> products)
        {
            this.orders = orders;
            this.customers = customers;
            this.products = products;
        }

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

            List<int> productIds = new List<int>();
            Console.WriteLine("IDs dos Produtos (separados por espaço): ");
            string?[] productIdStrings = Console.ReadLine().Split(' ');
            foreach (var id in productIdStrings)
            {
                productIds.Add(Convert.ToInt32(id));
            }

            orders.Add(new Order { OrderId = orderId, CustomerId = customerId, ProductIds = productIds, OrderDate = DateTime.Now });
            Console.WriteLine("Pedido criado com sucesso!\n");
        }

        private void ListOrders()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Lista de Pedidos");
            Console.WriteLine("**********************");
            foreach (var order in orders)
            {
                Console.WriteLine($"ID do Pedido: {order.OrderId}, ID do Cliente: {order.CustomerId}, Data: {order.OrderDate}");
                Console.WriteLine("Produtos:");
                foreach (var productId in order.ProductIds)
                {
                    var product = products.Find(p => p.ProductId == productId);
                    if (product != null)
                    {
                        Console.WriteLine($"- {product.Name} (R$ {product.Price})");
                    }
                }
            }
    }

}
}