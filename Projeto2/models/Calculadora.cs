namespace Projeto2.models
{
    public class Calculadora
    {
        public static void Somar(int x, int y)
        {
            System.Console.WriteLine($"Adição -> {x} + {y} = {x + y}");
        }

        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtrair -> {x} - {y} = {x - y}");
        }
    }
}