using System;

namespace ExemploPOO.models
{
    public class Pessoa
    {
        public string Nome {get; set; } 
        public int Idade { get; set; }
    
        public Pessoa()
        {
            this.Nome = "";
            this.Idade = 0;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu none é {Nome} e tenho {Idade} anos!");
        }
    
    }
}