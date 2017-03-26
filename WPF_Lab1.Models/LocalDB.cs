//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using WPF_Lab1.Models.Enums;

//namespace WPF_Lab1.Models
//{
//    public static class LocalDB
//    {
//        static LocalDB()
//        {
//            Students = new List<Student>()
//            {
//                new Student() { Name = "Владимир" },
//                new Student() { Name = "Вячеслав" },
//                new Student() { Name = "Евгения" },
//                new Student() { Name = "Алёна" },
//                new Student() { Name = "Евгений" },
//                new Student() { Name = "Сергей" },
//                new Student() { Name = "Анастасия" }
//            };

//            Employees = new List<Employee>()
//            {
//                new Employee() { Name = "Наталья Викторовна", Position = Position.ClassroomTeacher },
//                new Employee() { Name = "Неля Наумовна", Position = Position.Teacher },
//                new Employee() { Name = "Галина Петровна", Position = Position.ClassroomTeacher }
//            };

//            Groups = new List<Group>()
//            {
//                new Group() { Name = "9-1", ClassroomTeacher = Employees[0],
//                    Students = new List<Student>() { Students[0], Students[1], Students[2], Students[3] } },
//                new Group() { Name = "9-2", ClassroomTeacher = Employees[2],
//                    Students = new List<Student>() { Students[4], Students[5], Students[6] } }
//            };
//        }

//        public static List<Student> Students { get; set; }

//        public static List<Employee> Employees { get; set; }

//        public static List<Group> Groups { get; set; }
//    }
//}
