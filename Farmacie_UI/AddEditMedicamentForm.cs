
using System;
using System.Windows.Forms;

namespace Farmacie
{
    public partial class AddEditMedicamentForm : Form
    {
        public Medicament Medicament { get; private set; }

        public AddEditMedicamentForm(Medicament medicament = null)
        {
            InitializeComponent();
            if (medicament != null)
            {
                Medicament = medicament;
                txtTitlu.Text = medicament.Titlu;
                txtDescriere.Text = medicament.Descriere;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string titlu = txtTitlu.Text;
            string descriere = txtDescriere.Text;

            if (string.IsNullOrWhiteSpace(titlu) || string.IsNullOrWhiteSpace(descriere))
            {
                MessageBox.Show("Titlul și descrierea nu pot fi goale.");
                return;
            }

            if (Medicament == null)
            {
                Medicament = new Medicament(titlu, descriere);
            }
            else
            {
                Medicament.Titlu = titlu;
                Medicament.Descriere = descriere;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}