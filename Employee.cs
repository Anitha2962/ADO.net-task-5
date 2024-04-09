using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ad.net_task5.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoiningDate { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
