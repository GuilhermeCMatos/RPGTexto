using System;
using System.Windows.Forms;

namespace RPGTexto
{
    public partial class FormAventura : Form
    {
        private Personagem jogador;
        private int cenaAtual = 0;

        public FormAventura(Personagem personagem)
        {
            InitializeComponent();
            jogador = personagem;
            MostrarCena(0);
        }

        private void MostrarCena(int cena)
        {
            cenaAtual = cena;

            switch (cenaAtual)
            {
                case 0: //Base
                    lblHistoria.Text = $"Bem-vindo {jogador.Nome}! Você acorda em uma floresta misteriosa.";
                    btnOpcao1.Text = "Explorar à esquerda"; //1
                    btnOpcao2.Text = "Seguir em frente"; //2
                    btnOpcao3.Text = "Acampar"; //5
                    btnOpcao3.Visible = true;
                    break;

                case 1: //0-Esquerda
                    lblHistoria.Text = "Você segue pela esquerda e encontra um lago silencioso.";
                    btnOpcao1.Text = "Beber da água"; //3
                    btnOpcao2.Text = "Atravessar lago"; //6
                    btnOpcao3.Text = "Voltar"; //0
                    btnOpcao3.Visible = true;
                    break;

                case 2: //0-Frente
                    lblHistoria.Text = "Você continua em frente e chega a uma cabana abandonada.";
                    btnOpcao1.Text = "Entrar na cabana"; //4
                    btnOpcao2.Text = "Ignorar e seguir adiante"; //11
                    btnOpcao3.Text = "Voltar"; // 0
                    btnOpcao3.Visible = true;
                    break;

                case 3: //1-Beber água
                    lblHistoria.Text = "Você bebe da água e se sente magicamente revigorado, mas isso tem um preço. MAna +5! Vida -10!";
                    jogador.Mana += 5;
                    jogador.Vida -= 10;
                    btnOpcao1.Text = "Beber novamente"; //3
                    btnOpcao2.Text = "Voltar"; //1
                    btnOpcao3.Visible = false;
                    break;

                case 4: //2-cabana
                    lblHistoria.Text = "Dentro da cabana você encontra um pequena refeição preparada. Comer?";
                    jogador.Mana += 20;
                    btnOpcao1.Text = "Comer"; //12
                    btnOpcao2.Text = "Pular Janela"; //13
                    btnOpcao3.Text = "Voltar"; //2
                    btnOpcao3.Visible = true;
                    break;

                case 5: //0-Acampar
                    lblHistoria.Text = "Você Acampa um pouco e recupera 5 de vida e mana! Mas você é atacado por lobos no meio da noite!.";
                    jogador.Vida += 5;
                    jogador.Mana += 5;
                    btnOpcao1.Text = "Atacar com uma arma"; //9
                    btnOpcao2.Text = "Usar magia (15 mana)"; //10
                    btnOpcao3.Visible = false;
                    break;

                case 6: //1-Atravessar lago
                    lblHistoria.Text = "Você atravessa o lago a nado ou gasta magia para voar por ele?.";
                    btnOpcao1.Text = "Nadar"; //7
                    btnOpcao2.Text = "Voar (10 mana)"; //8
                    btnOpcao3.Text = "Voltar"; //1
                    btnOpcao3.Visible = true;
                    break;

                case 7: //6-nadar
                    lblHistoria.Text = "";
                    btnOpcao1.Text = ""; 
                    btnOpcao2.Text = "";
                    btnOpcao3.Text = "";
                    btnOpcao3.Visible = false;
                    break;

                case 8: //6-voar
                    lblHistoria.Text = "";
                    btnOpcao1.Text = "";
                    btnOpcao2.Text = "";
                    btnOpcao3.Text = "";
                    btnOpcao3.Visible = false;
                    break;

                case 9: //5-atacar com arma
                    lblHistoria.Text = "";
                    btnOpcao1.Text = "";
                    btnOpcao2.Text = "";
                    btnOpcao3.Text = "";
                    btnOpcao3.Visible = false;
                    break;

                case 10: //5-atacar com magia
                    lblHistoria.Text = "";
                    btnOpcao1.Text = "";
                    btnOpcao2.Text = "";
                    btnOpcao3.Text = "";
                    btnOpcao3.Visible = false;
                    break;

                case 11: //2-ignorar e seguir
                    lblHistoria.Text = "";
                    btnOpcao1.Text = "";
                    btnOpcao2.Text = "";
                    btnOpcao3.Text = "";
                    btnOpcao3.Visible = false;
                    break;

                case 12: //4-comer
                    lblHistoria.Text = "";
                    btnOpcao1.Text = "";
                    btnOpcao2.Text = "";
                    btnOpcao3.Text = "";
                    btnOpcao3.Visible = false;
                    break;

                case 13: //4-Pular janela
                    lblHistoria.Text = "";
                    btnOpcao1.Text = "";
                    btnOpcao2.Text = "";
                    btnOpcao3.Text = "";
                    btnOpcao3.Visible = false;
                    break;

                case 14: //
                    lblHistoria.Text = "";
                    btnOpcao1.Text = "";
                    btnOpcao2.Text = "";
                    btnOpcao3.Text = "";
                    btnOpcao3.Visible = false;
                    break;



                default:
                    lblHistoria.Text = "Fim da aventura (por enquanto)!";
                    btnOpcao1.Visible = false;
                    btnOpcao2.Visible = false;
                    btnOpcao3.Visible = false;
                    break;
            }

            AtualizarStatus();
        }

