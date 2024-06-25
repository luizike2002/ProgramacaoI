using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.Models;
using FoodApp.Repository;
using FoodApp.Utils;

namespace FoodApp.Controllers
{
    public class CustomerController
    {
        private CustomerRepository customerRepository;

        public CustomerController()
        {
            customerRepository = new CustomerRepository();
        }

        public void Insert(Customer customer)
        {
            customerRepository.Save(customer);
        }

        public Customer Get(int id)
        {
#pragma warning disable CS8603 

            return CustomerRepository.Retrieve(id);
#pragma warning restore CS8603 

        }

        public List<Customer> Get()
        {
            return CustomerRepository.Retrieve();
        }

        public List<Customer> GetByName(string name)
        {
            return CustomerRepository.RetrieveByName(name);
        }

        public bool ExportToDelimited()
        {
            List<Customer> list =
                CustomerRepository.Retrieve();

            string fileContent = string.Empty;
            foreach(var c in list)
            {
                fileContent += 
                    $"{c.PrintToExportDelimited()}\n";
            }

            string fileName = 
            $"Customer_{DateTimeOffset.Now.ToUnixTimeSeconds()}.txt";

            return ExportToFile.SaveToDelimitedTxt(fileName, fileContent);
        }

        public string ImportFromDelimited(string filePath, string delimiter)
        {
            bool result = true;
            string msgReturn = string.Empty;
            int lineCountSuccess = 0;
            int lineCountError = 0;
            int lineCountTotal = 0;

            try
            {
                if(!File.Exists(filePath))
                    return "ERRO: Arquivo de importação não encontrado.";

                using(StreamReader sr = new StreamReader(filePath))
                {
                    string line = string.Empty;
#pragma warning disable CS8600 
                    while ((line = sr.ReadLine()) != null)
                    {
                        lineCountTotal++; 

                        if(!customerRepository
                            .ImportFromTxt(line, delimiter))
                        {
                            result = false;
                            lineCountError++;
                        }
                        else
                        {
                            lineCountSuccess++;
                        }
                    }
#pragma warning restore CS8600 

                }
                
            }
            catch (System.Exception ex)
            {                                
                return $"ERRO: {ex.Message}";
            }

            if(result)
                msgReturn = "Dados importados com sucesso.";
            else
                msgReturn = "Dados parcialmente importados.";

            msgReturn += $"\nTotal de linhas: {lineCountTotal}";
            msgReturn += $"\nSucesso: {lineCountSuccess}";
            msgReturn += $"\nErro: {lineCountError}";

            return msgReturn;
        }
    }
}