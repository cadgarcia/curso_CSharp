using System;

namespace _89
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG     ";
            string nada = "";

            //copiando e alterando pra maiuscula
            string maior = original.ToUpper();
            Console.WriteLine("-" + maior + "-");

            //copiando e alterando pra minusculo
            string menor = original.ToLower();
            Console.WriteLine("-" + menor + "-");

            //copiando e trinando
            string podado = original.Trim();
            Console.WriteLine("-" + podado + "-");

            //procura pela primeira ocorrência
            int n1 = original.IndexOf("bc");
            Console.WriteLine(n1);

            //procura pela ultima ocorrência
            int n2 = original.LastIndexOf("bc");
            Console.WriteLine(n2);

            //recortar uma string
            string parcial = original.Substring(5);
            Console.WriteLine(parcial);

            //recortar uma string
            string parcial2 = original.Substring(6, 5);
            Console.WriteLine(parcial2);

            //substituir um char
            string troca = original.Replace('A', 'X');
            Console.WriteLine(troca);

            //substituir uma string
            string troca2 = original.Replace("abc", "xyz");
            Console.WriteLine(troca2);

            //testando se a string é nula ou vazia
            bool vazia = String.IsNullOrEmpty(troca2);
            Console.WriteLine(vazia);
            vazia = String.IsNullOrEmpty(nada);
            Console.WriteLine(vazia);

            //testando se a string é nula ou com espaços em branco
            bool branco = String.IsNullOrWhiteSpace(troca2);
            Console.WriteLine(branco);
        }
    }
}
