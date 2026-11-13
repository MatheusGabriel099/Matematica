using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMatematica
{
    public partial class Frm_Positivo : Form
    {
        int numeroPNN;
        public Frm_Positivo()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Abertura Abertura = new Frm_Abertura();
            Abertura.Show();
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) &&! (e.KeyChar == '-'))
            { 
                e.Handled = true;
                MessageBox.Show("Só é permitido números!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar ==13)
            {
                if (Txt_NumPositivo.Text != "")
                {
                    numeroPNN = int.Parse(Txt_NumPositivo.Text);

                    if (numeroPNN > 0)
                    {
                        MessageBox.Show("O número digitado é Neutro!!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (numeroPNN > 0)
                    {
                        MessageBox.Show("O número é Positivo!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("O número digitado é Negativo!!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Txt_NumPositivo.Clear();
                    Txt_NumPositivo.Focus();
                }
                else
                {
                    MessageBox.Show("Digite um Número!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
