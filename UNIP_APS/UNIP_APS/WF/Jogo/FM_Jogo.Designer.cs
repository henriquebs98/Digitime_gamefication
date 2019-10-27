namespace UNIP_APS
{
    partial class FM_Jogo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FM_Jogo));
            this.btnReinicia = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.dgvPlacar = new System.Windows.Forms.DataGridView();
            this.contador = new System.Windows.Forms.Label();
            this.lblqtdePalavras = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblqtdePalavrasDigitadas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.qtdeCaracterDigitados = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Relogio = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.qtdeErro = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.pbRelogioTempo = new System.Windows.Forms.PictureBox();
            this.txtCaixa = new System.Windows.Forms.TextBox();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnDesMute = new System.Windows.Forms.Button();
            this.pbseta1 = new System.Windows.Forms.PictureBox();
            this.pbseta2 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelogioTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbseta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbseta2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReinicia
            // 
            this.btnReinicia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(111)))));
            this.btnReinicia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReinicia.BackgroundImage")));
            this.btnReinicia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReinicia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReinicia.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinicia.ForeColor = System.Drawing.Color.Transparent;
            this.btnReinicia.Location = new System.Drawing.Point(15, 371);
            this.btnReinicia.Name = "btnReinicia";
            this.btnReinicia.Size = new System.Drawing.Size(36, 35);
            this.btnReinicia.TabIndex = 0;
            this.btnReinicia.UseVisualStyleBackColor = false;
            this.btnReinicia.Click += new System.EventHandler(this.btnReinicia_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.BackColor = System.Drawing.Color.White;
            this.txtTexto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTexto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.ForeColor = System.Drawing.Color.White;
            this.txtTexto.Location = new System.Drawing.Point(13, 284);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(728, 83);
            this.txtTexto.TabIndex = 1;
            this.txtTexto.Click += new System.EventHandler(this.txtTexto_Click);
            this.txtTexto.TextChanged += new System.EventHandler(this.txtTexto_TextChanged);
            this.txtTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTexto_KeyPress);
            // 
            // dgvPlacar
            // 
            this.dgvPlacar.AllowUserToAddRows = false;
            this.dgvPlacar.AllowUserToDeleteRows = false;
            this.dgvPlacar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(111)))));
            this.dgvPlacar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlacar.GridColor = System.Drawing.Color.Black;
            this.dgvPlacar.Location = new System.Drawing.Point(52, 474);
            this.dgvPlacar.Name = "dgvPlacar";
            this.dgvPlacar.ReadOnly = true;
            this.dgvPlacar.Size = new System.Drawing.Size(644, 45);
            this.dgvPlacar.TabIndex = 2;
            // 
            // contador
            // 
            this.contador.AutoSize = true;
            this.contador.BackColor = System.Drawing.Color.Transparent;
            this.contador.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(111)))));
            this.contador.Location = new System.Drawing.Point(340, 97);
            this.contador.Name = "contador";
            this.contador.Size = new System.Drawing.Size(24, 16);
            this.contador.TabIndex = 4;
            this.contador.Text = "60";
            // 
            // lblqtdePalavras
            // 
            this.lblqtdePalavras.AutoSize = true;
            this.lblqtdePalavras.BackColor = System.Drawing.Color.Transparent;
            this.lblqtdePalavras.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtdePalavras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(111)))));
            this.lblqtdePalavras.Location = new System.Drawing.Point(477, 76);
            this.lblqtdePalavras.Name = "lblqtdePalavras";
            this.lblqtdePalavras.Size = new System.Drawing.Size(16, 16);
            this.lblqtdePalavras.TabIndex = 5;
            this.lblqtdePalavras.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(41)))));
            this.label1.Location = new System.Drawing.Point(246, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantidade de palavras do texto :";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(111)))));
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Transparent;
            this.btnSair.Location = new System.Drawing.Point(705, 561);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(40, 38);
            this.btnSair.TabIndex = 9;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(111)))));
            this.label3.Location = new System.Drawing.Point(349, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Placar";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.BackColor = System.Drawing.Color.Transparent;
            this.lblData.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(41)))));
            this.lblData.Location = new System.Drawing.Point(559, 9);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(0, 13);
            this.lblData.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(228, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Quantidade de palavras digitadas:";
            // 
            // lblqtdePalavrasDigitadas
            // 
            this.lblqtdePalavrasDigitadas.AutoSize = true;
            this.lblqtdePalavrasDigitadas.BackColor = System.Drawing.Color.Transparent;
            this.lblqtdePalavrasDigitadas.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqtdePalavrasDigitadas.ForeColor = System.Drawing.Color.Green;
            this.lblqtdePalavrasDigitadas.Location = new System.Drawing.Point(464, 394);
            this.lblqtdePalavrasDigitadas.Name = "lblqtdePalavrasDigitadas";
            this.lblqtdePalavrasDigitadas.Size = new System.Drawing.Size(16, 16);
            this.lblqtdePalavrasDigitadas.TabIndex = 13;
            this.lblqtdePalavrasDigitadas.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(41)))));
            this.label6.Location = new System.Drawing.Point(223, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(254, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quantidade de caracteres digitados:";
            // 
            // qtdeCaracterDigitados
            // 
            this.qtdeCaracterDigitados.AutoSize = true;
            this.qtdeCaracterDigitados.BackColor = System.Drawing.Color.Transparent;
            this.qtdeCaracterDigitados.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdeCaracterDigitados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(111)))));
            this.qtdeCaracterDigitados.Location = new System.Drawing.Point(474, 417);
            this.qtdeCaracterDigitados.Name = "qtdeCaracterDigitados";
            this.qtdeCaracterDigitados.Size = new System.Drawing.Size(16, 16);
            this.qtdeCaracterDigitados.TabIndex = 15;
            this.qtdeCaracterDigitados.Text = "0";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(41)))));
            this.lblNome.Location = new System.Drawing.Point(76, 10);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(25, 15);
            this.lblNome.TabIndex = 17;
            this.lblNome.Text = "lll";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(41)))));
            this.lblEmail.Location = new System.Drawing.Point(76, 36);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(25, 15);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "lll";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(111)))));
            this.label7.Location = new System.Drawing.Point(24, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(111)))));
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Jogador:";
            // 
            // Relogio
            // 
            this.Relogio.Interval = 1000;
            this.Relogio.Tick += new System.EventHandler(this.Relogio_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(111)))));
            this.label9.Location = new System.Drawing.Point(360, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "segundos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-21, 537);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(281, -6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 78);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(273, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Quantidade de erros:";
            // 
            // qtdeErro
            // 
            this.qtdeErro.AutoSize = true;
            this.qtdeErro.BackColor = System.Drawing.Color.Transparent;
            this.qtdeErro.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qtdeErro.ForeColor = System.Drawing.Color.Red;
            this.qtdeErro.Location = new System.Drawing.Point(421, 373);
            this.qtdeErro.Name = "qtdeErro";
            this.qtdeErro.Size = new System.Drawing.Size(16, 16);
            this.qtdeErro.TabIndex = 25;
            this.qtdeErro.Text = "0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(316, 91);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.Transparent;
            this.lblMensagem.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(111)))));
            this.lblMensagem.Location = new System.Drawing.Point(246, 266);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(255, 15);
            this.lblMensagem.TabIndex = 27;
            this.lblMensagem.Text = "Clique no espaço abaibo para iniciar...";
            // 
            // pbRelogioTempo
            // 
            this.pbRelogioTempo.Image = ((System.Drawing.Image)(resources.GetObject("pbRelogioTempo.Image")));
            this.pbRelogioTempo.Location = new System.Drawing.Point(305, 91);
            this.pbRelogioTempo.Name = "pbRelogioTempo";
            this.pbRelogioTempo.Size = new System.Drawing.Size(33, 37);
            this.pbRelogioTempo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbRelogioTempo.TabIndex = 28;
            this.pbRelogioTempo.TabStop = false;
            // 
            // txtCaixa
            // 
            this.txtCaixa.BackColor = System.Drawing.SystemColors.Control;
            this.txtCaixa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCaixa.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(111)))));
            this.txtCaixa.Location = new System.Drawing.Point(14, 134);
            this.txtCaixa.Multiline = true;
            this.txtCaixa.Name = "txtCaixa";
            this.txtCaixa.Size = new System.Drawing.Size(728, 114);
            this.txtCaixa.TabIndex = 30;
            // 
            // btnMute
            // 
            this.btnMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(41)))));
            this.btnMute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMute.BackgroundImage")));
            this.btnMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(41)))));
            this.btnMute.Location = new System.Drawing.Point(652, 47);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(44, 42);
            this.btnMute.TabIndex = 40;
            this.btnMute.UseVisualStyleBackColor = false;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnDesMute
            // 
            this.btnDesMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(41)))));
            this.btnDesMute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDesMute.BackgroundImage")));
            this.btnDesMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDesMute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesMute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(41)))));
            this.btnDesMute.Location = new System.Drawing.Point(701, 47);
            this.btnDesMute.Name = "btnDesMute";
            this.btnDesMute.Size = new System.Drawing.Size(44, 42);
            this.btnDesMute.TabIndex = 39;
            this.btnDesMute.UseVisualStyleBackColor = false;
            this.btnDesMute.Click += new System.EventHandler(this.btnDesMute_Click);
            // 
            // pbseta1
            // 
            this.pbseta1.Image = ((System.Drawing.Image)(resources.GetObject("pbseta1.Image")));
            this.pbseta1.Location = new System.Drawing.Point(150, 251);
            this.pbseta1.Name = "pbseta1";
            this.pbseta1.Size = new System.Drawing.Size(30, 31);
            this.pbseta1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbseta1.TabIndex = 41;
            this.pbseta1.TabStop = false;
            // 
            // pbseta2
            // 
            this.pbseta2.Image = ((System.Drawing.Image)(resources.GetObject("pbseta2.Image")));
            this.pbseta2.Location = new System.Drawing.Point(549, 251);
            this.pbseta2.Name = "pbseta2";
            this.pbseta2.Size = new System.Drawing.Size(30, 31);
            this.pbseta2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbseta2.TabIndex = 42;
            this.pbseta2.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(111)))));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(41)))));
            this.btnVoltar.Location = new System.Drawing.Point(323, 561);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(114, 38);
            this.btnVoltar.TabIndex = 43;
            this.btnVoltar.Text = "Escolher outro componente";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FM_Jogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 600);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pbseta2);
            this.Controls.Add(this.pbseta1);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnDesMute);
            this.Controls.Add(this.txtCaixa);
            this.Controls.Add(this.pbRelogioTempo);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.qtdeErro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.qtdeCaracterDigitados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblqtdePalavrasDigitadas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblqtdePalavras);
            this.Controls.Add(this.contador);
            this.Controls.Add(this.dgvPlacar);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnReinicia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FM_Jogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigiTime";
            this.Load += new System.EventHandler(this.Jogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelogioTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbseta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbseta2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.DataGridView dgvPlacar;
        private System.Windows.Forms.Label contador;
        private System.Windows.Forms.Label lblqtdePalavras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblqtdePalavrasDigitadas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label qtdeCaracterDigitados;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer Relogio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label qtdeErro;
        private System.Windows.Forms.Button btnReinicia;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.PictureBox pbRelogioTempo;
        private System.Windows.Forms.TextBox txtCaixa;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnDesMute;
        private System.Windows.Forms.PictureBox pbseta1;
        private System.Windows.Forms.PictureBox pbseta2;
        private System.Windows.Forms.Button btnVoltar;
    }
}

