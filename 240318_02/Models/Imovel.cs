using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240318_02___Atv_Aula_5.Models
{
    public class Imovel
    {
        public int ImovelId {get; set;}
        public string Nome {get; set;}
        public string Discretion {get; set;}
        public double Valor {get; set;}
        public int Comodos {get; set;}
        public LocalityType LocalityType {get; set;}
        public BusinessType BusinessType {get; set;}

        public bool Validate()
        {
            return true;
        }        
    }

    public enum LocalityType
    {
        Rural,
        Urbano
    }
    public enum BusinessType
    {
        Location,
        Venda
    }
}