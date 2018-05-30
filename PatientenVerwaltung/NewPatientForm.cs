using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientenVerwaltung.PatientenKartei.PatientenObjekte;
using PatientenVerwaltung.PatientenKartei;

namespace PatientenVerwaltung
{
    public partial class NewPatientForm : Form
    {
        public NewPatientForm()
        {
            InitializeComponent();
        }

        private void BtnSaveNewPerson_Click(object sender, EventArgs e)
        {
            string gender = comboGender.Text;
            string title = comboTitle.Text;
            string lastname = txtLastname.Text;
            string firstname = txtFirstname.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text; 
            string plz = txtPlz.Text;
            string tel = txtTel.Text;
            string email = txtEmail.Text;
            DateTime birthdate = dateTimePickerBirthdate.Value;


            Patient patient = new Patient(title, gender, lastname, firstname, address, city, plz, tel, email, birthdate);
            PatientenKarte patientenKarte = new PatientenKarte(patient);

            Kartei.GetKartei().AddCard(patientenKarte);

            ListViewItem item = new ListViewItem();
            item.Text = patient.id.ToString();
            item.SubItems.Add(title);
            item.SubItems.Add(gender);
            item.SubItems.Add(lastname);
            item.SubItems.Add(firstname);
            item.SubItems.Add(birthdate.ToString());


            this.Close();
        }
    }
}
