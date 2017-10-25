using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetMaxPitagoras.Infrastructure.Security.Services;
using VetMaxPitagoras.Infrastructure.Security.Entities;
using VetMaxPitagoras.Infrastructure.InMemoryRepository.Security;

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
            RacaService racaService = new RacaService(new RacaRepository());
            //carrega especies
            try
            {
                List<Raca> racas = racaService.GetRacas();

                racas.ForEach(delegate (Raca r) {
                    cbxRaca.Items.Add(r.NomeRaça);
                });
            }
            finally
            {
                racaService = null;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        
    }
}
