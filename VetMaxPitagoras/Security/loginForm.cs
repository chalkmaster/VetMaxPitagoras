using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetMaxPitagoras.Infrastructure.InMemoryRepository.Security;
using VetMaxPitagoras.Infrastructure.Security.Entities;
using VetMaxPitagoras.Infrastructure.Security.Repository;
using VetMaxPitagoras.Infrastructure.Security.Services;

namespace VetMaxPitagoras.Security
{
    public partial class loginForm : Form
    {
        private AuthService _authService;
        public loginForm()
        {
            InitializeComponent();
            var authServicePadrao = new AuthService(new UserRepository());
            var userPadrao = new User();
            userPadrao.UserName = "a";
            userPadrao.Password = "a";
            authServicePadrao.AddNewUser(userPadrao); // ESTES SÃO LOGIN E SENHA PADRÃO
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            timer1_Tick(e, e);
            _authService = new AuthService(new UserRepository());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userToAuthenticate = new User();
            userToAuthenticate.UserName = textBox1.Text;
            userToAuthenticate.Password = textBox2.Text;

            if (_authService.TryAuthenticate(userToAuthenticate))
            {
                var tela = new mainForm();
                this.Hide();

                MessageBox.Show("Logado com sucesso");
                mainForm.mdiobj.cadastroToolStripMenuItem.Enabled = true;//aki habilita o item cadastro
                mainForm.mdiobj.listaToolStripMenuItem.Enabled = true; // aki habilita o item lista
                             
               
            } else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var CadastroUsuario = new mainForm();
            CadastroUsuario.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dataHora = DateTime.Now;
            lbDataHora.Text = " Data: " + dataHora.ToShortDateString() + " Hora: " + dataHora.ToLongTimeString();
        }
    }
}
