﻿using System;
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
using VetMaxPitagoras.Foundation.Pesquisa;

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
            login.MdiParent = this;
            login.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Maximized;
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

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var login = new loginForm();
            login.MdiParent = this;
            login.WindowState = FormWindowState.Maximized;
            login.Show();
        }

        private void funcionárioVeterinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var funcionarioRegister = new cadastrarVeterinario();
            funcionarioRegister.MdiParent = this;
            funcionarioRegister.WindowState = FormWindowState.Maximized;
            funcionarioRegister.Show();
        }

        private void funcionarioVeterinárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var funcionariopesquisa = new frmPesquisaFuncionario();
            funcionariopesquisa.MdiParent = this;
            funcionariopesquisa.WindowState = FormWindowState.Maximized;
            funcionariopesquisa.Show();
        }

        private void cartaoDeVacinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cartaoVacina = new fr();
            cartaoVacina.MdiParent = this;
            cartaoVacina.WindowState = FormWindowState.Maximized;
            cartaoVacina.Show();
        }
    }
}