        private void AtualizarStatus()
        {
            lblVida.Text = $"Vida: {jogador.Vida}/{jogador.VidaMaxima}";
            lblMana.Text = $"Mana: {jogador.Mana}/{jogador.ManaMaxima}";
        }

        private void btnOpcao1_Click(object sender, EventArgs e)
        {
            if (cenaAtual == 0) MostrarCena(1); //Esquerda
            else if (cenaAtual == 1) MostrarCena(3); //Beber
            else if (cenaAtual == 2) MostrarCena(4); //
            else if (cenaAtual == 3) MostrarCena(3); //Beber novamente
            else if (cenaAtual == 4) MostrarCena(0);
            else if (cenaAtual == 5) MostrarCena(9); // Atacar arma 
            else if (cenaAtual == 6) MostrarCena(7); //Nadar
            else if (cenaAtual == 7) MostrarCena(0);
            else if (cenaAtual == 8) MostrarCena(0);
            else if (cenaAtual == 9) MostrarCena(0);
            else if (cenaAtual == 10) MostrarCena(0);
            else if (cenaAtual == 11) MostrarCena(0);
            else if (cenaAtual == 12) MostrarCena(0);
            else if (cenaAtual == 13) MostrarCena(0);
            else if (cenaAtual == 14) MostrarCena(0);
            else if (cenaAtual == 15) MostrarCena(0);
        }

        private void btnOpcao2_Click(object sender, EventArgs e)
        {
            if (cenaAtual == 0) MostrarCena(2); //Frente
            else if (cenaAtual == 1) MostrarCena(6); //Atravessar
            else if (cenaAtual == 2) MostrarCena(11); // 
            else if (cenaAtual == 3) MostrarCena(1); //Voltar
            else if (cenaAtual == 4) MostrarCena(0);
            else if (cenaAtual == 5) MostrarCena(10); // Atacar magia
            else if (cenaAtual == 6) MostrarCena(8);  //Voar
            else if (cenaAtual == 7) MostrarCena(0);
            else if (cenaAtual == 8) MostrarCena(0);
            else if (cenaAtual == 9) MostrarCena(0);
            else if (cenaAtual == 10) MostrarCena(0);
            else if (cenaAtual == 11) MostrarCena(0);
            else if (cenaAtual == 12) MostrarCena(0);
            else if (cenaAtual == 13) MostrarCena(0);
            else if (cenaAtual == 14) MostrarCena(0);
            else if (cenaAtual == 15) MostrarCena(0);
        }

        private void btnOpcao3_Click(object sender, EventArgs e)
        {
            if (cenaAtual == 0) MostrarCena(5); //Acampar
            else if (cenaAtual == 1) MostrarCena(0); //Voltar
            else if (cenaAtual == 2) MostrarCena(0); //Voltar
            else if (cenaAtual == 3) MostrarCena(0);
            else if (cenaAtual == 4) MostrarCena(0);
            else if (cenaAtual == 5) MostrarCena(0);
            else if (cenaAtual == 6) MostrarCena(1); //voltar
            else if (cenaAtual == 7) MostrarCena(0);
            else if (cenaAtual == 8) MostrarCena(0);
            else if (cenaAtual == 9) MostrarCena(0);
            else if (cenaAtual == 10) MostrarCena(0);
            else if (cenaAtual == 11) MostrarCena(0);
            else if (cenaAtual == 12) MostrarCena(0);
            else if (cenaAtual == 13) MostrarCena(0);
            else if (cenaAtual == 14) MostrarCena(0);
            else if (cenaAtual == 15) MostrarCena(0);
        }

        private void FormAventura_Load(object sender, EventArgs e)
        {

        }
    }
}
