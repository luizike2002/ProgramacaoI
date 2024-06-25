using FoodApp.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace FoodApp.Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            List<Product> products = new List<Product>();
            List<Order> orders = new List<Order>();

            bool continueRunning = true;

            do
            {
                Console.WriteLine("**********************");
                Console.WriteLine("euComida");
                Console.WriteLine("**********************");
                Console.WriteLine("1 - Clientes");
                Console.WriteLine("2 - Produtos");
                Console.WriteLine("3 - Pedidos");
                Console.WriteLine("4 - Exportar dados para arquivo JSON");
                Console.WriteLine("5 - Importar dados de arquivo JSON");
                Console.WriteLine("0 - SAIR");

                int menuOption = 0;

                try
                {
                    menuOption = Convert.ToInt32(Console.ReadLine());

                    switch (menuOption)
                    {
                        case 1:
                            CustomerView customerView = new CustomerView(customers);
                            customerView.DisplayMenu();
                            break;

                        case 2:
                            ProductView productView = new ProductView(products);
                            productView.DisplayMenu();
                            break;

                        case 3:
                            OrderView orderView = new OrderView(orders, customers, products);
                            orderView.DisplayMenu();
                            break;

                        case 4:
                            ExportData(customers, orders);
                            break;

                        case 5:
                            ImportData(customers, orders);
                            break;

                        case 0:
                            continueRunning = false;
                            Console.WriteLine("Obrigado e volte sempre!");
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Opção inválida. Digite um número correspondente ao menu.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }

            } while (continueRunning);
        }

        static void ExportData(List<Customer> customers, List<Order> orders)
        {
            try
            {
                string filePath = "data.json";

                Utils.ExportToFile(filePath, customers, orders);

                Console.WriteLine($"Dados exportados para o arquivo {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao exportar dados: {ex.Message}");
            }
        }

        static void ImportData(List<Customer> customers, List<Order> orders)
        {
            try
            {
                string filePath = "data.json";

                Utils.ImportFromFile(filePath, customers, orders);

                Console.WriteLine($"Dados importados do arquivo {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao importar dados: {ex.Message}");
            }
        }
    }

    internal class OrderView
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

        internal void DisplayMenu()
        {
            throw new NotImplementedException();
        }

    }


    public static class Utils
    {
        public static void ExportToFile(string filePath, List<Customer> customers, List<Order> orders)
        {
            using (StreamWriter file = File.CreateText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, new { customers, orders });
            }
        }

        public static void ImportFromFile(string filePath, List<Customer> customers, List<Order> orders)
        {
            using (StreamReader file = File.OpenText(filePath))
            {
                JsonSerializer serializer = new JsonSerializer();
                var data = (JObject)serializer.Deserialize(file, typeof(JObject));

            
                JArray customersArray = (JArray)data["Customers"];
                customers.Clear(); 
                customers.AddRange(customersArray.ToObject<List<Customer>>());

                JArray ordersArray = (JArray)data["Orders"];
                orders.Clear(); 
                orders.AddRange((IEnumerable<Order>)ordersArray.ToObject<List<Order>>());
            }
        }
    }

    internal class JObject
    {
    }


    internal class JArray
    {
        internal IEnumerable<Customer> ToObject<T>()
        {
            throw new NotImplementedException();
        }

    }


    internal class JsonSerializer
    {
        public JsonSerializer()
        {
        }

        internal JObject Deserialize(StreamReader file, Type type)
        {
            throw new NotImplementedException();
        }

        internal void Serialize(StreamWriter file, object value)
        {
            throw new NotImplementedException();
        }
    }

}
