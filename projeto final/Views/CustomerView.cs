using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.Models;

namespace FoodApp
{
    public class CustomerView
    {
        
         private List<Customer> customers;

        public CustomerView(List<Customer> customers)
        {
            this.customers = customers;
        }

        public void DisplayMenu()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("euComida - Clientes");
            Console.WriteLine("**********************");
            Console.WriteLine("1 - Adicionar Cliente");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("0 - Voltar");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddCustomer();
                    break;
                case 2:
                    ListCustomers();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        private void AddCustomer()
        {
            Console.WriteLine("\nAdicionar Novo Cliente:");
            Console.Write("ID do Cliente: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome do Cliente: ");
            string? name = Console.ReadLine();
            Console.Write("Email do Cliente: ");
            string? email = Console.ReadLine();

            customers.Add(new Customer { CustomerId = id, Name = name, EmailAddress = email });
            Console.WriteLine("Cliente adicionado com sucesso!\n");
        }

        private void ListCustomers()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("Lista de Clientes");
            Console.WriteLine("**********************");
            foreach (var customer in customers)
            {
                Console.WriteLine($"ID: {customer.CustomerId}, Nome: {customer.Name}, Email: {customer.EmailAddress}");
            }
        }
    }
}