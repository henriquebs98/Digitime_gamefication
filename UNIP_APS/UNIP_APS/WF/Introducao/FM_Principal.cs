using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace UNIP_APS.WF
{
    public partial class FM_Principal : Form
    {

        SoundPlayer clique = new SoundPlayer("clique.wav");

        public FM_Principal()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            clique.Play();
            Application.Exit();
        }

        private void pbPrincipal_Click(object sender, EventArgs e)
        {
        
            clique.Play();

            Image foto = Image.FromFile("imagem (1).jpg");

            FM_Oque oq = new FM_Oque(" Lixo eletrônico (termo que não deve ser confundido com spam), é o nome dado aos resíduos resultantes da rápida obsolescência de equipamentos eletrônicos" +
                                      " (o que inclui televisores, celulares, computadores, geladeiras e outros dispositivos). " +
                                      " Tais resíduos, descartados em lixões, " +
                                      " constituem-se num sério risco para o meio ambiente, pois possuem em sua composição metais pesados altamente tóxicos," +
                                      " tais como mercúrio, cádmio, berílio e chumbo.Em contato com o solo, estes produtos contaminam o lençol freático; se queimados, poluem o ar. Além disso, " +
                                      " causam doenças graves em catadores.", "Lixo Eletrônico", true, false, foto);

            oq.Show();
            this.Hide();
        }
    }
}
