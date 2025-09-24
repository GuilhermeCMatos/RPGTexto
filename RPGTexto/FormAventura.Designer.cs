namespace RPGTexto
{
    partial class FormAventura
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnReiniciar;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        private void InitializeComponent()
        {
            lblHistoria = new Label();
            btnOpcao1 = new Button();
            btnOpcao2 = new Button();
            btnOpcao3 = new Button();
            lblVida = new Label();
            lblMana = new Label();
            btnReiniciar = new Button();
            SuspendLayout();
            // 
            // lblHistoria
            // 
            lblHistoria.AutoSize = true;
            lblHistoria.Font = new Font("Segoe UI", 10F);
            lblHistoria.Location = new Point(20, 20);
            lblHistoria.MaximumSize = new Size(420, 0);
            lblHistoria.Name = "lblHistoria";
            lblHistoria.Size = new Size(87, 19);
            lblHistoria.TabIndex = 0;
            lblHistoria.Text = "Texto inicial...";
            // 
            // btnOpcao1
            // 
            btnOpcao1.Location = new Point(20, 250);
            btnOpcao1.Name = "btnOpcao1";
            btnOpcao1.Size = new Size(140, 40);
            btnOpcao1.TabIndex = 1;
            btnOpcao1.Text = "Opção 1";
            btnOpcao1.UseVisualStyleBackColor = true;
            btnOpcao1.Click += btnOpcao1_Click;
            // 
            // btnOpcao2
            // 
            btnOpcao2.Location = new Point(180, 250);
            btnOpcao2.Name = "btnOpcao2";
            btnOpcao2.Size = new Size(140, 40);
            btnOpcao2.TabIndex = 2;
            btnOpcao2.Text = "Opção 2";
            btnOpcao2.UseVisualStyleBackColor = true;
            btnOpcao2.Click += btnOpcao2_Click;
            // 
            // btnOpcao3
            // 
            btnOpcao3.Location = new Point(340, 250);
            btnOpcao3.Name = "btnOpcao3";
            btnOpcao3.Size = new Size(140, 40);
            btnOpcao3.TabIndex = 3;
            btnOpcao3.Text = "Opção 3";
            btnOpcao3.UseVisualStyleBackColor = true;
            btnOpcao3.Click += btnOpcao3_Click;
            // 
            // lblVida
            // 
            lblVida.AutoSize = true;
            lblVida.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVida.Location = new Point(20, 220);
            lblVida.Name = "lblVida";
            lblVida.Size = new Size(56, 15);
            lblVida.TabIndex = 4;
            lblVida.Text = "Vida: 0/0";
            // 
            // lblMana
            // 
            lblMana.AutoSize = true;
            lblMana.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMana.Location = new Point(240, 220);
            lblMana.Name = "lblMana";
            lblMana.Size = new Size(62, 15);
            lblMana.TabIndex = 5;
            lblMana.Text = "Mana: 0/0";
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(420, 215);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(60, 25);
            btnReiniciar.TabIndex = 6;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // FormAventura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 320);
            Controls.Add(lblHistoria);
            Controls.Add(btnOpcao1);
            Controls.Add(btnOpcao2);
            Controls.Add(btnOpcao3);
            Controls.Add(lblVida);
            Controls.Add(lblMana);
            Controls.Add(btnReiniciar);
            Name = "FormAventura";
            Text = "RPG de Texto - Aventura";
            Load += FormAventura_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHistoria;
        private System.Windows.Forms.Button btnOpcao1;
        private System.Windows.Forms.Button btnOpcao2;
        private System.Windows.Forms.Button btnOpcao3; // novo botão
        private System.Windows.Forms.Label lblVida;
        private System.Windows.Forms.Label lblMana;
    }
}
