
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Farmacie
{
    public class Medicament
    {
        private static readonly Random random = new Random();

        public int Id { get; private set; }
        public string Titlu { get; set; }
        public string Descriere { get; set; }

        public Medicament(string titlu, string descriere)
        {
            Id = random.Next(1, 10000);
            Titlu = titlu;
            Descriere = descriere;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Titlu: {Titlu}, Descriere: {Descriere}";
        }
    }
    public partial class MainForm : Form
    {
        private List<Medicament> medicamente = new List<Medicament>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            var addForm = new AddEditMedicamentForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                medicamente.Add(addForm.Medicament);
                UpdateMedicamenteList();
            }
        }

        private void btnEditare_Click(object sender, EventArgs e)
        {
            if (listViewMedicamente.SelectedItems.Count > 0)
            {
                var selectedMedicament = (Medicament)listViewMedicamente.SelectedItems[0].Tag;
                var editForm = new AddEditMedicamentForm(selectedMedicament);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateMedicamenteList();
                }
            }
            else
            {
                MessageBox.Show("Selectează un medicament pentru a-l edita.");
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (listViewMedicamente.SelectedItems.Count > 0)
            {
                var selectedMedicament = (Medicament)listViewMedicamente.SelectedItems[0].Tag;
                medicamente.Remove(selectedMedicament);
                UpdateMedicamenteList();
            }
            else
            {
                MessageBox.Show("Selectează un medicament pentru a-l șterge.");
            }
        }

        private void btnCautare_Click(object sender, EventArgs e)
        {
            var searchForm = new SearchMedicamentForm(medicamente);
            searchForm.ShowDialog();
        }

        private void UpdateMedicamenteList()
        {
            listViewMedicamente.Items.Clear();
            foreach (var medicament in medicamente)
            {
                var listItem = new ListViewItem(new[] { medicament.Id.ToString(), medicament.Titlu, medicament.Descriere });
                listItem.Tag = medicament;
                listViewMedicamente.Items.Add(listItem);
            }
        }
    }

}