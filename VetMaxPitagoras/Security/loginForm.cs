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
    public partial class frmLogin : Form
    {
        private AuthService _authService;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            _authService = new AuthService(new UserRepository());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userToAuthenticate = new User();
            userToAuthenticate.UserName = txtLogin.Text;
            userToAuthenticate.Password = txtSenha.Text;

            if (_authService.TryAuthenticate(userToAuthenticate))
            {
                MessageBox.Show("Logado com sucesso");
            } else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
        }
    }
}
