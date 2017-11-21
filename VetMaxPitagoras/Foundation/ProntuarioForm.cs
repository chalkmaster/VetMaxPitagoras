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
    public partial class ProntuarioForm : Form
    {
        public ProntuarioForm()
        {
            InitializeComponent();
        }


        public void Limpar_Dados_Cadastro_Prontuario()
        {
            txtNomeClienteCadastroProntuario.ResetText();
            txtNomeAnimalCadastroProntuario.ResetText();
            maskedBoxDataEntradaCadastroAnimal.ResetText();
            txtAnamneseProntuarioAnimal.ResetText();
        }

        private void btnCancelarCadastroProntuari_Click(object sender, EventArgs e)
        {
            Limpar_Dados_Cadastro_Prontuario();
        }

        private void btnSalvarCadastroProntuario_Click(object sender, EventArgs e)
        {
            Limpar_Dados_Cadastro_Prontuario();
            MessageBox.Show("Operação realizada com sucesso !");
        }
    }
}
