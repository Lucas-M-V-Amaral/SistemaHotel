using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int IdPessoa { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }
        public string Profissao { get; set; }

        public Pessoa(string nome, int idPessoa, int idade, string genero, string profissao)
        {
            Nome = nome;
            IdPessoa = idPessoa;
            Idade = idade;
            Genero = genero;
            Profissao = profissao;
        }
    }
}
