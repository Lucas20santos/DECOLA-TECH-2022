using System;
using System.Collections.Generic;

namespace colecao_genericas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listas

            List<string> estados = new List<string>();
            estados.Add("PE");
            estados.Add("PI");
            estados.Add("BA");
            estados.Add("MA");
            estados.Add("AL");

            Console.WriteLine($"Números de elementos: {estados.Count}");

            // apresentados os valores da lista

            foreach (var item in estados)
            {
                System.Console.WriteLine(item);
            }

            for(int i = 0; i < estados.Count; i++)
            {
                System.Console.WriteLine($"indice - {i} valor - {estados[i]}");
            }

            // Filas

            Queue<string> fila = new Queue<string>();

            // Adicionando elementos na fila

            fila.Enqueue("Lucas");
            fila.Enqueue("Fernando");
            fila.Enqueue("Maria");

            while (fila.Count > 0)
            {
                System.Console.WriteLine($"Vez de {fila.Peek()} não remove da fila");
                System.Console.WriteLine($"Tirando da fila {fila.Dequeue()}");
            }

            var pilha = new Stack<string>();

            pilha.Push("Livro 1");
            pilha.Push("Livro 2");
            pilha.Push("Livro 3");

            while(pilha.Count > 0)
            {
                System.Console.WriteLine($"Próximo livro: {pilha.Peek}");
            }


        }
    }
}
