using System.Collections.Generic;

namespace colecao_genericas.Helper
{
    public class OperacoesLista
    {
        public void imprimirListaString(List<string> Lista)
        {
            for(int i = 0; i < Lista.Count; i++)
            {
                System.Console.WriteLine(Lista[i]);
            }
        }
    }
}