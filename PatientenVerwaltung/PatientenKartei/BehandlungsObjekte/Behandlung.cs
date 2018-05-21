using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientenVerwaltung.PatientenKartei.BehandlungsObjekte
{
    class Behandlung
    {
        private int Id;
        private DateTime Datum;
        public string Beschreibung;
        public string Untersuchung;
        private List<Verordnung> Verordnungen;
        public double Kosten;

        private Behandlung()
        {

        }

        public Behandlung(int id, DateTime date)
        {
            this.Id = id;
            this.Datum = date;
            this.Verordnungen = new List<Verordnung>();
        }

        public void AddVerordnung(Verordnung verordnung)
        {
            this.Verordnungen.Add(verordnung);
        }

        public void RemoveVerordnung(Verordnung verordnung)
        {
            this.Verordnungen.Remove(verordnung);
        }

        public List<Verordnung> GetVerordnungen()
        {
            return this.Verordnungen;
        }

        public Verordnung GetVerordnung(int id)
        {
            return Verordnungen.Find(x => x.GetId() == id);
        }

        public int GetId()
        {
            return this.Id;
        }
    }
}
