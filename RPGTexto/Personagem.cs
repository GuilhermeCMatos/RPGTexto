namespace RPGTexto
{
    public class Personagem
    {
        public string Nome { get; set; }

        private int vida;
        private int mana;

        public int VidaMaxima { get; private set; }
        public int ManaMaxima { get; private set; }

        public int Vida
        {
            get => vida;
            set => vida = value > VidaMaxima ? VidaMaxima : (value < 0 ? 0 : value);
        }

        public int Mana
        {
            get => mana;
            set => mana = value > ManaMaxima ? ManaMaxima : (value < 0 ? 0 : value);
        }

        public Personagem(string nome)
        {
            Nome = nome;
            VidaMaxima = 100;
            ManaMaxima = 50;
            Vida = VidaMaxima;
            Mana = ManaMaxima;
        }
    }
}
