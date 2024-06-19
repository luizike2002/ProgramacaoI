using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace _240325_01___Aula_6.Models
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CRMV { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
    }
}