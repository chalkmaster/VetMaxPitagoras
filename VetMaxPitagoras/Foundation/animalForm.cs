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
    public partial class animalForm : Form
    {
        public animalForm()
        {
            InitializeComponent();
        }
        Animal animal = new Animal();

        private void animalForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            animal.Nome = this.txtNome.Text;
            animal.NomeDono = this.txtNomeDoDono.Text;
            animal.Raça = this.txtRaca.Text;
            animal.TelefoneDono = this.txtTelefoneDoDono.Text;
            animal.TelefoneTipo = this.txtTipo.Text;

            do
            {
                if (txtNome.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Nome não foi preenchido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Focus();
                }
                else if (txtNomeDoDono.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Nome do dono não foi preenchido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Focus();
                }
                else if (txtRaca.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("A raça não foi preenchido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Focus();
                }
                else if (txtTelefoneDoDono.Text.Trim() == string.Empty) // vai mudar para aceitar tipo telefone.
                {
                    MessageBox.Show("O telefone não foi preenchido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.Focus();
                }
                else if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    txtTipo.Enabled = true;
                }
                break;
           
            }
            while (txtTipo.Text == "") ;

              
            var animalRepository = new AnimalRepository();
             animalRepository.Insert(animal);
             var animais = animalRepository.FindAll();
             foreach (Animal animalDataGrid in animais)
             {
                 string[] dados = { animalDataGrid.Nome, animalDataGrid.Raça,
                      animalDataGrid.NomeDono, animalDataGrid.TelefoneDono, animalDataGrid.TelefoneTipo};
                 this.dataCadAnimal.Rows.Add(dados);
             }
        }

        private void txtTipo_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtTipo.Text))
            {
                e.Cancel = true;
                txtTipo.Focus();
                validacaoAnimalCampos.SetError (txtTipo ,"Entre com tipo primeiro");
            }
            else
            {
                e.Cancel = false;
                validacaoAnimalCampos.SetError (txtTipo, null);
            }
        }
    }
}
    

