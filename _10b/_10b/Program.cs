using System;

namespace _10b
{
    class Program
    {
        static void Main(string[] args)
        {
            //calma
            string nome = "João Adão Freitas Moreira";
            Console.WriteLine(nome.Substring(10,7));    //Freitas
            Console.WriteLine(nome.Substring(18));      //Moreira
            Console.WriteLine();

            nome = "Aleckssandra Becker";
            string procura = "ck";
            Console.WriteLine(nome.IndexOf("Garcia"));  //-1
            Console.WriteLine(nome.IndexOf(procura));      //3
            Console.WriteLine(nome.IndexOf(procura,4));    //15
            Console.WriteLine();

            nome = "Thiago Fogaça";
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome.ToLower());
            Console.WriteLine();

            nome = " João ";
            Console.WriteLine("-" + nome + "-");
            Console.WriteLine("-" + nome.TrimStart() + "-");
            Console.WriteLine("-" + nome.TrimEnd() + "-");
            Console.WriteLine("-" + nome.Trim() + "-");
            Console.WriteLine();

            Console.WriteLine(nome.Trim().PadLeft(10,'x'));
            Console.WriteLine(nome.Trim().PadRight(10,'x'));
            Console.WriteLine();

            string dados = "João Carlos, projetista, 45 anos, esposo de Aleckssandra Becker";
            string[] vet = dados.Split(',');

            foreach (var item in vet)
            {
                Console.WriteLine(item.Trim());
            }
            dados = "";
            dados = String.Join(' ', vet);
            Console.WriteLine(dados);
        }
    }
}
