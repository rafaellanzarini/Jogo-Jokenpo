using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jokenpo
{
    public partial class Form1 : Form
    {
        IA joken = new IA();

        Play play = new Play();

        int papel = 1, pedra = 2, tesoura = 3, Jogador;

        int pontosJogador = 0, pontosIA = 0, numIA;

        int res = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
           Jogador = pedra;
            btnjogador.Text = "Jogador: pedra";
            Play();

        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            Jogador = papel;
            btnjogador.Text = "Jogador: papel";
            Play();
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            Jogador = tesoura;
            btnjogador.Text = "Jogador: tesoura";
            Play();
        }

        public void Play()
        {
            numIA = joken.EscolhaIndexIA();
           btnIA.Text = joken.EscolhaTextoIA(numIA);

            res = Jogador - numIA;

            if(res == 0)
            {
                btnVencedor.Text = "EMPATE";
            }
            else
            {
                btnVencedor.Text = play.RetornaTextoVencedor(res);
            }

            pontosJogador = play.retornapontosjogador(res, pontosJogador);
            somaJogador.Text = pontosJogador.ToString();

            pontosIA = play.retornapontosia(res, pontosIA);
            somaIA.Text = pontosIA.ToString();

            /*
            if ((res == -1) || (res == 2))
            {
                btnVencedor.Text = "Vencedor é Jogador";
                pontosJogador++;
                somaJogador.Text = pontosJogador.ToString();

            }
            else if ((res == -2) || (res == 1)) 
            {
                btnVencedor.Text = "Vencedor é IA";
                pontosIA++;
                somaIA.Text = pontosIA.ToString();
            }
            else 
            {
                btnVencedor.Text = "EMPATE";

            }
        */
        }
    }
}


                   



