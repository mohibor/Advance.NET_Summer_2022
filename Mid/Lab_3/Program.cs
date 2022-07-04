using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> {
                new Student(1, "Name 1", new DateTime(1992, 03, 2), 2.5),
                new Student(2, "Name 2", new DateTime(1990, 03, 2), 2.9),
                new Student(3, "Name 3", new DateTime(2015, 03, 2), 3.4),
                new Student(4, "Name 4", new DateTime(1996, 03, 2), 3.7),
                new Student(5, "Name 5", new DateTime(1998, 03, 2), 3.9)
            };
            /*
            foreach (var student in students)
            {
                Console.WriteLine();
            }
            */

            var filter1 = (from student in students where student.Cgpa > 3.0f select student).ToList();

            var filter2 = (from student in students where student.Id > 3 && student.Cgpa > 2.5 select student).ToList();

            var filter3 = (from student in students where (DateTime.Now.Subtract(student.Dob).Days / 365 > 18) select student).ToList();

            var filter4 = (from student in students select new { Id = student.Id, Cgpa = student.Cgpa }).ToList();

            var filter5 = (from student in students where (DateTime.Now.Subtract(student.Dob).Days / 365 < 16) select new { Id = student.Id, Dob = student.Dob}).ToList();


            foreach (var student in filter3)
            {
                Console.WriteLine(student.Id + "\t" + student.Name + "\t" + student.Dob.ToShortDateString() + "\t" + student.Cgpa);
            }
        }
    }
}
