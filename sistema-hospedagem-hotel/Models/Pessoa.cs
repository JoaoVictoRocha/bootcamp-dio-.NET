using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_hospedagem_hotel.models
{
    public class Pessoa
    {
        public Pessoa() {}
        public Pessoa(string nome) 
        {
            this.Nome = nome;
        }
        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
    }
}