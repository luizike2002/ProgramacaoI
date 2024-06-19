using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240325_01___Aula_6.Models
{
    public class Clinica
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public static int InstanceCount { get; set; }
        public int ObjectCount { get; set; }

        // Para listar + de um atendimento posterior ou atual
        // Representação a nivel de programa do Banco de Dados
        public List<Atendimento> Atendimentos { get; set; }
    }
}