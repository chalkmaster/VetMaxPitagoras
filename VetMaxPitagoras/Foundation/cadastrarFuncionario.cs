using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetMaxPitagoras.Foundation
{
    public partial class frmcadastrarfuncionario : Form
    {
        public frmcadastrarfuncionario()
        {
            InitializeComponent();
        }

        private void frmcadastrarfuncionario_Load(object sender, EventArgs e)
        {
            var funcionarioRepository = new FuncionarioRepository();
            this.dataCadFuncionario.DataSource = funcionarioRepository.FindAll();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text.Trim() == string.Empty) || (txtCargo.Text.Trim() == string.Empty) ||
           (txtDepartamento.Text.Trim() == string.Empty) || (dtpDataNascimento.Text.Trim() == string.Empty) ||
           (mtbTelefone.Text.Trim() == string.Empty) || (txtEndereco.Text.Trim() == string.Empty) ||
           (txtEmail.Text.Trim() == string.Empty) || (txtEspecialidade.Text.Trim() == string.Empty) ||
           (txtTitulacao.Text.Trim() == string.Empty))

            {
                return;
            }

            Funcionario funcionario = new Funcionario();
            var funcionariolRepository = new FuncionarioRepository();
            funcionario.Nome = this.txtNome.Text;
            funcionario.Cargo = this.txtCargo.Text;
            funcionario.DataNascimento = this.dtpDataNascimento.Text;
            funcionario.Email = this.txtEmail.Text;
            funcionario.Telefone = this.mtbTelefone.Text;
            funcionario.Departamento = this.txtDepartamento.Text;
            funcionario.Endereco = this.txtEndereco.Text;
            funcionario.Especialidade = this.txtEspecialidade.Text;
            funcionario.Titulacao = this.txtTitulacao.Text;
            funcionarioRepository.Insert(funcionario);
            this.dataCadFuncionario.DataSource = funcionarioRepository.FindAll();


        }

        private void grpCadFuncionario_Enter(object sender, EventArgs e)
        {

        }

    }
}
