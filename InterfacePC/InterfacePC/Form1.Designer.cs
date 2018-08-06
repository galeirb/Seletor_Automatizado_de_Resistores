﻿namespace InterfacePC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxSerialRx = new System.Windows.Forms.TextBox();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.cBoxCOMs = new System.Windows.Forms.ComboBox();
            this.txtBoxRRecebida = new System.Windows.Forms.TextBox();
            this.cBoxPeso1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAuto = new System.Windows.Forms.Button();
            this.txtBoxValor1 = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnNaoClica = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnLeituraRapida = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(353, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Monitor serial";
            // 
            // txtBoxSerialRx
            // 
            this.txtBoxSerialRx.Location = new System.Drawing.Point(269, 249);
            this.txtBoxSerialRx.Multiline = true;
            this.txtBoxSerialRx.Name = "txtBoxSerialRx";
            this.txtBoxSerialRx.ReadOnly = true;
            this.txtBoxSerialRx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxSerialRx.Size = new System.Drawing.Size(237, 85);
            this.txtBoxSerialRx.TabIndex = 20;
            this.txtBoxSerialRx.TextChanged += new System.EventHandler(this.txtBoxSerialRx_TextChanged);
            // 
            // SerialPort
            // 
            this.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // timerCOM
            // 
            this.timerCOM.Enabled = true;
            this.timerCOM.Interval = 1000;
            this.timerCOM.Tick += new System.EventHandler(this.timerCOM_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(591, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Resistências lidas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConectar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnConectar.Location = new System.Drawing.Point(19, 46);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 18;
            this.btnConectar.Text = "Conectar...";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click_1);
            // 
            // cBoxCOMs
            // 
            this.cBoxCOMs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxCOMs.FormattingEnabled = true;
            this.cBoxCOMs.Location = new System.Drawing.Point(63, 19);
            this.cBoxCOMs.Name = "cBoxCOMs";
            this.cBoxCOMs.Size = new System.Drawing.Size(75, 21);
            this.cBoxCOMs.TabIndex = 17;
            this.cBoxCOMs.SelectedIndexChanged += new System.EventHandler(this.cBoxCOMs_SelectedIndexChanged);
            // 
            // txtBoxRRecebida
            // 
            this.txtBoxRRecebida.Location = new System.Drawing.Point(522, 131);
            this.txtBoxRRecebida.Multiline = true;
            this.txtBoxRRecebida.Name = "txtBoxRRecebida";
            this.txtBoxRRecebida.ReadOnly = true;
            this.txtBoxRRecebida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxRRecebida.Size = new System.Drawing.Size(228, 203);
            this.txtBoxRRecebida.TabIndex = 15;
            this.txtBoxRRecebida.TextChanged += new System.EventHandler(this.txtBoxRRecebida_TextChanged);
            // 
            // cBoxPeso1
            // 
            this.cBoxPeso1.BackColor = System.Drawing.SystemColors.Window;
            this.cBoxPeso1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPeso1.FormattingEnabled = true;
            this.cBoxPeso1.Items.AddRange(new object[] {
            "Ω",
            "kΩ",
            "MΩ"});
            this.cBoxPeso1.Location = new System.Drawing.Point(80, 46);
            this.cBoxPeso1.Name = "cBoxPeso1";
            this.cBoxPeso1.Size = new System.Drawing.Size(54, 21);
            this.cBoxPeso1.TabIndex = 4;
            this.cBoxPeso1.SelectedIndexChanged += new System.EventHandler(this.cBoxPeso1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cBoxPeso1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAuto);
            this.groupBox1.Controls.Add(this.txtBoxValor1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(80, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 112);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleção do resistor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resistência desejada:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAuto.Location = new System.Drawing.Point(16, 77);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(54, 20);
            this.btnAuto.TabIndex = 25;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // txtBoxValor1
            // 
            this.txtBoxValor1.Location = new System.Drawing.Point(16, 46);
            this.txtBoxValor1.MaxLength = 5;
            this.txtBoxValor1.Name = "txtBoxValor1";
            this.txtBoxValor1.Size = new System.Drawing.Size(54, 20);
            this.txtBoxValor1.TabIndex = 0;
            this.txtBoxValor1.TextChanged += new System.EventHandler(this.txtBoxValor1_TextChanged);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(306, 198);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 16;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnDesconectar);
            this.groupBox2.Controls.Add(this.cBoxCOMs);
            this.groupBox2.Controls.Add(this.btnConectar);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(287, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 83);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conexão com Arduino";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDesconectar.Enabled = false;
            this.btnDesconectar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDesconectar.Location = new System.Drawing.Point(100, 46);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(81, 23);
            this.btnDesconectar.TabIndex = 19;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Location = new System.Drawing.Point(393, 198);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnNaoClica
            // 
            this.btnNaoClica.BackColor = System.Drawing.Color.White;
            this.btnNaoClica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNaoClica.Location = new System.Drawing.Point(726, 358);
            this.btnNaoClica.Name = "btnNaoClica";
            this.btnNaoClica.Size = new System.Drawing.Size(75, 26);
            this.btnNaoClica.TabIndex = 20;
            this.btnNaoClica.Text = "Sobre";
            this.btnNaoClica.UseVisualStyleBackColor = false;
            this.btnNaoClica.Click += new System.EventHandler(this.btnNaoClica_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.btnLeituraRapida);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(53, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Leitura Extrena";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(103, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "OFF";
            this.radioButton2.UseMnemonic = false;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(45, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 17);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.Text = "ON";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnLeituraRapida
            // 
            this.btnLeituraRapida.Enabled = false;
            this.btnLeituraRapida.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnLeituraRapida.Location = new System.Drawing.Point(45, 56);
            this.btnLeituraRapida.Name = "btnLeituraRapida";
            this.btnLeituraRapida.Size = new System.Drawing.Size(118, 23);
            this.btnLeituraRapida.TabIndex = 26;
            this.btnLeituraRapida.Text = "Leitura Rápida";
            this.btnLeituraRapida.UseVisualStyleBackColor = true;
            this.btnLeituraRapida.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::InterfacePC.Properties.Resources.Tela_de_execução;
            this.ClientSize = new System.Drawing.Size(804, 387);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnNaoClica);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxSerialRx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxRRecebida);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Separador Automatizado de Resistores";
            this.TransparencyKey = System.Drawing.Color.DodgerBlue;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxSerialRx;
        private System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Timer timerCOM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ComboBox cBoxCOMs;
        private System.Windows.Forms.TextBox txtBoxRRecebida;
        private System.Windows.Forms.ComboBox cBoxPeso1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxValor1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnNaoClica;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLeituraRapida;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

