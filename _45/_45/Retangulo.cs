using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45
{
    class Retangulo
    {
        public int Largura;
        public int Altura;

        public int Area() {
            return this.Largura * this.Altura;
        }

        public int Perimetro()
        {
            return 2 * (this.Altura + this.Largura);
        }

        public double Diagonal()
        {
            return  Math.Sqrt((this.Altura * this.Altura) + (this.Largura * this.Largura));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("AREA = ");
            sb.AppendLine(this.Area().ToString("F2"));
            sb.Append("PERIMETRO = ");
            sb.AppendLine(this.Perimetro().ToString("F2"));
            sb.Append("DIAGONAL = ");
            sb.AppendLine(this.Diagonal().ToString("F2"));
            return sb.ToString();
        }
    }
}
