using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240318_01___Aula_5.Models
{
    public class Address
    {
        //Definiçaõ de 8 atributos
        public int AddressId {get; set;}
        public string Street {get; set;}
        public string District {get; set;}
        public int Number {get; set;}
        public string City {get; set;}
        public string FederalState {get; set;}
        public string Coutry {get; set;}
        public string ZipCode {get; set;}
        public AddressType AddressType {get; set;}

    }
    //Enum é uma especie de Objeto simplificado
    public enum AddressType
    {
        Commercial, Residential
    }
}