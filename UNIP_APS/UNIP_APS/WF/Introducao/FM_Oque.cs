using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using UNIP_APS.WF.Jogo;

namespace UNIP_APS.WF
{
    public partial class FM_Oque : Form
    {
        #region Objetos Globais

        SoundPlayer clique = new SoundPlayer("clique.wav");

        #endregion

        #region Construtores

        public FM_Oque()
        {
            InitializeComponent();          
        }

        public FM_Oque(string txtTexto1, string lblTitulo1, Boolean estadoBotaoOque, Boolean EstadoBotaoJogar, Image imagem) 
        {
            InitializeComponent();
            txtTexto.Text = txtTexto1;
            lblTitulo.Text = lblTitulo1;
            btnOque.Visible = estadoBotaoOque;
            btnJogar.Visible = EstadoBotaoJogar;
            pb.Image = imagem;
            txtTexto.Enabled = false;
        
        }
        
        #endregion
    
        #region Botões

        private void btnOque_Click(object sender, EventArgs e)
        {
            
            clique.Play();
            FM_EscolhaComponente ec = new FM_EscolhaComponente();
            ec.Show();
            this.Close();

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            string textoDigitar = txtTexto.Text;
            FM_Instrucoes ins = new FM_Instrucoes(textoDigitar);
            ins.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        #endregion

    }
}
