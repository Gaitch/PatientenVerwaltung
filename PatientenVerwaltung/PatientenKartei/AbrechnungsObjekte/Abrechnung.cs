using PatientenVerwaltung.PatientenKartei.BehandlungsObjekte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientenVerwaltung.PatientenKartei.AbrechnungsObjekte
{
    public class Abrechnung
    {
        private Quartal Quartal;

        private Abrechnung()
        {

        }

        public Abrechnung(Quartal quartal)
        {
            this.Quartal = quartal;
        }

        public double GetKosten()
        {
            List<Behandlung> behandlungen = Quartal.GetBehandlungen();
            double kosten = 0.0;
            
            foreach(Behandlung b in behandlungen)
            {
                kosten += b.Kosten;
            }

            return kosten;
        }

        public Quartal GetQuartal()
        {
            return this.Quartal;
        }
    }
}
