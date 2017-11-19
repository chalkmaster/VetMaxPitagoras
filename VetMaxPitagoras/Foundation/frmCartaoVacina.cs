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
    public partial class frmCartaoVacina : Form
    {
        public frmCartaoVacina()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dtgControleVacina.CurrentRow.Index;
                dtgControleVacina.Rows.RemoveAt(index);
            }


            catch
            {
                MessageBox.Show("Selecione uma linha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblProprietario_Click(object sender, EventArgs e)
        {

        }

        private void frmCartaoVacina_Load(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            txtRaca.Enabled = false;
            txtCorMarca.Enabled = false;
            txtEspecie.Enabled = false;
            txtEspecie.Enabled = false;
            txtSexo.Enabled = false;
            txtDatadeNascimento.Enabled = false;
            txtProprietario.Enabled = false;
            txtResidencia.Enabled = false;
            txtEndereco.Enabled = false;
            txtCorMarca.Enabled = false; 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] dados = {txtData.Text, txtVacina.Text, txtRevacinacao.Text};
            this.dtgControleVacina.Rows.Add(dados);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numeros");
            }
        }

        private void dtgControleVacina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
