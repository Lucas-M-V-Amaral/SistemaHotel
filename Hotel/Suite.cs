using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Suite
    {
        public int Numero { get; set; }
        public int Andar { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
        public bool Ocupacao { get; set; }

        public Suite(int numero, int andar, int capacidade, decimal valorDiaria)
        {
            Numero = numero;
            Andar = andar;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
            Ocupacao = false;
        }
    }
}
