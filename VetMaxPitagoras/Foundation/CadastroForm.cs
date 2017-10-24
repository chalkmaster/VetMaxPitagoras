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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dadosCadastro = { txNome.Text, txSexo.Text, txCpf.Text, txFone.Text, txCelular.Text, txEndereco.Text, txNumero.Text, txComplemento.Text, txCidade.Text };


            var authService = new AuthService(new UserRepository());
            var userToInsert = new User();
            userToInsert.UserName = textBox1.Text;
            userToInsert.Password = textBox2.Text;
            authService.AddNewUser(userToInsert);

            
            
            Limpar_dados();
            MessageBox.Show("Cadastro efetuado com sucesso");

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Limpar_dados()
        {
            txNome.ResetText();
            txCpf.ResetText();
            txFone.ResetText();
            txCelular.ResetText();
            txEndereco.ResetText();
            txNumero.ResetText();
            txComplemento.ResetText();
            txCidade.ResetText();
            textBox1.ResetText();
            textBox2.ResetText();
            rdBtn_fem.ResetText();
            rdBtn_masc.ResetText();
        }
    }
}
