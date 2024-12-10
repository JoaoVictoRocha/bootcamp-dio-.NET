using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_hospedagem_hotel.models
{
    public class Reserva
    {
        public Reserva() 
        {
            Hospedes = new List<Pessoa>();
            Suite = new Suite();
        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Hospedes = new List<Pessoa>();
            Suite = new Suite();
        }

        public List<Pessoa> Hospedes {set; get;}
        public Suite Suite {set; get;}
        public int DiasReservados {set; get;}

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            if (hospedes.Count <= Suite.Capacidade)
            {
                foreach( Pessoa hospede in hospedes)
                {
                    this.Hospedes.Add(hospede);
                }
            }
            else
            {
                throw new InvalidOperationException("Número de hóspedes excede a capacidade");
            }
        }
        
        public void CadastrarSuite(Suite suite)
        {
            this.Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (this.DiasReservados >= 10)
            {
                valor -= valor * 0.10M;
            }
            return valor;
        }
    }
}