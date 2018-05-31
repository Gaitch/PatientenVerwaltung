using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientenVerwaltung.PatientenKartei.BehandlungsObjekte
{
    public class Verordnung
    {
        protected int Id;
        public string Beschreibung;

        protected Verordnung()
        {

        }

        public Verordnung(int id,string beschreibung)
        {
            this.Beschreibung = beschreibung;
            this.Id = id;
        }

        public int GetId()
        {
            return this.Id;
        }
    }
}