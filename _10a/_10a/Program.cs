using System;

namespace _10a
{
    class Program
    {
        static void Main(string[] args)
        {
            //O método substring é um método não estático que permite pegarmos uma porção de uma string.
            //Para utilizarmos o método substring, basta chamar o método a partir de uma variável string 
            //ou mesmo de uma string literal, conforme o exemplo.
            string nome = "João Carlos Garcia Moreira";
            string nome2 = "Aleckssandra Becker";
            Console.WriteLine(nome.Substring(12,6));    //imprime Garcia
            Console.WriteLine();

            //O método IndexOf é utilizado para localizar uma determinada palavra dentro da string.
            //Este método retornará a posição da string desejada. Caso a string não seja encontrada, 
            //será retornado o valor - 1.
            Console.WriteLine(nome.IndexOf("Garcia"));  //imprime 12 posição inicial encontrada
            Console.WriteLine(nome.IndexOf("Farias"));  //imprime -1, pois não encontrou nada
            Console.WriteLine(nome2.IndexOf("ck"));     //imprime 3, posição inicial encontrada
            Console.WriteLine(nome2.IndexOf("ck",4));   //imprime 15, posição inicial encontrada após o 3
            Console.WriteLine();

            //As funções ToUpper e ToLower permitem colocar uma string em letra minúsculas ou maiúsculas, 
            //conforme o exemplo a seguir.
            Console.WriteLine(nome.ToUpper());      //imprime JOÃO CARLOS GARCIA MOREIRA
            Console.WriteLine(nome.ToLower());      //imprime joão carlos garcia moreira
            Console.WriteLine();

            //As funções startswith e endswith verificam se a string começo ou termina com uma determinada 
            //palavra ou caracter. Estas funções retornam um valor booleano(true ou false).
            string arquivo = "testeteste.dwg";
            if (arquivo.StartsWith("teste"))
            {
                Console.WriteLine("Começa com teste");
            }
            if (arquivo.EndsWith("dwg"))
            {
                Console.WriteLine("É arquivo do autocad");
            }
            Console.WriteLine();

            //As funções de Trim servem para remover espaços em branco das strings. 
            //A função TrimStart remove os espaços em branco do início da string, 
            //já a função TrimEnd remove os espaços em branco do final da string.
            //A função Trim remove os espaços em branco do inicio e do fim da string.
            string nome3 = " JOÃO MOREIRA ";
            Console.WriteLine("normal:    " + "-" + nome3 + "-");
            Console.WriteLine("TrimEnd:   " + "-" + nome3.TrimEnd() + "-");
            Console.WriteLine("TrimStart: " + "-" + nome3.TrimStart() + "-");
            Console.WriteLine("Trim:      " + "-" + nome3.Trim() + "-");
            Console.WriteLine();

            //As funções PadLeft e PadRight servem para preencher uma string a esquerda ou a direita 
            //com um caracter especificado. Os exemplos a seguir mostra o uso das funções PadLeft e PadRight.
            string nome4 = "joao";
            Console.WriteLine(nome4.PadRight(10,'x'));
            Console.WriteLine(nome4.PadLeft(10,'x'));
            Console.WriteLine();

            //A função Split serve para quebrar uma string em um array de strings de acordo com um separador.
            //Ao contrário da função split, a função Join concatena um array de string inserindo um separador.
            string linha = "João, R$ 20000.00, 45, 16/03/1974, programador e projetista";
            string[] campos = linha.Split(',');
            foreach (var item in campos)
            {
                Console.WriteLine(item.Trim());
            }
            Console.WriteLine();

            //A função String.Format é uma das funções mais versáteis da classe string.
            //Esta função permite a criação de uma string baseada em um padrão.Podemos colocar dentro do 
            //padrão da string de formatação alguns tokens que poderam ser substituídos por variáveis passadas 
            //por parâmetro no comando format.
            //No exemplo abaixo, o padrão da string(primeiro parâmetro) contém um token { 0}. 
            //Este token indica que este valor deve ser substituido pelo segundo parâmetro passado para a 
            //função(neste caso a palavra “parâmetro”), exemplo:
            string teste;
            teste = String.Format("Formatação com {0} parâmetro. Agora são {1}. Valor numérico: {2}", 1, DateTime.Now, 15.5);
            Console.WriteLine(teste);
            Console.WriteLine();

            //No exemplo acima, temos o padrão da string com mais de um token, com números de 0 à 2.
            //A função também recebe 3 parâmetros adicionais que correspondem aos valores que serão substituídos 
            //na string. Além de informarmos os tokens, podemos informar regras de formatação que serão utilizadas 
            //de acordo com o tipo de dado passado por parâmetro, conforme o exemplo,
            string Teste = String.Format("Custom Format: {0:d/M/yyy HH:mm:ss}", DateTime.Now) ;
            Console.WriteLine(teste);
            int iNumero = 1024;
            string sTeste = String.Format("Formatação do número inteiro: {0:D}.", iNumero);
            Console.WriteLine(sTeste);
            sTeste = String.Format("Formatação do número inteiro: {0:D4}.", iNumero);
            Console.WriteLine(sTeste);
        }
    }
}
