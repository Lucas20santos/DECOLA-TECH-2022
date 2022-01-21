using System;
using Projeto2.models;
namespace Projeto2
{
    class Projeto2
    {

        static void Main(string[] args)
        {
            Console.Clear();
            // Pessoas p1 = new Pessoas("Lucas", "Santos");
            // p1.Apresentar();

            // Log log = new Log();

            Data data = new Data();
            data.setMes(2);
            data.ApresentarMes();
            data.setMes(20);
            data.ApresentarMes();

        }
    }
}
