using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.Models;
using FoodApp.Repository;
using FoodApp.Utils;

namespace FoodApp.Controllers
{
    public class OrderController
    {
        private OrderRepository OrderRepository;

        public OrderController()
        {
            OrderRepository = new OrderRepository();
        }

        public void Insert(Order Order)
        {
            OrderRepository.Save(Order);
        }

        public Order Get(int id)
        {            
            return OrderRepository.Retrieve(id);
        }

        public List<Order> Get()
        {
            return OrderRepository.Retrieve();
        }

        public List<Order> GetByName(string name)
        {
            return OrderRepository.RetrieveByName(name);
        }

        public bool ExportToDelimited()
        {
            List<Order> list = 
                OrderRepository.Retrieve();

            string fileContent = string.Empty;
            foreach(var c in list)
            {
                fileContent += 
                    $"{c.PrintToExportDelimited()}\n";
            }

            string fileName = 
            $"Order_{DateTimeOffset.Now.ToUnixTimeSeconds()}.txt";

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

                        if(!OrderRepository
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