using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using WPF_Lab1.Models.Enums;

namespace WPF_Lab1.Models
{
    public class Student
    {
        public Guid StudentId { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public string Photo { get; set; }

        public string Domicile { get; set; }

        public string PersonalPhoneNumber { get; set; }

        public string ParentPhoneNumber { get; set; }
        
        //[ForeignKey("Group")]
        //public Guid GroupId { get; set; }

        //public Group Group { get; set; }

        public RatingLeague RatingLeague { get; set; }

        public decimal Balance { get; set; }

        public float RatingPoints { get; set; }

        //public IEnumerable<Benefit> Benefits { get; set; }

        //public IEnumerable<Violation> Violations { get; set; }

        public string Characterization { get; set; }
    }
}
