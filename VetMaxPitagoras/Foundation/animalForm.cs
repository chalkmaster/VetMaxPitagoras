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

        private void animalForm_Load(object sender, EventArgs e)
        {
            var animalRepository = new AnimalRepository();
            this.dataCadAnimal.DataSource = animalRepository.FindAll();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {


            if (txtNome.Text.Trim() == string.Empty)
            {
                validacaoAnimalCampos.SetError(txtNome, "Nome não foi preenchido");
                txtNome.Focus();
                return;
                
            }
           
            else if (txtNomeDoDono.Text.Trim() == string.Empty)
            {
                validacaoAnimalCampos.SetError(txtNomeDoDono, "Nome do dono não foi preenchido");
                txtNomeDoDono.Focus();
                return;
            }
            else if (txtRaca.Text.Trim() == string.Empty)
            {
                validacaoAnimalCampos.SetError(txtRaca, "A raça não foi preenchido");
                txtRaca.Focus();
                return;
            }
            else if (txtTelefoneDoDono.Text.Trim() == string.Empty) // vai mudar para aceitar tipo telefone.
            {
                txtTelefoneDoDono.Focus();
                return;
            }
            else if (txtTipo.Text.Trim() == string.Empty)
            {
                validacaoAnimalCampos.SetError(txtRaca, "A raça não foi preenchido");
                txtTipo.Focus();
                return;
            }
           
            Animal animal = new Animal();
            var animalRepository = new AnimalRepository();
            animal.Nome = this.txtNome.Text;
            animal.NomeDono = this.txtNomeDoDono.Text;
            animal.Raça = this.txtRaca.Text;
            animal.TelefoneDono = this.txtTelefoneDoDono.Text;
            animal.TelefoneTipo = this.txtTipo.Text;
            animalRepository.Insert(animal);
            
            this.dataCadAnimal.DataSource = animalRepository.FindAll();

        }

        // permitir somente letras
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtNomeDoDono_KeyPress(object sender, KeyPressEventArgs e)
        { 
             if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void txtRaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        // fim permitir somente letras

        // aceitar somente numeros 
        private void txtTelefoneDoDono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

     
    }
}