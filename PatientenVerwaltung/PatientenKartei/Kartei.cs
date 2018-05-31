using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientenVerwaltung.PatientenKartei.PatientenObjekte;
using PatientenVerwaltung.PatientenKartei.AbrechnungsObjekte;
using PatientenVerwaltung.PatientenKartei.BehandlungsObjekte;
using PatientenVerwaltung.DataAccessLayer;
using System.Configuration;

namespace PatientenVerwaltung.PatientenKartei
{
    public class Kartei : BaseObject
    {
        private List<PatientenKarte> Karten;
        private static Kartei kartei;

        public Kartei()
        {
            this.Karten = new List<PatientenKarte>();
            string connectionString = ConfigurationManager.ConnectionStrings["praxis"].ConnectionString;
            PatientenKarteDO pDO = new PatientenKarteDO(connectionString);

            this.Karten.AddRange(pDO.GetAllPatientenKarten());
        }

        public List<PatientenKarte> GetCardsByLastnames(string lastname)
        {
            throw new NotImplementedException();
        }

        public List<PatientenKarte> GetCardsByFirstname(string firstname)
        {
            throw new NotImplementedException();
        }

        public PatientenKarte GetCard(int id)
        {
            return this.Karten.Find(x => x.GetPatient().id == id);
        }

        public void AddCard(PatientenKarte patientenKarte)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["praxis"].ConnectionString;
            PatientenKarteDO pDO = new PatientenKarteDO(connectionString);

            if (pDO.UpdateInsertObject(patientenKarte))
            {
                this.Karten.Add(patientenKarte);
            }
        }

        public void RemoveCard(PatientenKarte patientenKarte)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["praxis"].ConnectionString;
            PatientenKarteDO pDO = new PatientenKarteDO(connectionString);

            if (pDO.DeactivateObject(patientenKarte))
            {
                this.Karten.Remove(patientenKarte);
            }
        }

        public void RemoveCard(int id)
        {
            this.RemoveCard(this.GetCard(id));
        }
           
        public List<Behandlung> GetBehandlungenFromQuartal(Quartal quartal)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["praxis"].ConnectionString;
            BehandlungDO bDO = new BehandlungDO(connectionString);

            return bDO.GetBehandlungenFromQuartal(quartal);
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
