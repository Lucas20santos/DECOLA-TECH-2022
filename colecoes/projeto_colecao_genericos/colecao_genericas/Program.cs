using System;
using System.Collections.Generic;
using System.Linq;
namespace colecao_genericas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listas

            // List<string> estados = new List<string>();
            // estados.Add("PE");
            // estados.Add("PI");
            // estados.Add("BA");
            // estados.Add("MA");
            // estados.Add("AL");

            // Console.WriteLine($"Números de elementos: {estados.Count}");

            // // apresentados os valores da lista

            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine(item);
            // }

            // for(int i = 0; i < estados.Count; i++)
            // {
            //     System.Console.WriteLine($"indice - {i} valor - {estados[i]}");
            // }

            // Filas

            // Queue<string> fila = new Queue<string>();

            // // Adicionando elementos na fila

            // fila.Enqueue("Lucas");
            // fila.Enqueue("Fernando");
            // fila.Enqueue("Maria");

            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de {fila.Peek()} não remove da fila");
            //     System.Console.WriteLine($"Tirando da fila {fila.Dequeue()}");
            // }

            // var pilha = new Stack<string>();

            // pilha.Push("Livro 1");
            // pilha.Push("Livro 2");
            // pilha.Push("Livro 3");

            // while(pilha.Count > 0)
            // {
            //     System.Console.WriteLine($"Próximo livro: {pilha.Peek}");
            // }

            // Dicionários
            // Dictionary<string, string> estados = new Dictionary<string, string>();

            // estados.Add("PE", "Pernambuco");
            // estados.Add("BA", "Bahia");
            // estados.Add("CE", "Ceára");
            // estados.Add("AL", "Alagoas");

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");                
            // }

            // LINQ - Language-Integrated Query
            int[] arrayNumeros = new int[5] {1, 4, 8, 15, 19};

            // var numerosParesQury = 
            //     from num in arrayNumeros
            //     where num % 2 == 0
            //     ordemby num
            //     select num;

            var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            

            // System.Console.WriteLine("Numeros pares query : ".Join(", ", numerosParesQury));
            System.Console.WriteLine("Numeros pares métodos: ".Join(", ", numerosParesMetodo));
        }
    }
}
