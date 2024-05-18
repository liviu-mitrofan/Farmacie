
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Farmacie
{
    public partial class SearchMedicamentForm : Form
    {
        private readonly List<Medicament> medicamente;

        public SearchMedicamentForm(List<Medicament> medicamente)
        {
            InitializeComponent();
            this.medicamente = medicamente;
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            string criteriu = txtCriteriu.Text.ToLower();
            var rezultate = medicamente.Where(m => m.Titlu.ToLower().Contains(criteriu) || m.Descriere.ToLower().Contains(criteriu)).ToList();

            listBoxRezultate.DataSource = null;
            listBoxRezultate.DataSource = rezultate;
            listBoxRezultate.DisplayMember = "Titlu";
        }
    }
}
