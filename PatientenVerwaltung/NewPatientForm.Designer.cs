namespace PatientenVerwaltung
{
    partial class NewPatientForm
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
            this.btnSaveNewPerson = new System.Windows.Forms.Button();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.comboGender = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.comboTitle = new System.Windows.Forms.ComboBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblPlz = new System.Windows.Forms.Label();
            this.txtPlz = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnSaveNewPerson
            // 
            this.btnSaveNewPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewPerson.Location = new System.Drawing.Point(12, 500);
            this.btnSaveNewPerson.Name = "btnSaveNewPerson";
            this.btnSaveNewPerson.Size = new System.Drawing.Size(356, 35);
            this.btnSaveNewPerson.TabIndex = 61;
            this.btnSaveNewPerson.Text = "Speichern";
            this.btnSaveNewPerson.UseVisualStyleBackColor = true;
            this.btnSaveNewPerson.Click += new System.EventHandler(this.BtnSaveNewPerson_Click);
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.Location = new System.Drawing.Point(11, 410);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(112, 20);
            this.lblBirthdate.TabIndex = 59;
            this.lblBirthdate.Text = "Geburtsdatum";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(11, 381);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(357, 26);
            this.txtEmail.TabIndex = 58;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(11, 358);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 57;
            this.lblEmail.Text = "Email";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(11, 57);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(90, 20);
            this.lblGender.TabIndex = 56;
            this.lblGender.Text = "Geschlecht";
            // 
            // comboGender
            // 
            this.comboGender.FormattingEnabled = true;
            this.comboGender.Items.AddRange(new object[] {
            "Männlich",
            "Weiblich"});
            this.comboGender.Location = new System.Drawing.Point(12, 80);
            this.comboGender.Name = "comboGender";
            this.comboGender.Size = new System.Drawing.Size(122, 21);
            this.comboGender.TabIndex = 55;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTitle.TabIndex = 54;
            this.lblTitle.Text = "Titel";
            // 
            // comboTitle
            // 
            this.comboTitle.FormattingEnabled = true;
            this.comboTitle.Items.AddRange(new object[] {
            "Herr",
            "Frau"});
            this.comboTitle.Location = new System.Drawing.Point(12, 33);
            this.comboTitle.Name = "comboTitle";
            this.comboTitle.Size = new System.Drawing.Size(122, 21);
            this.comboTitle.TabIndex = 53;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(11, 329);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(357, 26);
            this.txtTel.TabIndex = 52;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(11, 306);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(34, 20);
            this.lblTel.TabIndex = 51;
            this.lblTel.Text = "Tel.";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(12, 277);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(246, 26);
            this.txtCity.TabIndex = 50;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(11, 254);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 20);
            this.lblCity.TabIndex = 49;
            this.lblCity.Text = "Ort";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(15, 228);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(357, 26);
            this.txtAddress.TabIndex = 48;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(11, 205);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(68, 20);
            this.lbladdress.TabIndex = 47;
            this.lbladdress.Text = "Adresse";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(11, 173);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(357, 26);
            this.txtFirstname.TabIndex = 46;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(11, 153);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(74, 20);
            this.lblFirstname.TabIndex = 45;
            this.lblFirstname.Text = "Vorname";
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(11, 124);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(357, 26);
            this.txtLastname.TabIndex = 44;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(11, 104);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(86, 20);
            this.lblLastname.TabIndex = 43;
            this.lblLastname.Text = "Nachname";
            // 
            // lblPlz
            // 
            this.lblPlz.AutoSize = true;
            this.lblPlz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlz.Location = new System.Drawing.Point(260, 254);
            this.lblPlz.Name = "lblPlz";
            this.lblPlz.Size = new System.Drawing.Size(38, 20);
            this.lblPlz.TabIndex = 42;
            this.lblPlz.Text = "PLZ";
            // 
            // txtPlz
            // 
            this.txtPlz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlz.Location = new System.Drawing.Point(264, 277);
            this.txtPlz.Name = "txtPlz";
            this.txtPlz.Size = new System.Drawing.Size(104, 26);
            this.txtPlz.TabIndex = 41;
            // 
            // dateTimePickerBirthdate
            // 
            this.dateTimePickerBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirthdate.Location = new System.Drawing.Point(12, 433);
            this.dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            this.dateTimePickerBirthdate.Size = new System.Drawing.Size(356, 26);
            this.dateTimePickerBirthdate.TabIndex = 62;
            // 
            // NewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 546);
            this.Controls.Add(this.dateTimePickerBirthdate);
            this.Controls.Add(this.btnSaveNewPerson);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.comboGender);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.comboTitle);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblPlz);
            this.Controls.Add(this.txtPlz);
            this.Name = "NewPatientForm";
            this.Text = "NewPatientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveNewPerson;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox comboTitle;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblPlz;
        private System.Windows.Forms.TextBox txtPlz;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthdate;
    }
}