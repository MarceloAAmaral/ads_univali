namespace inscricaoEventodeCorrida
{
    partial class form_excluirEvento
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
            this.grupo_consulta = new System.Windows.Forms.GroupBox();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.lbl_idAtleta = new System.Windows.Forms.Label();
            this.txt_idEvento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grupo_dadosEvento = new System.Windows.Forms.GroupBox();
            this.checkbox_42km = new System.Windows.Forms.CheckBox();
            this.checkbox_21km = new System.Windows.Forms.CheckBox();
            this.checkbox_10km = new System.Windows.Forms.CheckBox();
            this.checkbox_5km = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_etapa = new System.Windows.Forms.Label();
            this.lbl_horario = new System.Windows.Forms.Label();
            this.txt_etapa = new System.Windows.Forms.TextBox();
            this.txt_horario = new System.Windows.Forms.TextBox();
            this.lbl_local = new System.Windows.Forms.Label();
            this.txt_local = new System.Windows.Forms.TextBox();
            this.lbl_data = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.lbl_evento = new System.Windows.Forms.Label();
            this.txt_evento = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.grupo_consulta.SuspendLayout();
            this.grupo_dadosEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupo_consulta
            // 
            this.grupo_consulta.Controls.Add(this.btn_consulta);
            this.grupo_consulta.Controls.Add(this.lbl_idAtleta);
            this.grupo_consulta.Controls.Add(this.txt_idEvento);
            this.grupo_consulta.Location = new System.Drawing.Point(49, 66);
            this.grupo_consulta.Name = "grupo_consulta";
            this.grupo_consulta.Size = new System.Drawing.Size(701, 66);
            this.grupo_consulta.TabIndex = 12;
            this.grupo_consulta.TabStop = false;
            this.grupo_consulta.Text = "Consulta";
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(154, 18);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(141, 39);
            this.btn_consulta.TabIndex = 11;
            this.btn_consulta.Text = "CONSULTAR";
            this.btn_consulta.UseVisualStyleBackColor = true;
            // 
            // lbl_idAtleta
            // 
            this.lbl_idAtleta.AutoSize = true;
            this.lbl_idAtleta.Location = new System.Drawing.Point(52, 21);
            this.lbl_idAtleta.Name = "lbl_idAtleta";
            this.lbl_idAtleta.Size = new System.Drawing.Size(55, 13);
            this.lbl_idAtleta.TabIndex = 33;
            this.lbl_idAtleta.Text = "ID Evento";
            // 
            // txt_idEvento
            // 
            this.txt_idEvento.BackColor = System.Drawing.SystemColors.Window;
            this.txt_idEvento.Location = new System.Drawing.Point(52, 37);
            this.txt_idEvento.Name = "txt_idEvento";
            this.txt_idEvento.Size = new System.Drawing.Size(50, 20);
            this.txt_idEvento.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "EXCLUIR EVENTO";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // grupo_dadosEvento
            // 
            this.grupo_dadosEvento.Controls.Add(this.checkbox_42km);
            this.grupo_dadosEvento.Controls.Add(this.checkbox_21km);
            this.grupo_dadosEvento.Controls.Add(this.checkbox_10km);
            this.grupo_dadosEvento.Controls.Add(this.checkbox_5km);
            this.grupo_dadosEvento.Controls.Add(this.label6);
            this.grupo_dadosEvento.Controls.Add(this.lbl_etapa);
            this.grupo_dadosEvento.Controls.Add(this.lbl_horario);
            this.grupo_dadosEvento.Controls.Add(this.txt_etapa);
            this.grupo_dadosEvento.Controls.Add(this.txt_horario);
            this.grupo_dadosEvento.Controls.Add(this.lbl_local);
            this.grupo_dadosEvento.Controls.Add(this.txt_local);
            this.grupo_dadosEvento.Controls.Add(this.lbl_data);
            this.grupo_dadosEvento.Controls.Add(this.txt_data);
            this.grupo_dadosEvento.Controls.Add(this.lbl_evento);
            this.grupo_dadosEvento.Controls.Add(this.txt_evento);
            this.grupo_dadosEvento.Location = new System.Drawing.Point(49, 147);
            this.grupo_dadosEvento.Name = "grupo_dadosEvento";
            this.grupo_dadosEvento.Size = new System.Drawing.Size(700, 208);
            this.grupo_dadosEvento.TabIndex = 34;
            this.grupo_dadosEvento.TabStop = false;
            this.grupo_dadosEvento.Text = "Dados do evento";
            // 
            // checkbox_42km
            // 
            this.checkbox_42km.AutoSize = true;
            this.checkbox_42km.Enabled = false;
            this.checkbox_42km.Location = new System.Drawing.Point(284, 161);
            this.checkbox_42km.Name = "checkbox_42km";
            this.checkbox_42km.Size = new System.Drawing.Size(53, 17);
            this.checkbox_42km.TabIndex = 27;
            this.checkbox_42km.Text = "42Km";
            this.checkbox_42km.UseVisualStyleBackColor = true;
            // 
            // checkbox_21km
            // 
            this.checkbox_21km.AutoSize = true;
            this.checkbox_21km.Enabled = false;
            this.checkbox_21km.Location = new System.Drawing.Point(207, 161);
            this.checkbox_21km.Name = "checkbox_21km";
            this.checkbox_21km.Size = new System.Drawing.Size(53, 17);
            this.checkbox_21km.TabIndex = 26;
            this.checkbox_21km.Text = "21Km";
            this.checkbox_21km.UseVisualStyleBackColor = true;
            // 
            // checkbox_10km
            // 
            this.checkbox_10km.AutoSize = true;
            this.checkbox_10km.Enabled = false;
            this.checkbox_10km.Location = new System.Drawing.Point(125, 161);
            this.checkbox_10km.Name = "checkbox_10km";
            this.checkbox_10km.Size = new System.Drawing.Size(53, 17);
            this.checkbox_10km.TabIndex = 25;
            this.checkbox_10km.Text = "10Km";
            this.checkbox_10km.UseVisualStyleBackColor = true;
            // 
            // checkbox_5km
            // 
            this.checkbox_5km.AutoSize = true;
            this.checkbox_5km.Enabled = false;
            this.checkbox_5km.Location = new System.Drawing.Point(54, 161);
            this.checkbox_5km.Name = "checkbox_5km";
            this.checkbox_5km.Size = new System.Drawing.Size(47, 17);
            this.checkbox_5km.TabIndex = 24;
            this.checkbox_5km.Text = "5Km";
            this.checkbox_5km.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Percurso";
            // 
            // lbl_etapa
            // 
            this.lbl_etapa.AutoSize = true;
            this.lbl_etapa.Location = new System.Drawing.Point(519, 79);
            this.lbl_etapa.Name = "lbl_etapa";
            this.lbl_etapa.Size = new System.Drawing.Size(35, 13);
            this.lbl_etapa.TabIndex = 21;
            this.lbl_etapa.Text = "Etapa";
            // 
            // lbl_horario
            // 
            this.lbl_horario.AutoSize = true;
            this.lbl_horario.Location = new System.Drawing.Point(364, 79);
            this.lbl_horario.Name = "lbl_horario";
            this.lbl_horario.Size = new System.Drawing.Size(41, 13);
            this.lbl_horario.TabIndex = 20;
            this.lbl_horario.Text = "Horário";
            // 
            // txt_etapa
            // 
            this.txt_etapa.BackColor = System.Drawing.SystemColors.Window;
            this.txt_etapa.Enabled = false;
            this.txt_etapa.Location = new System.Drawing.Point(519, 95);
            this.txt_etapa.Name = "txt_etapa";
            this.txt_etapa.Size = new System.Drawing.Size(130, 20);
            this.txt_etapa.TabIndex = 19;
            // 
            // txt_horario
            // 
            this.txt_horario.BackColor = System.Drawing.SystemColors.Window;
            this.txt_horario.Enabled = false;
            this.txt_horario.Location = new System.Drawing.Point(364, 95);
            this.txt_horario.Name = "txt_horario";
            this.txt_horario.Size = new System.Drawing.Size(130, 20);
            this.txt_horario.TabIndex = 18;
            // 
            // lbl_local
            // 
            this.lbl_local.AutoSize = true;
            this.lbl_local.Location = new System.Drawing.Point(53, 79);
            this.lbl_local.Name = "lbl_local";
            this.lbl_local.Size = new System.Drawing.Size(84, 13);
            this.lbl_local.TabIndex = 7;
            this.lbl_local.Text = "Local do evento";
            // 
            // txt_local
            // 
            this.txt_local.Enabled = false;
            this.txt_local.Location = new System.Drawing.Point(54, 95);
            this.txt_local.Name = "txt_local";
            this.txt_local.Size = new System.Drawing.Size(283, 20);
            this.txt_local.TabIndex = 6;
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(515, 17);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(66, 13);
            this.lbl_data.TabIndex = 3;
            this.lbl_data.Text = "Data evento";
            // 
            // txt_data
            // 
            this.txt_data.Enabled = false;
            this.txt_data.Location = new System.Drawing.Point(519, 35);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(130, 20);
            this.txt_data.TabIndex = 2;
            // 
            // lbl_evento
            // 
            this.lbl_evento.AutoSize = true;
            this.lbl_evento.Location = new System.Drawing.Point(51, 19);
            this.lbl_evento.Name = "lbl_evento";
            this.lbl_evento.Size = new System.Drawing.Size(41, 13);
            this.lbl_evento.TabIndex = 1;
            this.lbl_evento.Text = "Evento";
            // 
            // txt_evento
            // 
            this.txt_evento.Enabled = false;
            this.txt_evento.Location = new System.Drawing.Point(51, 35);
            this.txt_evento.Name = "txt_evento";
            this.txt_evento.Size = new System.Drawing.Size(443, 20);
            this.txt_evento.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(333, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 39);
            this.button2.TabIndex = 35;
            this.button2.Text = "EXCLUIR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // form_excluirEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grupo_dadosEvento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grupo_consulta);
            this.Name = "form_excluirEvento";
            this.Text = "Excluir Evento";
            this.grupo_consulta.ResumeLayout(false);
            this.grupo_consulta.PerformLayout();
            this.grupo_dadosEvento.ResumeLayout(false);
            this.grupo_dadosEvento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupo_consulta;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Label lbl_idAtleta;
        private System.Windows.Forms.TextBox txt_idEvento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grupo_dadosEvento;
        private System.Windows.Forms.CheckBox checkbox_42km;
        private System.Windows.Forms.CheckBox checkbox_21km;
        private System.Windows.Forms.CheckBox checkbox_10km;
        private System.Windows.Forms.CheckBox checkbox_5km;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_etapa;
        private System.Windows.Forms.Label lbl_horario;
        private System.Windows.Forms.TextBox txt_etapa;
        private System.Windows.Forms.TextBox txt_horario;
        private System.Windows.Forms.Label lbl_local;
        private System.Windows.Forms.TextBox txt_local;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Label lbl_evento;
        private System.Windows.Forms.TextBox txt_evento;
        private System.Windows.Forms.Button button2;
    }
}