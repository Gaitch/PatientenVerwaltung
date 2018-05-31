using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientenVerwaltung.PatientenKartei.BehandlungsObjekte
{
    public class Rezept : Verordnung
    {
        public string Medikament;
        public string Anweisung;

        private Rezept()
        {

        }

        public Rezept(int id, string beschreibung, string medikament, string anweisung) : base(id ,beschreibung)
        {
            this.Medikament = medikament;
            this.Anweisung = anweisung;
        }
    }
}
