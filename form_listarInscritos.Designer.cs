﻿namespace inscricaoEventodeCorrida
{
    partial class form_listarInscritos
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
            this.label7 = new System.Windows.Forms.Label();
            this.grupo_filtros = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.comboBox_sexo = new System.Windows.Forms.ComboBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grupo_resultado = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_numRegistros = new System.Windows.Forms.Label();
            this.id_inscricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_equipe = new System.Windows.Forms.Label();
            this.txt_equipe = new System.Windows.Forms.TextBox();
            this.grupo_filtros.SuspendLayout();
            this.grupo_resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "LISTAR  INSCRITOS";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // grupo_filtros
            // 
            this.grupo_filtros.Controls.Add(this.lbl_equipe);
            this.grupo_filtros.Controls.Add(this.txt_equipe);
            this.grupo_filtros.Controls.Add(this.label3);
            this.grupo_filtros.Controls.Add(this.textBox2);
            this.grupo_filtros.Controls.Add(this.comboBox1);
            this.grupo_filtros.Controls.Add(this.label4);
            this.grupo_filtros.Controls.Add(this.lbl_sexo);
            this.grupo_filtros.Controls.Add(this.label2);
            this.grupo_filtros.Controls.Add(this.btn_consulta);
            this.grupo_filtros.Controls.Add(this.comboBox_sexo);
            this.grupo_filtros.Controls.Add(this.txt_nome);
            this.grupo_filtros.Controls.Add(this.label1);
            this.grupo_filtros.Controls.Add(this.textBox1);
            this.grupo_filtros.Location = new System.Drawing.Point(53, 68);
            this.grupo_filtros.Name = "grupo_filtros";
            this.grupo_filtros.Size = new System.Drawing.Size(700, 126);
            this.grupo_filtros.TabIndex = 13;
            this.grupo_filtros.TabStop = false;
            this.grupo_filtros.Text = "Filtros de consulta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Evento";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(282, 24);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_sexo.TabIndex = 14;
            this.lbl_sexo.Text = "Sexo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome";
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(172, 81);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(141, 39);
            this.btn_consulta.TabIndex = 12;
            this.btn_consulta.Text = "CONSULTAR";
            this.btn_consulta.UseVisualStyleBackColor = true;
            // 
            // comboBox_sexo
            // 
            this.comboBox_sexo.FormattingEnabled = true;
            this.comboBox_sexo.Location = new System.Drawing.Point(285, 44);
            this.comboBox_sexo.Name = "comboBox_sexo";
            this.comboBox_sexo.Size = new System.Drawing.Size(70, 21);
            this.comboBox_sexo.TabIndex = 3;
            this.comboBox_sexo.Text = "selecione";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(62, 44);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(214, 20);
            this.txt_nome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Inscr.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(364, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "selecione";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(538, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cidade";
            // 
            // grupo_resultado
            // 
            this.grupo_resultado.Controls.Add(this.label5);
            this.grupo_resultado.Controls.Add(this.dataGridView1);
            this.grupo_resultado.Controls.Add(this.lbl_numRegistros);
            this.grupo_resultado.Location = new System.Drawing.Point(53, 210);
            this.grupo_resultado.Name = "grupo_resultado";
            this.grupo_resultado.Size = new System.Drawing.Size(700, 307);
            this.grupo_resultado.TabIndex = 15;
            this.grupo_resultado.TabStop = false;
            this.grupo_resultado.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(622, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Registros";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_inscricao,
            this.nome,
            this.sexo,
            this.equipe,
            this.cidade});
            this.dataGridView1.Location = new System.Drawing.Point(0, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(700, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // lbl_numRegistros
            // 
            this.lbl_numRegistros.AutoSize = true;
            this.lbl_numRegistros.Location = new System.Drawing.Point(680, 16);
            this.lbl_numRegistros.Name = "lbl_numRegistros";
            this.lbl_numRegistros.Size = new System.Drawing.Size(13, 13);
            this.lbl_numRegistros.TabIndex = 3;
            this.lbl_numRegistros.Text = "0";
            // 
            // id_inscricao
            // 
            this.id_inscricao.HeaderText = "ID";
            this.id_inscricao.Name = "id_inscricao";
            this.id_inscricao.ReadOnly = true;
            this.id_inscricao.Width = 50;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 255;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Width = 70;
            // 
            // equipe
            // 
            this.equipe.HeaderText = "Equipe";
            this.equipe.Name = "equipe";
            this.equipe.ReadOnly = true;
            this.equipe.Width = 150;
            // 
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 130;
            // 
            // lbl_equipe
            // 
            this.lbl_equipe.AutoSize = true;
            this.lbl_equipe.Location = new System.Drawing.Point(6, 75);
            this.lbl_equipe.Name = "lbl_equipe";
            this.lbl_equipe.Size = new System.Drawing.Size(40, 13);
            this.lbl_equipe.TabIndex = 20;
            this.lbl_equipe.Text = "Equipe";
            // 
            // txt_equipe
            // 
            this.txt_equipe.Location = new System.Drawing.Point(6, 93);
            this.txt_equipe.Name = "txt_equipe";
            this.txt_equipe.Size = new System.Drawing.Size(156, 20);
            this.txt_equipe.TabIndex = 19;
            // 
            // form_listarInscritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.grupo_resultado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grupo_filtros);
            this.Name = "form_listarInscritos";
            this.Text = "Listar Inscritos";
            this.grupo_filtros.ResumeLayout(false);
            this.grupo_filtros.PerformLayout();
            this.grupo_resultado.ResumeLayout(false);
            this.grupo_resultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grupo_filtros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.ComboBox comboBox_sexo;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_equipe;
        private System.Windows.Forms.TextBox txt_equipe;
        private System.Windows.Forms.GroupBox grupo_resultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_inscricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.Label lbl_numRegistros;
    }
}