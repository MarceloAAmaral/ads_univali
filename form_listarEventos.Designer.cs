namespace inscricaoEventodeCorrida
{
    partial class form_listarEventos
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.txt_evento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grupo_resultado = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_numRegistros = new System.Windows.Forms.Label();
            this.id_inscricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo_filtros.SuspendLayout();
            this.grupo_resultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "LISTAR  EVENTOS";
            // 
            // grupo_filtros
            // 
            this.grupo_filtros.Controls.Add(this.label3);
            this.grupo_filtros.Controls.Add(this.txt_data);
            this.grupo_filtros.Controls.Add(this.label2);
            this.grupo_filtros.Controls.Add(this.btn_consulta);
            this.grupo_filtros.Controls.Add(this.txt_evento);
            this.grupo_filtros.Controls.Add(this.label1);
            this.grupo_filtros.Controls.Add(this.textBox1);
            this.grupo_filtros.Location = new System.Drawing.Point(53, 69);
            this.grupo_filtros.Name = "grupo_filtros";
            this.grupo_filtros.Size = new System.Drawing.Size(700, 84);
            this.grupo_filtros.TabIndex = 15;
            this.grupo_filtros.TabStop = false;
            this.grupo_filtros.Text = "Filtros de consulta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(353, 44);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(156, 20);
            this.txt_data.TabIndex = 17;
            this.txt_data.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Evento";
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(540, 25);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(141, 39);
            this.btn_consulta.TabIndex = 12;
            this.btn_consulta.Text = "CONSULTAR";
            this.btn_consulta.UseVisualStyleBackColor = true;
            // 
            // txt_evento
            // 
            this.txt_evento.Location = new System.Drawing.Point(67, 44);
            this.txt_evento.Name = "txt_evento";
            this.txt_evento.Size = new System.Drawing.Size(280, 20);
            this.txt_evento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Evento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 0;
            // 
            // grupo_resultado
            // 
            this.grupo_resultado.Controls.Add(this.label5);
            this.grupo_resultado.Controls.Add(this.dataGridView1);
            this.grupo_resultado.Controls.Add(this.lbl_numRegistros);
            this.grupo_resultado.Location = new System.Drawing.Point(53, 159);
            this.grupo_resultado.Name = "grupo_resultado";
            this.grupo_resultado.Size = new System.Drawing.Size(700, 327);
            this.grupo_resultado.TabIndex = 17;
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
            this.evento,
            this.data,
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
            // evento
            // 
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            this.evento.ReadOnly = true;
            this.evento.Width = 245;
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 130;
            // 
            // form_listarEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.grupo_resultado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grupo_filtros);
            this.Name = "form_listarEventos";
            this.Text = "Listar Eventos";
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
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.TextBox txt_evento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grupo_resultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_numRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_inscricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
    }
}