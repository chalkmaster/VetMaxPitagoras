using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetMaxPitagoras
{
    public partial class ListaClientes : Form
    {
        public ListaClientes()
        {
            InitializeComponent();
        }

        private void btnSair(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                // Este método apaga a linha selecionada
                int dadosIndex= dgv_dadosCadastroCliente.CurrentRow.Index;
                dgv_dadosCadastroCliente.Rows.RemoveAt(dadosIndex);

            }
            catch
            {
                MessageBox.Show("Por favor selecione uma linha ! ");
            }
        }
    }
}
