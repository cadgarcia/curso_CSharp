using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45b
{
    class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;
        public double NFinal;
        public string Status;

        public void CalculaNota()
        {
            this.NFinal = (((this.N1 * 30) + (this.N2 * 35) + (this.N2 * 35)) / 100);

            if (this.NFinal >= 60)
            {
                this.Status = "Aprovado";
            }
            else
            {
                this.Status = "Reprovado";
            }
        }

        public override string ToString()
        {
            if (this.Status == "Reprovado")
            {
                return "REPROVADO" + "\n" +
                    "Faltaram " + (60 - this.NFinal).ToString("F2") + " pontos"; 
            }
            else
            {
                return "APROVADO";
            }
        }
    }
}
