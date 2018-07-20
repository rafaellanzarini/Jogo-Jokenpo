namespace Jokenpo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPedra = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTesoura = new System.Windows.Forms.Button();
            this.btnjogador = new System.Windows.Forms.Label();
            this.btnIA = new System.Windows.Forms.Label();
            this.btnVencedor = new System.Windows.Forms.Label();
            this.somaJogador = new System.Windows.Forms.Label();
            this.somaIA = new System.Windows.Forms.Label();
            this.pontuacaoJogador = new System.Windows.Forms.Label();
            this.pontuacaoIA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPedra
            // 
            this.btnPedra.BackColor = System.Drawing.SystemColors.Info;
            this.btnPedra.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedra.Image = ((System.Drawing.Image)(resources.GetObject("btnPedra.Image")));
            this.btnPedra.Location = new System.Drawing.Point(43, 105);
            this.btnPedra.Name = "btnPedra";
            this.btnPedra.Size = new System.Drawing.Size(98, 93);
            this.btnPedra.TabIndex = 0;
            this.btnPedra.UseVisualStyleBackColor = false;
            this.btnPedra.Click += new System.EventHandler(this.btnPedra_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.BackColor = System.Drawing.SystemColors.Info;
            this.btnPapel.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapel.Image = ((System.Drawing.Image)(resources.GetObject("btnPapel.Image")));
            this.btnPapel.Location = new System.Drawing.Point(177, 105);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(120, 93);
            this.btnPapel.TabIndex = 1;
            this.btnPapel.UseVisualStyleBackColor = false;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnTesoura
            // 
            this.btnTesoura.BackColor = System.Drawing.SystemColors.Info;
            this.btnTesoura.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTesoura.Image = ((System.Drawing.Image)(resources.GetObject("btnTesoura.Image")));
            this.btnTesoura.Location = new System.Drawing.Point(333, 105);
            this.btnTesoura.Name = "btnTesoura";
            this.btnTesoura.Size = new System.Drawing.Size(164, 93);
            this.btnTesoura.TabIndex = 2;
            this.btnTesoura.UseVisualStyleBackColor = false;
            this.btnTesoura.Click += new System.EventHandler(this.btnTesoura_Click);
            // 
            // btnjogador
            // 
            this.btnjogador.AutoSize = true;
            this.btnjogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjogador.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnjogador.Location = new System.Drawing.Point(55, 35);
            this.btnjogador.Name = "btnjogador";
            this.btnjogador.Size = new System.Drawing.Size(86, 24);
            this.btnjogador.TabIndex = 3;
            this.btnjogador.Text = "Jogador";
            // 
            // btnIA
            // 
            this.btnIA.AutoSize = true;
            this.btnIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIA.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.btnIA.Location = new System.Drawing.Point(312, 35);
            this.btnIA.Name = "btnIA";
            this.btnIA.Size = new System.Drawing.Size(29, 24);
            this.btnIA.TabIndex = 4;
            this.btnIA.Text = "IA";
            // 
            // btnVencedor
            // 
            this.btnVencedor.AutoSize = true;
            this.btnVencedor.BackColor = System.Drawing.Color.Transparent;
            this.btnVencedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVencedor.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnVencedor.Location = new System.Drawing.Point(172, 283);
            this.btnVencedor.Name = "btnVencedor";
            this.btnVencedor.Size = new System.Drawing.Size(125, 29);
            this.btnVencedor.TabIndex = 6;
            this.btnVencedor.Text = "Vencedor";
            // 
            // somaJogador
            // 
            this.somaJogador.AutoSize = true;
            this.somaJogador.Font = new System.Drawing.Font("Mistral", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somaJogador.ForeColor = System.Drawing.Color.Tomato;
            this.somaJogador.Location = new System.Drawing.Point(313, 343);
            this.somaJogador.Name = "somaJogador";
            this.somaJogador.Size = new System.Drawing.Size(23, 27);
            this.somaJogador.TabIndex = 7;
            this.somaJogador.Text = "0";
            // 
            // somaIA
            // 
            this.somaIA.AutoSize = true;
            this.somaIA.Font = new System.Drawing.Font("Mistral", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somaIA.ForeColor = System.Drawing.Color.Tomato;
            this.somaIA.Location = new System.Drawing.Point(313, 399);
            this.somaIA.Name = "somaIA";
            this.somaIA.Size = new System.Drawing.Size(23, 27);
            this.somaIA.TabIndex = 8;
            this.somaIA.Text = "0";
            // 
            // pontuacaoJogador
            // 
            this.pontuacaoJogador.AutoSize = true;
            this.pontuacaoJogador.Font = new System.Drawing.Font("Mistral", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontuacaoJogador.ForeColor = System.Drawing.Color.MediumBlue;
            this.pontuacaoJogador.Location = new System.Drawing.Point(41, 343);
            this.pontuacaoJogador.Name = "pontuacaoJogador";
            this.pontuacaoJogador.Size = new System.Drawing.Size(162, 27);
            this.pontuacaoJogador.TabIndex = 9;
            this.pontuacaoJogador.Text = "Pontuação Jogador";
            // 
            // pontuacaoIA
            // 
            this.pontuacaoIA.AutoSize = true;
            this.pontuacaoIA.Font = new System.Drawing.Font("Mistral", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pontuacaoIA.ForeColor = System.Drawing.Color.MediumBlue;
            this.pontuacaoIA.Location = new System.Drawing.Point(41, 399);
            this.pontuacaoIA.Name = "pontuacaoIA";
            this.pontuacaoIA.Size = new System.Drawing.Size(119, 27);
            this.pontuacaoIA.TabIndex = 10;
            this.pontuacaoIA.Text = "Pontuação IA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 435);
            this.Controls.Add(this.pontuacaoIA);
            this.Controls.Add(this.pontuacaoJogador);
            this.Controls.Add(this.somaIA);
            this.Controls.Add(this.somaJogador);
            this.Controls.Add(this.btnVencedor);
            this.Controls.Add(this.btnIA);
            this.Controls.Add(this.btnjogador);
            this.Controls.Add(this.btnTesoura);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPedra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPedra;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTesoura;
        private System.Windows.Forms.Label btnjogador;
        private System.Windows.Forms.Label btnIA;
        private System.Windows.Forms.Label btnVencedor;
        private System.Windows.Forms.Label somaJogador;
        private System.Windows.Forms.Label somaIA;
        private System.Windows.Forms.Label pontuacaoJogador;
        private System.Windows.Forms.Label pontuacaoIA;
    }
}

