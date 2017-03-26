using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Lab1.Models.Enums;

namespace WPF_Lab1.Models.DataAccess
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            context.Students.AddRange(new List<Student>()
            {
                new Student() { StudentId = Guid.NewGuid(), Name = "Владимир", DateOfBirth = new DateTime(1998, 6, 12)},
                new Student() { StudentId = Guid.NewGuid(), Name = "Вячеслав", DateOfBirth = new DateTime(1998, 11, 7)},
                new Student() { StudentId = Guid.NewGuid(), Name = "Евгения", DateOfBirth = new DateTime(1998, 2, 10)},
                new Student() { StudentId = Guid.NewGuid(), Name = "Алёна", DateOfBirth = new DateTime(1998, 5, 5)},
                new Student() { StudentId = Guid.NewGuid(), Name = "Евгений", DateOfBirth = new DateTime(1998, 9, 3)},
                new Student() { StudentId = Guid.NewGuid(), Name = "Сергей", DateOfBirth = new DateTime(1998, 7, 1)},
                new Student() { StudentId = Guid.NewGuid(), Name = "Анастасия", DateOfBirth = new DateTime(1998, 12, 8)}
            });
            context.SaveChanges();

            context.Employees.AddRange(new List<Employee>()
            {
                new Employee() {EmployeeId = Guid.NewGuid(), Name = "Наталья Викторовна", Position = Position.ClassroomTeacher},
                new Employee() {EmployeeId = Guid.NewGuid(), Name = "Неля Наумовна", Position = Position.Teacher},
                new Employee() {EmployeeId = Guid.NewGuid(), Name = "Галина Петровна", Position = Position.ClassroomTeacher}
            });
            context.SaveChanges();

            context.Groups.AddRange(new List<Group>()
            {
                new Group()
                {
                    GroupId = Guid.NewGuid(),
                    Name = "9-1",
                    ClassroomTeacher = context.Employees.ToList().ElementAt(0),
                    Students = new List<Student>()
                    {
                        context.Students.ToList().ElementAt(0),
                        context.Students.ToList().ElementAt(1),
                        context.Students.ToList().ElementAt(2),
                        context.Students.ToList().ElementAt(3)
                    }
                },
                new Group()
                {
                    GroupId = Guid.NewGuid(),
                    Name = "9-2",
                    ClassroomTeacher = context.Employees.ToList().ElementAt(2),
                    Students = new List<Student>() {
                        context.Students.ToList().ElementAt(4),
                        context.Students.ToList().ElementAt(5),
                        context.Students.ToList().ElementAt(6)
                    }
                }
            });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
