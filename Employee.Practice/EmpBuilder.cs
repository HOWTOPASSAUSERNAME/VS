using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Practice
{
    public class EmpBuilder
    {
        public string  FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }

        public bool Gender { get; set; }


        public static EmpBuilder Create()
        {
            return new EmpBuilder();
        }

        public EmpBuilder SetName(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            return this;
        }
        public EmpBuilder SetEmail(string email) {
            this.Email = email;
            return this;
        }

         public EmpBuilder SetAddress(string country,int postalCode,string city, string address) {
            this.Country = country;
            this.PostalCode = postalCode;
            this.City = city;
            this.Address = address;

            return this;        
        }
        public EmpBuilder SetGender(bool gender)
        {
            this.Gender = gender;
            return this;

        }

        public Employee Build() {

            return new Employee(this);
        }






    }
}
