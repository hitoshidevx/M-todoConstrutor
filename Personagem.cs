namespace MetodoConstrutor
{
    public class Personagem
    {
        public string Nome { get; set; }
        public string Classe { get; set; }
        public int Vida { get; set; }
        public int Escudo { get; set; }

        public Personagem(){

        }

        public Personagem(string _classe){
            this.Classe = _classe;
        }

        public Personagem(string _nome, string _classe, int _vida, int _escudo){
            this.Nome = _nome;
            this.Classe = _classe;
            this.Vida = _vida;
            this.Escudo = _escudo;
        }


    }
}