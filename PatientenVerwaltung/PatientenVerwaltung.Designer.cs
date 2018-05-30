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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnNewPatient = new System.Windows.Forms.Button();
            this.btnDeletePatien = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1256, 614);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            // btnDeletePatien
            // 
            this.btnDeletePatien.Location = new System.Drawing.Point(1274, 41);
            this.btnDeletePatien.Name = "btnDeletePatien";
            this.btnDeletePatien.Size = new System.Drawing.Size(184, 23);
            this.btnDeletePatien.TabIndex = 2;
            this.btnDeletePatien.Text = "Patient löschen";
            this.btnDeletePatien.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1274, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1274, 194);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Behandlung hinzufügen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // PatientenVerwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 630);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDeletePatien);
            this.Controls.Add(this.btnNewPatient);
            this.Controls.Add(this.listView1);
            this.Name = "PatientenVerwaltung";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PatientenVerwaltung_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnNewPatient;
        private System.Windows.Forms.Button btnDeletePatien;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

