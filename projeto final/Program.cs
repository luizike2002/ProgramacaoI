using System;
using System.Collections.Generic;
using System.IO; // Necessário para ler arquivos
using FoodApp.Models;
using FoodApp.Utils;

namespace FoodApp
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
                Console.WriteLine("4 - Importar Dados de Clientes"); // Nova opção para importar dados
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
                            ImportData(customers); // Chama a função de importação de dados
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

        static void ImportData(List<Customer> customers)
        {
            Console.WriteLine("\nImportar Dados de Clientes:");

            try
            {
                // Supondo que os dados dos clientes estão em um arquivo chamado "customers.txt" no formato "ID, Nome, Email"
                string filePath = "customer.txt";

                if (File.Exists(filePath))
                {
                    var lines = File.ReadAllLines(filePath);

                    foreach (var line in lines)
                    {
                        var data = line.Split(',');

                        if (data.Length == 3)
                        {
                            int id = Convert.ToInt32(data[0]);
                            string name = data[1].Trim();
                            string email = data[2].Trim();

                            customers.Add(new Customer { CustomerId = id, Name = name, EmailAddress = email });
                        }
                    }

                    Console.WriteLine("Dados importados com sucesso!\n");
                }
                else
                {
                    Console.WriteLine("Arquivo não encontrado.\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao importar dados: {ex.Message}\n");
            }
        }
    }
}
