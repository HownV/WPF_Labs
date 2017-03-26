using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Lab1.Models
{
    public class Group
    {
        public Guid GroupId { get; set; }

        public string Name { get; set; }

        //[ForeignKey("ClassroomTeacher")]
        //public Guid ClassroomTeacherId { get; set; }

        public Employee ClassroomTeacher { get; set; }

        public ICollection<Student> Students { get; set; }

        public override string ToString()
        { 
            return Name;
        }
    }
}
