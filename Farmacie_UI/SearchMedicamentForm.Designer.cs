namespace Farmacie
{
    partial class SearchMedicamentForm
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
        private System.Windows.Forms.TextBox txtCriteriu;
        private System.Windows.Forms.Label lblCriteriu;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.ListBox listBoxRezultate;

        private void InitializeComponent()
        {
            this.txtCriteriu = new System.Windows.Forms.TextBox();
            this.lblCriteriu = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.listBoxRezultate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // txtCriteriu
            this.txtCriteriu.Location = new System.Drawing.Point(78, 12);
            this.txtCriteriu.Size = new System.Drawing.Size(194, 20);

            // lblCriteriu
            this.lblCriteriu.AutoSize = true;
            this.lblCriteriu.Location = new System.Drawing.Point(12, 15);
            this.lblCriteriu.Text = "Criteriu:";

            // btnCauta
            this.btnCauta.Location = new System.Drawing.Point(116, 38);
            this.btnCauta.Size = new System.Drawing.Size(75, 23);
            this.btnCauta.Text = "Caută";
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);

            // listBoxRezultate
            this.listBoxRezultate.FormattingEnabled = true;
            this.listBoxRezultate.Location = new System.Drawing.Point(12, 67);
            this.listBoxRezultate.Size = new System.Drawing.Size(260, 95);

            // SearchMedicamentForm
            this.ClientSize = new System.Drawing.Size(284, 174);
            this.Controls.Add(this.txtCriteriu);
            this.Controls.Add(this.lblCriteriu);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.listBoxRezultate);
            this.Text = "Căutare Medicament";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion
    }
}