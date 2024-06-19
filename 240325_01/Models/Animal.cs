using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace _240325_01___Aula_6.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Raca { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Nome { get; set; }
        public string NomeTutor { get; set; }
        public string FoneTutor { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }

        // Criando um Metodo de Validação

        public bool Validar()
        {
            var isValid = true;
            
            // Caso queira verificar se foi escrito um nome!!!
            // Deve Ser usado o "string".IsNullOrWhiteSpace();

            if( string.IsNullOrWhiteSpace(Nome) )
                isValid = false;

            if( string.IsNullOrWhiteSpace(NomeTutor) )
                isValid = false;

            return isValid;
        }
    }
}