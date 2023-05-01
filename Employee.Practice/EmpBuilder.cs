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

        private List<Employee> _employees = new List<Employee>();
        public static EmpBuilder Create()
        {
            return new EmpBuilder();
        } 

        public EmpBuilder SetName(string lastName,string firstName)
        {
            var employee = new Employee() {LastName =lastName,FirstName=firstName };
            _employees.Add(employee);
            return this;
        }

        public EmpBuilder SetEmail(string email)
        {
            var employee = new Employee() { Email = email };
            _employees.Add(employee);
            return this;
        }

        public EmpBuilder Address(string country, int postalCode, string city, string address) {

            var employee = new Employee() 
            { 
                Country = country
                ,PostalCode=postalCode
                ,City = city
                ,Address = address
            };
            _employees.Add(employee);
            return this;
        }

        public EmpBuilder SetGender(bool gender)
        {
            var employee = new Employee() { Gender = gender };
            _employees.Add(employee);
            return this;

        }
        public  Employee[]Build()
        {
            return _employees.ToArray();

        }

    }
}
