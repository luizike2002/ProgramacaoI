using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.Models;
using FoodApp.Data;

#pragma warning disable IDE0130 

namespace FoodApp.Repository
#pragma warning restore IDE0130 

{
    public class CustomerRepository
    {                
        /*
        public void Save(Customer customer)
        {
            customer.CustomerId = this.GetNextId();
            DataSet.Customers.Add(customer);
        }
        */

        public void Save(Customer customer, bool autoGenerateId = true)
        {
            if(autoGenerateId)
                customer.CustomerId = this.GetNextId();

            DataSet.Customers.Add(customer);
        }        

        public static Customer? Retrieve(int id)
        {            
            foreach(var c in DataSet.Customers)
            {
                if( c.CustomerId == id )                
                    return c;                
            }

            return null;
        }

        public static List<Customer> Retrieve()
        {
            return DataSet.Customers;
        }

        public static List<Customer> RetrieveByName(string name)
        {
            List<Customer> retorno = [];
            foreach(var c in DataSet.Customers)
            {
#pragma warning disable CS8602 
                if (c.Name.Contains(name))
                {
                    retorno.Add(c);
                }
#pragma warning restore CS8602 

            }

            return retorno;
        }

        public bool ImportFromTxt(string line, string delimiter)
        {
            if(string.IsNullOrWhiteSpace(line))
                return false;

            string[] data = line.Split(delimiter);

            if(data.Count() < 1)
                return false;

            Customer c = new Customer{
                CustomerId = Convert.ToInt32((data[0] == null ? 0 : data[0])),
                Name = (data[1] == null ? string.Empty : data[1]),
                EmailAddress = (data[2] ?? string.Empty)
            };

            Save(c, false);

            return true;
        }

        private int GetNextId()
        {
            int n = 0;
            foreach(var c in DataSet.Customers)
            {
                if(c.CustomerId > n)                
                    n = c.CustomerId;
            }

            return ++n;
        }        
    }
}