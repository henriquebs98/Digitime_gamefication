using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIP_APS
{
    public partial class FM_Inicial : Form
    {
        #region Variáveis e Objetos Globais

        SoundPlayer fundo = new SoundPlayer("eletronic.wav");
        SoundPlayer clique = new SoundPlayer("clique.wav");
        string texto;

        #endregion

        #region Construtores


        public FM_Inicial()
        {
            InitializeComponent();
        }



        public FM_Inicial(string textoDigitar)
        {
            InitializeComponent();
            texto = textoDigitar;
        }




        #endregion

        private void Inicial_Load(object sender, EventArgs e)
        {
            fundo.Play();
            fundo.PlayLooping();
            progressBar1.Value = 0;
            progressBar1.Maximum = 2;       
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            fundo.Stop();
            clique.Play();

            if ((txtNome.Text != string.Empty) & (txtEmail.Text != string.Empty))
            {
                while (progressBar1.Value < progressBar1.Maximum)
                {
                    progressBar1.Value++;
                    Thread.Sleep(1000);
                }
                progressBar1.Value = 0;
                FM_Jogo j = new FM_Jogo(txtNome.Text, txtEmail.Text, texto);
                this.Close();
                j.Show();
            }
            else
            {
                MessageBox.Show("Digite seu Nome e Email para poder acessar o Jogo!");
            }

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            clique.Play();
            Application.Exit();
        }

        #region Botões de volume


        private void btnMute_Click(object sender, EventArgs e)
        {
            fundo.Stop();
        }

        private void btnDesMute_Click(object sender, EventArgs e)
        {
            fundo.Play();
        }


        #endregion




    }

}

