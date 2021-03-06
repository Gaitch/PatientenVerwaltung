﻿using PatientenVerwaltung.PatientenKartei;
using PatientenVerwaltung.PatientenKartei.BehandlungsObjekte;
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
    public partial class Behanldung_hinzufügen : Form
    {
        public Behanldung_hinzufügen()
        {
            InitializeComponent();
        }

        private void BtnSaveTreatment_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Today;
            string currentDateString = DateTime.Today.ToLongDateString();
            string description = txtDescription.Text;
            string examination = txtExamination.Text;
            double price = Convert.ToDouble(txtPrice.Text);

            lblCurrentDate.Text = currentDateString;

            Behandlung behandlung = new Behandlung(currentDate);
            behandlung.Beschreibung = description;
            behandlung.Untersuchung = examination;
            behandlung.Kosten = price;
        }

        private void BtnOpenVerordnungForm_Click(object sender, EventArgs e)
        {
            VerordnungForm f = new VerordnungForm();
            f.Show();
        }

        private void BtnOpenRezeptForm_Click(object sender, EventArgs e)
        {
            RezeptForm r = new RezeptForm();
            r.Show();
        }
    }
}