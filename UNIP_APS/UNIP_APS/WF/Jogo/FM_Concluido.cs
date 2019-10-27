using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace UNIP_APS
{
    public partial class FM_Concluido : Form
    {
        #region Objetos Globais

        SoundPlayer clique = new SoundPlayer("clique.wav");
        SoundPlayer palmas = new SoundPlayer("aplausos.wav");

        #endregion

        public FM_Concluido()
        {
            InitializeComponent();
        }

        private void FM_Concluido_Load(object sender, EventArgs e)
        {
            palmas.Play();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            clique.Play();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.prefeitura.sp.gov.br/cidade/secretarias/regionais/amlurb/ecopontos/index.php?p=4626"); ;
        }
    }
}
