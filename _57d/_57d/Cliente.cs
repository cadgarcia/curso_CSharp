using System;
using System.Collections.Generic;
using System.Text;

namespace _57d
{
    class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }
        public char Sexo { get; set; }

        private bool _aprovado;

        public bool Aprovado
        {
            get { return _aprovado; }
        }

        private int _idade;

        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value > 18)
                {
                    _aprovado = true;
                }
                else
                {
                    _aprovado = false;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder() {
                sb.AppendLine("Cliente " + this.Nome + ",");
                sb.AppendLine("CPF: " + this.CPF + ",");
                
            }
        }
    }



}
}
