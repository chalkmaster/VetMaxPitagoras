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

        private void Button1_Click(object sender, EventArgs e)
        {
             //string[] dadosCadastro = { txNome.Text,txCpf.Text, txEndereco.Text, txCidade.Text };

            var authService = new AuthService(new UserRepository());
            var userToInsert = new User();
            //dadosCadastro inseridos na tela cadastro cliente
            //userToInsert.UserName = textBox1.Text;
            //userToInsert.Password = textBox2.Text;
            authService.AddNewUser(userToInsert);

            //Limpar_dados();
            MessageBox.Show("Cadastro efetuado com sucesso");
 
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void Limpar_dados_Cadastro_Cliente()
        {
            txtNomeCliente.ResetText();
            comboBoxSexoCliente.ResetText();
            maskedTextBoxNascimentoCliente.ResetText();
            maskedTextBoxCpfCliente.ResetText();
            maskedTextBoxIdentidadeCliente.ResetText();
            txtEnderecoCliente.ResetText();
            txtCidadeCliente.ResetText();
            comboBoxUfCliente.ResetText();
            maskedTextBoxCepCliente.ResetText();
            comboBoxTelefoneCliente.ResetText();
            maskedTextBoxTelefoneCliente.ResetText();
            txtBoxEmailCliente.ResetText();

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Limpar_dados_Cadastro_Cliente();
        }

        private void btnSairCadastroCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSairPesquisarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
