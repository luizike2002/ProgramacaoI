using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240318_01___Aula_5.Models
{
    public class Custumer
    {
        //Definição de 5 Atributos
        public int CustumerId {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public DateTime BirthDate {get; set;}
        public string EmailAdress {get; set;}

        //public Address Address1 {get; set;}
        //public Address Address2 {get; set;}

        //Atributo para lista de endereços
        public List<Address> Addresses = new List<Address>();

        //Metodos
        public bool Validate()
        {
            return true;
        }
    }
}
