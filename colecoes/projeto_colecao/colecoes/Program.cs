using System;
using colecoes.Helper;

namespace colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] {6, 3, 8, 1, 9};
            int[] arrayCopia = new int[10];
            
            OperacoesArrays op = new OperacoesArrays();
            string[] arrayString = op.converterParaArrayString(array);
            System.Console.WriteLine(arrayString[0]);
            

            // int valor = 1;
            // bool existe = op.Existe(array, valor);
            // bool maior = op.todosMaiorQue(array, valor);
            
            // if(maior)
            // {
            //     System.Console.WriteLine("Todos os elementos são maiores que ", valor);
            // }
            // else
            // {
            //     System.Console.WriteLine("Nem todos são maiores que ", valor);
            // }

            // int indice = op.ObterIndice(array, valor);
            // if(indice > -1)
            // {
            //     System.Console.WriteLine("O indice do elemento {0} é {1}", valor, indice);
            // }
            // else
            // {
            //     System.Console.WriteLine("O valor procurado não foi encontrado");
            // }

            // System.Console.WriteLine($"Capacidade atual: {array.Length}");
            // op.redimensionarArray(ref array, 10);
            // System.Console.WriteLine($"Nova capacidade: {array.Length}");

            // if(existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor");
            // }


            // System.Console.WriteLine("Array Original");
            // op.ImprimirArray(array);

            // // op.OrdenarBubbleSort(ref array);
            // op.Ordenar(ref array);
            // Console.WriteLine("Array Ordenado");
            // op.ImprimirArray(array);

            // Console.WriteLine("Antes de copiar");
            // op.ImprimirArray(array);

            // op.Copiar(ref array, ref arrayCopia);
            // Console.WriteLine("Array após copiar");
            // op.ImprimirArray(arrayCopia);
            
            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = 30;

            // FOR - Normal
            // System.Console.WriteLine("For - Normal");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     Console.WriteLine($"posicao {i} - valor {arrayInteiros[i]}");
            // }

            // //FOR - Outro
            // System.Console.WriteLine("For - Outro");
            // int cont = 0;
            // foreach (var item in arrayInteiros)
            // {                
            //     System.Console.WriteLine($"posicao {cont} - valor {item}");
            //     cont++;
            // }

            // int[,] matriz = new int[4, 2]
            // {
            //     { 8, 8 },
            //     { 2, 3 },
            //     { 4, 5 },
            //     { 4, 6 }
            // };

            // for(int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for(int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine($"Linha: {i} coluna: {j} valor: {matriz[i,j]}");
            //     }
            // }



        }
    }    
}
