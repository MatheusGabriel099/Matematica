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
    public partial class Frm_Dobro : Form
    {
        int numerodobro; //Criando uma Variavel

        public Frm_Dobro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          Frm_Abertura Abertura = new Frm_Abertura();
            Abertura.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            { 
                e.Handled = true;
                MessageBox.Show("Só é permitido Número!!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if(e.KeyChar == 13)
            {
                if (Txt_NumDobro.Text != "")
                {
                    numerodobro = int.Parse(Txt_NumDobro.Text);
                    numerodobro = numerodobro * 2;
                    MessageBox.Show("O Dobro é: " + numerodobro, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txt_NumDobro.Clear();
                    Txt_NumDobro.Focus();
                }
                else
                {
                    MessageBox.Show("Digite um Número!!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
