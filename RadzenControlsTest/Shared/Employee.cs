using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadzenControlsTest.Shared
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int? ManagerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime HireDate { get; set; }
        public string City { get; set; }
    }
}
