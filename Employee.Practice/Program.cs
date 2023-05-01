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
            Employee emp = EmpBuilder.Create()
                .SetName("Allen","Kuo").Build();

            Console.WriteLine(emp.FirstName);
        }
    }

    public class Employee
    {

        public Employee(EmpBuilder builder)
        {
            // todo 擷取builder的資料, 檢查資料是否正確
            // ...
            if (string.IsNullOrEmpty(builder.FirstName)) { throw new Exception("NULL"); }


            // 設定到Employee的屬性上
            this.FirstName = builder.FirstName;
            this.LastName = builder.LastName;
            this.Email = builder.Email;
            this.Gender = builder.Gender;
            this.Address = builder.Address; 
            this.Gender = builder.Gender;
            this.City = builder.City;
            this.PostalCode = builder.PostalCode;
            this.Country = builder.Country;
                
        }
        public string FirstName { get; set; }
    
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }

        public bool  Gender { get; set; }

    }
}
