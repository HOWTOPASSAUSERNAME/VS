using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] kai = EmpBuilder.Create()
                .SetName("Kai", "Lin")
                .SetEmail("solarsido@gmail.com")
                .Address("台灣",700,"台南市","中華西路一段111號")
                .SetGender(true)
                .Build();

            
        }
    }

    public class Employee
    {
        public string FirstName {
            get
            {
                return FirstName;
            }
                
            set
            {
                if (string.IsNullOrEmpty(value)) { throw new ArgumentNullException("Null,請重新輸入"); }
                FirstName = value;
            }
                 }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }

        public bool  Gender { get; set; }

    }
}
