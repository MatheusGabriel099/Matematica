namespace ProjetoMatematica
{
    partial class Frm_ParOuImpar
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
            this.Lbl_Par = new System.Windows.Forms.Label();
            this.Lbl_DigiteNumero = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Par
            // 
            this.Lbl_Par.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Par.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Par.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Par.Location = new System.Drawing.Point(253, 158);
            this.Lbl_Par.Name = "Lbl_Par";
            this.Lbl_Par.Size = new System.Drawing.Size(406, 50);
            this.Lbl_Par.TabIndex = 0;
            this.Lbl_Par.Text = "Par ou Ímpar";
            this.Lbl_Par.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_DigiteNumero
            // 
            this.Lbl_DigiteNumero.AutoSize = true;
            this.Lbl_DigiteNumero.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_DigiteNumero.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DigiteNumero.Location = new System.Drawing.Point(345, 236);
            this.Lbl_DigiteNumero.Name = "Lbl_DigiteNumero";
            this.Lbl_DigiteNumero.Size = new System.Drawing.Size(228, 32);
            this.Lbl_DigiteNumero.TabIndex = 1;
            this.Lbl_DigiteNumero.Text = "Digite um Número";
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(375, 282);
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(156, 27);
            this.textbox.TabIndex = 2;
            // 
            // Frm_ParOuImpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoMatematica.Properties.Resources.ParOuImpar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(918, 502);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.Lbl_DigiteNumero);
            this.Controls.Add(this.Lbl_Par);
            this.Name = "Frm_ParOuImpar";
            this.Text = "Par Ou Ímpar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Par;
        private System.Windows.Forms.Label Lbl_DigiteNumero;
        private System.Windows.Forms.TextBox textbox;
    }
}