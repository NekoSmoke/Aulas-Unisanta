namespace WindowsFormsApp3
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rbt_Deslocamento = new System.Windows.Forms.RadioButton();
            this.Rbt_Periodo = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_Tempo = new System.Windows.Forms.TextBox();
            this.Txt_Angulo = new System.Windows.Forms.TextBox();
            this.Txt_Comprimento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Calcular = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.Gbx_Ensaio = new System.Windows.Forms.GroupBox();
            this.Lbx_Ensaio = new System.Windows.Forms.ListBox();
            this.Lbl_DataHora = new System.Windows.Forms.Label();
            this.Tmr_DataHora = new System.Windows.Forms.Timer(this.components);
            this.Pbx_Pendulo = new System.Windows.Forms.PictureBox();
            this.Tmr_Animacao = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Gbx_Ensaio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Pendulo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rbt_Deslocamento);
            this.groupBox1.Controls.Add(this.Rbt_Periodo);
            this.groupBox1.Location = new System.Drawing.Point(479, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o estado";
            // 
            // Rbt_Deslocamento
            // 
            this.Rbt_Deslocamento.AutoSize = true;
            this.Rbt_Deslocamento.Location = new System.Drawing.Point(230, 33);
            this.Rbt_Deslocamento.Name = "Rbt_Deslocamento";
            this.Rbt_Deslocamento.Size = new System.Drawing.Size(93, 17);
            this.Rbt_Deslocamento.TabIndex = 1;
            this.Rbt_Deslocamento.TabStop = true;
            this.Rbt_Deslocamento.Text = "Deslocamento";
            this.Rbt_Deslocamento.UseVisualStyleBackColor = true;
            // 
            // Rbt_Periodo
            // 
            this.Rbt_Periodo.AutoSize = true;
            this.Rbt_Periodo.Location = new System.Drawing.Point(52, 33);
            this.Rbt_Periodo.Name = "Rbt_Periodo";
            this.Rbt_Periodo.Size = new System.Drawing.Size(61, 17);
            this.Rbt_Periodo.TabIndex = 0;
            this.Rbt_Periodo.TabStop = true;
            this.Rbt_Periodo.Text = "Periodo";
            this.Rbt_Periodo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_Tempo);
            this.groupBox2.Controls.Add(this.Txt_Angulo);
            this.groupBox2.Controls.Add(this.Txt_Comprimento);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(479, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 178);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dado do Pêndulo";
            // 
            // Txt_Tempo
            // 
            this.Txt_Tempo.Location = new System.Drawing.Point(95, 124);
            this.Txt_Tempo.Name = "Txt_Tempo";
            this.Txt_Tempo.Size = new System.Drawing.Size(100, 20);
            this.Txt_Tempo.TabIndex = 8;
            // 
            // Txt_Angulo
            // 
            this.Txt_Angulo.Location = new System.Drawing.Point(95, 83);
            this.Txt_Angulo.Name = "Txt_Angulo";
            this.Txt_Angulo.Size = new System.Drawing.Size(100, 20);
            this.Txt_Angulo.TabIndex = 7;
            // 
            // Txt_Comprimento
            // 
            this.Txt_Comprimento.Location = new System.Drawing.Point(95, 34);
            this.Txt_Comprimento.Name = "Txt_Comprimento";
            this.Txt_Comprimento.Size = new System.Drawing.Size(100, 20);
            this.Txt_Comprimento.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "(s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "(°)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "(cm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ângulo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comprimento";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_Calcular);
            this.groupBox3.Controls.Add(this.Btn_Limpar);
            this.groupBox3.Location = new System.Drawing.Point(12, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 214);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // Btn_Calcular
            // 
            this.Btn_Calcular.Image = global::WindowsFormsApp3.Properties.Resources.calcular;
            this.Btn_Calcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Calcular.Location = new System.Drawing.Point(7, 114);
            this.Btn_Calcular.Name = "Btn_Calcular";
            this.Btn_Calcular.Size = new System.Drawing.Size(433, 94);
            this.Btn_Calcular.TabIndex = 1;
            this.Btn_Calcular.Text = "Calcular";
            this.Btn_Calcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Calcular.UseVisualStyleBackColor = true;
            this.Btn_Calcular.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.Image = global::WindowsFormsApp3.Properties.Resources.Limpar1;
            this.Btn_Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpar.Location = new System.Drawing.Point(7, 14);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(433, 94);
            this.Btn_Limpar.TabIndex = 0;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Limpar.UseVisualStyleBackColor = true;
            this.Btn_Limpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gbx_Ensaio
            // 
            this.Gbx_Ensaio.Controls.Add(this.Lbx_Ensaio);
            this.Gbx_Ensaio.Location = new System.Drawing.Point(479, 278);
            this.Gbx_Ensaio.Name = "Gbx_Ensaio";
            this.Gbx_Ensaio.Size = new System.Drawing.Size(362, 293);
            this.Gbx_Ensaio.TabIndex = 9;
            this.Gbx_Ensaio.TabStop = false;
            this.Gbx_Ensaio.Text = "Ensaio";
            // 
            // Lbx_Ensaio
            // 
            this.Lbx_Ensaio.FormattingEnabled = true;
            this.Lbx_Ensaio.Location = new System.Drawing.Point(7, 20);
            this.Lbx_Ensaio.Name = "Lbx_Ensaio";
            this.Lbx_Ensaio.Size = new System.Drawing.Size(349, 264);
            this.Lbx_Ensaio.TabIndex = 0;
            // 
            // Lbl_DataHora
            // 
            this.Lbl_DataHora.AutoSize = true;
            this.Lbl_DataHora.Location = new System.Drawing.Point(191, 549);
            this.Lbl_DataHora.Name = "Lbl_DataHora";
            this.Lbl_DataHora.Size = new System.Drawing.Size(65, 13);
            this.Lbl_DataHora.TabIndex = 10;
            this.Lbl_DataHora.Text = "Data e Hora";
            // 
            // Tmr_DataHora
            // 
            this.Tmr_DataHora.Enabled = true;
            this.Tmr_DataHora.Tick += new System.EventHandler(this.Tmr_DataHora_Tick);
            // 
            // Pbx_Pendulo
            // 
            this.Pbx_Pendulo.Image = global::WindowsFormsApp3.Properties.Resources.Pend1;
            this.Pbx_Pendulo.Location = new System.Drawing.Point(12, 12);
            this.Pbx_Pendulo.Name = "Pbx_Pendulo";
            this.Pbx_Pendulo.Size = new System.Drawing.Size(440, 302);
            this.Pbx_Pendulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Pendulo.TabIndex = 11;
            this.Pbx_Pendulo.TabStop = false;
            // 
            // Tmr_Animacao
            // 
            this.Tmr_Animacao.Enabled = true;
            this.Tmr_Animacao.Tick += new System.EventHandler(this.Tmr_Animacao_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 583);
            this.Controls.Add(this.Pbx_Pendulo);
            this.Controls.Add(this.Lbl_DataHora);
            this.Controls.Add(this.Gbx_Ensaio);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.Gbx_Ensaio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Pendulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rbt_Deslocamento;
        private System.Windows.Forms.RadioButton Rbt_Periodo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_Tempo;
        private System.Windows.Forms.TextBox Txt_Angulo;
        private System.Windows.Forms.TextBox Txt_Comprimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_Calcular;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.GroupBox Gbx_Ensaio;
        private System.Windows.Forms.ListBox Lbx_Ensaio;
        private System.Windows.Forms.Label Lbl_DataHora;
        private System.Windows.Forms.Timer Tmr_DataHora;
        private System.Windows.Forms.PictureBox Pbx_Pendulo;
        private System.Windows.Forms.Timer Tmr_Animacao;
    }
}

