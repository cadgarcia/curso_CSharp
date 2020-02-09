using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60
{
    public class Conta
    {
        private int Numero { get; set; }
        private double Saldo { get; set; }
        private Pessoa Titular { get; set; }

        public Conta(int numero, Pessoa titular)
        {
            this.Numero = numero;
            this.Titular = titular;
        }

        public Conta(int numero, Pessoa titular, double saldo)
        {
            this.Saldo = Saldo;
        }

        public override string ToString()
        {
            return "Conta " + this.Numero +
                ", Titular: " + this.Titular.Nome +
                ", Saldo: " + this.Saldo.ToString("F2");
        }
    }
}
