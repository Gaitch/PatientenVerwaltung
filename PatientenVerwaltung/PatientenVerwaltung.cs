using PatientenVerwaltung.PatientenKartei;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientenVerwaltung
{
    public partial class PatientenVerwaltung : Form
    {
        public PatientenVerwaltung()
        {
            InitializeComponent();
        }

        private void BtnNewPatient_Click(object sender, EventArgs e)
        {
            NewPatientForm newPatientForm = new NewPatientForm();
            newPatientForm.Show();
        }

        private void PatientenVerwaltung_Load(object sender, EventArgs e)
        {

        }

        private void BtnDeletePatient_Click(object sender, EventArgs e)
        {
            string text = lsvPatientCards.SelectedItems[0].Text;
            int id = Convert.ToInt32(text);

            Kartei.GetKartei().RemoveCard(id);

            lsvPatientCards.Items.Remove(lsvPatientCards.SelectedItems[0]);
        }
    }
}
