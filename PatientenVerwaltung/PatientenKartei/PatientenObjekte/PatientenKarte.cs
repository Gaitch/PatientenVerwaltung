using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientenVerwaltung.PatientenKartei.BehandlungsObjekte;

namespace PatientenVerwaltung.PatientenKartei.PatientenObjekte
{
    public class PatientenKarte
    {
        private Patient Patient;
        private List<Behandlung> Behandlungen;

        private PatientenKarte()
        {

        }

        public PatientenKarte(Patient patient)
        {
            this.Patient = patient;
        }


        public Patient GetPatient()
        {
            return this.Patient;
        }

        public Behandlung GetBehandlung(int id)
        {
            return this.Behandlungen.Find(x => x.GetId() == id);
        }

        public List<Behandlung> GetBehandlungen()
        {
            return this.Behandlungen;
        }

        public void AddBehandlung(Behandlung behandlung)
        {
            this.Behandlungen.Add(behandlung);
        }

        public void RemoveBehandlung(int id)
        {
            this.Behandlungen.Remove(this.GetBehandlung(id));
        }

        public void RemoveBehandlung(Behandlung behandlung)
        {
            this.Behandlungen.Remove(behandlung);
        }
    }
}
