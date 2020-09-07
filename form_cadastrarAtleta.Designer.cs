namespace inscricaoEventodeCorrida
{
    partial class form_cadastrarAtleta
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.select_sexo = new System.Windows.Forms.ComboBox();
            this.grupo_dadosPessoais = new System.Windows.Forms.GroupBox();
            this.lbl_equipe = new System.Windows.Forms.Label();
            this.txt_equipe = new System.Windows.Forms.TextBox();
            this.lbl_alergia = new System.Windows.Forms.Label();
            this.lbl_telefone = new System.Windows.Forms.Label();
            this.txt_alergia = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_cod_area = new System.Windows.Forms.TextBox();
            this.lbl_cod_cidade = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.lbl_bairro = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.lbl_endereco = new System.Windows.Forms.Label();
            this.txt_tipo_sangue = new System.Windows.Forms.TextBox();
            this.lbl_tipo_sangue = new System.Windows.Forms.Label();
            this.txt_nascimento = new System.Windows.Forms.TextBox();
            this.lbl_nascimento = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_cadastrarAtleta = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.grupo_dadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(47, 26);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome";
            this.lbl_nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(52, 43);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(446, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // select_sexo
            // 
            this.select_sexo.FormattingEnabled = true;
            this.select_sexo.Location = new System.Drawing.Point(516, 42);
            this.select_sexo.Name = "select_sexo";
            this.select_sexo.Size = new System.Drawing.Size(131, 21);
            this.select_sexo.TabIndex = 2;
            // 
            // grupo_dadosPessoais
            // 
            this.grupo_dadosPessoais.Controls.Add(this.lbl_equipe);
            this.grupo_dadosPessoais.Controls.Add(this.txt_equipe);
            this.grupo_dadosPessoais.Controls.Add(this.lbl_alergia);
            this.grupo_dadosPessoais.Controls.Add(this.lbl_telefone);
            this.grupo_dadosPessoais.Controls.Add(this.txt_alergia);
            this.grupo_dadosPessoais.Controls.Add(this.txt_telefone);
            this.grupo_dadosPessoais.Controls.Add(this.txt_cod_area);
            this.grupo_dadosPessoais.Controls.Add(this.lbl_cod_cidade);
            this.grupo_dadosPessoais.Controls.Add(this.lbl_sexo);
            this.grupo_dadosPessoais.Controls.Add(this.comboBox2);
            this.grupo_dadosPessoais.Controls.Add(this.label9);
            this.grupo_dadosPessoais.Controls.Add(this.txt_cidade);
            this.grupo_dadosPessoais.Controls.Add(this.lbl_cidade);
            this.grupo_dadosPessoais.Controls.Add(this.txt_bairro);
            this.grupo_dadosPessoais.Controls.Add(this.lbl_bairro);
            this.grupo_dadosPessoais.Controls.Add(this.txt_numero);
            this.grupo_dadosPessoais.Controls.Add(this.lbl_numero);
            this.grupo_dadosPessoais.Controls.Add(this.txt_endereco);
            this.grupo_dadosPessoais.Controls.Add(this.lbl_endereco);
            this.grupo_dadosPessoais.Controls.Add(this.txt_tipo_sangue);
            this.grupo_dadosPessoais.Controls.Add(this.lbl_tipo_sangue);
            this.grupo_dadosPessoais.Controls.Add(this.txt_nascimento);
            this.grupo_dadosPessoais.Controls.Add(this.lbl_nascimento);
            this.grupo_dadosPessoais.Controls.Add(this.txt_email);
            this.grupo_dadosPessoais.Controls.Add(this.lbl_email);
            this.grupo_dadosPessoais.Controls.Add(this.txt_nome);
            this.grupo_dadosPessoais.Controls.Add(this.lbl_nome);
            this.grupo_dadosPessoais.Controls.Add(this.select_sexo);
            this.grupo_dadosPessoais.Location = new System.Drawing.Point(50, 68);
            this.grupo_dadosPessoais.Name = "grupo_dadosPessoais";
            this.grupo_dadosPessoais.Size = new System.Drawing.Size(701, 379);
            this.grupo_dadosPessoais.TabIndex = 5;
            this.grupo_dadosPessoais.TabStop = false;
            this.grupo_dadosPessoais.Text = "Dados pessoais";
            // 
            // lbl_equipe
            // 
            this.lbl_equipe.AutoSize = true;
            this.lbl_equipe.Location = new System.Drawing.Point(52, 322);
            this.lbl_equipe.Name = "lbl_equipe";
            this.lbl_equipe.Size = new System.Drawing.Size(40, 13);
            this.lbl_equipe.TabIndex = 32;
            this.lbl_equipe.Text = "Equipe";
            // 
            // txt_equipe
            // 
            this.txt_equipe.Location = new System.Drawing.Point(52, 338);
            this.txt_equipe.Name = "txt_equipe";
            this.txt_equipe.Size = new System.Drawing.Size(287, 20);
            this.txt_equipe.TabIndex = 31;
            // 
            // lbl_alergia
            // 
            this.lbl_alergia.AutoSize = true;
            this.lbl_alergia.Location = new System.Drawing.Point(359, 261);
            this.lbl_alergia.Name = "lbl_alergia";
            this.lbl_alergia.Size = new System.Drawing.Size(82, 13);
            this.lbl_alergia.TabIndex = 30;
            this.lbl_alergia.Text = "Alguma alergia?";
            // 
            // lbl_telefone
            // 
            this.lbl_telefone.AutoSize = true;
            this.lbl_telefone.Location = new System.Drawing.Point(210, 261);
            this.lbl_telefone.Name = "lbl_telefone";
            this.lbl_telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_telefone.TabIndex = 29;
            this.lbl_telefone.Text = "Telefone";
            // 
            // txt_alergia
            // 
            this.txt_alergia.Location = new System.Drawing.Point(359, 277);
            this.txt_alergia.Name = "txt_alergia";
            this.txt_alergia.Size = new System.Drawing.Size(287, 20);
            this.txt_alergia.TabIndex = 27;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(210, 277);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(131, 20);
            this.txt_telefone.TabIndex = 25;
            // 
            // txt_cod_area
            // 
            this.txt_cod_area.Location = new System.Drawing.Point(52, 278);
            this.txt_cod_area.Name = "txt_cod_area";
            this.txt_cod_area.Size = new System.Drawing.Size(131, 20);
            this.txt_cod_area.TabIndex = 23;
            // 
            // lbl_cod_cidade
            // 
            this.lbl_cod_cidade.AutoSize = true;
            this.lbl_cod_cidade.Location = new System.Drawing.Point(52, 261);
            this.lbl_cod_cidade.Name = "lbl_cod_cidade";
            this.lbl_cod_cidade.Size = new System.Drawing.Size(53, 13);
            this.lbl_cod_cidade.TabIndex = 22;
            this.lbl_cod_cidade.Text = "Cód. área";
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Location = new System.Drawing.Point(516, 26);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(31, 13);
            this.lbl_sexo.TabIndex = 21;
            this.lbl_sexo.Text = "Sexo";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(584, 216);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(63, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(584, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "UF";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(359, 216);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(220, 20);
            this.txt_cidade.TabIndex = 18;
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(359, 199);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(40, 13);
            this.lbl_cidade.TabIndex = 17;
            this.lbl_cidade.Text = "Cidade";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(52, 216);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(289, 20);
            this.txt_bairro.TabIndex = 16;
            // 
            // lbl_bairro
            // 
            this.lbl_bairro.AutoSize = true;
            this.lbl_bairro.Location = new System.Drawing.Point(50, 199);
            this.lbl_bairro.Name = "lbl_bairro";
            this.lbl_bairro.Size = new System.Drawing.Size(34, 13);
            this.lbl_bairro.TabIndex = 15;
            this.lbl_bairro.Text = "Bairro";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(516, 161);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(131, 20);
            this.txt_numero.TabIndex = 14;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(516, 144);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_numero.TabIndex = 13;
            this.lbl_numero.Text = "Número";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(52, 161);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(446, 20);
            this.txt_endereco.TabIndex = 12;
            // 
            // lbl_endereco
            // 
            this.lbl_endereco.AutoSize = true;
            this.lbl_endereco.Location = new System.Drawing.Point(52, 144);
            this.lbl_endereco.Name = "lbl_endereco";
            this.lbl_endereco.Size = new System.Drawing.Size(53, 13);
            this.lbl_endereco.TabIndex = 11;
            this.lbl_endereco.Text = "Endereço";
            // 
            // txt_tipo_sangue
            // 
            this.txt_tipo_sangue.Location = new System.Drawing.Point(516, 102);
            this.txt_tipo_sangue.Name = "txt_tipo_sangue";
            this.txt_tipo_sangue.Size = new System.Drawing.Size(131, 20);
            this.txt_tipo_sangue.TabIndex = 9;
            // 
            // lbl_tipo_sangue
            // 
            this.lbl_tipo_sangue.AutoSize = true;
            this.lbl_tipo_sangue.Location = new System.Drawing.Point(516, 85);
            this.lbl_tipo_sangue.Name = "lbl_tipo_sangue";
            this.lbl_tipo_sangue.Size = new System.Drawing.Size(66, 13);
            this.lbl_tipo_sangue.TabIndex = 8;
            this.lbl_tipo_sangue.Text = "Tipo sangue";
            // 
            // txt_nascimento
            // 
            this.txt_nascimento.Location = new System.Drawing.Point(359, 102);
            this.txt_nascimento.Name = "txt_nascimento";
            this.txt_nascimento.Size = new System.Drawing.Size(131, 20);
            this.txt_nascimento.TabIndex = 7;
            // 
            // lbl_nascimento
            // 
            this.lbl_nascimento.AutoSize = true;
            this.lbl_nascimento.Location = new System.Drawing.Point(367, 85);
            this.lbl_nascimento.Name = "lbl_nascimento";
            this.lbl_nascimento.Size = new System.Drawing.Size(87, 13);
            this.lbl_nascimento.TabIndex = 6;
            this.lbl_nascimento.Text = "Data nascimento";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(52, 102);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(289, 20);
            this.txt_email.TabIndex = 4;
            this.txt_email.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(52, 85);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "E-mail";
            this.lbl_email.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_cadastrarAtleta
            // 
            this.btn_cadastrarAtleta.Location = new System.Drawing.Point(339, 461);
            this.btn_cadastrarAtleta.Name = "btn_cadastrarAtleta";
            this.btn_cadastrarAtleta.Size = new System.Drawing.Size(141, 39);
            this.btn_cadastrarAtleta.TabIndex = 6;
            this.btn_cadastrarAtleta.Text = "CADASTRAR";
            this.btn_cadastrarAtleta.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "CADASTRAR ATLETA";
            // 
            // form_cadastrarAtleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_cadastrarAtleta);
            this.Controls.Add(this.grupo_dadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "form_cadastrarAtleta";
            this.Text = "Cadastrar Atleta";
            this.grupo_dadosPessoais.ResumeLayout(false);
            this.grupo_dadosPessoais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.ComboBox select_sexo;
        private System.Windows.Forms.GroupBox grupo_dadosPessoais;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label lbl_bairro;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label lbl_endereco;
        private System.Windows.Forms.TextBox txt_tipo_sangue;
        private System.Windows.Forms.Label lbl_tipo_sangue;
        private System.Windows.Forms.TextBox txt_nascimento;
        private System.Windows.Forms.Label lbl_nascimento;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbl_telefone;
        private System.Windows.Forms.TextBox txt_alergia;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_cod_area;
        private System.Windows.Forms.Label lbl_cod_cidade;
        private System.Windows.Forms.Label lbl_equipe;
        private System.Windows.Forms.TextBox txt_equipe;
        private System.Windows.Forms.Label lbl_alergia;
        private System.Windows.Forms.Button btn_cadastrarAtleta;
        private System.Windows.Forms.Label label7;
    }
}