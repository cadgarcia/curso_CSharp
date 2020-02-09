using System;


namespace _60c
{
    public class Pessoa
    {
        public string Nome { get; private set; }

        public Pessoa()
        {

        }

        public Pessoa(string nome)
        {
            this.Nome = nome;
        }
    }
}
