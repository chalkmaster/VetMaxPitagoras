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

        private void button1_Click(object sender, EventArgs e)
        {
            var authService = new AuthService(new UserRepository());
            var userToInsert = new User();
            userToInsert.UserName = textBox1.Text;
            userToInsert.Password = textBox2.Text;
            authService.AddNewUser(userToInsert);
        }
    }
}
