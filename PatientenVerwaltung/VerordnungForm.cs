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

namespace PatientenVerwaltung.PatientenKartei
{
    public partial class VerordnungForm : Form
    {
        public VerordnungForm()
        {
            InitializeComponent();
        }



        private void BtnSaveVerordnung_Click(object sender, EventArgs e)
        {
            string description = txtPrescriptionDescription.Text;

            Verordnung verordnung = new Verordnung(0, description);

            this.Close();
        }
    }
}
