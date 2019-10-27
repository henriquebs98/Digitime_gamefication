using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using UNIP_APS.Classes.Introducao;

namespace UNIP_APS.WF
{
    public partial class FM_EscolhaComponente : Form
    {

        #region Variáveis Globais

        bool  habilitado = true;
        bool desabilitado = false;
        
        // Objeto que reproduzirá o som do clique dos botões, 
        //passando como parametrô o arquivo de audio exitente na pasta do projeto
        SoundPlayer clique = new SoundPlayer("clique.wav");
        #endregion

        #region Construtores

        public FM_EscolhaComponente()
        {
            InitializeComponent();
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = false;
            pb4.Visible = false;
         
        }
        #endregion

        #region Botões
        private void btnImpressora_Click(object sender, EventArgs e)
        {           
            clique.Play();

            // importando imagem da pasta do projeto
            Image foto = Image.FromFile("imagem (5).jpg");

            Impressora imp = new Impressora();
             imp.Nome = "Impressora";
             imp.Funcao = "Imprimir"; 
             imp.Descricao = "A reciclagem de uma impressora implica a desmontagem do aparelho, "                                               +
                             "a separação das suas partes segundo o tipo(plástico, metal, borracha) "                                           +
                             "e trituração de determinadas partes.Depois de triturados, os resíduos são transformados em matéria-prima e "      +
                             "reinseridos na cadeia produtiva de outros novos produtos.As partes que não podem ser totalmente recicladas, "     +
                             "são encaminhadas para o destino menos danoso possível.Para um descarte certo e ecológico, procure a fabricante "  +
                             "da impressora que, de acordo com a PNRS, deve recolher os itens produzidos por ela mesma e destinar à "           +
                             "reciclagem -outra opção são empresas específicas que reciclam eletrônicos. ";

            FM_Oque oq = new FM_Oque(imp.Descricao, "Como Reciclar uma " + imp.Nome, desabilitado, habilitado, foto);
            oq.Show();
            this.Hide();
        }

        private void btnComputador_Click(object sender, EventArgs e)
        {           
            clique.Play();

            // importando imagem da pasta do projeto
            Image foto = Image.FromFile("imagem (2).jpg");

            Computador c = new Computador();
            c.Nome = "Computador";
            c.Funcao = "Automatizar funções";
            c.Descricao = "O plástico contido nos eletrônicos é "                                               +
                            "primeiramente moído e derretido, então ele "                                       +
                            "passa por uma máquina que o transforma em "                                        +
                            "fios, parecido com espaguete. Quando o plástico em fios estiver resfriado ele "    +
                            "passa pelo granulador, que o tritura em pequenos grãos que são vendidos "          +
                            "para fábricas que utilizam este resíduo novamente para fabricação de seus "        +
                            "produtos.";

            FM_Oque oq = new FM_Oque(c.Descricao, "Como Reciclar um " + c.Nome, desabilitado, habilitado, foto);
            oq.Show();
            this.Hide();


        }

        private void btnPilha_Click(object sender, EventArgs e)
        {           
            clique.Play();

            // importando imagem da pasta do projeto
            Image foto = Image.FromFile("imagem (6).jpg");

            Pilha p = new Pilha();
            p.Nome = "Pilha";
            p.Funcao = "Fornecer Energia";
            p.Descricao = "Pilhas e baterias têm uma cobertura plástica, que é removida e lavada com "+
                          "água para eliminação de metais. Depois da lavagem, a parte plástica é "    +
                          "encaminhada a recicladores especializados no material.";

            FM_Oque oq = new FM_Oque(p.Descricao, "Como Reciclar uma " + p.Nome, desabilitado, habilitado, foto);
            oq.Show();
            this.Hide();

        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            clique.Play();

            // importando imagem da pasta do projeto
            Image foto = Image.FromFile("imagem (3).jpg");

            Monitor m = new Monitor();
            m.Nome = "Monitor";
            m.Funcao = "Exibir imagem";
            m.Descricao =  "A maior parte do material (placa marrom, bobina, ferro, alumínio, plástico, "     + 
                            "fiação) segue para reciclagem direta. “Com o tubo é feita a abertura por "       + 
                            "máquina especial em ambiente vedado, separando o vidro frontal, limpo, que "     + 
                            "segue para o reciclador de vidro diretamente, pois não precisa de tratamento "   + 
                            "e o vidro do tubo (com o chumbo) é moído para ser agregado, em partes, a "       +
                            "vidros que necessitam de refração de luz (brilho), como cristal, por exemplo.";

            FM_Oque oq = new FM_Oque(m.Descricao, "Como Reciclar um " + m.Nome, desabilitado, habilitado, foto);
            oq.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Efeitos dos botões
        private void btnImpressora_MouseHover(object sender, EventArgs e)
        {
            pb1.Visible = true;
        }

        private void btnImpressora_MouseLeave(object sender, EventArgs e)
        {
            pb1.Visible = false;
        }

        private void btnMonitor_MouseHover(object sender, EventArgs e)
        {
            pb2.Visible = true;
        }

        private void btnMonitor_MouseLeave(object sender, EventArgs e)
        {
            pb2.Visible = false;
        }

        private void btnPilha_MouseHover(object sender, EventArgs e)
        {
            pb3.Visible = true;
        }

        private void btnPilha_MouseLeave(object sender, EventArgs e)
        {
            pb3.Visible = false;
        }

        private void btnComputador_MouseHover(object sender, EventArgs e)
        {
            pb4.Visible = true;
        }

        private void btnComputador_MouseLeave(object sender, EventArgs e)
        {
            pb4.Visible = false;
        }
        #endregion


    }
}
