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
using UNIP_APS.WF;

namespace UNIP_APS
{
    public partial class FM_Jogo : Form
    {

        #region Variaveis Globais

        DateTime data_hora;
        Jogador jogador = new Jogador();
        ListaJogador lista;
        string textoDigitado;
        string texto;
        string comparavel;
        int erros = 0;   
        #endregion

        #region Objetos Globais

        SoundPlayer clique = new SoundPlayer("clique.wav");
        SoundPlayer musica = new SoundPlayer("eletronic.wav");

        #endregion

        #region Construtores

        public FM_Jogo()
        {
            InitializeComponent();
        }

        public FM_Jogo(string nome, string email, string texto)
        {
            InitializeComponent();

            // Atribuição dos valores recebidos através dos parâmetros do método construtor da classe 
            // aos label' e aos atributos do objeto Jogador.
            lblNome.Text = nome;
            lblEmail.Text = email;
            jogador.Nome = nome;
            jogador.Email = email;



            // Geração de um numero aleatório, para ser passado como parâmmetro do método sortear da classe GeraTexto
            // dessa forma, a classe GeraTexto retornará e atribuirá ao lblTexto um texto diferente a cada chamada.
            //Random rdn = new Random();
            //int numero;
            //numero = rdn.Next(1, 10);
            txtCaixa.Text = texto;
            txtCaixa.Enabled = false;
        }
        #endregion
       
        public void Jogo_Load(object sender, EventArgs e)
        {
            musica.Play();
            // escondendo relogio.;
            pbRelogioTempo.Visible = false;

            // definindo a data
            data_hora = DateTime.Now;
            lblData.Text = data_hora.ToLongDateString();

            // capturando texto e as palavras
            string texto = txtCaixa.Text;
            string[] palavras = texto.Split(' ');

            // atribuindo q quantidade de palavras no label
            lblqtdePalavras.Text = Convert.ToString(palavras.Length);
        }

        #region Eventos do TextBox

        private void txtTexto_Click(object sender, EventArgs e)
        {

            clique.Play();
            // Iniciando o Contador.
            Relogio.Start();
            musica.Play();

            // Limpando a mensagem;
            lblMensagem.Text = string.Empty;
            pbseta1.Visible = false;
            pbseta2.Visible = false;
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificação de tecla digitada e Texto
            if (e.KeyChar != (char)08 && (textoDigitado != comparavel))
            {
                erros++;
            }
        }

        public void  txtTexto_TextChanged(object sender, EventArgs e)
        {
            try
            {    // capturando valores:
                textoDigitado = txtTexto.Text;
                texto = txtCaixa.Text;

                // esta variável receberá o texto sorteado pegando o tamanho completo do texto que está sendo digitado.
                comparavel = texto.Substring(0, textoDigitado.Length);

                #region  Comparando os textos


                if (textoDigitado == comparavel)
                {
                    lblqtdePalavrasDigitadas.Enabled = true;
                    this.txtTexto.BackColor = Color.Green;
                    string[] palavras = textoDigitado.Split(' ');
                    lblqtdePalavrasDigitadas.Text = Convert.ToString(palavras.Length - 1);
                    qtdeCaracterDigitados.Text = Convert.ToString(textoDigitado.Length);
                }
                else
                {
                    this.txtTexto.BackColor = Color.Red;
                    lblqtdePalavrasDigitadas.Enabled = false;
                    qtdeErro.Text = Convert.ToString(erros);
                }
                #endregion


                #region Caso o Jogo seja finalizado
                if (textoDigitado == texto)
                {

                    Relogio.Stop();
                    pbRelogioTempo.Visible = false;

                    FM_Concluido fim = new FM_Concluido();
                    fim.Show();

                    txtTexto.Enabled = false;

                    jogador.Pontuacao = Convert.ToInt32(lblqtdePalavrasDigitadas.Text);
                    jogador.tempo = 60 - Convert.ToInt32(contador.Text);
                    jogador.Erro = Convert.ToInt16(qtdeErro.Text);
                    jogador.finalizado = "Sim";

                    contador.Text = "60";

                    lista = new ListaJogador();
                    lista.Add(jogador);

                    dgvPlacar.DataSource = lista;
                    dgvPlacar.Refresh();
                    txtTexto.Text = string.Empty;
                    this.txtTexto.BackColor = Color.Gray;
                    erros = 0;
                    this.qtdeErro.Text = "0";
                }
                #endregion
            }

            catch (Exception)
            {
                MessageBox.Show("você digitou um caractere a mais!");
            }
        }
        
        #endregion

        #region Relógio

        private void Relogio_Tick(object sender, EventArgs e)
        {
            pbRelogioTempo.Visible = true;
            contador.Text = (Convert.ToInt32(contador.Text) - 1).ToString();

            if (contador.Text == "0")
            {
                Relogio.Stop();
                pbRelogioTempo.Visible = false;
                txtTexto.Enabled = false;
                this.txtTexto.BackColor = Color.Gray;
                FM_GameOver gameover = new FM_GameOver();
                gameover.Show();

                //MessageBox.Show("Fim do Tempo, seu placar está sendo gerado...");

                jogador.Pontuacao = Convert.ToInt32(lblqtdePalavrasDigitadas.Text);
                jogador.tempo = 60;
                jogador.finalizado = "Não";
                contador.Text = "60";
                jogador.Erro = Convert.ToInt32(qtdeErro.Text); 

                lista = new ListaJogador();
                lista.Add(jogador);

                dgvPlacar.DataSource = lista;
                dgvPlacar.DataSource = lista;
                dgvPlacar.Refresh();

                txtTexto.Text = string.Empty;
                this.txtTexto.BackColor = Color.Gray;
                erros = 0;
                this.qtdeErro.Text = "0";
            }
        }
        
        #endregion

        #region Botões

        private void btnReinicia_Click(object sender, EventArgs e)
        {
            clique.Play();
            Relogio.Stop();
            contador.Text = "60";
            txtTexto.Text = string.Empty;
            qtdeErro.Text = "0";
            lblqtdePalavrasDigitadas.Text = Convert.ToString(0);
            txtTexto.Enabled = true;
            this.txtTexto.BackColor = Color.White;
            pbRelogioTempo.Visible = false;
            lblMensagem.Text = "Clique no espaço abaixo para iniciar !";
            pbseta1.Visible = true;
            pbseta2.Visible = true;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            clique.Play();
            this.Close();
            Application.Exit();
        }
      
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FM_EscolhaComponente fc = new FM_EscolhaComponente();
            fc.Show();
            this.Hide();
        }

        #region Botões de Musica

        private void btnMute_Click(object sender, EventArgs e)
        {
            musica.Stop();
        }

        private void btnDesMute_Click(object sender, EventArgs e)
        {
            musica.Play();
        }

        #endregion

        #endregion
       

        
    }
}
