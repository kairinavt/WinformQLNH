using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Model
{
    public class Employee
    {
        public string id { get; set; }
        public string password { get; set; }
        public string role  { get; set; }

        public Employee(string id, string password, string role)
        {

        }
    }
  
}
