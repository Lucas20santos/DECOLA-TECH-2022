namespace Mentoria.src.Classes
{
    public class Heroi
    {
        private string nome { get; set; }
        private int PontosVidas { get; set; }
        private int PontosMagia { get; set; }
        private string ClassesFantastica { get; set; }
        private int nivel { get; set; }
        private Heroi(string nome, string ClassesFantastica)
        {
            this.nome = nome;
            this.ClassesFantastica = ClassesFantastica;
            this.nivel = 1;
            this.PontosVidas = 50;
            this.PontosMagia = 50;
        }

        public override string ToString()
        {
            return $"Nome: {this.nome}\nPontos de Magia: {this.PontosMagia}\nPontos de Vida: {this.PontosVidas}\nNível: {this.nivel}\nClasse Fantastica: {this.ClassesFantastica}";
        }

        public string Atacar()
        {
            Random dados = new Random();
            int forcaDoAtaque = this.nivel + dados.Next(1,20);
        }
    }
}