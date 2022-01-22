using System;
using Projeto2.models;
namespace Projeto2
{
    class Projeto2
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            Console.Clear();
            
            // Operacao op = Calculadora.Somar;
            Operacao op = new Operacao(Calculadora.Somar);
            op += Calculadora.Subtrair;
            op.Invoke(10, 10);
            op(20, 34);
            // Pessoas p1 = new Pessoas("Lucas", "Santos");
            // p1.Apresentar();

            // Log log = new Log();

            // Data data = new Data();
            // data.setMes(2);
            // data.ApresentarMes();
            // data.setMes(20);
            // data.ApresentarMes();


        }
    }
}
