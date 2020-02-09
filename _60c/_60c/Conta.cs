using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _60c
{
    public class Conta
    {
        public int Numero { get; private set; }
        public double Saldo { get; private set; }
        private Pessoa Titular { get; set; }

        public Conta(int numero, Pessoa titular)
        {
            this.Numero = numero;
            this.Titular = titular;
        }

        public Conta(int numero, Pessoa titular, double saldo) :this (numero, titular)
        {
            this.Saldo = saldo;
        }

        public override string ToString()
        {
            return "Conta " + this.Numero +
                ", Titular: " + this.Titular.Nome +
                ", Saldo: $" + this.Saldo.ToString("F2");
        }

        public void Depositar(double valor) {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (Saldo >= (valor))
            {
                valor += 5;
                Saldo -= valor;
            }
        }
    }
}
