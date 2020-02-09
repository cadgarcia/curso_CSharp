using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54
{
    class Carro
    {
        public string Modelo;
        int Portas;
        bool AirBag;
        bool ABS;
        string Cor;
        int Ano;

        public Carro()
        {

        }

        public Carro(string modelo) :this() {
            Modelo = modelo;
        }

        public Carro(int portas, string cor, int ano) :this() {
            Portas = portas;
            Cor = cor;
            Ano = ano;
        }
    }
}
