using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientenVerwaltung.PatientenKartei.BehandlungsObjekte;

namespace PatientenVerwaltung.PatientenKartei.AbrechnungsObjekte
{
    class Quartal
    {
        private int Quartalsnummer;
        private int Year;
        private DateTime Von;
        private DateTime Bis;

        public Quartal()
        {
            this.SetCurrentQuartNr();
            this.Year = DateTime.Now.Year;
        }

        private Quartal(int quartalsnummer, int year)
        {
            this.Quartalsnummer = quartalsnummer;
            this.Year = year;
        }

        private void SetCurrentQuartNr()
        {
            DateTime now = DateTime.Now;

            if (now.Month > 0 && now.Month < 4)
            {
                this.Quartalsnummer = 1;
            }
            else if (now.Month > 3 && now.Month < 7)
            {
                this.Quartalsnummer = 2;
            }
            else if (now.Month > 6 && now.Month < 10)
            {
                this.Quartalsnummer = 3;
            }
            else if (now.Month > 9 && now.Month < 13)
            {
                this.Quartalsnummer = 4;
            }
        }

        private void SetVonBisDates()
        {
            switch(this.Quartalsnummer)
            {
                case 1:
                    this.Von = new DateTime(this.Year, 1, 1);
                    this.Bis = new DateTime(this.Year, 3, 31);
                    break;
                case 2:
                    this.Von = new DateTime(this.Year, 4, 1);
                    this.Bis = new DateTime(this.Year, 6, 30);
                    break;
                case 3:
                    this.Von = new DateTime(this.Year, 7, 1);
                    this.Bis = new DateTime(this.Year, 9, 30);
                    break;
                case 4:
                    this.Von = new DateTime(this.Year, 10, 1);
                    this.Bis = new DateTime(this.Year, 12, 31);
                    break;
                default:
                    break;
            }
        }

        public DateTime GetVonDate()
        {
            return this.Von;
        }

        public DateTime GetBisDate()
        {
            return this.Bis;
        }

        public List<Behandlung> GetBehandlungen()
        {
            Kartei kartei = Kartei.GetKartei();
            return kartei.GetBehandlungFromQuartal(this);
        }
        


    }
}
