using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UNIP_APS.WF.Jogo
{
    public partial class FM_Instrucoes : Form
    {

        string textoDigitar;

        #region Construtores


        public FM_Instrucoes()
        {
            InitializeComponent();
        }
        public FM_Instrucoes(string texto)
        {
            InitializeComponent();
            textoDigitar = texto;
        }
     
        
        #endregion

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            FM_Inicial inicial = new FM_Inicial(textoDigitar);
            inicial.Show();
            this.Hide();
        }

        private void FM_Instrucoes_Load(object sender, EventArgs e)
        {

        }
    }
}
