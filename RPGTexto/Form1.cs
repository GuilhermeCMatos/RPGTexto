using System;
using System.Windows.Forms;

namespace RPGTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComecar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Digite um nome para começar a aventura!");
                return;
            }

            Personagem jogador = new Personagem(nome);
            FormAventura aventura = new FormAventura(jogador);
            aventura.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
