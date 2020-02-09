using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45a
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return (this.SalarioBruto - this.Imposto);
        }

        public void AumentarSalario(double percentual)
        {
            percentual /= 100.0;
            percentual += 1;
            this.SalarioBruto *= percentual;
        }

        public override string ToString()
        {
            return "Funcionario: " +
                this.Nome +
                ", $ " +
                this.SalarioLiquido().ToString("F2");
            Console.WriteLine();
        }
    }
}
