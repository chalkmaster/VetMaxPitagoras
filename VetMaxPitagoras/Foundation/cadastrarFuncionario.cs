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
            var funcionarioRepository = new FuncionarioRepository();
            funcionario.Nome = this.txtNome.Text;
            funcionario.cargo = this.txtCargo.Text;
            funcionario.datanascimento = this.dtpDataNascimento.MaxDate;
            funcionario.email = this.txtEmail.Text;
            funcionario.telefone = this.mtbTelefone.Mask;
            funcionario.departamento = this.txtDepartamento.Text;
            funcionario.endereco = this.txtEndereco.Text;
            funcionario.especialidade = this.txtEspecialidade.Text;
            funcionario.titulacao = this.txtTitulacao.Text;
            funcionarioRepository.Insert(funcionario);
            this.dataCadFuncionario.DataSource = funcionarioRepository.FindAll();


        }

        private void grpCadFuncionario_Enter(object sender, EventArgs e)
        {

        }

        private void txtEspecialidade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
