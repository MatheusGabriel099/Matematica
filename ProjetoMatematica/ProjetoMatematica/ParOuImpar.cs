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
    public partial class Frm_ParOuImpar : Form
    {
        int numeroparimpar;
        public Frm_ParOuImpar()
        {
            InitializeComponent();
        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Abertura Abertura = new Frm_Abertura();
            Abertura.Show();
            Hide();
        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Só é permitido Números!!!!", "Aviso!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 13)
            {
                if (Txt_ParouImpar.Text != "")
                {
                    numeroparimpar = int.Parse(Txt_ParouImpar.Text);

                    if (numeroparimpar % 2 == 0)
                    {
                        MessageBox.Show("O número é Par!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("O número é Impar!!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Txt_ParouImpar.Clear();
                    Txt_ParouImpar.Focus();
                }
                else
                { 
                   MessageBox.Show("Digite um Número!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                }
            }
        }
    }
}
