using System;

namespace Projeto2.models
{
    public class Pessoas
    {
        private string nome;
        private string sobrenome;

        public Pessoas()
        {
            this.nome = string.Empty;
            this.sobrenome = string.Empty;
        }

        public Pessoas(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {this.nome} {this.sobrenome}");
        }
    }
}