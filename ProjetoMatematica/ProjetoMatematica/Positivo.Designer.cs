namespace ProjetoMatematica
{
    partial class Frm_Positivo
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
            this.Lbl_Positivo = new System.Windows.Forms.Label();
            this.Lbl_DigiteNumeroo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Positivo
            // 
            this.Lbl_Positivo.AutoSize = true;
            this.Lbl_Positivo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Positivo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Positivo.Location = new System.Drawing.Point(217, 152);
            this.Lbl_Positivo.Name = "Lbl_Positivo";
            this.Lbl_Positivo.Size = new System.Drawing.Size(458, 45);
            this.Lbl_Positivo.TabIndex = 0;
            this.Lbl_Positivo.Text = "Positivo, Negativo ou Neutro";
            // 
            // Lbl_DigiteNumeroo
            // 
            this.Lbl_DigiteNumeroo.AutoSize = true;
            this.Lbl_DigiteNumeroo.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_DigiteNumeroo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DigiteNumeroo.Location = new System.Drawing.Point(260, 254);
            this.Lbl_DigiteNumeroo.Name = "Lbl_DigiteNumeroo";
            this.Lbl_DigiteNumeroo.Size = new System.Drawing.Size(235, 32);
            this.Lbl_DigiteNumeroo.TabIndex = 1;
            this.Lbl_DigiteNumeroo.Text = "Digite um Número:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(501, 254);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 31);
            this.textBox1.TabIndex = 2;
            // 
            // Frm_Positivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoMatematica.Properties.Resources.Positivo_jpeg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 502);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbl_DigiteNumeroo);
            this.Controls.Add(this.Lbl_Positivo);
            this.Name = "Frm_Positivo";
            this.Text = "Positivo, Negativo ou Neutro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Positivo;
        private System.Windows.Forms.Label Lbl_DigiteNumeroo;
        private System.Windows.Forms.TextBox textBox1;
    }
}