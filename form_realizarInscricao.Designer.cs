namespace inscricaoEventodeCorrida
{
    partial class form_realizarInscricao
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
            this.grupo_dadosInscricao = new System.Windows.Forms.GroupBox();
            this.lbl_nomeAtleta = new System.Windows.Forms.Label();
            this.txt_nomeAtleta = new System.Windows.Forms.TextBox();
            this.lbl_percurso = new System.Windows.Forms.Label();
            this.comboBox_percurso = new System.Windows.Forms.ComboBox();
            this.lbl_evento = new System.Windows.Forms.Label();
            this.comboBox_evento = new System.Windows.Forms.ComboBox();
            this.btn_cadastrarEvento = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.grupo_dadosInscricao.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo_dadosInscricao
            // 
            this.grupo_dadosInscricao.Controls.Add(this.lbl_nomeAtleta);
            this.grupo_dadosInscricao.Controls.Add(this.txt_nomeAtleta);
            this.grupo_dadosInscricao.Controls.Add(this.lbl_percurso);
            this.grupo_dadosInscricao.Controls.Add(this.comboBox_percurso);
            this.grupo_dadosInscricao.Controls.Add(this.lbl_evento);
            this.grupo_dadosInscricao.Controls.Add(this.comboBox_evento);
            this.grupo_dadosInscricao.Location = new System.Drawing.Point(55, 74);
            this.grupo_dadosInscricao.Name = "grupo_dadosInscricao";
            this.grupo_dadosInscricao.Size = new System.Drawing.Size(700, 173);
            this.grupo_dadosInscricao.TabIndex = 0;
            this.grupo_dadosInscricao.TabStop = false;
            this.grupo_dadosInscricao.Text = "Dados da inscrição";
            this.grupo_dadosInscricao.Enter += new System.EventHandler(this.grupo_dadosInscricao_Enter);
            // 
            // lbl_nomeAtleta
            // 
            this.lbl_nomeAtleta.AutoSize = true;
            this.lbl_nomeAtleta.Location = new System.Drawing.Point(50, 96);
            this.lbl_nomeAtleta.Name = "lbl_nomeAtleta";
            this.lbl_nomeAtleta.Size = new System.Drawing.Size(80, 13);
            this.lbl_nomeAtleta.TabIndex = 31;
            this.lbl_nomeAtleta.Text = "Nome do Atleta";
            // 
            // txt_nomeAtleta
            // 
            this.txt_nomeAtleta.Location = new System.Drawing.Point(50, 113);
            this.txt_nomeAtleta.Name = "txt_nomeAtleta";
            this.txt_nomeAtleta.Size = new System.Drawing.Size(600, 20);
            this.txt_nomeAtleta.TabIndex = 30;
            // 
            // lbl_percurso
            // 
            this.lbl_percurso.AutoSize = true;
            this.lbl_percurso.Location = new System.Drawing.Point(520, 30);
            this.lbl_percurso.Name = "lbl_percurso";
            this.lbl_percurso.Size = new System.Drawing.Size(49, 13);
            this.lbl_percurso.TabIndex = 29;
            this.lbl_percurso.Text = "Percurso";
            // 
            // comboBox_percurso
            // 
            this.comboBox_percurso.FormattingEnabled = true;
            this.comboBox_percurso.Location = new System.Drawing.Point(520, 45);
            this.comboBox_percurso.Name = "comboBox_percurso";
            this.comboBox_percurso.Size = new System.Drawing.Size(130, 21);
            this.comboBox_percurso.TabIndex = 28;
            // 
            // lbl_evento
            // 
            this.lbl_evento.AutoSize = true;
            this.lbl_evento.Location = new System.Drawing.Point(52, 30);
            this.lbl_evento.Name = "lbl_evento";
            this.lbl_evento.Size = new System.Drawing.Size(41, 13);
            this.lbl_evento.TabIndex = 27;
            this.lbl_evento.Text = "Evento";
            // 
            // comboBox_evento
            // 
            this.comboBox_evento.FormattingEnabled = true;
            this.comboBox_evento.Location = new System.Drawing.Point(50, 45);
            this.comboBox_evento.Name = "comboBox_evento";
            this.comboBox_evento.Size = new System.Drawing.Size(443, 21);
            this.comboBox_evento.TabIndex = 26;
            // 
            // btn_cadastrarEvento
            // 
            this.btn_cadastrarEvento.Location = new System.Drawing.Point(335, 285);
            this.btn_cadastrarEvento.Name = "btn_cadastrarEvento";
            this.btn_cadastrarEvento.Size = new System.Drawing.Size(141, 39);
            this.btn_cadastrarEvento.TabIndex = 8;
            this.btn_cadastrarEvento.Text = "CADASTRAR";
            this.btn_cadastrarEvento.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "INSCRIÇÃO";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // form_realizarInscricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_cadastrarEvento);
            this.Controls.Add(this.grupo_dadosInscricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "form_realizarInscricao";
            this.Text = "Inscrição";
            this.grupo_dadosInscricao.ResumeLayout(false);
            this.grupo_dadosInscricao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo_dadosInscricao;
        private System.Windows.Forms.Button btn_cadastrarEvento;
        private System.Windows.Forms.Label lbl_nomeAtleta;
        private System.Windows.Forms.TextBox txt_nomeAtleta;
        private System.Windows.Forms.Label lbl_percurso;
        private System.Windows.Forms.ComboBox comboBox_percurso;
        private System.Windows.Forms.Label lbl_evento;
        private System.Windows.Forms.ComboBox comboBox_evento;
        private System.Windows.Forms.Label label7;
    }
}