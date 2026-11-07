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
    }
}
