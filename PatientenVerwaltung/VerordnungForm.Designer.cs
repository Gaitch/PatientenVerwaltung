namespace PatientenVerwaltung.PatientenKartei
{
    partial class VerordnungForm
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
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrescriptionDescription = new System.Windows.Forms.TextBox();
            this.btnSaveVerordnung = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPrescriptionDescription);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(537, 90);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Verordnung";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Beschreibung";
            // 
            // txtPrescriptionDescription
            // 
            this.txtPrescriptionDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrescriptionDescription.Location = new System.Drawing.Point(172, 58);
            this.txtPrescriptionDescription.Name = "txtPrescriptionDescription";
            this.txtPrescriptionDescription.Size = new System.Drawing.Size(359, 26);
            this.txtPrescriptionDescription.TabIndex = 3;
            // 
            // btnSaveVerordnung
            // 
            this.btnSaveVerordnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveVerordnung.Location = new System.Drawing.Point(12, 182);
            this.btnSaveVerordnung.Name = "btnSaveVerordnung";
            this.btnSaveVerordnung.Size = new System.Drawing.Size(127, 32);
            this.btnSaveVerordnung.TabIndex = 4;
            this.btnSaveVerordnung.Text = "Save";
            this.btnSaveVerordnung.UseVisualStyleBackColor = true;
            this.btnSaveVerordnung.Click += new System.EventHandler(this.BtnSaveVerordnung_Click);
            // 
            // VerordnungForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 226);
            this.Controls.Add(this.btnSaveVerordnung);
            this.Controls.Add(this.groupBox2);
            this.Name = "VerordnungForm";
            this.Text = "VerordnungForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrescriptionDescription;
        private System.Windows.Forms.Button btnSaveVerordnung;
    }
}