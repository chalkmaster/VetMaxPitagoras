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
using VetMaxPitagoras.Infrastructure.Security.Services;

namespace VetMaxPitagoras.Foundation
{
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != txtConfSenha.Text){
                MessageBox.Show("A senhas digitadas tem que ser identicas");
            }
            else {
                var authService = new AuthService(new UserRepository());
                var userToInsert = new User();
                userToInsert.UserName = txtNome.Text;
                userToInsert.Password = txtSenha.Text;
                authService.AddNewUser(userToInsert);
                MessageBox.Show("cad");
            }
        }

        private void userForm_Load(object sender, EventArgs e)
        {

        } 
    }
}
