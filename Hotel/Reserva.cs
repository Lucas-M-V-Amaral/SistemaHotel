using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Reserva
    {
        public Pessoa Cliente { get; set; }
        public Suite SuiteReservada { get; set; }
        public DateOnly InicioReserva { get; set; }
        public DateOnly FimReserva { get; set; }
        public decimal ValorTotal { get; set; }

        /*public Reserva(Pessoa cliente, Suite suiteReservada, DateOnly inicioReserva, DateOnly fimReserva)
        {
            Cliente = cliente;
            SuiteReservada = suiteReservada;
            InicioReserva = inicioReserva;
            FimReserva = fimReserva;
        }*/


    }
}
