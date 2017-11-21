using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetMaxPitagoras.Foundation;
using VetMaxPitagoras.Security;

namespace VetMaxPitagoras
{
    public partial class mainForm : Form
    {
        public static mainForm mdiobj; // este mdiobj manipula o menustrips
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            cadastroToolStripMenuItem.Enabled = false; // aki desabilita o item cadastro 
            listaToolStripMenuItem.Enabled = false; // aki desabilita o intem lista
           

            var login = new loginForm();
            login.MdiParent = this;
            login.WindowState = FormWindowState.Maximized;
            login.Show();
            mdiobj = this;
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CadastroCliente = new FrmCadastro();
            CadastroCliente.MdiParent = this;
            CadastroCliente.WindowState = FormWindowState.Maximized;
            CadastroCliente.Show();
            
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var CadastroEstoque = new EstoqueForm();
            CadastroEstoque.MdiParent = this;
            CadastroEstoque.WindowState = FormWindowState.Maximized;
            CadastroEstoque.Show();
        }

        private void ProntuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CadastroProntuario = new ProntuarioForm();
            CadastroProntuario.MdiParent = this;
            CadastroProntuario.WindowState = FormWindowState.Maximized;
            CadastroProntuario.Show();
        }
    }
}
