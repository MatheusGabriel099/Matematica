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

        }

        private void Btn_Fechar_Click_1(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void Rad_Dobro_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
