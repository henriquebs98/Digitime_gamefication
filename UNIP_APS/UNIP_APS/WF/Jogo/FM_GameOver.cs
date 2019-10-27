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
    public partial class FM_GameOver : Form
    {

        #region Objetos Globais

        SoundPlayer clique = new SoundPlayer("clique.wav");
        SoundPlayer vaia = new SoundPlayer("vaia.wav");
       
        #endregion

        public FM_GameOver()
        {
            InitializeComponent();
        }

        private void FM_GameOver_Load(object sender, EventArgs e)
        {           
            vaia.Play();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {           
            clique.Play();
            this.Close();
        }

    }
}
