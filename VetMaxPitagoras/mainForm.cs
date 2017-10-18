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
            var login = new frmLogin();
            login.MdiParent = this;
            login.WindowState = FormWindowState.Maximized;
            login.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userRegister = new userForm();
            userRegister.MdiParent = this;
            userRegister.WindowState = FormWindowState.Normal;
            userRegister.Show();
        }

        private void animaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var animalRegister = new animalForm();
            animalRegister.MdiParent = this;
            animalRegister.WindowState = FormWindowState.Maximized;
            animalRegister.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void funcionárioDaClínicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var funcionarioRegister = new frmcadastrarfuncionario();
            funcionarioRegister.MdiParent = this;
            funcionarioRegister.WindowState = FormWindowState.Maximized;
            funcionarioRegister.Show();
        }
    }
}
