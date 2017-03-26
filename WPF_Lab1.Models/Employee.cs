using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Lab1.Models.Enums;

namespace WPF_Lab1.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }

        public string Name { get; set; }

        public Position Position { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
