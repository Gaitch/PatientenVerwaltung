using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientenVerwaltung.PatientenKartei.PatientenObjekte
{
    public class Patient
    {
        public int id;
        public string title,
            gender,
            lastname,
            firstname,
            address,
            city,
            plz,
            tel,
            email;
        public DateTime birthdate;

        private Patient()
        {

        }

        public Patient(
            //int id,
            string title,
            string gender,
            string lastname,
            string firstname,
            string address,
            string city,
            string plz,
            string tel,
            string email,
            DateTime birthdate)
        {
            //this.id = id;
            this.title = title;
            this.gender = gender;
            this.lastname = lastname;
            this.firstname = firstname;
            this.address = address;
            this.city = city;
            this.plz = plz;
            this.tel = tel;
            this.email = email;
            this.birthdate = birthdate;
        }
    }
}
