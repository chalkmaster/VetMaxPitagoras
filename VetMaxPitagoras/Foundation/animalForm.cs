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

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            Animal animal = new Animal();
            animal.Nome = this.txtNome.Text;
            animal.NomeDono = this.txtNomeDoDono.Text;
            animal.Raça = this.txtRaca.Text;
            animal.TelefoneDono = this.txtTelefoneDoDono.Text;
            animal.TelefoneTipo = this.txtTipo.Text;

            var animalRepository = new AnimalRepository();
            animalRepository.Insert(animal);

            var animais = animalRepository.FindAll();

            foreach(Animal animalDataGrid in animais){
                string[] dados = { animalDataGrid.Nome, animalDataGrid.Raça,
                     animalDataGrid.NomeDono, animalDataGrid.TelefoneDono, animalDataGrid.TelefoneTipo};
                this.dataCadAnimal.Rows.Add(dados);
            }

        }
    }
}
