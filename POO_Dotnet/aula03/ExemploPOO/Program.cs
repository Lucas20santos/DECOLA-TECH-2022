using System;
using ExemploPOO.models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Lucas";
            p1.Idade = 29;
            p1.Apresentar();
        }
    }
}