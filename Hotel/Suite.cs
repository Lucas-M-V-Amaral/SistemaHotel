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
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
        public bool Ocupacao { get; set; }

        public Suite(int numero, int capacidade, decimal valorDiaria)
        {
            Numero = numero;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
            Ocupacao = false;
        }
    }
}
