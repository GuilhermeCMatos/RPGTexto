using System;
using System.Windows.Forms;

namespace RPGTexto
{
    public partial class FormAventura : Form
    {
        private Personagem jogador;
        private int cenaAtual = 0;

        // Flags para eventos que só devem ocorrer uma vez
        private bool refeicaoUsada = false;
        private bool lapideUsada = false;

        public FormAventura(Personagem personagem)
        {
            InitializeComponent();
            jogador = personagem;
            MostrarCena(0);
        }

        private void MostrarCena(int cena)
        {
            cenaAtual = cena;

            // Sempre reativar todos os botões
            btnOpcao1.Visible = true;
            btnOpcao2.Visible = true;
            btnOpcao3.Visible = true;

            switch (cenaAtual)
            {
                case 0: //Base
                    lblHistoria.Text = $"Bem-vindo {jogador.Nome}! Você acorda em uma floresta misteriosa.";
                    btnOpcao1.Text = "Explorar à esquerda"; //1
                    btnOpcao2.Text = "Seguir em frente"; //11
                    btnOpcao3.Text = "Acampar";
                    break;

                // CAMINHO DA ESQUERDA

                case 1: // Esquerda
                    lblHistoria.Text = "Você se vê de frente a um lago silencioso.";
                    btnOpcao1.Text = "Beber da água"; //2
                    btnOpcao2.Text = "Atravessar lago"; //3
                    btnOpcao3.Text = "Voltar"; //0
                    break;

                case 2: // Beber água
                    lblHistoria.Text = "Você bebe da água e se sente magicamente revigorado, mas isso tem um preço. MAna +5! Vida -10!";
                    jogador.Mana += 5;
                    jogador.Vida -= 10;
                    btnOpcao1.Text = "Beber novamente"; //2
                    btnOpcao2.Text = "Voltar"; //1
                    btnOpcao3.Visible = false;
                    break;

                case 3: // Atravessar lago
                    lblHistoria.Text = "Você atravessa o lago a nado ou gasta magia para voar por ele?";
                    btnOpcao1.Text = "Nadar"; //4
                    btnOpcao2.Text = "Voar (10 mana)"; //5
                    btnOpcao3.Visible = false;
                    break;

                case 4: // Nadar
                    lblHistoria.Text = "Você nada pelo lago e acaba sendo atacado por criaturas. -20 de Vida!";
                    jogador.Vida -= 20;
                    btnOpcao1.Text = "Avançar (Vila)"; //6
                    btnOpcao2.Text = "Voltar (Início)"; //1
                    btnOpcao3.Visible = false;
                    break;

                case 5: // Voar
                    lblHistoria.Text = "Você voa por cima gastando um pouco de mana. Mana -10!";
                    jogador.Mana -= 10;
                    btnOpcao1.Text = "Avançar (Vila)"; //6
                    btnOpcao2.Text = "Voltar (Início)"; //1
                    btnOpcao3.Visible = false;
                    break;

                case 6: // Outro lado do lago
                    lblHistoria.Text = "O outro lado do lago guarda uma pequena vila vazia.";
                    btnOpcao1.Text = "Adentrar na vila"; //7
                    btnOpcao2.Text = "Voltar"; // 3
                    btnOpcao3.Visible = false;
                    break;

                case 7: // Vila
                    lblHistoria.Text = "A vila é vazia e sem vida, mas aparenta ter um grande templo.";
                    btnOpcao1.Text = "Adentrar no templo"; //9
                    btnOpcao2.Text = "Entrar em uma casa"; //8
                    btnOpcao3.Text = "Voltar"; //6
                    break;

                case 8: // Casa qualquer
                    lblHistoria.Text = "A casa parece vazia, estar nela te deixa cansado por algum motivo.";
                    jogador.Mana -= 5;
                    btnOpcao1.Text = "Continuar"; //8
                    btnOpcao2.Text = "Sair"; //7
                    btnOpcao3.Visible = false;
                    break;

                case 9: // Templo
                    lblHistoria.Text = "O templo é gigantesco e belo, uma placa em um altar diz 'Deixa MUITA mana para passar'.";
                    btnOpcao1.Text = "Deixar toda a mana"; //10
                    btnOpcao2.Text = "Voltar"; //7
                    btnOpcao3.Visible = false;
                    break;

                case 10: // Mundo dos sonhos
                    lblHistoria.Text = "Você entra em um mundo de sonhos, cheio de cores e magia!";
                    jogador.Mana = 0;
                    btnOpcao1.Text = "Explorar o mundo dos sonhos"; //999
                    btnOpcao2.Text = "Voltar"; //9
                    btnOpcao3.Visible = false;
                    break;

                // CAMINHO DO MEIO

                case 11: // Frente
                    lblHistoria.Text = "Você avista uma pequena cabana abandonada.";
                    btnOpcao1.Text = "Entrar na cabana"; //12
                    btnOpcao2.Text = "Ignorar e seguir adiante"; //14
                    btnOpcao3.Text = "Voltar"; //0
                    break;

                case 12: // Cabana
                    lblHistoria.Text = "Dentro da cabana você encontra uma janela quebrada e uma pequena refeição preparada";
                    btnOpcao1.Text = "Comer refeição"; //13
                    btnOpcao2.Text = "Pular Janela"; //14
                    btnOpcao3.Text = "Voltar"; //11
                    break;

                case 13: //Comer
                    if (refeicaoUsada == true)
                    {
                        lblHistoria.Text = "você já comeu a refeição.";
                        btnOpcao1.Text = "Voltar"; //12
                        btnOpcao2.Visible = false;
                        btnOpcao3.Visible = false;
                    }
                    else
                    {
                        lblHistoria.Text = "Você come a refeição.";
                        if (!refeicaoUsada)
                        {
                            jogador.Vida += 20;
                            refeicaoUsada = true; // marca como usada
                            lblHistoria.Text += " Vida +20!";
                        }
                        btnOpcao1.Text = "Voltar"; //12
                        btnOpcao2.Visible = false;
                        btnOpcao3.Visible = false;                       
                    }
                        break;

                case 14: // pular a janela ou ignorar a cabana
                    lblHistoria.Text = "Do outro lado da casa, você encontra uma pequena lápede.";
                    btnOpcao1.Text = "Rezar"; //15
                    btnOpcao2.Text = "Ignorar"; //16
                    btnOpcao3.Text = "Voltar"; //11
                    break;

                case 15: // Rezar
                    if (lapideUsada == true)
                    {
                        lblHistoria.Text = "Você já rezou.";
                        btnOpcao1.Text = "Avançar"; //16
                        btnOpcao2.Text = "Voltar"; //11
                        btnOpcao3.Visible = false;
                    }
                    else
                    {
                        lblHistoria.Text = "Você reza para a pequena lápedi.";
                        if (!lapideUsada)
                        {
                            jogador.Mana += 20;
                            lapideUsada = true; // marca como usada
                            lblHistoria.Text += " Mana +20!";
                        }
                        btnOpcao1.Text = "Avançar"; //16
                        btnOpcao2.Text = "Voltar"; //11
                        btnOpcao3.Visible = false;
                    }
                    break;

                case 16: // Árvore
                    lblHistoria.Text = "Logo depois da lápede, você se depara com uma grande árvore. Essa árvore parece morta, quer gastar mana para revive-la?";
                    btnOpcao1.Text = "Sim (-20)"; //17
                    btnOpcao2.Text = "Voltar"; //14
                    btnOpcao3.Visible = false;
                    break;

                case 17: // Reviver árvore
                    if (jogador.Vida <= 60)
                    {
                        lblHistoria.Text = "Você tenta enfrentar a árvore, mas estava muito fraco. GAME OVER!";
                        jogador.Mana -= 20;
                        btnOpcao1.Visible = false;
                        btnOpcao2.Visible = false;
                        btnOpcao3.Visible = false;
                    }
                    else
                    {
                        lblHistoria.Text = "A árvore revive e se afasta após uma longa batalha. Você encontra um reino escondido dentro da floresta.";
                        jogador.Mana -= 20;
                        jogador.Vida -= 60;
                        btnOpcao1.Text = "Adentrar no reino"; //999
                        btnOpcao2.Visible = false;
                        btnOpcao3.Visible = false;
                    }
                    break;

                // FINAIS

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

        // Método para verificar se o jogador tem toda a mana
        private bool ChecarManaMaxima()
        {
            if (jogador.Mana == jogador.ManaMaxima)
            {
                // O jogador tem toda a mana
                return true;
            }
            else
            {
                // O jogador não tem toda a mana, perde tudo e não avança
                jogador.Mana = 0;
                AtualizarStatus();
                MessageBox.Show("Você não tinha toda a mana! Ela se esgota e nada acontece.");
                return false;
            }
        }

        private void btnOpcao1_Click(object sender, EventArgs e)
        {
            switch (cenaAtual)
            {
                case 0: MostrarCena(1); break;        // Esquerda
                case 1: MostrarCena(2); break;        // Beber
                case 2: MostrarCena(2); break;        // Beber novamente
                case 3: MostrarCena(4); break;        // Nadar 
                case 4: MostrarCena(6); break;        // Ir para a vila 
                case 5: MostrarCena(6); break;        // Ir para a vila
                case 6: MostrarCena(7); break;        // Entrar na vila
                case 7: MostrarCena(9); break;        // Templo
                case 8: MostrarCena(8); break;        // Continuar
                case 9: // Templo, deixar toda a mana
                    if (ChecarManaMaxima())
                        MostrarCena(10); // Mundo dos sonhos
                    else
                        MostrarCena(9); // Continua no templo
                    break;
                case 10: MostrarCena(999); break;

                // CAMINHO DO MEIO

                case 11: MostrarCena(12); break;      // Entrar na cabana
                case 12: MostrarCena(13); break;      // Comer
                case 13: MostrarCena(12); break;      // Voltar
                case 14: MostrarCena(15); break;      // Rezar
                case 15: MostrarCena(16); break;      // Avançar
                case 16: MostrarCena(17); break;      // Revivier árvore
            }
        }

        private void btnOpcao2_Click(object sender, EventArgs e)
        {
            switch (cenaAtual)
            {
                case 0: MostrarCena(11); break;       // -
                case 1: MostrarCena(3); break;       // Atravessar
                case 2: MostrarCena(1); break;       // Voltar 
                case 3: MostrarCena(5); break;       // Voar   
                case 4: MostrarCena(1); break;       // Voltar para a costa
                case 5: MostrarCena(1); break;       // Voltar para a costa
                case 6: MostrarCena(3); break;       // Voltar  
                case 7: MostrarCena(8); break;       // Casa   
                case 8: MostrarCena(8); break;       // Ficar  
                case 9: MostrarCena(7); break;       // Voltar

                // CAMINHO DO MEIO

                case 11: MostrarCena(14); break;     // Ignorar
                case 12: jogador.Vida -= 10; MostrarCena(14); MessageBox.Show("Você se cortou pulando a janela. Vida -10!");  break;     // Pular Janela
                case 14: MostrarCena(16); break;     // Ignorar
                case 15: MostrarCena(11); break;     // Voltar Voltar
                case 16: MostrarCena(14); break;     //
            }
        }

        private void btnOpcao3_Click(object sender, EventArgs e)
        {
            switch (cenaAtual)
            {
                case 0: MostrarCena(0); break;        // -  
                case 1: MostrarCena(0); break;        // Voltar 
                case 7: MostrarCena(6); break;        // Casa

                // CAMINHO DO MEIO

                case 11: MostrarCena(0); break;       // Voltar
                case 12: MostrarCena(11); break;      // Voltar
                case 14: MostrarCena(11); break;      // Voltar
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // Restaura a vida e mana máximas
            jogador.Vida = jogador.VidaMaxima;
            jogador.Mana = jogador.ManaMaxima;

            // Reseta flags de eventos
            refeicaoUsada = false;
            lapideUsada = false;

            // Volta para a primeira cena
            MostrarCena(0);
        }

        private void FormAventura_Load(object sender, EventArgs e)
        {

        }
    }
}
