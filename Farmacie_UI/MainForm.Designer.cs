namespace Farmacie
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.ListView listViewMedicamente;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnEditare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnCautare;

        private void InitializeComponent()
        {
            this.listViewMedicamente = new System.Windows.Forms.ListView();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnEditare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnCautare = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // listViewMedicamente
            this.listViewMedicamente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
        new System.Windows.Forms.ColumnHeader { Text = "ID", Width = 50 },
        new System.Windows.Forms.ColumnHeader { Text = "Titlu", Width = 150 },
        new System.Windows.Forms.ColumnHeader { Text = "Descriere", Width = 200 }
    });
            this.listViewMedicamente.FullRowSelect = true;
            this.listViewMedicamente.GridLines = true;
            this.listViewMedicamente.HideSelection = false;
            this.listViewMedicamente.Location = new System.Drawing.Point(12, 12);
            this.listViewMedicamente.Size = new System.Drawing.Size(450, 212);
            this.listViewMedicamente.View = System.Windows.Forms.View.Details;

            // btnAdauga
            this.btnAdauga.Location = new System.Drawing.Point(12, 230);
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.Text = "Adaugă";
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);

            // btnEditare
            this.btnEditare.Location = new System.Drawing.Point(93, 230);
            this.btnEditare.Size = new System.Drawing.Size(75, 23);
            this.btnEditare.Text = "Editare";
            this.btnEditare.Click += new System.EventHandler(this.btnEditare_Click);

            // btnStergere
            this.btnStergere.Location = new System.Drawing.Point(174, 230);
            this.btnStergere.Size = new System.Drawing.Size(75, 23);
            this.btnStergere.Text = "Ștergere";
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);

            // btnCautare
            this.btnCautare.Location = new System.Drawing.Point(255, 230);
            this.btnCautare.Size = new System.Drawing.Size(75, 23);
            this.btnCautare.Text = "Căutare";
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(482, 263);
            this.Controls.Add(this.listViewMedicamente);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnEditare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnCautare);
            this.Text = "Gestionare Farmacie";
            this.ResumeLayout(false);
        }

        #endregion
    }
}

