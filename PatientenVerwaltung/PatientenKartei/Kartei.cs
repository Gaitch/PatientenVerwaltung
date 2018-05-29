using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientenVerwaltung.PatientenKartei.PatientenObjekte;
using PatientenVerwaltung.PatientenKartei.AbrechnungsObjekte;
using PatientenVerwaltung.PatientenKartei.BehandlungsObjekte;

namespace PatientenVerwaltung.PatientenKartei
{
    public class Kartei
    {
        private List<PatientenKarte> Karten;
        private static Kartei kartei;

        public Kartei()
        {

        }

        public List<PatientenKarte> GetCardsByLastnames(string lastname)
        {
            throw new Exception();
        }

        public List<PatientenKarte> GetCardsByFirstname(string firstname)
        {
            throw new Exception();
        }

        public PatientenKarte GetCard(int id)
        {
            throw new Exception();
        }

        public void AddCard(PatientenKarte patientenKarte)
        {

        }

        public void RemoveCard(PatientenKarte patientenKarte)
        {

        }

        public void RomveCard(int id)
        {

        }
           
        public List<Behandlung> GetBehandlungenFromQuartal(Quartal quartal)
        {
            return null;
        }

        public static Kartei GetKartei()
        {
            if(kartei == null)
            {
                kartei = new Kartei();
            }

            return kartei;
        }
    }
}
