namespace ProjetoMatematica
{
    partial class Frm_Abertura
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
            this.Lbl_Projeto = new System.Windows.Forms.Label();
            this.Rad_Dobro = new System.Windows.Forms.RadioButton();
            this.Rad_ParOuImpar = new System.Windows.Forms.RadioButton();
            this.Rad_Antecessor = new System.Windows.Forms.RadioButton();
            this.Rad_Positivo = new System.Windows.Forms.RadioButton();
            this.Rad_Operacao = new System.Windows.Forms.RadioButton();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Projeto
            // 
            this.Lbl_Projeto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl_Projeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_Projeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_Projeto.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Projeto.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Projeto.Location = new System.Drawing.Point(12, 12);
            this.Lbl_Projeto.Name = "Lbl_Projeto";
            this.Lbl_Projeto.Size = new System.Drawing.Size(910, 54);
            this.Lbl_Projeto.TabIndex = 0;
            this.Lbl_Projeto.Text = "Projetos";
            this.Lbl_Projeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rad_Dobro
            // 
            this.Rad_Dobro.AutoSize = true;
            this.Rad_Dobro.BackColor = System.Drawing.Color.Transparent;
            this.Rad_Dobro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Dobro.ForeColor = System.Drawing.Color.Crimson;
            this.Rad_Dobro.Location = new System.Drawing.Point(213, 143);
            this.Rad_Dobro.Name = "Rad_Dobro";
            this.Rad_Dobro.Size = new System.Drawing.Size(88, 29);
            this.Rad_Dobro.TabIndex = 1;
            this.Rad_Dobro.Text = "Dobro";
            this.Rad_Dobro.UseVisualStyleBackColor = false;
            this.Rad_Dobro.CheckedChanged += new System.EventHandler(this.Rad_Dobro_CheckedChanged);
            // 
            // Rad_ParOuImpar
            // 
            this.Rad_ParOuImpar.AutoSize = true;
            this.Rad_ParOuImpar.BackColor = System.Drawing.Color.Transparent;
            this.Rad_ParOuImpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_ParOuImpar.ForeColor = System.Drawing.Color.Orange;
            this.Rad_ParOuImpar.Location = new System.Drawing.Point(236, 204);
            this.Rad_ParOuImpar.Name = "Rad_ParOuImpar";
            this.Rad_ParOuImpar.Size = new System.Drawing.Size(130, 24);
            this.Rad_ParOuImpar.TabIndex = 2;
            this.Rad_ParOuImpar.Text = "Par ou Ímpar";
            this.Rad_ParOuImpar.UseVisualStyleBackColor = false;
            this.Rad_ParOuImpar.CheckedChanged += new System.EventHandler(this.Rad_ParOuImpar_CheckedChanged);
            // 
            // Rad_Antecessor
            // 
            this.Rad_Antecessor.AutoSize = true;
            this.Rad_Antecessor.BackColor = System.Drawing.Color.Transparent;
            this.Rad_Antecessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Antecessor.ForeColor = System.Drawing.Color.MediumPurple;
            this.Rad_Antecessor.Location = new System.Drawing.Point(318, 268);
            this.Rad_Antecessor.Name = "Rad_Antecessor";
            this.Rad_Antecessor.Size = new System.Drawing.Size(223, 24);
            this.Rad_Antecessor.TabIndex = 3;
            this.Rad_Antecessor.Text = "Antecessor ou Sucessor\r\n";
            this.Rad_Antecessor.UseVisualStyleBackColor = false;
            this.Rad_Antecessor.CheckedChanged += new System.EventHandler(this.Rad_Antecessor_CheckedChanged);
            // 
            // Rad_Positivo
            // 
            this.Rad_Positivo.AutoSize = true;
            this.Rad_Positivo.BackColor = System.Drawing.Color.Transparent;
            this.Rad_Positivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Positivo.ForeColor = System.Drawing.Color.SeaGreen;
            this.Rad_Positivo.Location = new System.Drawing.Point(477, 204);
            this.Rad_Positivo.Name = "Rad_Positivo";
            this.Rad_Positivo.Size = new System.Drawing.Size(253, 24);
            this.Rad_Positivo.TabIndex = 4;
            this.Rad_Positivo.Text = "Positivo, Negativo ou Neutro";
            this.Rad_Positivo.UseVisualStyleBackColor = false;
            this.Rad_Positivo.CheckedChanged += new System.EventHandler(this.Rad_Positivo_CheckedChanged);
            // 
            // Rad_Operacao
            // 
            this.Rad_Operacao.AutoSize = true;
            this.Rad_Operacao.BackColor = System.Drawing.Color.Transparent;
            this.Rad_Operacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rad_Operacao.ForeColor = System.Drawing.Color.Violet;
            this.Rad_Operacao.Location = new System.Drawing.Point(539, 143);
            this.Rad_Operacao.Name = "Rad_Operacao";
            this.Rad_Operacao.Size = new System.Drawing.Size(191, 24);
            this.Rad_Operacao.TabIndex = 5;
            this.Rad_Operacao.Text = "Operação Aritmética";
            this.Rad_Operacao.UseVisualStyleBackColor = false;
            this.Rad_Operacao.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Fechar.FlatAppearance.BorderSize = 2;
            this.Btn_Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Btn_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fechar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fechar.ForeColor = System.Drawing.Color.Red;
            this.Btn_Fechar.Location = new System.Drawing.Point(875, 12);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(47, 46);
            this.Btn_Fechar.TabIndex = 6;
            this.Btn_Fechar.Text = "X";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click_1);
            // 
            // Frm_Abertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoMatematica.Properties.Resources.lousa3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(934, 541);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.Rad_Operacao);
            this.Controls.Add(this.Rad_Positivo);
            this.Controls.Add(this.Rad_Antecessor);
            this.Controls.Add(this.Rad_ParOuImpar);
            this.Controls.Add(this.Rad_Dobro);
            this.Controls.Add(this.Lbl_Projeto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Abertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matemática";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Projeto;
        private System.Windows.Forms.RadioButton Rad_Dobro;
        private System.Windows.Forms.RadioButton Rad_ParOuImpar;
        private System.Windows.Forms.RadioButton Rad_Antecessor;
        private System.Windows.Forms.RadioButton Rad_Positivo;
        private System.Windows.Forms.RadioButton Rad_Operacao;
        private System.Windows.Forms.Button Btn_Fechar;
    }
}

