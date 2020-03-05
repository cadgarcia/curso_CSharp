using System;
using System.Collections.Generic;
using System.Text;

namespace _57c
{
    class Carro
    {
        public string Modelo { get; set; }
        public int QtdePortas { get; set; } = 2;

        public double Valor { get; private set; } = 50000;

        private int _desconto;

        public int Desconto {
            get {
                return _desconto;
            }
            set {
                if (value < 15)
                {
                    _desconto = value;
                }
            }
        }

        public Carro(string modelo, int qtdePortas, int desconto)
        {
            Modelo = modelo;
            QtdePortas = qtdePortas;
            Desconto = desconto;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Modelo: " + this.Modelo + ", " + this.QtdePortas + " portas, R$ " + this.Valor);
            return sb.ToString();
        }
    }
}
