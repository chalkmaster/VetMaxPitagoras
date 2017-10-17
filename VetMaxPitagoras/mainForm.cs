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
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            var login = new loginForm();
           // login.MdiParent = this;
            login.WindowState = FormWindowState.Maximized;
            login.Show();
        }
        
        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userRegister = new FrmCadastro();
            userRegister.MdiParent = this;
            userRegister.WindowState = FormWindowState.Maximized;
            userRegister.Show();
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

        private void clientesCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ListaClientesCadastrados = new ListaClientes();
            ListaClientesCadastrados.MdiParent = this;
            ListaClientesCadastrados.Show();
        }
    }
}
