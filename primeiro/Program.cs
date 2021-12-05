using System;
using Enum;

namespace mynamespace;
    // o namespace é usado para organizar as classes
    
    public class Programa
    {
        static void Main()
        {
            Primeiro p = new Primeiro();
            p.nome = "primeiro";
            p.idade = 12;
            p.cpf = "000.000.000-00";
            Console.WriteLine(p.nome);
            Console.WriteLine(p.idade);
            Console.WriteLine(p.cpf);

            // maneira num 1 pra chamar um enum
            var pessoa = (Pessoas)0;

            // maneira num 2 pra chamar um enum
            Pessoas pessoa2 = Pessoas.Julia;

            Console.WriteLine(pessoa);
            Console.WriteLine(pessoa2);

        }
    }
