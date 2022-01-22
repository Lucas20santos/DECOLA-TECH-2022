using System;
// using Projeto2.models;
namespace Projeto2
{
    class Projeto2
    {
        static void Main(string[] args)
        {
            double s = 0;
            for (int i = 1; i <= 100; i++)
            {
                s += 1/i;
            }
            var x = Math.Round(s, 2);
            Console.WriteLine();
        }
    }
}
