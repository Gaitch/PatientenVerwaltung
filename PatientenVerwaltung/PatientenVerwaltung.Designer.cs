namespace PatientenVerwaltung
{
    partial class PatientenVerwaltung
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsvPatientCards = new System.Windows.Forms.ListView();
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBirthdate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lsvPatientCards
            // 
            this.lsvPatientCards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colTitle,
            this.colGender,
            this.colLastname,
            this.colFirstname,
            this.colBirthdate});
            this.lsvPatientCards.Location = new System.Drawing.Point(12, 12);
            this.lsvPatientCards.MultiSelect = false;
            this.lsvPatientCards.Name = "lsvPatientCards";
            this.lsvPatientCards.Size = new System.Drawing.Size(1256, 614);
            this.lsvPatientCards.TabIndex = 0;
            this.lsvPatientCards.UseCompatibleStateImageBehavior = false;
            this.lsvPatientCards.View = System.Windows.Forms.View.Details;
            // 
            // btnNewPatient
            // 
            this.btnNewPatient.Location = new System.Drawing.Point(1274, 12);
            this.btnNewPatient.Name = "btnNewPatient";
            this.btnNewPatient.Size = new System.Drawing.Size(184, 23);
            this.btnNewPatient.TabIndex = 1;
            this.btnNewPatient.Text = "Patient hinzufügen";
            this.btnNewPatient.UseVisualStyleBackColor = true;
            this.btnNewPatient.Click += new System.EventHandler(this.BtnNewPatient_Click);
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Location = new System.Drawing.Point(1274, 41);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(184, 23);
            this.btnDeletePatient.TabIndex = 2;
            this.btnDeletePatient.Text = "Patient löschen";
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            this.btnDeletePatient.Click += new System.EventHandler(this.BtnDeletePatient_Click);
            // 
            // colId
            // 
            this.colId.Tag = "ID";
            this.colId.Text = "ID";
            this.colId.Width = 164;
            // 
            // colTitle
            // 
            this.colTitle.Text = "Titel";
            this.colTitle.Width = 104;
            // 
            // colGender
            // 
            this.colGender.Text = "Geschlecht";
            this.colGender.Width = 141;
            // 
            // colLastname
            // 
            this.colLastname.Text = "Nachname";
            this.colLastname.Width = 334;
            // 
            // colFirstname
            // 
            this.colFirstname.Text = "Vorname";
            this.colFirstname.Width = 356;
            // 
            // colBirthdate
            // 
            this.colBirthdate.Text = "Geburtsdatum";
            this.colBirthdate.Width = 145;
            // 
            // PatientenVerwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 630);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.btnNewPatient);
            this.Controls.Add(this.lsvPatientCards);
            this.Name = "PatientenVerwaltung";
            this.Text = "Patienten Verwaltung";
            this.Load += new System.EventHandler(this.PatientenVerwaltung_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsvPatientCards;
        private System.Windows.Forms.Button btnNewPatient;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colGender;
        private System.Windows.Forms.ColumnHeader colLastname;
        private System.Windows.Forms.ColumnHeader colFirstname;
        private System.Windows.Forms.ColumnHeader colBirthdate;
    }
}

