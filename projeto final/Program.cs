using System;
using System.Collections.Generic;
using FoodApp.Models;

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
    }
    }
