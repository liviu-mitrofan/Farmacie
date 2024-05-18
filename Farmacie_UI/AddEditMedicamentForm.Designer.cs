namespace Farmacie
{
    partial class AddEditMedicamentForm
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
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblDescriere;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;

        private void InitializeComponent()
        {
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblDescriere = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtTitlu
            this.txtTitlu.Location = new System.Drawing.Point(78, 12);
            this.txtTitlu.Size = new System.Drawing.Size(194, 20);

            // txtDescriere
            this.txtDescriere.Location = new System.Drawing.Point(78, 38);
            this.txtDescriere.Multiline = true;
            this.txtDescriere.Size = new System.Drawing.Size(194, 60);

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Location = new System.Drawing.Point(12, 15);
            this.lblTitlu.Text = "Titlu:";

            // lblDescriere
            this.lblDescriere.AutoSize = true;
            this.lblDescriere.Location = new System.Drawing.Point(12, 41);
            this.lblDescriere.Text = "Descriere:";

            // btnOk
            this.btnOk.Location = new System.Drawing.Point(116, 104);
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(197, 104);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // AddEditMedicamentForm
            this.ClientSize = new System.Drawing.Size(284, 139);
            this.Controls.Add(this.txtTitlu);
            this.Controls.Add(this.txtDescriere);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblDescriere);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Text = "Adăugare/Editare Medicament";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion
    }
}