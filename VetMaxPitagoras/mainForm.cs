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
            cadastroToolStripMenuItem.Enabled = false; // aki desabilita o intem cadastro 
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
            
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userAnimal = new AnimaisForm();
            userAnimal.MdiParent = this;
            userAnimal.WindowState = FormWindowState.Maximized;
            userAnimal.Show();
        }

        private void animaisCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ListaAnimais = new ListaAnimaisForm1();
            ListaAnimais.MdiParent = this;
            ListaAnimais.WindowState = FormWindowState.Maximized;
            ListaAnimais.Show();
        }

        private void usuárioSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userRegister = new userForm();
            userRegister.MdiParent = this;
            userRegister.WindowState = FormWindowState.Maximized;
            userRegister.Show();
        }
    }
}
