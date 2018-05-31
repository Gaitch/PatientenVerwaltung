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
    public partial class RezeptForm : Form
    {
        public RezeptForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string medication = txtMedication.Text;
            string instruction = txtInstruction.Text;

            Rezept rezept = new Rezept(0, "",medication, instruction);

            this.Close();
        }
    }
}
