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
    public partial class Frm_Abertura : Form
    {
        public Frm_Abertura()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Frm_OperacaoAritmetica aritmetica = new Frm_OperacaoAritmetica();
            aritmetica.Show();
            Hide();
        }

        private void Btn_Fechar_Click_1(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void Rad_Dobro_CheckedChanged(object sender, EventArgs e)
        {
           Frm_Dobro dobro = new Frm_Dobro();
            dobro.Show();
            Hide();
        }

        private void Rad_ParOuImpar_CheckedChanged(object sender, EventArgs e)
        {
            Frm_ParOuImpar Impar = new Frm_ParOuImpar();
            Impar.Show();
            Hide();
        }

        private void Rad_Antecessor_CheckedChanged(object sender, EventArgs e)
        {
            Frm_Antecessor antecessor = new Frm_Antecessor();
            antecessor.Show();
            Hide();
        }

        private void Rad_Positivo_CheckedChanged(object sender, EventArgs e)
        {
            Frm_Positivo positivo = new Frm_Positivo();
            positivo.Show();
            Hide();
        }
    }
}
