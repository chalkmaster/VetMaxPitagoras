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
            CarregarComboRacas();
            CarregarComboEspecies();
        }

        private void CarregarComboRacas()
        {
            RacaService racaService = null;
            List<Raca> racas = null;
            try
            {
                racaService = new RacaService(new RacaRepository());
                racas = racaService.GetRacas();
                racas.ForEach(delegate(Raca r) {
                    cbxRaca.Items.Add(r.NomeRaça);
                });

            }
            finally
            {
                racaService = null;
                racas = null;
            }
                   
        }

        private void CarregarComboEspecies()
        {
            EspecieService especieService = null;
            List<Especie> especies = null;
            try
            {
                especieService = new EspecieService(new EspecieRepository());
               especies = especieService.GetEspecies();
                especies.ForEach(delegate(Especie e)
                {
                    cbxEspecie.Items.Add(e.Nome);
                });

            }
            finally
            {
                especieService = null;
                especies = null;
            }

        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text.Trim() == string.Empty) || (txtNomeDoDono.Text.Trim() == string.Empty) ||
           (cbxRaca.Text.Trim() == string.Empty) || (txtTipo.Text.Trim() == string.Empty))
            {
                return;
            }
            
            Animal animal = new Animal();
            var animalRepository = new AnimalRepository();
            animal.Nome = this.txtNome.Text;
            animal.NomeDono = this.txtNomeDoDono.Text;
            animal.Raça = this.cbxRaca.Text;
            animal.Espécie = this.cbxEspecie.Text;
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

        private void txtEspecie_KeyPress(object sender, KeyPressEventArgs e)
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
            txtNome.BackColor = Color.White;
        }

        private void txtNome_Leave(object sender, EventArgs e) // verifica se campo esta vazio se estiver muda de cor e mostra mensagem de erro senão estiver limpa o campo e o erro.
        {
            if (txtNome.Text.Trim() == string.Empty)
            {
                this.txtNome.Leave += new EventHandler(txtNome_Leave);
                txtNome.BackColor = System.Drawing.Color.DarkRed;
                validacaoAnimalCampos.SetError(txtNome, "Campo Obrigátorio");
            }
            else
                validacaoAnimalCampos.Clear();
        }

        private void txtNomeDoDono_Enter(object sender, EventArgs e)
        {
            this.txtNomeDoDono.Enter += new EventHandler(txtNomeDoDono_Enter);
            txtNomeDoDono.BackColor = Color.White;
        }

        private void txtNomeDoDono_Leave(object sender, EventArgs e)
        {
            if (txtNomeDoDono.Text.Trim() == string.Empty)
            {
                this.txtNomeDoDono.Leave += new EventHandler(txtNomeDoDono_Leave);
                txtNomeDoDono.BackColor = System.Drawing.Color.DarkRed;
                validacaoAnimalCampos.SetError(txtNomeDoDono, "Campo Obrigátorio");
            }
            else
                validacaoAnimalCampos.Clear();
        }

        private void txtRaca_Enter(object sender, EventArgs e)
        {
            this.cbxRaca.Enter += new EventHandler(txtRaca_Enter);
            cbxRaca.BackColor = Color.White;
        }

        private void txtRaca_Leave(object sender, EventArgs e)
        {
            if (cbxRaca.Text.Trim() == string.Empty)
            {
                this.cbxRaca.Leave += new EventHandler(txtRaca_Leave);
                cbxRaca.BackColor = System.Drawing.Color.DarkRed;
                validacaoAnimalCampos.SetError(cbxRaca, "Campo Obrigátorio");
            }
            else
                validacaoAnimalCampos.Clear();
        }

        private void txtEspecie_Enter(object sender, EventArgs e)
        {
            this.cbxEspecie.Enter += new EventHandler(txtEspecie_Enter);
            cbxEspecie.BackColor = Color.White;
        }

        private void txtEspecie_Leave(object sender, EventArgs e)
        {
            if (cbxEspecie.Text.Trim() == string.Empty)
            {
                this.cbxEspecie.Leave += new EventHandler(txtEspecie_Leave);
                cbxEspecie.BackColor = System.Drawing.Color.DarkRed;
                validacaoAnimalCampos.SetError(cbxEspecie, "Campo Obrigátorio");
            }
            else
                validacaoAnimalCampos.Clear();
        }


        private void txtTipo_Enter(object sender, EventArgs e)
        {
            this.txtTipo.Enter += new EventHandler(txtTipo_Enter);
            txtTipo.BackColor = Color.White;
        }

        private void txtTipo_Leave(object sender, EventArgs e)
        {
            if (txtTipo.Text.Trim() == string.Empty)
            {
                this.txtTipo.Leave += new EventHandler(txtTipo_Leave);
                txtTipo.BackColor = System.Drawing.Color.DarkRed;
                validacaoAnimalCampos.SetError(txtTipo, "Campo Obrigátorio");
            }
            else
                validacaoAnimalCampos.Clear();
        }

        private void grupoCadAnimal_Enter(object sender, EventArgs e)
        {

        }
    }
}