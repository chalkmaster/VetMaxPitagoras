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
            if ((txtNome.Text.Trim() == string.Empty) || (txtNomeDoDono.Text.Trim() == string.Empty)|| 
                (txtRaca.Text.Trim() == string.Empty) || (txtTelefoneDoDono.Text.Trim() == string.Empty)
                || (txtTipo.Text.Trim() == string.Empty))
            {
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

        // permitir somente letras,backspace e tecla espaço.
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
        // fim permitir somente letras,backspace e tecla espaço.

        // aceitar somente numeros 
        private void txtTelefoneDoDono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtNome_Enter(object sender, EventArgs e) // quando clica ele muda a cor do textbox, precisa senão vai ficar so vermelho.
        {
            this.txtNome.Enter += new EventHandler(txtNome_Enter);
            txtNome.BackColor = Color.WhiteSmoke;
        }

        private void txtNome_Leave(object sender, EventArgs e) // verifica se campo esta vazio se estiver muda de cor e mostra mensagem de erro senão estiver limpa o campo e o erro.
        {
            if(txtNome.Text.Trim() == string.Empty)
            { 
            this.txtNome.Leave += new EventHandler(txtNome_Leave);
            txtNome.BackColor = System.Drawing.Color.DarkRed;
            validacaoAnimalCampos.SetError(txtNome, "Digite o nome do animal e continue seu cadastro que o erro irá sair.");
            }
            else 
                validacaoAnimalCampos.Clear();
        }

        private void txtNomeDoDono_Enter(object sender, EventArgs e)
        {
            this.txtNomeDoDono.Enter += new EventHandler(txtNomeDoDono_Enter);
            txtNomeDoDono.BackColor = Color.WhiteSmoke;
        }

        private void txtNomeDoDono_Leave(object sender, EventArgs e)
        {
            if (txtNomeDoDono.Text.Trim() == string.Empty)
            {
                this.txtNomeDoDono.Leave += new EventHandler(txtNomeDoDono_Leave);
                txtNomeDoDono.BackColor = System.Drawing.Color.DarkRed;
                validacaoAnimalCampos.SetError(txtNomeDoDono, "Digite o nome do dono e continue seu cadastro que o erro irá sair.");
            }
            else
                validacaoAnimalCampos.Clear();
        }

        private void txtRaca_Enter(object sender, EventArgs e)
        {
            this.txtRaca.Enter += new EventHandler(txtRaca_Enter);
            txtRaca.BackColor = Color.WhiteSmoke;
        }

        private void txtRaca_Leave(object sender, EventArgs e)
        {
            if (txtRaca.Text.Trim() == string.Empty)
            {
                this.txtRaca.Leave += new EventHandler(txtRaca_Leave);
                txtRaca.BackColor = System.Drawing.Color.DarkRed;
                validacaoAnimalCampos.SetError(txtRaca, "Digite a raça do animal e continue seu cadastro que o erro irá sair.");
            }
            else
                validacaoAnimalCampos.Clear();
        }

        private void txtTipo_Enter(object sender, EventArgs e)
        {
            this.txtTipo.Enter += new EventHandler(txtTipo_Enter);
            txtTipo.BackColor = Color.WhiteSmoke;
        }

        private void txtTipo_Leave(object sender, EventArgs e)
        {
            if (txtTipo.Text.Trim() == string.Empty)
            {
                this.txtTipo.Leave += new EventHandler(txtTipo_Leave);
                txtTipo.BackColor = System.Drawing.Color.DarkRed;
                validacaoAnimalCampos.SetError(txtTipo, "Digite o Tipo e continue seu cadastro que o erro irá sair.");
            }
            else
                validacaoAnimalCampos.Clear();
        }

       
    }
}